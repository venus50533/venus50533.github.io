using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberJudgment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //請輸入一個整數數字，判斷其結果為奇數或偶數，並且在 Console 上顯示結果

            Console.WriteLine("請輸入一個數字");
            string input = Console.ReadLine();

            if (int.TryParse(input ,out int num)) //如果是有效輸入
            {
                Isnum(num); //奇偶判斷
            }
            else
            {
                Console.WriteLine("請進行有效輸入");
            }

            Console.ReadLine();
        }

        private static void Isnum(int num)
        {
            if (num % 2 == 0) { Console.WriteLine("偶數"); }
            else { Console.WriteLine("奇數"); }
        }
    }
}
