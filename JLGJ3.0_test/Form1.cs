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
using System.Security.Cryptography.X509Certificates;
using System.Media;

namespace JLGJ3._0_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int numFinal = 0;

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


        //创建 随机位置的  按钮
        public void createButton(List<Button> list)
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
            button.BackgroundImage = list[list.Count - 1].BackgroundImage;
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.Tag = list[list.Count - 1].Tag;

            // 将按钮添加到相应的链表中
            list.Add(button);
            button.Click += button_Click; // 关联点击事件处理程序
        }

        // 随机生成button，背景是随机图片
        public void ShowButton()
        {
            //生成 button1的按钮
            for(int i = 0; i< 3 ; i++)
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
                button.Tag = randomImageFile;
                // 设置按钮的背景图片
                button.BackgroundImage = Image.FromFile(randomImageFile);
                button.BackgroundImageLayout = ImageLayout.Stretch;

                // 将按钮添加到相应的链表中
                button1.Add(button);

                button.Click += button_Click; // 关联点击事件处理程序
                createButton(button1);
                createButton(button1);
            }

            //生成 button2的按钮
            for (int i = 0; i < 3; i++)
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
                button.Tag = randomImageFile;
                // 设置按钮的背景图片
                button.BackgroundImage = Image.FromFile(randomImageFile);
                button.BackgroundImageLayout = ImageLayout.Stretch;

                // 将按钮添加到相应的链表中
                button2.Add(button);

                button.Click += button_Click; // 关联点击事件处理程序
                createButton(button2);
                createButton(button2);

            }


            //生成 button3的按钮
            for (int i = 0; i < 3; i++)
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
                button.Tag = randomImageFile;
                // 设置按钮的背景图片
                button.BackgroundImage = Image.FromFile(randomImageFile);
                button.BackgroundImageLayout = ImageLayout.Stretch;

                // 将按钮添加到相应的链表中
                button3.Add(button);

                button.Click += button_Click; // 关联点击事件处理程序
                createButton(button3);
                createButton(button3);
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
            MessageBox.Show("游戏开始了！！！");
            ShowButton();
            LoadButton();
            music();
            //隐藏
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer2.Visible = false;
            //刷新
            this.Invalidate();
        }


        //将 button添加到  form里面
        public void LoadButton()
        {
            Contain();
            foreach(List<Button> buttonList in buttonLists)
            {
                foreach (Button button in buttonList)
                {
                    Controls.Add(button);
                }
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
            //如果可以点击 ，则移动，达到三个则删除
            if (IsClick(clickedButton, buttonOverLaped1))
            {

                sound();
                move(clickedButton);
                
                addList(clickedButton);
                //showNum(clickedButton);
                removeButton();
                victory();
                defate(numFinal);
                this.Invalidate();
            }
        }
        //用于 调试 代码
        void showNum( Button button)
        {
            if(WhichKun(button) == 1)
            {
                MessageBox.Show("第一种图片的个数是"+button_1.Count.ToString());
            }
            else if (WhichKun(button) == 2)
            {
                MessageBox.Show("第2种图片的个数是" + button_2.Count.ToString());
            }
            else if (WhichKun(button) == 3)
            {
                MessageBox.Show("第3种图片的个数是" + button_3.Count.ToString());
            }
            else if (WhichKun(button) == 4)
            {
                MessageBox.Show("第4种图片的个数是" + button_4.Count.ToString());
            }else if (WhichKun(button) == 5)
            {
                MessageBox.Show("第5种图片的个数是" + button_5.Count.ToString());
            }
        }


        /// <summary>
        /// 检查 被点击的button 是否 有重叠的button
        /// </summary>
        /// <param name="button">被点击的按钮</param>
        /// <returns>返回重叠的按钮集合</returns>
        public List<Button> IsOverLap(Button button)
        {
            //通过其矩形边界来表示 假设被点击按钮
            Rectangle buttonRect = new Rectangle(button.Left, button.Top, button.Width, button.Height);
            //定义链表  用来装  与被点击的按钮重叠的按钮
            List<Button> buttonOverLaped2 = new List<Button>();

            // 增强 for 循环  嵌套 遍历所有的按钮（从最上层开始）
            foreach (List<Button> buttonList in buttonLists)
            {
                for (int i = 0; i < buttonList.Count; i++)
                {
                    //定义周围的按钮
                    Button surroundingButton = buttonList[i];
                    // 转化为矩形 
                    Rectangle surroundingButtonRect = new Rectangle(surroundingButton.Left, surroundingButton.Top, surroundingButton.Width, surroundingButton.Height);
                    //进行重叠判断 不包括被点击的按钮
                    if (buttonRect.IntersectsWith(surroundingButtonRect) && buttonRect != surroundingButtonRect)
                    {
                        //重叠按钮添加到 重叠链表，不包括 被点击的按钮
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
        public bool IsClick(Button button ,List<Button> list)
        {
            //MessageBox.Show(list.Count.ToString());
            //被点击按钮的层级关系
            int ClickedFloor = IsWhichFloor(button);
            //重叠的按钮的层级关系
            int[] floor = new int[10];//设定最高10层
            for(int m = 0;m <floor.Length; m++)
            {
                floor[m] = 10;
            }

            int i = 0;// 数组 索引

            //遍历链表 ，求得层级关系，保存在数组里边
            foreach(Button btn in list)
            {
                if (button1.Contains(btn))
                {
                    floor[i%10] = 1;
                    i++;
                }else if (button2.Contains(btn))
                {
                    floor[i%10] = 2;
                    i++;
                }else if (button3.Contains(btn))
                {
                    floor[i % 10] = 3;
                    i++;
                }
            }
            //最下面 框 里的按钮不能点击
            if(button.Location.Y == 445)
            {
                return false;
            }
            //被点击的按钮的层级关系  == 1  或者  被点击的按钮周围没有重叠的按钮
            if(ClickedFloor == 1  || list.Count == 0)
            {
                return true;
            }
            else
            {
                for (int j = 0; j < 10; j++)
                {
                    if (floor[j] == 1)
                    {
                        return false;
                    }
                }
                //定义标志位  ，如果 重叠的按钮 的层级关系  优先级  全部小于 被点击的按钮  ，则可以点击
                int flag = 1;//表示  默认 全部 小于
                for(int k = 0; k < floor.Length-1; k++)
                {
                    if (floor[k]  < ClickedFloor)
                    {
                        flag = 0;// 表示 存在 层级关系  优先级更高的  按钮 
                    }
                }
                if(flag == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


                /*if (ClickedFloor == 2)
                {
                    return true;
                }
                else if (ClickedFloor == 3 && list == null)
                {
                    return true;
                }else
                {
                    return false;
                }*/
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
            t = numFinal;
            button.Location = NextPoint(t++ % 7);

            numFinal++;// 方框中 的button 数加一

            //MessageBox.Show(numFinal.ToString());
        }

        //判断 被点击的按钮的背景是  哪种kun
        public int WhichKun(Button button)
        {
            //表示背景  的序列号
            int backNum = 0;

            //将背景转化为字符串  进行比较
            if (button.Tag.ToString()==imageFiles[0].ToString())
            {
                backNum = 1;
            }
            else if (button.Tag.ToString() == imageFiles[1].ToString())
            {
                backNum = 2;
            }else if(button.Tag.ToString() == imageFiles[2].ToString())
            {
                backNum = 3;
            }else if (button.Tag.ToString() == imageFiles[3].ToString())
            {
                backNum = 4;
            }else if(button.Tag.ToString() == imageFiles[4].ToString())
            {
                backNum = 5;
            }
            return backNum;
        }

        //定义 链表  用来装 每种 图片 的 具体按钮
        static List<Button> button_1 = new List<Button>();
        static List<Button> button_2 = new List<Button>();
        static List<Button> button_3 = new List<Button>();
        static List<Button> button_4 = new List<Button>();
        static List<Button> button_5 = new List<Button>();


        /// <summary>
        /// /被点击的按钮的 计数（添加到链表中）  的方法
        /// </summary>
        /// <param name="button">被点击的按钮</param>
        /// <returns></returns>
        public List<Button>  addList (Button button)
        {
            if (WhichKun(button) == 1)
            {
                button_1.Add(button);
                return button_1;
            }else if(WhichKun(button) == 2)
            { 
                button_2.Add(button); 
                return button_2;
            }
            else if(WhichKun(button) == 3)
            {
                button_3.Add(button); 
                return button_3;
            }
            else if (WhichKun(button) == 4) 
            {
                button_4.Add(button);
                return button_4;
            }
            else
            {
                button_5.Add(button);
                return button_5;
            }
        }


        /// <summary>
        /// 删除 按钮的方法
        /// </summary>
        /// <param name="button">被点击的按钮</param>
       public void removeButton()
       {
            if(button_1.Count == 3)
            {
                for (int i = 0; i < button_1.Count; i++)
                {
                    Button button = button_1[i];
                    // 遍历窗体的 Controls 集合
                    for (int j = Controls.Count - 1; j >= 0; j--)
                    {
                        Control control = Controls[j];

                        // 检查控件类型是否为 Button
                        if (control == button)
                        {
                            // 从窗体的 Controls 集合中移除按钮
                            Controls.Remove(button);
                            numFinal--;//删除一个 button 减一
                            //MessageBox.Show(numFinal.ToString());
                            this.Invalidate();
                        }
                    }
                }
                button_1.Clear();
            }
            else if (button_2.Count  == 3)
            {
                for (int i = 0; i < button_2.Count; i++)
                {
                    Button button = button_2[i];
                    // 遍历窗体的 Controls 集合
                    for (int j = Controls.Count - 1; j >= 0; j--)
                    {
                        Control control = Controls[j];

                        // 检查控件类型是否为 Button
                        if (control == button)
                        {
                            // 从窗体的 Controls 集合中移除按钮
                            Controls.Remove(button);
                            numFinal--;//删除一个 button 减一
                            //MessageBox.Show(numFinal.ToString());
                            this.Invalidate();
                        }
                    }
                }
                button_2.Clear();
            }
            else if (button_3.Count == 3)
            {
                for (int i = 0; i < button_3.Count; i++)
                {
                    Button button = button_3[i];
                    // 遍历窗体的 Controls 集合
                    for (int j = Controls.Count - 1; j >= 0; j--)
                    {
                        Control control = Controls[j];

                        // 检查控件类型是否为 Button
                        if (control == button)
                        {
                            // 从窗体的 Controls 集合中移除按钮
                            Controls.Remove(button);
                            numFinal--;//删除一个 button 减一
                            //MessageBox.Show(numFinal.ToString());
                            this.Invalidate();
                        }
                    }
                }
                button_3.Clear();
            }
            else if (button_4.Count == 3)
            {
                for (int i = 0; i < button_4.Count; i++)
                {
                    Button button = button_4[i];
                    // 遍历窗体的 Controls 集合
                    for (int j = Controls.Count - 1; j >= 0; j--)
                    {
                        Control control = Controls[j];

                        // 检查控件类型是否为 Button
                        if (control == button)
                        {
                            // 从窗体的 Controls 集合中移除按钮
                            Controls.Remove(button);
                            numFinal--;//删除一个 button 减一
                            //MessageBox.Show(numFinal.ToString());
                            this.Invalidate();
                        }
                    }
                }
                button_4.Clear();
            }
            else if (button_5.Count == 3)
            {
                for (int i = 0; i < button_5.Count; i++)
                {
                    Button button = button_5[i];
                    // 遍历窗体的 Controls 集合
                    for (int j = Controls.Count - 1; j >= 0; j--)
                    {
                        
                        if (Controls[j] == button)
                        {
                            
                            // 从窗体的 Controls 集合中移除按钮
                            Controls.Remove(Controls[j]);
                            numFinal--;//删除一个 button 减一
                            //MessageBox.Show(numFinal.ToString());
                            this.Invalidate();
                        }
                    }
                }
                button_5.Clear();
            }
       }

        //游戏失败
        public void defate(int num)
        {
            if(num == 7)
            {
                MessageBox.Show("游戏失败 ！！！");
                this.Close();
            }
        }

        //游戏成功
        public void victory()
        {
            // 判断Form中是否存在Button控件
            bool hasButtonControl = false;

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    hasButtonControl = true;
                    break;
                }
            }

            if (!hasButtonControl)
            {
                MessageBox.Show("胜利！！！");
            }
        }

        // 音效
        public void sound()
        {
            try
            {
                // 设置音效文件的路径
                string soundFilePath = "amagi.MP3";

                // 播放音效
                axWindowsMediaPlayer1.URL = soundFilePath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                // 处理播放音效时的异常
                MessageBox.Show($"{ex.Message}");
            }
        }

        public void music()
        {
            
            try
            {
                
                // 设置音效文件的路径
                string soundFilePath = "kun舞.MP3";

                //播放音乐
                axWindowsMediaPlayer2.URL = soundFilePath;
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            catch(Exception ex)
            {
                //播放音乐时的 异常
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}

