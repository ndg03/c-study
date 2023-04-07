using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayTrace
{
    /// <summary>
    /// 光线
    /// </summary>
    internal class Ray
    {
        //起点 和 方向
        Point3D org;

        Vector3D dir;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="org"></param>
        /// <param name="dir"></param>
        public Ray(Point3D org, Vector3D dir)
        {
            this.org = org;
            this.dir = dir;
        }
        public HitRecord Hit(Sphere sphere)
        {
            HitRecord hr = new HitRecord();

            dir.nomalLize();
            /*double A = dir.A * dir.A + dir.B * dir.B + dir.C * dir.C;*/
            double A = 1;
            double B = 2 * (dir.A * (org.X - sphere.Center.X)
                + dir.B * (org.Y - sphere.Center.Y)
                + dir.C * (org.Z - sphere.Center.Z));
            double C = (org.X - sphere.Center.X) * (org.X - sphere.Center.X)
                + (org.Y - sphere.Center.Y) * (org.Y - sphere.Center.Y)
                + (org.Z - sphere.Center.Z) * (org.Z - sphere.Center.Z)
                - sphere.Radius * sphere.Radius;
            double delta2 = B * B - 4 * A * C;
            if (delta2 < 0)
            {
                hr.IsHit = false;
                return hr;
                /*return new Point3D(0, 0, 0);*/
            }
            else
            {
                hr.IsHit = true;

                double delta = Math.Sqrt(delta2);
                /*double t0 = (-B - delta) / (2 * A);*/
                double t0 = (-B - delta) / 2;
                Point3D hitPoint = new Point3D(org.X + dir.A * t0, org.Y + dir.B * t0, org.Z + dir.C * t0);
                Vector3D nomalV = hitPoint - sphere.Center;

                hr.T = t0;
                hr.HitPoint = hitPoint;
                hr.NormalVector = nomalV;

                return hr;
            }
        }
    }
}
