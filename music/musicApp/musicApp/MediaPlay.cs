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

namespace musicApp
{
	public partial class MediaPlay : Form
	{
		public MediaPlay()
		{
			InitializeComponent();
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
	}
}
