using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hzy
{
	public partial class Loading : Form
	{
		public Loading()
		{
			InitializeComponent();
			TopMost = true;  //置顶
			FormBorderStyle = FormBorderStyle.None;
			CenterToScreen();
		}

	}
}
