using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*輸入一個有意義的英文敘述字串，計算其個別單字數量(不區分大小寫)，例如 “To be or not to be”，
                會得到以下結果：
                 to : 2
                 be : 2
                 or : 1
                 not : 1*/

            Console.WriteLine("輸入一個有意義的英文敘述字串");
            var input = Console.ReadLine();
            string[] output = input.Split(' ');
            Dictionary<string, int> a = new Dictionary<string, int>();

            foreach (var word in output)
            {
                string w = word.Trim().ToLower();
                if (!a.ContainsKey(w))
                {
                    a.Add(w, 1);
                }
                else
                {
                    a[word] += 1;
                }
            }

            foreach (var keyValue in a)
            {
                Console.WriteLine($"{keyValue.Key}：{keyValue.Value}");
            };

            Console.ReadLine();


        }
    }
}
