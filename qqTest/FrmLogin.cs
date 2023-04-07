using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qqTest
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void but_login_Click(object sender, EventArgs e)
        {
            string account = tbAccount.Text;
            string password = tbKey.Text;
            if (account == "ndg" && password == "123")
            {
                this.Hide();
                main_1 m1 = new main_1();
                m1.Show();
            }
            else
            {
                //Console.WriteLine("账号或者密码输入错误！请重新输入！");
            }
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_exit_MouseEnter(object sender, EventArgs e)
        {
            //关闭的控件  背景色变成红色
            butExit.BackColor = Color.Red;
        }

        private void but_exit_MouseLeave(object sender, EventArgs e)
        {
            butExit.BackColor = Color.Transparent;
        }

        private int oldX, oldY;
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.oldX = e.X;
                this.oldY = e.Y;
            }
        }
        int seder;
        bool right = true;
        private void pictureBoxHead_MouseEnter(object sender, EventArgs e)
        {
            timerMove.Enabled = true;
            seder = 5;
            right = true;
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            if (pictureBoxPlus.Location.X >= 280 && right)
            {
                seder = 0;
            }
            if (pictureBoxPlus.Location.X <= 200 && !right)
            {
                seder = 0;
            }
            pictureBoxPlus.Location = new Point(pictureBoxPlus.Location.X + seder, pictureBoxPlus.Location.Y);
        }

        private void pictureBoxHead_MouseLeave(object sender, EventArgs e)
        {
            right = false;
            seder = -5;
            //pictureBoxPlus.Location = new Point(pictureBoxPlus.Location.X + seder, pictureBoxPlus.Location.Y);
        }

        //控制窗体移动
        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += (e.X - oldX);
                this.Top += (e.Y - oldY);
            }
        }
    }
}
