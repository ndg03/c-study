using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        public enum SpecialEffectType {None,Cat ,Grass};
        SpecialEffectType seType;
        Image imgGirl;
        int index = 0;
        //猫耳朵
        Image[] imgEars;
        Image[] imgMoustache;
        //载入资源
        private void Form1_Load(object sender, EventArgs e)
        {
            imgGirl = Image.FromFile("res/girl/kun.jpg");
            imgEars = new Image[80];
            imgMoustache = new Image[80];
            for (int i = 0; i < 80; i++)
            {
                imgEars[i] = Image.FromFile("res/ear/ear_" +
                    i.ToString("D3") + ".png");//占三位  不足自动补0
                imgMoustache[i] = Image.FromFile("res/moustache/moustache_" +
                    i.ToString("D3") + ".png");
            }
            imgGrass = new Image[61];
            imgYuanQuan = new Image[61];
            for (int i = 0; i < 61; i++)
            {
                imgGrass[i] = Image.FromFile("res/grass/grass_" +
                    i.ToString("D3") + ".png");//占三位  不足自动补0
                imgYuanQuan[i] = Image.FromFile("res/yuan/yuan_" +
                    i.ToString("D3") + ".png");
            }
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            index++;
            if(index >= 79)
            {
                index = 0;
            }
            pictureBox1.Invalidate();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            //Image img = Image.FromFile("res/girl/kun.jpg");
            g.DrawImage(imgGirl, 0, 0);
            if( seType == SpecialEffectType.Cat)
            {
                g.DrawImage(imgEars[index % 80], 200, 0);
                g.DrawImage(imgMoustache[index % 80], 200, 200);
            }else if (seType == SpecialEffectType.Grass)
            {
                g.DrawImage(imgGrass[index % 61], 200, 0);
                g.DrawImage(imgYuanQuan[index % 61], 300, 200);
            }
            
        }
        Image[] imgGrass;
        Image[] imgYuanQuan;
        /// <summary>
        /// 猫耳朵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEar_Click(object sender, EventArgs e)
        {
            seType = SpecialEffectType.Cat;
            
            index = 0; 
        }
        /// <summary>
        /// 种草
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGrass_Click(object sender, EventArgs e)
        {
            seType = SpecialEffectType.Grass;
            
            index = 0;
        }
    }
}
