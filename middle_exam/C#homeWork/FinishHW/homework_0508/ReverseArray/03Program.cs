using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray //1,2,3,4,5,6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 輸入一串以逗號分隔的字串，並將其反向顯示 
             * 例如:輸入 12,13,23,32
                    結果 32,23,13,12
                請使用迴圈、String 類別*/
            Console.WriteLine("輸入一串以逗號分隔的字串");
            string input = Console.ReadLine();
            string[] str = input.Split(',');
            int j = str.Length - 1;

            for (int i = 0; i < str.Length / 2; i++)
            {
                string temp;
                temp = str[j];
                str[j] = str[i];
                str[i] = temp;

                j--;
            }
            Console.WriteLine(string.Join(",", str));
            Console.ReadLine();
        }
    }
}
