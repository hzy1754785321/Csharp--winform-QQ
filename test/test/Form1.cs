using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Diagnostics;

namespace test
{
	public partial class Form1 : Form
	{
		private ContextMenuStrip onlyfornumber;
		string strAppPath = Application.StartupPath;
		public Form1()
		{
			InitializeComponent();
			onlyfornumber = new ContextMenuStrip();
			onlyfornumber.Items.Add("选择图片");
			onlyfornumber.Items[0].Click += button1_Click;
			source.ContextMenuStrip = onlyfornumber;
		}

		MemoryStream ms;
		private static Process p;
		private void button1_Click(object sender, EventArgs e)
		{
			if (p == null)
			{
				p = new Process();
				p.StartInfo.FileName = "Server.exe";
				p.Start();
			}
			else
			{
				if (p.HasExited) //是否正在运行
				{
					p.Start();
				}
			}
			p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;


		//OpenFileDialog fileDialog = new OpenFileDialog();

		//if (fileDialog.ShowDialog() == DialogResult.OK)
		//{
		//	string extension = Path.GetExtension(fileDialog.FileName);
		//	string[] str = new string[] { ".gif", ".jpge", ".jpg" };
		//	if (!((IList)str).Contains(extension))
		//	{
		//		MessageBox.Show("仅能上传gif,jpge,jpg格式的图片！");
		//	}
		//	else
		//	{
		//		FileInfo fileInfo = new FileInfo(fileDialog.FileName);
		//		if (fileInfo.Length > 20480)
		//		{
		//			MessageBox.Show("上传的图片不能大于20K");
		//		}
		//		else
		//		{
		//			source.Image = Image.FromFile(fileDialog.FileName);
		//			ms = new MemoryStream();
		//			Image bi = source.Image;
		//			bi.Save(ms, source.Image.RawFormat);
		//			byte[] bytes = null;
		//			bytes = ms.ToArray();
		//			listBox1.Items.Add(bytes);
		//			string strPath = strAppPath + "\\Image\\photo.png";
		//			using (var fsWrite = new FileStream(strPath, FileMode.Append))
		//			{
		//				fsWrite.Write(bytes, 0, bytes.Length);
		//			}
		//		}
		//	}
		//}
	}


		private void button2_Click(object sender, EventArgs e)
		{
			Process[] pProcess;
			pProcess = Process.GetProcesses();
			for (int i = 1; i <= pProcess.Length - 1; i++)
			{
				if (pProcess[i].ProcessName == "Server")   //任务管理器应用程序的名
				{
					pProcess[i].Kill();
					break;
				}
			}
				//string strpath = strapppath + "\\image\\photo.png";
				//using (var fsread = new filestream(strpath, filemode.open))
				//{
				//	int fslen = (int)fsread.length;
				//	byte[] hebyte = new byte[fslen];
				//	int r = fsread.read(hebyte, 0, hebyte.length);
				//	string mystr = encoding.utf8.getstring(hebyte);
				//	listbox1.items.add(hebyte);
				//	var ts = new memorystream(hebyte);
				//	ts.position = 0;
				//	var img = image.fromstream(ts);
				//	target.image = img;
				//	ts.close();
				//}
			}

		private void SetNewPhoto(object sender, MouseEventArgs e)
		{
			base.OnMouseUp(e);
			if (e.Button == MouseButtons.Right)
			{
				skinContextMenuStrip1.Show(this, e.Location);
			}
		}
	}
}
