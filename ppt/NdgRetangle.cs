using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppt
{
    class NdgGeometry
    {
        public Color fillColor = Color.Pink;
        public Color frameColor = Color.Black;
        public int frameWidth = 3;
        public DashStyle dashStyle = DashStyle.Dash;

        public virtual void Draw(Graphics g)
        {}
    }
    /// <summary>
    /// 矩形
    /// </summary>
    internal class NdgRetangle:NdgGeometry
    {
        public Point startPoint;
        public int w;
        public int h;
        TextureBrush tb;
        public NdgRetangle()
        {
            Bitmap bmp = (Bitmap)Image.FromFile("1.jpg");
            tb = new TextureBrush(bmp);
            //不平铺
            //tb.WrapMode = System.Drawing.Drawing2D.WrapMode.Clamp;
        }
        public override void Draw(Graphics g)
        {
            /*SolidBrush sb = new SolidBrush(fillColor);*/
            g.FillRectangle(tb,startPoint.X,startPoint.Y,w,h);
            //画边框
            //创建笔
            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle= dashStyle;
            g.DrawRectangle(pen,startPoint.X,startPoint.Y,w,h);
        }
    }
    /// <summary>
    /// 涂鸦线
    /// </summary>
    class NdgFreeLine:NdgGeometry
    {
        public List<Point> lstPoints = new List<Point>();
        
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(fillColor, 3);
            g.DrawLines(pen,lstPoints.ToArray());
        }
    }
    /// <summary>
    /// 椭圆
    /// </summary>
    internal class NdgEllipse:NdgGeometry
    {
        public Point startPoint;
        public int w;
        public int h;
        TextureBrush tb;
        public NdgEllipse()
        {
            Bitmap bmp = (Bitmap)Image.FromFile("1.jpg");
            
            tb = new TextureBrush(bmp);
        }
        public override void Draw(Graphics g)
        {
            //填充
            /*SolidBrush sb = new SolidBrush(fillColor);*/
            g.FillEllipse(tb, startPoint.X, startPoint.Y, w, h);
            //画边框
            //创建笔
            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle = dashStyle;
            g.DrawEllipse(pen, startPoint.X, startPoint.Y, w, h);
        }
    }
}
