using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zhiyin_2
{
    public partial class Form1 : Form
    {
        // 五张图片的文件名
        private static string[] imageFiles = { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg" };
        Button[] buttons = new Button[imageFiles.Length];
        public Form1()
        {
            InitializeComponent();

            Random random = new Random();
            
            // 创建按钮数组
            for (int i = 0; i < imageFiles.Length; i++)
            {
                buttons[i] = new Button();  // 创建按钮实例
                // 生成随机的横坐标和纵坐标
                int x = random.Next(0, this.Width - buttons[i].Width);
                int y = random.Next(0, this.Height - buttons[i].Height);

                

                buttons[i].Size = new Size(100, 100);
                buttons[i].Location = new Point(x, y);
                buttons[i].BackgroundImage = Image.FromFile(imageFiles[i]);
                buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
                buttons[i].Click += new EventHandler(button_Click);
                Controls.Add(buttons[i]);
                //将按钮设置为  无边框
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;

                buttons[i].SendToBack();  // 将 button2 带到最顶层
            }
            for (int i = 0; i < imageFiles.Length; i++)
            {
                Controls.SetChildIndex(buttons[i], i); // 将 button1 设置为父容器的第一个子控件
            }



            CompareButtons(buttons[1], buttons[2]);




        }
        /// <summary>
        /// 判断两个按钮是否重叠
        /// </summary>
        /// <param name="button1"></param>
        /// <param name="button2"></param>
        /// <returns>是否</returns>
        bool IsOverlap(Button button1, Button button2)
        {
            Rectangle rect1 = new Rectangle(button1.Location, button1.Size);
            Rectangle rect2 = new Rectangle(button2.Location, button2.Size);

            return rect1.IntersectsWith(rect2);
        }

        void button_Click(object sender, EventArgs e)
        {
            /*Button clickedButton = (Button)sender; // 将触发事件的按钮转换为 Button 类型
            int index = Controls.GetChildIndex(clickedButton);
            MessageBox.Show(index.ToString());*/


            Button clickedButton = (Button)sender; // 获取触发事件的按钮实例
            int index = Array.IndexOf(buttons, clickedButton); // 查找按钮在 buttons 数组中的索引
            MessageBox.Show("按钮索引: " + index);

        }

        void CompareButtons(Button button1, Button button2)
        {
            if (button1.Bounds.IntersectsWith(button2.Bounds))
            {
                int zIndex1 = Controls.GetChildIndex(button1);
                int zIndex2 = Controls.GetChildIndex(button2);

                if (zIndex1 > zIndex2)
                {
                    MessageBox.Show("按钮1在上层");
                }
                else if (zIndex1 < zIndex2)
                {
                    MessageBox.Show("按钮2在上层");
                }
                else
                {
                    MessageBox.Show("按钮1和按钮2在同一层级");
                }
            }
            else
            {
                MessageBox.Show("按钮1和按钮2没有重叠");
            }
        }

    }
}
