using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            //Console.WriteLine(s++); // s before add 1 i,e, 0
            Console.WriteLine(++s); // s after add 1 i,e, 1
            //s++; // s = s + 1;
            //++s; // s = s + 1;
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
