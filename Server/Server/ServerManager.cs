using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Backend;

namespace Server
{
	class ServerManager
	{
		public static List<Dictionary<int, string>> _serverInterface = new List<Dictionary<int, string>>();

		//public static void LoadInterface()
		//{
		//	StreamReader sr = new StreamReader(@"d:\interface.txt", Encoding.Default);
		//	string line;
		//	var dic = new Dictionary<int, string>();
		//	while ((line = sr.ReadLine()) != null)
		//	{
		//		var temp = line.ToString().Split(',');
		//		dic.Add(int.Parse(temp[0]), temp[1]);
		//		_serverInterface.Add(dic);
		//	}
		//}

		public static void AddDispatcher(int id, string funName)
		{
			var newInterface = new Dictionary<int, string>();
			newInterface.Add(id, funName);
			//var fs = new FileStream(@"d:\interface.txt", FileMode.Create);
			//using (var sw = new StreamWriter(fs))
			//{
			//	foreach (var d in newInterface)
			//	{
			//		sw.Write(d.Key + "," + d.Value);
			//	}
			//	sw.Flush();
			//	sw.Close();
			//	fs.Close();
			_serverInterface.Add(newInterface);
			//}
		}

		public static void InitDispatcher()
		{
			AddDispatcher(1, "ServerUser.User.Login");
			AddDispatcher(2, "ServerUser.User.Register");
			AddDispatcher(3, "ServerUser.User.SetName");
			AddDispatcher(4, "ServerUser.User.SetSign");
			AddDispatcher(5, "ServerUser.User.SetPhoto");
			AddDispatcher(6, "ServerUser.User.ChatWithOther");
			AddDispatcher(7, "ServerUser.User.QueryUserInfo");
		}

		public static string GetFunInfo(int key)
		{
			foreach (var dic in _serverInterface)
			{
				if (dic.TryGetValue(key, out string value))
				{
					return value;
				}
			}
			Log.Error("没有找到对应函数:{0}", key);
			return null;
		}

		public static void DataCheck()
		{
			string strAppPath = Application.StartupPath;
			string QQChatPath = @"\Data\QQChat.db3";
			var strPath = strAppPath + QQChatPath;
			if (!File.Exists(strPath))
			{
				DataStorage.SQLiteHelper.NewDbFile(strPath);
				string tableName = "user";
				DataStorage.SQLiteHelper.NewUserTable(strPath, tableName);
			}
		}
	}
}
