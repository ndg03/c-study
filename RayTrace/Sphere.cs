using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTrace
{
    /// <summary>
    /// 球体类
    /// </summary>
    internal class Sphere
    {
        //球心 + 半径
        Point3D center;
        double radius;

        public Sphere()
        {
            Center = new Point3D();
            radius= 1;
        }
        public Sphere(Point3D c ,double r)
        {
            Center= c;
            radius= r;
        }

        public Sphere(double x,double y,double z,double r)
        {
            Center = new Point3D(x,y,z);
            radius = r;
        }

        public double Radius { get => radius; set => radius = value; }
        internal Point3D Center { get => center; set => center = value; }
    }
}
