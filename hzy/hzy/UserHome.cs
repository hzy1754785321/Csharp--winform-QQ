using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace hzy
{
	public partial class UserHome : Form
	{
		private ContextMenuStrip onlyfornumber;
		public UserHome()
		{
			InitializeComponent();
			onlyfornumber = new ContextMenuStrip();
			onlyfornumber.Items.Add("选择图片");
			onlyfornumber.Items[0].Click += SelectPhoto; 
			UserPhoto.ContextMenuStrip = onlyfornumber;
		}
		private void SetNewPhoto(object sender, MouseEventArgs e)
		{
			base.OnMouseUp(e);
			if (e.Button == MouseButtons.Right)
			{
				choosePhoto.Show(this, e.Location);
			}
		}
		MemoryStream ms;
		public void SelectPhoto(object sender ,EventArgs e)
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
						UserPhoto.Image = Image.FromFile(fileDialog.FileName);
						ms = new MemoryStream();
						Image bi = UserPhoto.Image;
						bi.Save(ms, UserPhoto.Image.RawFormat);
					}
				}
			}
		}

		private void skinTextBox1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void skinTextBox2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void skinLabel2_Click(object sender, EventArgs e)
		{

		}

		private void skinPictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void UserHome_Load(object sender, EventArgs e)
		{

		}

	
	}
}
