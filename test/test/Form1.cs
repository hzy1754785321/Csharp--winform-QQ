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
using Newtonsoft.Json;

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
			//if (p == null)
			//{
			//	p = new Process();
			//	p.StartInfo.FileName = "Server.exe";
			//	p.Start();
			//}
			//else
			//{
			//	if (p.HasExited) //是否正在运行
			//	{
			//		p.Start();
			//	}
			//}
			//p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;


			OpenFileDialog filedialog = new OpenFileDialog();

			if (filedialog.ShowDialog() == DialogResult.OK)
			{
				string extension = Path.GetExtension(filedialog.FileName);
				string[] str = new string[] { ".gif", ".jpge", ".jpg" };
				if (!((IList)str).Contains(extension))
				{
					MessageBox.Show("仅能上传gif,jpge,jpg格式的图片！");
				}
				else
				{
					var fileinfo = new FileInfo(filedialog.FileName);
					if (fileinfo.Length > 20480)
					{
						MessageBox.Show("上传的图片不能大于20k");
					}
					else
					{
						source.Image = Image.FromFile(filedialog.FileName);
						ms = new MemoryStream();
						var bi = source.Image;
						bi.Save(ms, source.Image.RawFormat);
						byte[] bytes = null;
						object ob = new object();
						bytes = ms.ToArray();
						var sbt1 = Convert.ToBase64String(bytes);

						var sbt = Encoding.ASCII.GetString(bytes);
						//			var tbs = Encoding.ASCII.GetBytes(sbt);
						//		var sbt1 = Encoding.Unicode.GetString(bytes);
						//	var tbs1 = Encoding.Unicode.GetBytes(sbt1);
						//			listBox1.Items.Add(tbs.Length.ToString());
						//		listBox1.Items.Add(tbs1.Length.ToString());
						//	ob = bytes;
						ob = sbt1;
						var test = new testInfo();
						test.test = ob;
						var type = test.test.GetType();
						listBox1.Items.Add(type.ToString());
						listBox1.Items.Add(bytes.Length.ToString());
						var msg = JsonConvert.SerializeObject(test);
						var newTest = new testInfo();
						newTest = JsonConvert.DeserializeObject<testInfo>(msg);
						var type1 = newTest.test.GetType();
						string ss = newTest.test as string;
						//	var newByte = Encoding.ASCII.GetBytes(ss);
						var newByte = Convert.FromBase64String(ss);
						listBox1.Items.Add(type1.ToString());
						listBox1.Items.Add(newByte.Length);

						var ts = new MemoryStream(newByte);
						ts.Position = 0;
						try
						{
							var img = Image.FromStream(ts);
							target.Image = img;
						}
						catch(Exception ex)
						{
							listBox1.Items.Add(ex.Message);
						}
						ts.Close();

						//	string strpath = strAppPath + "\\image\\photo.png";
						//using (var fswrite = new FileStream(strpath, FileMode.Append))
						//{
						//	fswrite.Write(bytes, 0, bytes.Length);
						//}
					}
				}
			}
		}

		[Serializable]
		public class testInfo
		{
			public object test;
		}


		private void button2_Click(object sender, EventArgs e)
		{
			//Process[] pProcess;
			//pProcess = Process.GetProcesses();
			//for (int i = 1; i <= pProcess.Length - 1; i++)
			//{
			//	if (pProcess[i].ProcessName == "Server")   //任务管理器应用程序的名
			//	{
			//		pProcess[i].Kill();
			//		break;
			//	}
			//}
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
