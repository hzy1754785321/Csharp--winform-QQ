using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;

namespace musicApp
{
	public partial class MediaPlay : Form
	{
        const int WM_COPYDATA = 0x004A;
        public MediaPlay()
		{
			InitializeComponent();
		}

        public MediaPlay(string str)
        {
            InitializeComponent();
            MediaList.Items.Add(Path.GetFileName(str));
            mediaPath.Add(str);
            MediaPlayer.URL = mediaPath[0];
            MediaPlayer.Ctlcontrols.play();
        }

		public List<string> mediaPath = new List<string>();

		public void OpenMedia(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "请选择视频文件";
			ofd.InitialDirectory = @"D:\Media";
			ofd.Multiselect = true;
			ofd.Filter = @"视频文件|*.mp4||*.mov|所有文件|*.*";
			ofd.ShowDialog();
			string[] path = ofd.FileNames;
			for (int i = 0; i < path.Length; i++)
			{
				MediaList.Items.Add(Path.GetFileName(path[i]));
				mediaPath.Add(path[i]);
			}
		}

		public void StartMedia(object sender, EventArgs e)
		{
			var index = MediaList.SelectedIndex;
			MediaPlayer.URL = mediaPath[index];
			MediaPlayer.Ctlcontrols.play();
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
                byte[] sarr = System.Text.Encoding.Default.GetBytes(mediaPath[MediaList.SelectedIndex]);
                int len = sarr.Length;
                COPYDATASTRUCT cds;
                cds.dwData = (IntPtr)100;
                cds.lpData = mediaPath[MediaList.SelectedIndex];
                cds.cbData = len + 1;
                cds.type = 1; //视频
                SendMessage(WINDOW_HANDLER, WM_COPYDATA, 0, ref cds);
            }
        }
    }
}
