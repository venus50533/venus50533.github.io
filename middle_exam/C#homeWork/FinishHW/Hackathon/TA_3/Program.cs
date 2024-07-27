using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串有意義的英文句子");
            var input = Console.ReadLine();
            var result = input
                .Split(' ')
                .Select(x=>x.ToLower())
                .GroupBy(x=>x)
                .Select(gp => $"{gp.Key} : {gp.Count()}");
            Console.WriteLine(string.Join(Environment.NewLine, result));
            Console.ReadLine();
        }
    }
}
