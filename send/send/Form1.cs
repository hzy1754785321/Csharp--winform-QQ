using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinFormSendMsg
{
    public partial class Form1 : Form
    {
        const int WM_COPYDATA = 0x004A;
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(
            int hWnd, // handle to destination window
            int Msg, // message
            int wParam, // first message parameter
            ref COPYDATASTRUCT lParam // second message parameter
        );

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern int FindWindow(string lpClassName, string lpWindowName);

        private void button1_Click(object sender, EventArgs e)
        {
            //int WINDOW_HANDLER = FindWindow(null, @"欲发送程序窗口的标题");
            int WINDOW_HANDLER = FindWindow(null, @"getMessage");
            if (WINDOW_HANDLER != 0)
            {
                byte[] sarr = System.Text.Encoding.Default.GetBytes(this.textBox1.Text);
                int len = sarr.Length;
                COPYDATASTRUCT cds;
                cds.dwData = (IntPtr)100;
                cds.lpData = this.textBox1.Text;
                cds.cbData = len + 1;
                SendMessage(WINDOW_HANDLER, WM_COPYDATA, 0, ref cds);
            }
        }
    }

    public struct COPYDATASTRUCT
    {
        public IntPtr dwData;
        public int cbData;
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpData;
    }
}