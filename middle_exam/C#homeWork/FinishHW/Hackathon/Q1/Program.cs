using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*使用 Console.ReadLine() 讀取一個整數 max(至少大於 90)，
             * 在螢幕上用 WriteLine 分行顯示1~ max，其中可被 3 整除者替換為 Build，
             * 可被5 整除者替換為 School，可以被 3 和 5 同時整除者替換為 Dann*/

            Console.WriteLine("請輸入一個整數(至少大於 90)");
            var max = int.Parse(Console.ReadLine());

            var result = Enumerable.Range(1, max).Select(x =>
            {
                if (x % 3 == 0 && x % 5 == 0) { return "Dann"; }
                if (x % 5 == 0) { return "School"; }
                if (x % 3 == 0) { return "Build"; }
                return x.ToString();
            });
            Console.WriteLine(string.Join(Environment.NewLine,result)); ;
          

            Console.ReadLine();
        }
        private void Normal()
        {
            Console.WriteLine("請輸入一個整數(至少大於 90)");
            var input = int.Parse(Console.ReadLine());
            for (int x = 1; x <= input; x++)
            {
                if (x % 15 == 0)
                {
                    Console.WriteLine("Dann");
                    continue;
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("School");
                    continue;
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine("Build");
                    continue;
                }
                Console.WriteLine(x);
            }

        }

    }
}
