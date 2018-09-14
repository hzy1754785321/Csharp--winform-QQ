using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Data.SQLite;
using Backend;
using Server;

namespace ServerUser
{
	public partial class User
	{
		public static Dictionary<int, UserInfo> userKey = new Dictionary<int, UserInfo>();
		public static Socket _connection ;
		
		public User()
		{ }

		public bool Register(int userId, string name, string passwd)
		{
			//	ServerManager.AddDispatcher((int)Interface.register, System.Reflection.MethodBase.GetCurrentMethod().Name);
			if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(userId.ToString()) && !string.IsNullOrEmpty(passwd))
			{
				var users = new List<UserAccount>();
				var info = DataStorage.SQLiteHelper.QueryUserInfo(userId);
				if (info != null)
				{
					Log.Error("该ID已存在");
					return false;
				}
				var now = DateTime.Now;
				DataStorage.SQLiteHelper.CreateUserInfoAsync(userId, now, now, name, passwd);
				Log.Debug("user:{0} register success!", userId);
				return true;
			}
			Log.Error("账号或密码为空");
			return false;
		}

		public Result Login(int userId, string passwd)
		{
			var ret = new Result();
			if (!string.IsNullOrEmpty(userId.ToString()) && !string.IsNullOrEmpty(passwd))
			{
				var users = new List<UserAccount>();
				var info = DataStorage.SQLiteHelper.QueryUserInfo(userId);
				if (info == null)
				{
					Log.Error("该账号不存在");
					ret.ret = 0;
					return ret;
				}
				if (info.passwd.CompareTo(passwd) != 0)
				{
					Log.Error("密码错误");
					ret.ret = -1;
					return ret;
				}
				var now = DateTime.Now;
				info.lastActive = now;
				info.signature = "这个人很懒,什么都没写";
				UpdateUserInfo(info);
				userKey.Add(info.userId, info);
				ret.ret = 1;
				ret.Value = JsonConvert.SerializeObject(info);
				return ret;
			}
			else
			{
				Log.Error("账号或密码为空");
				ret.ret = -2;
				return ret;
			}
		}
	}
}
