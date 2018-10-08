using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyObject.Common
{
	[Serializable]
	public class Packet
	{
		public string Title { get; private set; }
		public string Content { get; private set; }
		public StatusCode Status { get; private set; }
		public Packet(string Title, StatusCode Status, string Content)
		{
			this.Title = Title;
			this.Content = Content;
			this.Status = Status;
		}
		public string Time
		{
			get
			{
				var Now = DateTime.Now;
				return string.Format("[{0}/{1}/{2} {3}:{4}:{5}]",Now.Day,Now.Month,Now.Year,Now.Hour,Now.Minute,Now.Second);
			}
		}
	}
	public enum StatusCode
	{
		Success,
		Error,
		LogIn,
		LogOut,
		Chat
	}

	public static class ExtensionClass
	{
		public static string ToJson(this Packet packet)
		{
			return JsonConvert.SerializeObject(packet);
		}
		public static Packet ToPacket(this string packetString)
		{
			return JsonConvert.DeserializeObject<Packet>(packetString);
		}
		public static Packet ToPacket(this object packetString)
		{
			return JsonConvert.DeserializeObject<Packet>(packetString.ToString());
		}
	}
}
