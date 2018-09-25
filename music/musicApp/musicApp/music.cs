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
using System.Media;

namespace musicApp
{
	public partial class music : Form
	{
		public music()
		{
			InitializeComponent();
		}

		public static bool isStart;
		List<string> musicPath = new List<string>();

		public void OpenClick(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "请选择音乐文件";
			ofd.InitialDirectory = @"D:\Music";
			ofd.Multiselect = true;
			ofd.Filter = @"音乐文件|*.mp3||*.wav|所有文件|*.*";
			ofd.ShowDialog();
			string[] path = ofd.FileNames;
			for (int i = 0; i < path.Length; i++)
			{
				musicList.Items.Add(Path.GetFileName(path[i]));
				musicPath.Add(path[i]);
			}
		}

		
		SoundPlayer sp = new SoundPlayer();
		static FileStream fs;
		public void PlayMusic_Double_Click(object sender, EventArgs e)
		{
			SoundPlayer sp = new SoundPlayer();
			sp.SoundLocation = musicPath[musicList.SelectedIndex];
			if (!isStart)
			{
				isStart = true;
				Start.Text = "暂停";
				sp.Play();
			}
			else
			{
				isStart = false;
				Start.Text = "播放";
				sp.Stop();
			}
		}


		public void PlayerMusic(object sender, EventArgs e)
		{
			SoundPlayer sp = new SoundPlayer();
			sp.SoundLocation = musicPath[musicList.SelectedIndex];
			if (!isStart)
			{
				isStart = true;
				Start.Text = "暂停";
				sp.Play();
			}
			else
			{
				isStart = false;
				Start.Text = "播放";
				sp.Stop();
			}
		}

		public void NextMusic(object sender, EventArgs e)
		{
			int index = musicList.SelectedIndex;
			index++;
			if (index == musicList.Items.Count)
			{
				index = 0;
			}
			musicList.SelectedIndex = index;
			sp.SoundLocation = musicPath[index];
			sp.Play();
		}

		public void LastMusic(object sender, EventArgs e)
		{
			int index = musicList.SelectedIndex;
			index--;
			if (index < 0)
			{
				index = musicList.Items.Count - 1;
			}
			musicList.SelectedIndex = index;
			sp.SoundLocation = musicPath[index];
			sp.Play();
		}

		private void button1_Paint(object sender, PaintEventArgs e)
		{
			Button btn = sender as Button;
			System.Drawing.Drawing2D.GraphicsPath btnPath = new System.Drawing.Drawing2D.GraphicsPath();
			System.Drawing.Rectangle newRectangle = btn.ClientRectangle;
			newRectangle.Inflate(-2, -1);
			e.Graphics.DrawEllipse(System.Drawing.Pens.BlanchedAlmond, newRectangle);
			newRectangle.Inflate(-2, -4);
			btnPath.AddEllipse(newRectangle);
			btn.Region = new System.Drawing.Region(btnPath);
		}
	}
}
