using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1：顯示 c:\temp\a.jpg
            Console.WriteLine("D:\\temp\\animal.jpg");
            Console.WriteLine(@"D:\temp\animal.jpg");

            Console.WriteLine();

            //Q2：顯示 我是一個"好學生".
            Console.WriteLine("我是一個\"好學生\".");

            Console.WriteLine();

            //Q3：顯示兩行文字
            //我是第一行
            //我是第二行
            Console.WriteLine("我是第一行\n我是第二行");

            Console.Read();
        }
    }
}
