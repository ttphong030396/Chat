using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProxyObject.Common
{
	public class UserClient
	{
		public int UserId { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
		public string LastIpAddress { get; set; }
		public bool Online { get; set; } = false;
		public UserClient() { }

		
	}
	
	public static class ExtensionMethod
	{
		public static string ToJson(this List<UserClient> users)
		{
			return JsonConvert.SerializeObject(users);
		}
		public static List<UserClient> ToUsersClient(this string UsersJson)
		{
			return JsonConvert.DeserializeObject<List<UserClient>>(UsersJson);
		}
		public static string ToJSon(this UserClient user)
		{
			return JsonConvert.SerializeObject(user);
		}
		public static UserClient ToUserClient(this string user)
		{
			return JsonConvert.DeserializeObject<UserClient>(user);
		}
		public static UserClient ToUserClient(this object user)
		{
			return JsonConvert.DeserializeObject<UserClient>(user.ToString());
		}
		public static List<UserClient> ToUsersClient(this object UsersJson)
		{
			return JsonConvert.DeserializeObject<List<UserClient>>(UsersJson.ToString());
		}
	}
}
