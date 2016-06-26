using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotRas;

namespace NK_CSharp
{
    public partial class Success : Form
    {
        RasDialer dialer = null;
        System.Collections.ObjectModel.ReadOnlyCollection<RasConnection> rasConnList = RasConnection.GetActiveConnections();
        public Success()
        {
            InitializeComponent();
        }
        public Success(RasDialer dialer)
        {
            InitializeComponent();
            this.dialer = dialer;
        }
        private void button_ToTaskBar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            this.Netkeeper.Visible = true;
        }

        private void button_HangUp_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (RasConnection rasConn in rasConnList)
                {
                    rasConn.HangUp();
                }
                System.Threading.Thread.Sleep(1000);
                MessageBox.Show("注销成功", "Black☆Rock Shooter ┏ (゜ω゜)=☞");
                MainForm mf = new MainForm();
                mf.label_ReturnInfo.Text = "已注销";
                this.Hide();
                mf.ShowDialog();
                this.Dispose();

            }
            catch (Exception)
            {
                MessageBox.Show("注销出现异常，点击确定关闭程序", "Black☆Rock Shooter ┏ (゜ω゜)=☞");
            }
        }

        private void Netkeeper_Click(object sender, EventArgs e)
        {
            this.Netkeeper.Visible = false;
            this.Visible = true;
        }
    }
}
