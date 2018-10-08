using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyObject.Common
{
	public class Cache
	{
		private static IObServer server;
		private static Cache instance = null;
		private Cache() {

		}
		public static Cache Instance
		{
			get
			{
				if (Cache.instance == null)
					Cache.instance = new Cache();
				return Cache.instance;
			}
		}

		public static void Attach(IObServer server)
		{
			//if (!Cache.servers.Contains(server))
			//	Cache.servers.Add(server);
			Cache.server = server;
		}

		public void Notify(string PacketJson)
		{
			//	foreach (var server in Cache.servers)
			server.Notify(PacketJson);
		}
	}
}
