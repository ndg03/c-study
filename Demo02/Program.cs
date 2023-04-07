using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建数组并初始化,如果没有初始化，int类型会默认赋值为0
            int[] marks = new int[3] { 1, 2,3 };
            //还可以省略数组大小
            int[] marks2 = new int[] { 3, 4, 5 };

            //可以用for循环和   foreach 循环来遍历数组
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }
            Console.ReadLine();
        }
    }
}
