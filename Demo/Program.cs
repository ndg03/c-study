using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //单问号用于对int，double，bool等无法直接赋值为null的数据类型进行null的赋值，
            //意思是这个数据类型是Nullable类型的
            int i;//默认值为 0
            int? ii;//默认值为 null

            //Nullable类型（可空类型），可以表示其基础数据类型正常范围内的值，加上一个null
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14159265358;
            bool? boolval = new bool?();
            Console.WriteLine("显示可空类型的值：{0},{1},{2},{3}",num1,num2,num3,num4);
            Console.WriteLine("一个可空的布尔值：{0}", boolval);
           // Console.ReadLine();

            //Null 合并运算符
            Double? num5 = new Double?();
            Double num6;
            num6 = num5 ?? 3.14;//如果num5为Null，那么吧3.14赋值给num6,否则把num5赋值给num6
            Console.WriteLine("num6的值：{0}", num6);
            Console.ReadLine();
        }
    }
}
