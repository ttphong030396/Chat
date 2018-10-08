using ProxyObject.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyObject.Proxy.Client
{
	public class ClientProxy :MarshalByRefObject
	{
		public static string ObjectName {
			get
			{
				return typeof(ClientProxy).Name;
			}
		}
		public void Notify(string content)
		{
			Cache.Instance.Notify(content);
		}
		
	}
}
