using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g = null;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //实例化
            g = e.Graphics;
            //自定义钢笔对象
            Pen pen = new Pen(Color.Black,1000);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            if(lstAllPoint.Count >= 2)
            {
                //画直线
                //g.DrawLine(Pens.Black, 0, 0, 1000, 1000);
                g.DrawLines(pen, lstAllPoint.ToArray());   
            }
            for(int i = 0; i < lstAllPoint.Count; i++)
            {
                Color rndColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                SolidBrush sb = new SolidBrush(rndColor);
                g.FillEllipse(sb, lstAllPoint[i].X-15, lstAllPoint[i].Y-15, 30, 30);
            }  
        }
        //存放所有的移动轨迹
        List<Point> lstAllPoint = new List<Point>();
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            /*lstAllPoint.Add(e.Location);

            this.Invalidate();//重绘*/
        }
        Random r = new Random();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //随机生成一个点
            lstAllPoint.Add(e.Location);
            this.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = r.Next(this.Width);
            int y = r.Next(this.Height);
            lstAllPoint.Add(new Point(x, y));
            this.Invalidate();
        }
    }
}
