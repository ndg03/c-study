using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入：");
            string str = Console.ReadLine();
            Console.WriteLine("Hello " + str);
            Console.ReadKey();
        }
    }
}
