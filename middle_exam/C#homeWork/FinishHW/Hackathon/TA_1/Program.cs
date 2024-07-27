using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var input = Console.ReadLine();
            //Console.WriteLine("請輸入數字");
            //int result = 0;
            //while (int.TryParse(input, out result))
            //{
            //    Console.WriteLine("請輸入數字");
            //    input = Console.ReadLine();
            //}

            //string input;
            //int result = 0;
            //do {
            //    Console.WriteLine("請輸入數字");
            //    input = Console.ReadLine();
            //} while (!int.TryParse(input, out result));

            //Parse 成功
            //Program.DisplayResult(result); //靜態方法從型別上叫

            var obj = new NumberReplacer();
            obj.DisplayResult();

            
            //new 出物件
            //呼叫 產出結果
            Console.ReadLine();

        }

        //成員註解 ///
        private static void DisplayResult(int result)
        {
            for (int num = 0; num <= result; num++)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("Dann");
                }
                if (num % 5 == 0)
                {
                    Console.WriteLine("Build");
                }
                if (num % 3 == 0)
                {
                    Console.WriteLine("School");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        } 

    }
    internal class NumberReplacer 
        //高內聚成員
        //低相依
    {
        //只有建構式裡面可以設定readonly的欄位
        //唯獨展開的樣子 private readonly int _n; 

        //private int _number; 真正放資料的地方是這個欄位
        public int Number { get; private set; }
        public NumberReplacer()
        {
            //處理使用者輸入數字並帶入Number
            string input;
            int result = 0;
            do{
                Console.WriteLine("請輸入數字");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out result));
            Number = result;
        }

        public void DisplayResult()
        {
            for (int num = 0; num <= Number; num++)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("Dann");
                }
                if (num % 5 == 0)
                {
                    Console.WriteLine("Build");
                }
                if (num % 3 == 0)
                {
                    Console.WriteLine("School");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
   
}
