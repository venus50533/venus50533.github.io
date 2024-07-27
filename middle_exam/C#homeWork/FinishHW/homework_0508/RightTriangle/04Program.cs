using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 請輸入一個整數數字，利用迴圈顯示以下結果：若輸入是 5 則結果為
                    5
                    44
                    333
                    2222
                    11111*/

            Console.WriteLine("請輸入一個整數數字");
            int level = int.Parse(Console.ReadLine());
            int num = level;

            for (int i = 1; i <= level; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < i; j++)
                {
                    Console.Write(num);
                }
                num--;

            }

            Console.ReadLine();

        }
    }
}
