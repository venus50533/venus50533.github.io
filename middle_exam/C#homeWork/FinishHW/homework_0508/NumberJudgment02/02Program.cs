using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberJudgment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //輸入一串以逗號分隔的整數數字字串，將其依照奇偶數分割為兩個數列，並且予以排序顯示結果
            //分割逗號請參考 String.Split 方法
            //例如： 輸入 8,7,9,3,11,6,2,18
            //結果為兩列
            //奇數: 3,7,9,11
            //偶數: 2,6,8,18

            Console.WriteLine("請輸入一串以逗號分隔的整數數字字串");
            string input = Console.ReadLine();
            string[] strArray = input.Split(',');    //將字串分割
            List<int> numList = new List<int>();
            //建立奇數跟偶數的清單
            List<int> oddlist = new List<int>();
            List<int> evenlist = new List<int>();


            //將字串們存入清單中
            foreach (string str in strArray)
            {
                if (int.TryParse(str, out int intNum))
                {
                    numList.Add(intNum);
                }
                else
                { Console.WriteLine("非正確輸入"); }
            }
            numList.Sort();                           //先將清單排序
            foreach (int num in numList)              //將數字分別加入對應的清單
            {
                if (num % 2 != 0)
                {
                    oddlist.Add(num);
                }
                else
                {
                    evenlist.Add(num);
                }
            }
            //Substring、

            Console.Write($"奇數：{string.Join(",", oddlist)}\n");
            Console.Write($"偶數：{string.Join(",", evenlist)}");

            Console.ReadLine();

        }


    }
}
