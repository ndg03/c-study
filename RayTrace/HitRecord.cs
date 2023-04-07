using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTrace
{
    internal class HitRecord
    {
        bool isHit;//是否击中
        double t;//击中点参数
        Point3D hitPoint;//击中点
        Vector3D normalVector;//法线向量
        public bool IsHit { get => isHit; set => isHit = value; }
        public double T { get => t; set => t = value; }
        internal Point3D HitPoint { get => hitPoint; set => hitPoint = value; }
        internal Vector3D NormalVector { get => normalVector; set => normalVector = value; }

        public override string ToString()
        {
            return $"isHit: {isHit}, t: {t}, hitPoint: ({hitPoint.X}, {hitPoint.Y}, {hitPoint.Z}), normalVector: ({normalVector.A}, {normalVector.B}, {normalVector.C})";
        }
    }
}
