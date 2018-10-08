using ProxyObject.Common;
using ProxyObject.Proxy.Client;
using ProxyObject.Proxy.Server;
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;

namespace Client
{
	static class Program
	{
		public static UserClient User = null;
		public static ServerProxy srvProxy { get; set; } = null;
		public static string IpAddress { get; private set; }
		public static int Port = 9000;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			IpAddress = GetLocalIPAddress();
			CreateChannel(9005);
			InitService();
			ConnectToServer("tcp", "192.168.98.172", Port, ServerProxy.ObjectName);
			CheckSession();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new fClientHome());
		}
		static void CreateChannel(int port)
		{
			TcpChannel channel = new TcpChannel(port);
			ChannelServices.RegisterChannel(channel);

		}

		static void ConnectToServer(string method, string ip, int port, string servicename)
		{
			string url = string.Format("{0}://{1}:{2}/{3}", method, ip, port, servicename);
			srvProxy = (ServerProxy)Activator.GetObject(typeof(ServerProxy), url);
		}

		public static void CheckSession()
		{
			string strUser = Logger.ReadLine();
			if (strUser != string.Empty)
				User = strUser.ToUserClient();
			else
				User = null;
		}
		private static void InitService()
		{
			RemotingConfiguration.RegisterWellKnownServiceType(typeof(ClientProxy), ClientProxy.ObjectName, WellKnownObjectMode.Singleton);
		}
		private static string GetLocalIPAddress()
		{
			var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var ip in host.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					return ip.ToString();
				}
			}
			throw new Exception("No network adapters with an IPv4 address in the system!");
		}
	}
}
