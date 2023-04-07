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
            Point3D org = new Point3D(1, -2, -1);
            Vector3D dir = new Vector3D(1,2,4);
            Ray ray = new Ray(org,dir);

            Point3D center = new Point3D(3,0,5);
            Sphere sphere = new Sphere(center, 3);

            /*Point3D hitPoint = ray.IsHit(sphere);
            label1.Text= hitPoint.ToString();
            double t0 = ray.IsHit(sphere);
            label1.Text = t0.ToString();*/

            HitRecord hr = ray.Hit(sphere);
            label1.Text = hr.ToString();
        }
    }
}
