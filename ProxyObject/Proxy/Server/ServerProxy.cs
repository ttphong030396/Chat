using ProxyObject.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProxyObject.Proxy.Server
{
	public class ServerProxy : MarshalByRefObject
	{
		private List<UserClient> UsersData = new List<UserClient>() {
			new UserClient(){UserId = 1, Username = "tthanhphong", Password ="123",Name ="Thái Thanh Phong"},
			new UserClient(){UserId = 2, Username = "npdat", Password ="123",Name ="Nguyễn Phát Đạt",Online=true},
			new UserClient(){UserId = 3, Username = "nvthe", Password ="123",Name ="Nguyễn Văn Thế"},
			new UserClient(){UserId = 4, Username = "nthieu", Password ="123",Name ="Nguyễn Trung Hiếu"},
			new UserClient(){UserId = 5, Username = "dqtri", Password ="123",Name ="Đoàn Quốc Trí"},
			new UserClient(){UserId = 6, Username = "ntsly", Password ="123",Name ="Nguyễn Thị Sao Ly"}
		};
		public static string ObjectName { get { return typeof(ServerProxy).Name; } }
		public string GetUserOnline(string username)
		{
			var users = UsersData.Where(u => u.Online == true && !u.Username.Equals(username)).ToList();
			return users.ToJson();
		}

		public Packet Login(string username, string password,string Ipaddress)
		{
			var user = UsersData.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
			Packet msg;
			if (user != null)
			{
				user.Online = true;
				user.LastIpAddress = Ipaddress;
				string content = user.ToJSon();
				UpdateUser(user);
				msg = new Packet("Login success", StatusCode.Success, content);
				
			}
			else
			{
				msg = new Packet("Username or password is not correct", StatusCode.Error, user.ToJSon());
			}
			return msg;
		}
		public void Notify(string json)
		{
			Cache.Instance.Notify(json);
		}
		public void UpdateUser(UserClient userUpdate)
		{
			foreach (var user in UsersData)
			{
				if (user.UserId == userUpdate.UserId)
				{
					user.Name = userUpdate.Name;
					user.Online = userUpdate.Online;
					user.Password = userUpdate.Password;
				}
			}
		}
		public void Logout(string packetJson)
		{
			var pket = packetJson.ToPacket();
			var user = pket.Content.ToUserClient();
			user.Online = false;
			UpdateUser(user);
			Cache.Instance.Notify(packetJson);
		}
	}
}
