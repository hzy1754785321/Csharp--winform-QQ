using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hzy
{

	[Serializable]
	public class Message
	{
		/// <summary>
		/// 执行函数
		/// </summary>
		public int key;
		/// <summary>
		/// 传递参数内容
		/// </summary>
		public List<string> Value;
		/// <summary>
		/// 长度 0:string 1:int
		/// </summary>
		public List<int> length;
	}

	[Serializable]
	public class Result
	{
		/// <summary>
		/// 执行结果   0:失败  1:成功
		/// </summary>
		public int ret;
		/// <summary>
		/// 返回字符内容
		/// </summary>
		public string Value;
	}
	public class UserAccount
	{
		public int userId;
		public string passwd;
		public UserAccount() { }
		public UserAccount(int userId, string passwd)
		{
			this.userId = userId;
			this.passwd = passwd;
		}
		public static UserAccount Parse(string str)
		{
			if (string.IsNullOrEmpty(str))
			{
				return null;
			}
			var args = str.Split(';');
			return new UserAccount() { userId =int.Parse(args[0]), passwd = args[1] };
		}

	}
}
