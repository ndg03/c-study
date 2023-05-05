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
        private string[] imageFiles = { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg" };

        public Form1()
        {
            InitializeComponent();
            Button[] buttons = new Button[imageFiles.Length];
            // 创建按钮数组
            for (int i = 0; i < imageFiles.Length; i++)
            {
                buttons[i] = new Button();  // 创建按钮实例
                buttons[i].Size = new Size(100, 100);
                buttons[i].Location = new Point(10 + i * 50, 10);
                buttons[i].BackgroundImage = Image.FromFile(imageFiles[i]);
                buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
                buttons[i].Click += new EventHandler(button_Click);
                Controls.Add(buttons[i]);

                // 将新创建的按钮置于顶层
                buttons[i].BringToFront();
            }
        }

        private int[] GetOverlappingButtons(Button button)
        {
            List<int> overlappingButtonIndices = new List<int>();
            for (int i = 0; i < this.Controls.Count; i++)
            {
                Control control = this.Controls[i];
                if (control != button && control.Bounds.IntersectsWith(button.Bounds) && control is Button)
                {
                    overlappingButtonIndices.Add(i);
                }
            }
            return overlappingButtonIndices.ToArray();
        }
        private int[] GetOverlappingButtonIndices(Button button)
        {
            List<int> overlappingIndices = new List<int>();
            foreach (Control control in this.Controls)
            {
                if (control != button && control.Bounds.IntersectsWith(button.Bounds) && control is Button)
                {
                    overlappingIndices.Add(this.Controls.GetChildIndex(control));
                }
            }
            return overlappingIndices.ToArray();
        }
        private bool IsTopButton(Button button)
        {
            int buttonIndex = this.Controls.GetChildIndex(button);
            int[] overlappingIndices = GetOverlappingButtonIndices(button);
            foreach (int index in overlappingIndices)
            {
                if (index >= buttonIndex)
                {
                    return false;
                }
            }
            return true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (IsTopButton((Button)sender))
            {
                // 如果按钮位于顶层，则执行相应操作
                // 在这里编写按钮单击事件的逻辑代码
                MessageBox.Show("你干嘛");
            }
            else
            {
                // 如果按钮不位于顶层，则不执行操作
                MessageBox.Show("哎哟");
            }
            
        }
    }
}
