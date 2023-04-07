using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screensaver_Zhiyin
{
    public partial class FrmScreen : Form
    {
        int delty = 120;//y轴的偏移量
        int deltx = 160;//x轴的偏移量
        public FrmScreen()
        {
            InitializeComponent();
        }

        private void tim_ngm_Tick(object sender, EventArgs e)
        {
            lbl_ngm.Top += delty;
            lbl_ngm.Left += deltx;

            if(lbl_ngm.Top +lbl_ngm.Height  > this.Height || lbl_ngm.Top < 0)
            {
                //设置偏移量为负数
                //lbl_ngm.Top -= 10;
                delty = -delty;
                
            }
            if(lbl_ngm.Left + lbl_ngm.Width > this.Width  || lbl_ngm.Left < 0)
            {
                deltx= -deltx;
            }
        }

        private void FrmScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }
    }
}
