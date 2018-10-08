using ProxyObject.Common;
using ProxyObject.Proxy;
using ProxyObject.Proxy.Client;
using ProxyObject.Proxy.Server;
using System;
using System.Windows.Forms;

namespace Server
{
	public partial class fServerHome : Form,IObServer
	{
		public fServerHome()
		{
			InitializeComponent();
			Cache.Attach(this);
			txtLog.Text += "-------------------------------------\n";
			txtLog.Text += "Server is starting ...\n";
			txtLog.Text += "Service name: " + ServerProxy.ObjectName + "\n";
			txtLog.Text += "IP Address: " + Program.IpAddress + "\n";
			txtLog.Text += "On Port: " + Program.Port + "\n";
			txtLog.Text += "Protocal: " + Program.Protocal + "\n";
			txtLog.Text += "Url: " + Program.Protocal + "://" + Program.IpAddress + ":" + Program.Port + "/" + ServerProxy.ObjectName + "\n";
			txtLog.Text += "-------------------------------------\n";
			txtLog.Select(txtLog.Text.Length - 1, 0);
		}
		public void Notify(string PacketJson)
		{
			var pket = PacketJson.ToPacket();
			switch(pket.Status)
			{
				case StatusCode.LogIn:
					var user = pket.Content.ToUserClient();
					if (txtLog.InvokeRequired)
					{
						txtLog.Invoke(new Action(() => {
							txtLog.Text += pket.Time + " - " + pket.Title + "\n";
							txtLog.Select(txtLog.Text.Length - 1, 0);
							txtLog.ScrollToCaret();
						}));
					}

					Program.ConnectToServer("tcp", "192.168.98.172", 9005, ClientProxy.ObjectName);
					Program.cliProxy.Notify(PacketJson);
					break;

				case StatusCode.LogOut:
					if (txtLog.InvokeRequired)
					{
						txtLog.Invoke(new Action(() => {
							txtLog.Text += pket.Time + " - " + pket.Title + "\n";
							txtLog.Select(txtLog.Text.Length - 1, 0);
							txtLog.ScrollToCaret();
						}));
					}
					break;
				case StatusCode.Chat:
					if (txtLog.InvokeRequired)
					{
						txtLog.Invoke(new Action(() => {
							txtLog.Text += pket.Time + " - " + pket.Content + "\n";
							txtLog.Select(txtLog.Text.Length - 1, 0);
							txtLog.ScrollToCaret();
						}));
					}
					break;
			}
		}
	}
}
