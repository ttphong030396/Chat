using ProxyObject.Proxy.Client;
using ProxyObject.Proxy.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Server
{
	static class Program
	{
		public static ClientProxy cliProxy { get; set; } = null;
		public static string IpAddress { get; private set; }
		public static string Port { get; private set; }
		public static string Protocal { get; private set; }
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			IpAddress = GetLocalIPAddress();
			RegisterChannel();
			InitService();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new fServerHome());
		}
		private static void RegisterChannel()
		{
			Port = ConfigurationManager.AppSettings["Port"].ToString();
			Protocal = ConfigurationManager.AppSettings["Protocal"].ToString();
			switch(Protocal)
			{
				case "tcp":
					TcpChannel tcp = new TcpChannel(int.Parse(Port));
					ChannelServices.RegisterChannel(tcp);
					break;
				case "http":
					HttpChannel http = new HttpChannel(int.Parse(Port));
					ChannelServices.RegisterChannel(http);
					break;
			}
		}
		private static void InitService()
		{
			RemotingConfiguration.RegisterWellKnownServiceType(typeof(ServerProxy), ServerProxy.ObjectName, WellKnownObjectMode.Singleton);
		}

		public static void ConnectToServer(string method, string ip, int port, string servicename)
		{
			string url = string.Format("{0}://{1}:{2}/{3}", method, ip, port, servicename);
			cliProxy = (ClientProxy)Activator.GetObject(typeof(ClientProxy), url);
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
