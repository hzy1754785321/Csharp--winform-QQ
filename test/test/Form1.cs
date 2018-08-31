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

namespace test
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		MemoryStream ms;
		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();

			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				string extension = Path.GetExtension(fileDialog.FileName);
				string[] str = new string[] { ".gif", ".jpge", ".jpg" };
				if (!((IList)str).Contains(extension))
				{
					MessageBox.Show("仅能上传gif,jpge,jpg格式的图片！");
				}
				else
				{
					FileInfo fileInfo = new FileInfo(fileDialog.FileName);
					if (fileInfo.Length > 20480)
					{
						MessageBox.Show("上传的图片不能大于20K");
					}
					else
					{
						source.Image = Image.FromFile(fileDialog.FileName);
						ms = new MemoryStream();
						Image bi = source.Image;
						bi.Save(ms, source.Image.RawFormat);
					}
				}
			}
		}


		private void button2_Click(object sender, EventArgs e)
		{
			Image img = Image.FromStream(ms, true);
			target.Image = img;
			ms.Close();
		}

		private void SetNewPhoto(object sender, PreviewKeyDownEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Right:
					if (button1.ContextMenuStrip != null)
					{
						button1.ContextMenuStrip.Show(button1,
							new Point(0, button1.Height), ToolStripDropDownDirection.BelowRight);
					}
					break;
				default:
					break;
			}
		}
	}
}
