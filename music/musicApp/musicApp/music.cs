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

		List<>

		private void music_Load(object sender, EventArgs e)
		{

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
