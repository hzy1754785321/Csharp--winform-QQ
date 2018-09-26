using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend;
using Server;
using System.Net.Sockets;
using Newtonsoft.Json;

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

		public void ChatWithOther(string msg)
		{
			var chatMessage = JsonConvert.DeserializeObject<ChatMessage>(msg);
			if (server.userConnections.TryGetValue(chatMessage.targetId, out Socket socket))
			{
				var ret = new Result();
				ret.retKey = (int)Interface.message;
				ret.Value = JsonConvert.SerializeObject(chatMessage);
				var retStr = JsonConvert.SerializeObject(ret);
				server.SendMessage(socket,retStr);
			}
			else
			{
				var friend = new FriendInfo();
				friend.friendId = chatMessage.targetId;
				friend.history.Add(chatMessage);
				if (userKey.TryGetValue(chatMessage.chatId, out UserInfo userInfo))
				{
					userInfo.friend.Add(friend);
					userInfo.historyId.Add(chatMessage.targetId);
					UpdateUserInfo(userInfo);
				}
				else
				{
					var info = DataStorage.SQLiteHelper.QueryUserInfo(chatMessage.chatId);
					if (info != null)
					{
						info.friend.Add(friend);
						info.historyId.Add(chatMessage.targetId);
						UpdateUserInfo(info);
					}
				}
			}
		}

		public void addFriend(int mineId,int friendId)
		{
			if (userKey.TryGetValue(mineId, out UserInfo userInfo))
			{
				UserInfo
			}

	}
}
