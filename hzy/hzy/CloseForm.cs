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
    public partial class CloseForm : Form
    {
        public int _userId;

        public CloseForm()
        {
            InitializeComponent();
            CenterToScreen();
            close.Checked = false;
            noClose.Checked = false;
        }

        public void WantClose(object ssender, EventArgs e)
        {
            if (close.Checked)
            {
                UserHome.CloseMain(_userId);
                this.Close();
            }
        }

        public void NoCloseCheck(object sender, EventArgs e)
        {
            if (noClose.Checked)
            {
                UserHome.NoCloseMain();
                this.Close();
            }
        }
    }
}
