using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NK_CSharp
{
    public partial class MainForm : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MyThreadProc()
        {
            Application.Run(new Success());
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            string str_un = text_Username.Text.ToString();
            string str_pw = text_Password.Text.ToString();            
            if (str_un.Length == 0 || str_pw.Length == 0)
            {
                MessageBox.Show("用户名和密码均不能为空，请检查");
            }
            else
            {
                User aUser = new User(str_un, str_pw);
                bool isDialSuccess = true;// aUser.dial();
                if (isDialSuccess)
                {
                    Success sf = new Success();
                    this.Hide();
                    System.Threading.Thread mt = new System.Threading.Thread(new System.Threading.ThreadStart(MyThreadProc));
                    mt.Start();
                    this.Dispose();
                }
                else
                {
                    label_ReturnInfo.Text = "拨号失败";
                }
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
    }
}
