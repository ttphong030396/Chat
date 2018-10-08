using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public partial class TagMessage : UserControl
	{
		public TagMessage(MessageType type,string Message)
		{
			InitializeComponent();
			this.Dock = DockStyle.Bottom;
			switch(type)
			{
				case MessageType.Empty:
					this.pnBackColor.BackColor = Color.Transparent;
					this.lbMessage.Hide();
					this.lbTime.Hide();
					break;
				case MessageType.Receiver:
					this.pnBackColor.BackColor = Color.Silver;
					this.lbMessage.ForeColor = Color.Black;
					this.lbTime.ForeColor = Color.Black;
					break;
				case MessageType.Sender:
					this.pnBackColor.BackColor = Color.FromArgb(0, 123, 255);
					this.lbMessage.ForeColor = Color.White;
					this.lbTime.ForeColor = Color.White;
					break;
			}
			this.lbMessage.Text = Message;
			this.lbTime.Text = GetTimeNow();
		}
		private string GetTimeNow()
		{
			var TimeNow = DateTime.Now;
			return string.Format("{0}:{1}",TimeNow.Hour,TimeNow.Minute);
		}
	}
}
