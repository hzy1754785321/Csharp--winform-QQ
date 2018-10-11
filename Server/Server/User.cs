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

		public Result Register(int userId, string name, string passwd)
		{

			var ret = new Result();
			ret.retKey = (int)Interface.register;
			//	ServerManager.AddDispatcher((int)Interface.register, System.Reflection.MethodBase.GetCurrentMethod().Name);
			if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(userId.ToString()) && !string.IsNullOrEmpty(passwd))
			{
				var users = new List<UserAccount>();
				var info = DataStorage.SQLiteHelper.QueryUserInfo(userId);
				if (info != null)
				{
					Log.Error("该ID已存在");
					ret.Value = JsonConvert.SerializeObject(false);
					return ret;
				}
				var now = DateTime.Now;
				DataStorage.SQLiteHelper.CreateUserInfoAsync(userId, now, now, name, passwd);
				Log.Debug("user:{0} register success!", userId);
				ret.Value = JsonConvert.SerializeObject(true);
				return ret;
			}
			Log.Error("账号或密码为空");
			ret.Value = JsonConvert.SerializeObject(false);
			return ret;
		}

		public Result Login(int userId, string passwd)
		{
			var ret = new Result
			{
				retKey = (int)Interface.login
			};
			if (!string.IsNullOrEmpty(userId.ToString()) && !string.IsNullOrEmpty(passwd))
			{
				var users = new List<UserAccount>();
				var info = DataStorage.SQLiteHelper.QueryUserInfo(userId);
				if (info == null || info.passwd.CompareTo(passwd) != 0)
				{
					ret.Value = null;
					Log.Error("该账号不存在或密码错误");
					return ret;
				}
				var now = DateTime.Now;
				info.lastActive = now;
				info.signature = "这个人很懒,什么都没写";
				UpdateUserInfo(info);
				userKey.Add(info.userId, info);
				ret.Value = JsonConvert.SerializeObject(info);
				return ret;
			}
			else
			{
				ret.Value = null;
				Log.Error("账号或密码为空");
				return ret;
			}
		}

		public Result QueryUserInfo(int userId)
		{
			var ret = new Result
			{
				retKey = (int)Interface.userInfo
			};
			if (userKey.TryGetValue(userId, out UserInfo userInfo))
			{
				ret.Value = JsonConvert.SerializeObject(userInfo);
				return ret;
			}
			else
			{
				var info = DataStorage.SQLiteHelper.QueryUserInfo(userId);
				if (info == null)
					ret.Value = JsonConvert.SerializeObject(false);
				else
					ret.Value = JsonConvert.SerializeObject(info);
				return ret;
			}
		}

        public void UserInfoSave(string user)
        {
            var userInfo = JsonConvert.DeserializeObject<UserInfo>(user);
            if (userKey.TryGetValue(userInfo.userId, out UserInfo oldInfo))
            {
                userKey[userInfo.userId] = userInfo;
            }
            UpdateUserInfo(userInfo);
        }

        public void loginOut(int userId)
        { 
            userKey.Remove(userId);
            server.userConnections.Remove(userId);
            _connection.Shutdown(SocketShutdown.Both);
            _connection.Close();
        }

	}
}
