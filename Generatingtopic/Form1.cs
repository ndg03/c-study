using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generatingtopic
{
    public partial class Form1 : Form
    {
        int opLeft = 1;//操作数A
        int opRight = 1;//操作数B
        string operater = "+";//运算符
        double result = 2;//标准答案
        public Form1()
        {
            InitializeComponent();
        }
        private void but_setquestion_Click(object sender, EventArgs e)
        {
            //出题！！！
            //随机生成两个操作数
            Random rnd = new Random();
            opLeft = rnd.Next(10);
            opRight = rnd.Next(10);
            //一个操作符号
            int opr = rnd.Next(4);//运算符(0:+ )
            //在对应控件上显示运算式子     
            switch (opr)
            {
                case 0:
                    operater = "+";
                    result = opLeft + opRight;
                    break;
                case 1:
                    operater = "-";
                    result = opLeft - opRight;
                    break;
                case 2:
                    operater = "*";
                    result = opLeft * opRight;
                    break;
                case 3:
                    operater = "/";
                    if (opRight == 0)
                    {
                        opRight = rnd.Next(1,10);
                    }
                    result = opLeft * 1.0 / opRight;
                    result = Math.Round(result, 2);
                    break;
            }
            lbl_left.Text = opLeft.ToString();
            lbl_right.Text = opRight.ToString();
            lbl_char.Text = operater;
            textBox1.Text = String.Empty;
        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            //用户的输入允许为整数和小数
            double userAns;
            if (double.TryParse(textBox1.Text, out userAns))
            {
                // 使用Math.Abs函数处理浮点数比较的精度问题
                if (Math.Abs(userAns - result) < 0.0001)
                {
                    string strT = "\t" + opLeft + operater + opRight + "="
                        + result + "\t\t回答正确";
                    listbox_show.Items.Add(strT);
                }
                else
                {
                    string strF = "\t" + opLeft + operater + opRight + "="
                        + result + "\t\t回答错误！！！";
                    listbox_show.Items.Add(strF);
                }
            }
        }
    }
}
