using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        private static decimal _Tax;
        static void Main(string[] args)
        {
            /* 中華民國的稅率級距表如下： 
             * 1 年收入0 ~ 540,000 : 5%
               2 年收入 540,001 ~  1,210,000 : 12%
               3 年收入 1,210,001 ~  2,420,000 : 20%
               4 年收入 2,420,001 ~  4,530,000 : 30%
               5 年收入 4,530,001 ~ 10,310,000 : 40%
               6 年收入 10,310,001~            : 50%
            撰寫一個程式可以輸入年收入，然後依照上面的公式計算應繳納稅額。 請使用 Decimal。*/

            Console.WriteLine("請輸入您的年收入，用以計算應繳納稅額");
            string input = Console.ReadLine();
            decimal salary = Convert.ToDecimal(input);
            decimal tax1 = PayTax(salary);
            decimal tax2 = 0 ;
            int level;
 
            var result = new List<( int i,decimal money ,decimal rate,decimal start, decimal End)>
            {
                (1,0,0.05m,0m,540000m),             
                (2,27000m,0.12m,540001m,1210000m),    
                (3,107400m,0.2m,1210001m,2420000m),    
                (4,349400.68m,0.3m,2420001m,4530000m),
                (5,982400m,0.4m,4530001m,10310000m),
                (6,3294400m,0.5m,10310001m,salary)            
            
            };

            foreach (var rang in result) 
            {
                
                if (salary >= rang.start && salary <= rang.End)
                {
                    tax2 = (salary - rang.start) * rang.rate;
                    if (rang.i  > 0)
                    {
                        tax2 += rang.money;
                    }
                    
                }
            
            }

            //Console.WriteLine($"應繳納稅額為{string.Format("{0:N}}",tax)}");  錯的
            Console.WriteLine($"應繳納稅額為{tax1.ToString("N0")}");
            Console.WriteLine($"應繳納稅額為{tax2.ToString("###,###")}");




            Console.ReadLine();



        }

        static decimal PayTax(decimal salary)
        {
            decimal tax = 0;
            if (salary >= 0 && salary <= 540000)
            {
                tax = salary * 0.05m;
            }
            else if (salary > 540000 && salary <= 1210000)
            {
                tax = (540000 * 0.05m) + (salary - 540000) * 0.12m;
            }
            else if (salary > 1210000 && salary <= 2420000)
            {
                tax = (540000 * 0.05m) + (1210000 - 540000) * 0.12m + (salary - 1210000) * 0.2m;
            }
            else if (salary > 2420000 && salary <= 4530000)
            {
                tax = (540000 * 0.05m) + (1210000 - 540000) * 0.12m + (2420000 - 1210000) * 0.2m + (salary - 2420000) * 0.3m;
            }
            else if (salary > 4530000 && salary <= 10310000)
            {
                tax = (540000 * 0.05m) + (1210000 - 540000) * 0.12m + (2420000 - 1210000) * 0.2m + (4530000 - 2420000) * 0.3m + (salary - 4530000) * 0.4m;

            }
            else if (salary > 10310000)
            {
                tax = (540000 * 0.05m) + (1210000 - 540000) * 0.12m + (2420000 - 1210000) * 0.2m + (4530000 - 2420000) * 0.3m + (10310000 - 4530000) * 0.4m + (salary - 10310000) * 0.5m;

            }
            return _Tax =tax ;

        }
        static void Q()
        {
            /* 測試數據，每一個輸入都要得到正確的輸出
               100,000 -> 5,000
               540,000 -> 27,000
               540,001 -> 27,000.12
               1,210,000 -> 107,400
               1,218,000 -> 109,000
               2,420,000 -> 349,400
               2,500,000 -> 373,400
               4,530,000 -> 982,400
               5,530,000 -> 1,382,400
               10,310,000 -> 3,294,400
               10,710,000 -> 3,494,400
            
             https://learn.microsoft.com/zh-cn/dotnet/standard/base-types/custom-numeric-format-strings
             */
        }
    }
}
