using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 年收入0 ~540,000 : 5 %
            //    2 年收入 540,001 ~1,210,000 : 12 %
            //    3 年收入 1,210,001 ~2,420,000 : 20 %
            //    4 年收入 2,420,001 ~4,530,000 : 30 %
            //    5 年收入 4,530,001 ~10,310,000 : 40 %
            //    6 年收入 10,310,001~            : 50 %
            var inputList = new List<string>()
             { "100000","540000","540001","1210000","12180000","2420000","2500000","4530000","5530000","10310000","10710000",};
            foreach (var input in inputList)
            {
                decimal income = decimal.Parse(input);
                decimal tax = GetTaxFee(income);
                Console.WriteLine($"{income.ToString("c")} -> {tax.ToString("#,#.##")}");
                //ToString("#,#.00") 只要沒有就補0,#是有就補,0是一定藥補 
            }
            Console.ReadLine();

        }
        static decimal GetTaxFee(decimal income)
        {
            List<MyTaxRateGrade>taxRateGrades = new List<MyTaxRateGrade>()
            { 
                new MyTaxRateGrade(0.05m,0),
                new MyTaxRateGrade(0.12m,540_000),
                new MyTaxRateGrade(0.2m,1_210_000),
                new MyTaxRateGrade(0.3m,2_420_000),
                new MyTaxRateGrade(0.4m,4_530_000),
                new MyTaxRateGrade(0.5m,10_310_000)
            };
            var orderedGrades = taxRateGrades
                .OrderByDescending(g => g.Lower) //why??
                .Where(g => g.Lower < income);
            decimal upper = income;
            decimal tax = 0;

            foreach (var grade in orderedGrades)
            {
                tax += (upper - grade.Lower) * grade.Rate;
                upper = grade.Lower;
            }
            return tax;
        }
    }
    public class MyTaxRateGrade
    {
        public decimal Lower { get; set; }
        public decimal Rate { get; set; }
        public MyTaxRateGrade(decimal rate, decimal lower)
        {
            Lower = lower;
            Rate = rate;
        }
    }
}
