using ProxyObject.Common;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public partial class fInbox : Form
	{
		public UserClient Owner { get; private set; }
		public UserClient Partner { get; private set; }

		public fInbox(UserClient owner,UserClient partner)
		{
			InitializeComponent();
			this.Owner = owner;
			this.Partner = partner;
			this.Text = this.Partner.Name + " (" + partner.Username + ")";
			this.pnReceiver.ControlAdded += ControlAdded;
			this.pnSender.ControlAdded += ControlAdded;
		}

		private void ControlAdded(object sender, ControlEventArgs e)
		{
			((Panel)sender).ScrollControlIntoView(e.Control);
		}
		private void btnSend_Click(object sender, EventArgs e)
		{
			if (txtMessage.Text.Trim().Equals(string.Empty))
				return;
			var sendMess = new TagMessage(MessageType.Sender,txtMessage.Text);
			var emptyMess = new TagMessage(MessageType.Empty, "");
			pnSender.Controls.Add(sendMess);
			pnReceiver.Controls.Add(emptyMess);

			var pket = new Packet("", StatusCode.Chat, txtMessage.Text);
			Program.srvProxy.Notify(pket.ToJson());
			txtMessage.Clear();
		}
	}
}
