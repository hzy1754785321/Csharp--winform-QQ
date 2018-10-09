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
using System.Runtime.InteropServices;

namespace musicApp
{
	public partial class music : Form
	{
        const int WM_COPYDATA = 0x004A;
        public music()
		{
			InitializeComponent();
		}

        public music(string[] str)
        {
            if (str.Length == 1)
            {
                InitializeComponent();
                musicList.Items.Add(Path.GetFileName(str[0]));
                musicPath.Add(str[0]);
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = musicPath[0];
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
            else
            {
                MediaPlay mp = new MediaPlay(str[0]);
                mp.Show();
            }
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

		public void GotoMedia(object sender,EventArgs e)
		{
			MediaPlay mp = new MediaPlay();
			mp.MdiParent = this.MdiParent;
			mp.Show();
			this.Hide();
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



        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(
            int hWnd,
            int Msg,
            int wParam, 
            ref COPYDATASTRUCT lParam
        );

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern int FindWindow(string lpClassName, string lpWindowName);

        private void button1_Click(object sender, EventArgs e)
        {
            //int WINDOW_HANDLER = FindWindow(null, @"欲发送程序窗口的标题");
            int WINDOW_HANDLER = FindWindow(null, @"Chat");
            if (WINDOW_HANDLER != 0)
            {
                byte[] sarr = System.Text.Encoding.Default.GetBytes(musicPath[musicList.SelectedIndex]);
                int len = sarr.Length;
                COPYDATASTRUCT cds;
                cds.dwData = (IntPtr)100;
                cds.lpData = musicPath[musicList.SelectedIndex];
                cds.cbData = len + 1;
                cds.type = 0; //音乐
                SendMessage(WINDOW_HANDLER, WM_COPYDATA, 0, ref cds);
            }
        }
    }

    public struct COPYDATASTRUCT
    {
        public IntPtr dwData;
        public int cbData;
        public int type;
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpData;
    }

}
