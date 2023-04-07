using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kwMusic
{
    class LyricLine
    {
        public double time;
        public string lyrics;
    }
    internal class KuLyrics
    {
/*        //存时间和歌词
        public List<double> listTime = new List<double> ();
        public List<string> listLyrics = new List<string> ();*/

        //封装为一个类
        public List<LyricLine> listLine= new List<LyricLine>();
        public void load(string fileName)
        {
            //读取歌词文件
            Encoding en = Encoding.GetEncoding("GB2312");
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs, en);
            //循环读取
            while (true)
            {
                //读一行
                string str = sr.ReadLine();
                //读完了的时候
                if (str == null)
                {
                    break;
                }
                //读到空行
                if (str == "")
                {
                    continue;
                }
                //划分时间信息
                string strMinute = str.Substring(1, 2);
                string strSecond = str.Substring(4, 5);
                double time = double.Parse(strMinute) * 60 + double.Parse(strSecond);
                /*listTime.Add(time);*/

                //划分歌词信息
                //str = str.Substring(10);   将str改变了，不好
                string strLyric = str.Substring(10);

                LyricLine ll = new LyricLine();
                ll.time = time;
                ll.lyrics = strLyric;
                listLine.Add(ll);
                /*listLyrics.Add(strLyric);*/
            }
            //关闭
            sr.Close();
            fs.Close();
        }
    }  
}
