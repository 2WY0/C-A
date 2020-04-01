using System;
using System.Collections.Generic;
using System.Text;

namespace 初试
{
    class Class1
    {
        static void MainD(string[] args)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("0 剪刀\n1 包袱\n2 锤头\n3 退出");
            Console.WriteLine("--------------------");
            IsWin(1,2);
        }

        public static int Game()
        {
            Random r = new Random();
            int num = r.Next(0, 2);
            return num;
        }

        private static void IsWin(int a,int b)
        {
            if (a>b)
            {
                Console.WriteLine("你赢了");
            }
            if (a == b)
            {
                Console.WriteLine("平局");
            }
            if (a < b)
            {
                Console.WriteLine("你输了");
            }
        }
    }
}
