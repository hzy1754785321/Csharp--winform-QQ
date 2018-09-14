using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend;
using Server;
using System.Net.Sockets;

namespace ServerUser
{
	public partial class User
	{
		public void SetName(int userId, string name)
		{
			if (userKey.TryGetValue(userId, out UserInfo userInfo))
			{
				userInfo.name = name;
				UpdateUserInfo(userInfo);
			}
		}

		public void SetSign(int userId, string sign)
		{
			if (userKey.TryGetValue(userId, out UserInfo userInfo))
			{
				userInfo.signature = sign;
				UpdateUserInfo(userInfo);
			}
			else
			{
				var info = DataStorage.SQLiteHelper.QueryUserInfo(userId);
			}
		}

		public void SetPhoto(int userId, string photo)
		{
			if (userKey.TryGetValue(userId, out UserInfo userInfo))
			{
				userInfo.photo = photo;
				UpdateUserInfo(userInfo);
			}
		}

		public void ChatWithOther(int userId, string content)
		{
			if(server.userConnections.TryGetValue(userId,out Socket socket))
			{
				server.SendMessage(socket, content);
			}
		}

	}
}
