using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //三元運算式 ? :
            /* Q1 輸入一串以逗號分隔的字串，並將其反向顯示; 例如  輸入 12,18,13,23,  結果 32,23,13,18,12*/
            string input = Console.ReadLine();
            //var a = input.Split(',').Reverse();
            Console.WriteLine(string.Join(",", input.Split(',').ToArray().Reverse())); //不用ToArray跟Split

            /* Q2 請輸入一個整數數字，利用linq顯示以下結果：
               若輸入是 5 則結果為
               5
               44
               333
               2222
               11111*/
            Console.WriteLine("\n請輸入一個整數數字1-9");
            var x = int.Parse(Console.ReadLine());
            var xx = Enumerable.Range(1, x).Select(i => string.Concat(Enumerable.Repeat(x - i + 1, i))).ToList();
            //下面為什麼不行
            //Console.WriteLine(string.Join("\n",
            //    Enumerable.Range(1, int.Parse(Console.ReadLine())).
            //               Select(i => string.Concat(Enumerable.Repeat(int.Parse(Console.ReadLine) - i + 1, i).ToList())).ToList()));


            /* Q3 輸入一串以逗號分隔的整數數字字串，將其依照奇偶數分割為兩個數列，並且予以排序顯示結果 例如：輸入 8,7,9,3,11,6,2,18 結果為兩列
                奇數 : 3,7,9,11
                偶數 : 2,6,8,18*/
            Console.WriteLine("\n輸入一串以逗號分隔的整數數字字串");
            var input3 = Console.ReadLine().Split(',').Select(int.Parse).OrderBy(n=>n);

            Console.WriteLine(
                $"奇數{string.Join(",",input3.Where(i => i % 2 != 0))}" +
                $"{Environment.NewLine}" +
                $"偶數{string.Join(",", input3.Where(i => i % 2 == 0))}");

            //版本2
            Console.WriteLine("輸入一串以逗號分隔的整數數字字串");
            string input3_2 = Console.ReadLine();

            // 將輸入的字串轉換成整數數列並分割成奇數和偶數
            var numbers = input3_2.Split(',')
                               .Select(int.Parse)
                               //GroupBy(n => n % 2 == 0)：根據奇偶性對數字進行分組。
                               .GroupBy(n => n % 2 != 0)
                               //OrderBy(g => g.Key)：按分組鍵排序，確保偶數組（鍵為 true）在奇數組（鍵為 false）之前。
                               .OrderBy(g => g.Key)
                               //將分組結果轉換成一個字典，鍵為 "奇數" 或 "偶數"，值為排序後的數列。
                               .ToDictionary(g => g.Key ? "奇數" : "偶數", g => g.OrderBy(n => n).ToList());

            // 輸出結果
            foreach (var kvp in numbers)
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(",", kvp.Value)}");
            }


            

            Console.ReadLine();

        }
    }
}
