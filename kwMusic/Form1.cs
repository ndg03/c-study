using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kwMusic
{
    public partial class frmBackGround : Form
    {

        /// <summary>
        /// 找到一个目录下的所有文件
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="pattern"></param>
        /// <param name="fileList"></param>
        public void GetFiles(DirectoryInfo directory, string pattern, ref List<string> fileList)
        {
            if (directory.Exists || pattern.Trim() != string.Empty)
            {
                try
                {
                    foreach (FileInfo info in directory.GetFiles(pattern))
                    {
                        fileList.Add(info.Name.Remove(info.Name.LastIndexOf(".")).ToString());
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                foreach (DirectoryInfo info in directory.GetDirectories())//获取文件夹下的子文件夹
                {
                    GetFiles(info, pattern, ref fileList);//递归调用该函数，获取子文件夹下的文件
                }
            }
        }

        public frmBackGround()
        {
            InitializeComponent();
        }
        KuLyrics k1;
        //实现歌曲的播放和暂停

        //代表音乐是否正在播放
        bool isPlaying = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //如果正在播放
            if (isPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                picPlay.BackgroundImage = Properties.Resources.play;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                picPlay.BackgroundImage = Properties.Resources.pause;
            }
            isPlaying = !isPlaying;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //显示播放时间
            lblTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString
                + "/" + axWindowsMediaPlayer1.currentMedia.durationString;

            for(int i = 0;i<k1.listLine.Count;i++) { 
                if(axWindowsMediaPlayer1.Ctlcontrols.currentPosition >k1.listLine[i].time  && 
                    axWindowsMediaPlayer1.Ctlcontrols.currentPosition < k1.listLine[i+1].time)
                {
                    //显示歌词
                    lblLyrics.Text = k1.listLine[i].lyrics;
                }            
            }
        }

        private void frmBackGround_Load(object sender, EventArgs e)
        {
            //获取 文件夹下面所有的MP3文件信息
            List<string> lstAllMp3FileName = new List<string>();
                         //exe所在的目录
            string dir = Environment.CurrentDirectory + "/song";
            GetFiles(new DirectoryInfo(dir), "*.*", ref lstAllMp3FileName);
            //显示到我的listbox
            listBox1.Items.AddRange(lstAllMp3FileName.ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取用户选择的歌曲名称
            string curMp3Name = listBox1.SelectedItem.ToString();
            //利用歌词类，实现歌词的载入解析
            k1 = new KuLyrics();
            k1.load("lyrics/" + curMp3Name + ".lrc");
            axWindowsMediaPlayer1.URL = "song/" + curMp3Name + ".mp3";
            picPlay.BackgroundImage = Properties.Resources.pause;
            this.BackgroundImage = Image.FromFile("bg/" + curMp3Name + ".jpg");
            timer1.Enabled = true; 
        }
    }
}
