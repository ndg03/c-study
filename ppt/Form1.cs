using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g = null;
        bool isDrawing = false;
        List<NdgGeometry> lstGeo = new List<NdgGeometry>();

        NdgRetangle rect;
        NdgFreeLine freeLine;
        NdgEllipse ellipse;

        //绘制矩形
        int drawIndex = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            for (int i = 0; i < drawIndex; i++)
            {
                lstGeo[i].Draw(g);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing= true;
            //如果用户选择的是矩形
            if (rbtnRectangle.Checked)
            {
                rect = new NdgRetangle();
                rect.startPoint = e.Location;
                lstGeo.Add(rect);
            }
            else if (rbtnFreeline.Checked)
            {
                freeLine = new NdgFreeLine();
                freeLine.lstPoints.Add(e.Location);
                lstGeo.Add(freeLine);
            }
            else if (rbtEllipse.Checked)
            {
                ellipse = new NdgEllipse();
                ellipse.startPoint = e.Location;
                lstGeo.Add(ellipse);
            }
            drawIndex = lstGeo.Count;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing= false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (rbtnRectangle.Checked)
                {
                    //最后一个
                    NdgRetangle rect = (NdgRetangle)lstGeo[lstGeo.Count - 1];
                    rect.w = e.Location.X - rect.startPoint.X;
                    rect.h = e.Location.Y - rect.startPoint.Y;
                }else if (rbtnFreeline.Checked)
                { 
                    NdgFreeLine freeLine = (NdgFreeLine)lstGeo[lstGeo.Count - 1];
                    freeLine.lstPoints.Add(e.Location);
                }else if (rbtEllipse.Checked)
                {
                    NdgEllipse ellipse = (NdgEllipse)lstGeo[lstGeo.Count - 1];
                    ellipse.w = e.Location.X - ellipse.startPoint.X;
                    ellipse.h = e.Location.Y - ellipse.startPoint.Y;
                }
                //刷新
                this.Invalidate();
            }
        }

        //重做
        private void btnRetry_Click(object sender, EventArgs e)
        {
            if(drawIndex < lstGeo.Count - 1)
            {
                drawIndex++;
            }
            this.Invalidate();
        }
        //撤销
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (drawIndex > 0)
            {
                drawIndex--;
            }
            this.Invalidate();
        }
    }
}
