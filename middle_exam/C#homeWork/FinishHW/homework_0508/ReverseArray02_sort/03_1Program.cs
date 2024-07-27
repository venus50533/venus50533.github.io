using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray02_sort
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* 輸入一串以逗號分隔的字串，將其反向顯示 並 排序!!! 
             * 例如:輸入 12,13,23,32
                    結果 32,23,13,12
                請使用迴圈、String 類別*/

            Console.WriteLine("輸入一串以逗號分隔的字串將其反向顯示 並 排序");
            string input = Console.ReadLine();
            string[] strArr = input.Split(',');
            int[] intArr = Array.ConvertAll(strArr, int.Parse);

            for (int i = 0; i < intArr.Length; i++) //每個數字都要輪到
            {
                int key; //暫存
                for (int j = 1; j < intArr.Length; j++)  //每個位置都要輪到
                {
                    if (intArr[j] > intArr[j - 1])
                    {
                        key = intArr[j - 1];
                        intArr[j - 1] = intArr[j];
                        intArr[j] = key;
                    }
                }
            }

            Console.Write(string.Join(",", intArr));

            Console.ReadLine();

        }


    }
}
