using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayTrace
{
    internal class Vector3D
    {
        double a;
        double b;
        double c;

        public Vector3D()
        {
            a = 0;
            b = 0;
            c = 1;
        }
        public Vector3D(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //运算符重载
        public static Vector3D operator *(double n, Vector3D v)
        {
            return new Vector3D(n * v.a, n * v.b, n * v.c);
        }
        public static Vector3D operator *(Vector3D v, double n)
        {
            return new Vector3D(n * v.a, n * v.b, n * v.c);
        }
        /// <summary>
        /// 向量的点乘
        /// </summary>
        /// <param name="v1">向量1</param>
        /// <param name="v2">向量2</param>
        /// <returns>实数</returns>
        public static double operator *(Vector3D v1, Vector3D v2)
        {
            return v1.a * v2.a + v1.b * v2.b + v1.c * v2.c;
        }

        /// <summary>
        /// 向量的叉乘
        /// </summary>
        /// <param name="v1">向量1</param>
        /// <param name="v2">向量2</param>
        /// <returns>向量</returns>
        public static Vector3D operator ^(Vector3D v1, Vector3D v2)
        {
            Vector3D v = new Vector3D();
            v.a = v1.b * v2.c - v2.b * v1.c;
            v.b = -(v1.a * v2.c - v2.a * v1.c);
            v.c = v1.a * v2.b - v2.a * v1.b;
            return v;
        }
        /// <summary>
        /// 加
        /// </summary>
        /// <param name="v1">向量1</param>
        /// <param name="v2">向量2</param>
        /// <returns>向量</returns> 
        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            Vector3D v = new Vector3D();
            v.a = v1.a + v2.a;
            v.b = v1.b + v2.b;
            v.c = v1.c + v2.c;
            return v;
        }
        /// <summary>
        /// 减
        /// </summary>
        /// <param name="v1">向量1</param>
        /// <param name="v2">向量2</param>
        /// <returns>向量</returns>
        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            Vector3D v = new Vector3D();
            v.a = v1.a - v2.a;
            v.b = v1.b - v2.b;
            v.c = v1.c - v2.c;
            return v;
        }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }


        public double length()
        {
            return Math.Sqrt(a * a + b * b + c * c);
        }
        public void nomalLize()
        {
            double len = length();
            a = a / len;
            b = b / len;
            c = c / len;
        }
    }
}
