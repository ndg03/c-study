using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zy_Zy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
            // 加载图像并将其添加到 ImageList 对象中
            imageList1.ImageSize = new Size(50, 50); //设置图片大小
            Random random = new Random();
            for (int i = 0; i < 10; i++) // 假设要添加10张随机图片
            {
                int randomNumber = random.Next(1, 8); // 生成1到7之间的随机整数
                string fileName = randomNumber.ToString() + ".jpg"; // 构造文件名
                imageList1.Images.Add(Image.FromFile(fileName)); // 加载并添加图像
            }
            // 为每个 ListViewItem 设置图像和文本
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = "" + i; // 为每个项设置文本
                listView1.Items.Add(item);
            }
            // 分配 ImageList 给 listView1 控件的 LargeImageList 属性
            listView1.LargeImageList = imageList1;
        }
    }
}
