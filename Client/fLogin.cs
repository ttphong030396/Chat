using ProxyObject.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public partial class fLogin : Form
	{
		public fLogin()
		{
			InitializeComponent();
		}

		private void txtUsername_TextChanged(object sender, EventArgs e)
		{
			error.SetError(txtUsername, "");
		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{
			error.SetError(txtPassword, "");
		}


		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (txtUsername.Text.Trim().Equals(string.Empty))
			{
				error.SetError(txtUsername, "Username invalid");
				txtUsername.Focus();
				return;
			}

			if (txtPassword.Text.Trim().Equals(string.Empty))
			{
				error.SetError(txtPassword, "Password invalid");
				txtPassword.Focus();
				return;
			}

			var msg = Program.srvProxy.Login(txtUsername.Text, txtPassword.Text,Program.IpAddress);
			if (msg.Status == StatusCode.Success)
			{
				MessageBox.Show(msg.Title, msg.Status.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Logger.WriteLine(msg.Content, false);
				Program.CheckSession();
				this.Close();
			}
			else
			{
				MessageBox.Show(msg.Title, msg.Status.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void lbRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}
	}
}
