using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace JLGJ3._0_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //定义三个链表用来装 分别表示三个层级关系
        List<Button> button1 = new List<Button>();
        List<Button> button2 = new List<Button>();
        List<Button> button3 = new List<Button>();
        //定义  一个list  装  list
        List<List<Button>> buttonLists = new List<List<Button>>();

        // 定义一个链表  用来  存  被重叠的按钮
        List<Button> buttonOverLaped1;
        /// <summary>
        /// 装的方法 ,从第一个开始（最上层）
        /// </summary>
        public void Contain()
        {
            buttonLists.Add(button1);
            buttonLists.Add(button2);
            buttonLists.Add(button3);
        }
        //随机数生成器
        private Random random = new Random();
        //图片路径
        public string[] imageFiles = { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg" };
        // 随机生成button，背景是随机图片
        public void ShowButton()
        {
            //生成 button1的按钮
            for(int i = 0; i< 8 ; i++)
            {
                // 创建按钮对象
                Button button = new Button();
                // 设置按钮属性
                button.Width = 100;
                button.Height = 100;
                // 设置按钮随机位置
                SetRandomButtonPosition(button);
                // 检查按钮是否与已创建的按钮重叠
                bool overlap = CheckButtonOverlap1(button);
                // 如果按钮与已创建的按钮重叠，则重新设置随机位置
                while (overlap)
                {
                    SetRandomButtonPosition(button);
                    overlap = CheckButtonOverlap1(button);
                }

                // 随机选择一张图片
                string randomImageFile = GetRandomImageFile();

                // 设置按钮的背景图片
                button.BackgroundImage = Image.FromFile(randomImageFile);
                button.BackgroundImageLayout = ImageLayout.Stretch;

                // 将按钮添加到相应的链表中
                button1.Add(button);

                button.Click += button_Click; // 关联点击事件处理程序
            }

            //生成 button2的按钮
            for (int i = 0; i < 8; i++)
            {
                // 创建按钮对象
                Button button = new Button();
                // 设置按钮属性
                button.Width = 100;
                button.Height = 100;
                // 设置按钮随机位置
                SetRandomButtonPosition(button);
                // 检查按钮是否与已创建的按钮重叠
                bool overlap = CheckButtonOverlap2(button);
                // 如果按钮与已创建的按钮重叠，则重新设置随机位置
                while (overlap)
                {
                    SetRandomButtonPosition(button);
                    overlap = CheckButtonOverlap2(button);
                }

                // 随机选择一张图片
                string randomImageFile = GetRandomImageFile();

                // 设置按钮的背景图片
                button.BackgroundImage = Image.FromFile(randomImageFile);
                button.BackgroundImageLayout = ImageLayout.Stretch;

                // 将按钮添加到相应的链表中
                button2.Add(button);

                button.Click += button_Click; // 关联点击事件处理程序
            }


            //生成 button3的按钮
            for (int i = 0; i < 8; i++)
            {
                // 创建按钮对象
                Button button = new Button();
                // 设置按钮属性
                button.Width = 100;
                button.Height = 100;
                // 设置按钮随机位置
                SetRandomButtonPosition(button);
                // 检查按钮是否与已创建的按钮重叠
                bool overlap = CheckButtonOverlap3(button);
                // 如果按钮与已创建的按钮重叠，则重新设置随机位置
                while (overlap)
                {
                    SetRandomButtonPosition(button);
                    overlap = CheckButtonOverlap3(button);
                }

                // 随机选择一张图片
                string randomImageFile = GetRandomImageFile();

                // 设置按钮的背景图片
                button.BackgroundImage = Image.FromFile(randomImageFile);
                button.BackgroundImageLayout = ImageLayout.Stretch;

                // 将按钮添加到相应的链表中
                button3.Add(button);

                button.Click += button_Click; // 关联点击事件处理程序
            }
        }

        // 随机选择一张图片文件路径
        private string GetRandomImageFile()
        {
            int index = random.Next(imageFiles.Length);
            return imageFiles[index];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowButton();
            LoadButton();
            //刷新
            this.Invalidate();
        }
        //将 button添加到  form里面
        public void LoadButton()
        {
            foreach (Button button in button1)
            {
                Controls.Add(button);
            }
            foreach (Button button in button2)
            {
                Controls.Add(button);
            }
            foreach (Button button in button3)
            {
                Controls.Add(button);
            }

        }
        //设置按钮的随机位置
        private void SetRandomButtonPosition(Button button)
        {
            int x = random.Next(ClientSize.Width - button.Width);
            int y = random.Next(ClientSize.Height -150 - button.Height);
            button.Location = new Point(x, y);
        }

        //检查 确保 button1中button不会重叠
        private bool CheckButtonOverlap1(Button button)
        {
            foreach (Button existingButton in button1)
            {
                if (button.Bounds.IntersectsWith(existingButton.Bounds))
                {
                    return true;
                }
            }
            return false;
        }
        //检查 确保 button2中button不会重叠
        private bool CheckButtonOverlap2(Button button)
        {
            foreach (Button existingButton in button2)
            {
                if (button.Bounds.IntersectsWith(existingButton.Bounds))
                {
                    return true;
                }
            }
            return false;
        }
        //检查 确保 button3中button不会重叠
        private bool CheckButtonOverlap3(Button button)
        {
            foreach (Button existingButton in button3)
            {
                if (button.Bounds.IntersectsWith(existingButton.Bounds))
                {
                    return true;
                }
            }
            return false;
        }
        //按钮点击事件
        void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            buttonOverLaped1 = IsOverLap(clickedButton);


            if (button1.Contains(clickedButton)  && IsClick(clickedButton,buttonOverLaped1))
            {
                move(clickedButton);
                //MessageBox.Show("属于第一个链表的按钮被点击了！");
            }
            else if (button2.Contains(clickedButton) && IsClick(clickedButton, buttonOverLaped1))
            {
                MessageBox.Show("属于第2个链表的按钮被点击了！");
            }
            else if (button3.Contains(clickedButton) && IsClick(clickedButton, buttonOverLaped1))
            {
                MessageBox.Show("属于第3个链表的按钮被点击了！");
            }
        }



        /// <summary>
        /// 检查 被点击的button 是否 有重叠的button
        /// </summary>
        /// <param name="button">被点击的按钮</param>
        /// <returns>返回重叠的按钮集合</returns>
        public List<Button> IsOverLap(Button button)
        {
            //通过其矩形边界来表示
            // 假设被点击按钮
            Rectangle buttonRect = new Rectangle(button.Left, button.Top, button.Width, button.Height);
            //调用 方法 方便 遍历所有的按钮
            Contain();
            //定义标志位 是否有重叠的
            List<Button> buttonOverLaped2 = new List<Button>();
            // 嵌套的 for 循环遍历所有的按钮（从最上层开始）
            foreach (List<Button> buttonList in buttonLists)
            {
                for (int i = 0; i < buttonList.Count; i++)
                {
                    Button surroundingButton = buttonList[i];
                    // 对周围按钮进行操作
                    Rectangle surroundingButtonRect = new Rectangle(surroundingButton.Left, surroundingButton.Top, surroundingButton.Width, surroundingButton.Height);
                    if (buttonRect.IntersectsWith(surroundingButtonRect) && buttonRect != surroundingButtonRect)//不包括被点击的按钮
                    {
                        //表示重叠了
                        buttonOverLaped2.Add(surroundingButton);
                    }

                }
            }
            return buttonOverLaped2;
        }
        /// <summary>
        /// 判断 是否能点击 ，没有重叠的  或者 在顶层  的 可以点击
        /// </summary>
        /// <param name="button">被点击的按钮</param>
        /// <param name="list">重叠的 按钮 链表</param>
        /// <returns>是否</returns>
        public Boolean IsClick(Button button ,List<Button> list)
        {
            //被点击按钮的层级关系
            int ClickedFloor = IsWhichFloor(button);
            //重叠的按钮的层级关系
            int[] floor = new int[2];//设定最高2层
            int i = 0;// 数组 索引
            //遍历链表 ，求得层级关系，保存在数组里边
            foreach(Button btn in list)
            {
                if (button1.Contains(btn))
                {
                    floor[i%2] = 1;
                    i++;
                }else if (button2.Contains(btn))
                {
                    floor[i%2] = 2;
                    i++;
                }else if (button3.Contains(btn))
                {
                    floor[i % 2] = 3;
                    i++;
                }
            }

            if(ClickedFloor == 1  || list == null)
            {
                return true;
            }
            else
            {
                for (int j = 0; j < 2; j++)
                {
                    if (floor[j] == 1)
                    {
                        return false;
                    }
                }

                if (ClickedFloor == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //判断按钮的层级关系
        public int IsWhichFloor(Button button)
        {
            if (button1.Contains(button))
            {
                return 1;//最顶层
            }
            else if (button2.Contains(button))
            {
                return 2;
            }
            else if(button3.Contains(button)) 
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            draw();
        }
        //矩形的 位置 初始值
        public int rectX =0;
        public int rectY =0;
        //画出  下面矩形的方法
        void draw()
        {
            int rectWidth = 800;  // 矩形宽度
            int rectHeight = 130; // 矩形高度

            // 计算矩形的位置，使其居中于窗体底部
            rectX = (ClientSize.Width - rectWidth) / 2;
            rectY = ClientSize.Height - rectHeight - 3;

            Rectangle rect = new Rectangle(rectX, rectY, rectWidth, rectHeight);

            using (Graphics g = CreateGraphics())
            {
                Pen pen = new Pen(Color.Yellow, 5);  // 创建黄色边框的 Pen 对象
                g.DrawRectangle(pen, rect);
                pen.Dispose();  // 绘制完成后释放 Pen 对象
            }
        }

        /// <summary>
        /// 定义下一个按钮的位置
        /// </summary>
        /// <param name="n">下一个按钮 是第几个</param>
        /// <returns></returns>
        public Point NextPoint(int n)
        {
            Point point = new Point(109 + n * 112,445);
            return point;
        }
        int t = 0;//初始化按钮个数
        //定义 方法 移动 按钮
        public void move(Button button)
        {
            button.Location = NextPoint(t++ % 7);
        }
    }
}
