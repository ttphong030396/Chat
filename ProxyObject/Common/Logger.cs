using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProxyObject.Common
{
	public class Logger
	{
		private static string path = "./system.user.dll";

		public static void WriteLine(string input, bool Append)
		{
			using (var sw = new StreamWriter(path, Append))
			{
				sw.Write(Serialize(input).ToString());
			}
		}
		public static string ReadLine()
		{
			try
			{
				using (var sr = new StreamReader(path))
				{
					return Deserialize(sr.ReadLine());
				}
			}
			catch (Exception)
			{
				return string.Empty;
			}
		}

		private static string Serialize(string input)
		{
			using (var ms = new MemoryStream())
			{
				BinaryFormatter bf = new BinaryFormatter();
				bf.Serialize(ms, input);
				return ToString(ms.ToArray());
			}
		}
		private static string Deserialize(string input)
		{
			byte[] a = ToArray(input);
			using (var ms = new MemoryStream(a))
			{
				BinaryFormatter bf = new BinaryFormatter();
				return bf.Deserialize(ms).ToString();
			}
		}

		private static string ToString(byte[] arrayBytes)
		{
			string ret = "";
			foreach (byte byt in arrayBytes)
				ret += byt + "-";
			return ret.Trim('-');
		}
		private static byte[] ToArray(string input)
		{
			string[] inputarray = input.Split('-');
			byte[] ret = new byte[inputarray.Length];
			int index = 0;
			foreach (var item in inputarray)
			{
				ret[index++] = byte.Parse(item);
			}
			return ret;
		}
	}
}
