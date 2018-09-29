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
	public partial class AddGroup : Form
	{
		public int mineId;
		public AddGroup()
		{
			InitializeComponent();
		}

		public void Search(object sender, EventArgs e)
		{
			if (!IsInt(searchText.Text))
			{
				MessageBox.Show("请输入正确的用户ID!");
				return;
			}
		}

		public static bool IsInt(string str)
		{
			try
			{
				int a = Convert.ToInt32(str);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

	}
}
