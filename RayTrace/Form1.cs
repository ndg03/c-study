using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayTrace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //测试代码
            /*Point3D org = new Point3D(1, -2, -1);
            Vector3D dir = new Vector3D(1,2,4);
            Ray ray = new Ray(org,dir);

            Point3D center = new Point3D(3,0,5);
            Sphere sphere = new Sphere(center, 3);
            HitRecord hr = ray.Hit(sphere);
            label1.Text = hr.ToString();*/

            //成像平面
            ViewPlan vp = new ViewPlan();
            vp.leftTopLoc = new Point3D(-1, 1, 0);
            vp.w = 2;
            vp.h = 2;
            vp.resW = 800;
            vp.resH = 800;

            //步长
            double xStep = vp.w / vp.resW;
            double yStep = vp.h / vp.resH;

            //球体
            Point3D center = new Point3D(0, 0, -10);
            double radius = 1;
            Sphere sp = new Sphere(center, radius);

            //图片
            Bitmap bmp = new Bitmap(vp.resW, vp.resH);

            //摄像机
            Point3D eye = new Point3D(0, 0, 20);

            //生成每个从  摄像机所在位置，往成像平面的每个像素点生成一条光线
            for (int i = 0; i < vp.resW; i++)
            {
                for (int j = 0; j < vp.resH; j++)
                {
                    Point3D pixelLoc = new Point3D(
                        vp.leftTopLoc.X + xStep * i,
                        vp.leftTopLoc.Y - yStep * j,
                        0);
                    Vector3D dir = pixelLoc - eye;
                    //dir.nomalLize();//归一化    
                    Ray ray = new Ray(eye, dir);
                    //每条光线与球体相交
                    HitRecord hr = ray.Hit(sp);

                    if (hr.IsHit == true)
                    {
                        bmp.SetPixel(i, j, Color.Pink);
                    }
                    else
                    {
                        bmp.SetPixel(i, j, Color.White);
                    }
                }
            }//for 循环结束

            //显示图片
            this.BackgroundImage = bmp;
        }
    }
}
