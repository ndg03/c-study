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
        NdgTriangle triangle;
        NdgIsoscelesTriangle isoscelesTriangle;
        NdgArrow arrow;
        NdgPentagon pentagon;
        NdgRightTriangle rightTriangle;

        //绘制
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
            isDrawing = true;
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
            else if (rbtTriangle.Checked)
            {
                triangle = new NdgTriangle();
                triangle.startPoint = e.Location;
                lstGeo.Add(triangle);
            }
            else if (rbtIsoscelesTriangle.Checked)
            {
                isoscelesTriangle = new NdgIsoscelesTriangle();
                isoscelesTriangle.startPoint = e.Location;
                lstGeo.Add(isoscelesTriangle);
            }else if (rbtRightTriangle.Checked)
            {
                rightTriangle= new NdgRightTriangle();
                rightTriangle.Point1 = e.Location;
                lstGeo.Add(rightTriangle);
            }
            else if (rbtArrow.Checked)
            {
                arrow= new NdgArrow();
                arrow.startPoint = e.Location;
                lstGeo.Add(arrow);
            }else if (rbtPentagon.Checked)
            {
                pentagon= new NdgPentagon();
                pentagon.startPoint = e.Location;
                lstGeo.Add(pentagon);
            }
            drawIndex = lstGeo.Count;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
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
                }
                else if (rbtnFreeline.Checked)
                {
                    NdgFreeLine freeLine = (NdgFreeLine)lstGeo[lstGeo.Count - 1];
                    freeLine.lstPoints.Add(e.Location);
                }
                else if (rbtEllipse.Checked)
                {
                    NdgEllipse ellipse = (NdgEllipse)lstGeo[lstGeo.Count - 1];
                    ellipse.w = e.Location.X - ellipse.startPoint.X;
                    ellipse.h = e.Location.Y - ellipse.startPoint.Y;
                }
                else if (rbtTriangle.Checked)
                {
                    NdgTriangle triangle = (NdgTriangle)lstGeo[lstGeo.Count - 1];
                    triangle.Point1 = new Point(triangle.startPoint.X, triangle.startPoint.Y - e.Location.Y);
                    triangle.Point2 = e.Location;
                    triangle.Point3 = new Point((triangle.startPoint.X + e.Location.X) / 2, triangle.startPoint.Y); 
                }else if (rbtIsoscelesTriangle.Checked)
                {
                    NdgIsoscelesTriangle isoscelesTriangle = (NdgIsoscelesTriangle)lstGeo[lstGeo.Count - 1];
                    isoscelesTriangle.Point1 = new Point(isoscelesTriangle.startPoint.X,e.Location.Y);
                    isoscelesTriangle.Point2 = e.Location;
                    isoscelesTriangle.Point3 = new Point((isoscelesTriangle.Point1.X + isoscelesTriangle.Point2.X) / 2, isoscelesTriangle.startPoint.Y);
                }
                else if (rbtRightTriangle.Checked)
                {
                    NdgRightTriangle rightTriangle = (NdgRightTriangle)lstGeo[lstGeo.Count-1];
                    rightTriangle.Point2 = new Point(rightTriangle.Point1.X, e.Location.Y);
                    rightTriangle.Point3 = e.Location;
                }
                else if (rbtArrow.Checked)
                {
                    NdgArrow arrow = (NdgArrow)lstGeo[lstGeo.Count - 1];
                    arrow.Point1 = new Point(arrow.startPoint.X,(arrow.startPoint.Y + e.Location.Y)/2);
                    arrow.Point2 = new Point((arrow.startPoint.X + e.Location.X)/2,arrow.startPoint.Y);
                    arrow.Point3 = new Point(e.Location.X,arrow.Point1.Y);
                    arrow.Point4 = new Point((arrow.startPoint.X + arrow.Point2.X)/2 , e.Location.Y);
                    arrow.Point5 = new Point((e.Location.X + arrow.Point2.X)/2, e.Location.Y);
                    arrow.Point6 = new Point(arrow.Point4.X, arrow.Point1.Y);
                    arrow.Point7 = new Point(arrow.Point5.X , arrow.Point1.Y);
                }else if (rbtPentagon.Checked)
                {
                    NdgPentagon pentagon = (NdgPentagon)lstGeo[lstGeo.Count - 1];
                    pentagon.Point1 = new Point(pentagon.startPoint.X, (pentagon.startPoint.Y + e.Location.Y) / 2);
                    pentagon.Point2 = new Point((pentagon.startPoint.X + e.Location.X) / 2, pentagon.startPoint.Y);
                    pentagon.Point3 = new Point(e.Location.X, pentagon.Point1.Y);
                    pentagon.Point4 = new Point((pentagon.startPoint.X + pentagon.Point2.X) / 2, e.Location.Y);
                    pentagon.Point5 = new Point((e.Location.X + pentagon.Point2.X) / 2, e.Location.Y);
                }
                //刷新
                this.Invalidate();
            }
        }

        //重做
        private void btnRetry_Click(object sender, EventArgs e)
        {
            if (drawIndex <= lstGeo.Count - 1)
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
