using ProxyObject.Common;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
	public partial class fClientHome : Form, IObServer
	{
		private Dictionary<string, Form> fInboxs = new Dictionary<string, Form>();
		private Queue<Thread> ThreadManager = new Queue<Thread>();
		public fClientHome()
		{
			InitializeComponent();
			Cache.Attach(this);
		}
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void UpdateControl(object content)
		{
			try
			{
				var pket = content.ToPacket();
				var user = pket.Content.ToUserClient();
				if (lbName.InvokeRequired)
				{
					lbName.Invoke(new Action(() =>
					{
						lbName.Text = user.Name;
					}));
				}
				if (lbUSername.InvokeRequired)
				{
					lbUSername.Invoke(new Action(() =>
					{
						lbUSername.Text = user.Username;
					}));
				}
				Program.CheckSession();
				if (Program.User != null && Program.User.Username != user.Username)
				{
					AddItem(user);
				}
			}
			catch (Exception)
			{
			}
		}

		private void AddItem(UserClient user)
		{
			if (lsvOnline.InvokeRequired)
			{
				lsvOnline.Invoke(new Action(() =>
				{
					lsvOnline.Items.Add(new ListViewItem(user.Name) { Tag = user });
				}));
			}
			else
			{
				lsvOnline.Items.Add(new ListViewItem(user.Name) { Tag = user });
			}
		}

		private void AddItems(List<UserClient> users)
		{
			foreach (var item in users)
			{
				AddItem(item);
			}
		}
		private void fClientHome_Load(object sender, EventArgs e)
		{
			if (Program.User == null)
			{
				fLogin flg = new fLogin();
				flg.ShowDialog();
			}
			string stringJson = Program.srvProxy.GetUserOnline(Program.User.Username);
			var usersOnline = JsonToListUserClient(stringJson);
			var pket = new Packet(
					string.Format("{0} ({1}) just been login",Program.User.Name,Program.User.Username),
					StatusCode.LogIn, 
					Program.User.ToJSon()
				);
			var content = pket.ToJson();
			Program.srvProxy.Notify(content);
			AddItems(usersOnline);
		}
		private List<UserClient> JsonToListUserClient(string stringJson)
		{
			return stringJson.ToUsersClient();
		}
		public void Notify(string PacketJson)
		{
			Thread thr = new Thread(UpdateControl);
			thr.Start(PacketJson);
			ThreadManager.Enqueue(thr);
		}

		private void lsvOnline_DoubleClick(object sender, EventArgs e)
		{
			ListView lsv = (ListView)sender;
			var SelectedItem = lsv.SelectedItems[0];
			var user = (UserClient)SelectedItem.Tag;
			if (!fInboxs.ContainsKey(user.Username))
			{
				fInbox inbox = new fInbox(Program.User, user);
				fInboxs.Add(user.Username, inbox);
				inbox.FormClosed += Inbox_FormClosed;
				inbox.Show();
			}
			fInboxs[user.Username].WindowState = FormWindowState.Normal;
		}

		private void Inbox_FormClosed(object sender, FormClosedEventArgs e)
		{
			fInbox f = (fInbox)sender;
			fInboxs.Remove(f.Partner.Username);
		}

		private void fClientHome_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Are you sure you want exit??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.No))
			{
				e.Cancel = true;
			}
		}

		private void fClientHome_FormClosed(object sender, FormClosedEventArgs e)
		{
			while (ThreadManager.Count > 0)
				ThreadManager.Dequeue().Abort();
			var pket = new Packet(
					string.Format("{0} ({1}) just been logout", Program.User.Name, Program.User.Username),
					StatusCode.LogOut,
					Program.User.ToJSon()
				);
			Program.srvProxy.Logout(pket.ToJson());
		}
	}
}
