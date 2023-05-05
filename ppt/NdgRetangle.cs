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
        {
        }
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
            Bitmap bmp = (Bitmap)Image.FromFile("2.jpg");
            
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
    /// <summary>
    /// 三角形
    /// </summary>
    class NdgTriangle : NdgGeometry
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }
        public Point startPoint { get; set; }
        TextureBrush tb;

        public NdgTriangle()
        {
            Bitmap bmp = (Bitmap)Image.FromFile("3.jpg");
            tb = new TextureBrush(bmp);
        }
        public override void Draw(Graphics g)
        {
            //创建笔
            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle = dashStyle;
            //画三角形
            g.DrawPolygon(pen, new Point[] { Point1, Point2, Point3 });
            //填充三角形
            g.FillPolygon(tb, new Point[] { Point1, Point2, Point3 });
        }
    }
    /// <summary>
    /// 等腰三角形
    /// </summary>
    class NdgIsoscelesTriangle : NdgGeometry
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }
        public Point startPoint { get; set; }
        TextureBrush tb;

        public NdgIsoscelesTriangle()
        {
            Bitmap bmp = (Bitmap)Image.FromFile("4.jpg");
            tb = new TextureBrush(bmp);
        }
        public override void Draw(Graphics g)
        {
            //创建笔
            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle = dashStyle;
            //画三角形
            g.DrawPolygon(pen, new Point[] { Point1, Point2, Point3 });
            //填充三角形
            g.FillPolygon(tb, new Point[] { Point1, Point2, Point3 });
        }
    }
    /// <summary>
    /// 等腰三角形
    /// </summary>
    class NdgRightTriangle : NdgGeometry
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }
        TextureBrush tb;

        public NdgRightTriangle()
        {
            Bitmap bmp = (Bitmap)Image.FromFile("5.jpg");
            tb = new TextureBrush(bmp);
        }
        public override void Draw(Graphics g)
        {
            //创建笔
            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle = dashStyle;
            //画三角形
            g.DrawPolygon(pen, new Point[] { Point1, Point2, Point3 });
            //填充三角形
            g.FillPolygon(tb, new Point[] { Point1, Point2, Point3 });
        }
    }
    /// <summary>
    /// 箭头
    /// </summary>
    class NdgArrow : NdgGeometry
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }
        public Point Point4 { get; set; }
        public Point Point5 { get; set; }

        public Point Point6 { get; set; }
        public Point Point7 { get; set; }
        public Point startPoint { get; set; }
        TextureBrush tb;

        public NdgArrow()
        {
            Bitmap bmp = (Bitmap)Image.FromFile("6.jpg");
            tb = new TextureBrush(bmp);
        }

        public override void Draw(Graphics g)
        {
            //创建笔
            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle = dashStyle;
            //画箭头
            g.DrawPolygon(pen, new Point[] { Point1, Point2, Point3,Point7, Point5, Point4 ,Point6});
            //填充箭头
            g.FillPolygon(tb, new Point[] { Point1, Point2, Point3,Point7, Point5, Point4 , Point6 });
        }
    }
    /// <summary>
    /// 五边形
    /// </summary>
    class NdgPentagon : NdgGeometry
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }
        public Point Point4 { get; set; }
        public Point Point5 { get; set; }
        public Point startPoint { get; set; }

        TextureBrush tb;

        public NdgPentagon()
        {
            Bitmap bmp = (Bitmap)Image.FromFile("7.jpg");
            tb = new TextureBrush(bmp);
        }

        public override void Draw(Graphics g)
        {
            //创建笔
            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle = dashStyle;
            //画五边形
            g.DrawPolygon(pen, new Point[] { Point1, Point2, Point3, Point4, Point5 });
            //填充五边形
            g.FillPolygon(tb, new Point[] { Point1, Point2, Point3, Point5, Point4 });
        }
    }


}
