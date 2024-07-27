using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 請輸入一個中華民國年份、將輸入轉為西元年，判斷是否為閏年，DateTime 結構
            //任何能以 4 整除的年份都是閏年：例如 1988 年、1992 年及 1996 年都是閏年。
            //西曆規定能以 100(例如1900 年) 整除的年份，同時也要能以 400 整除，才算是閏年。
            /*如果年份被 4 整除，則移至步驟 2。 否則，請跳至步驟 5。
                如果年份被 100 整除，則移至步驟 3。 否則，請跳至步驟 4。
                如果年份被 400 整除，則移至步驟 4。 否則，請跳至步驟 5。
                該年份為閏年 (有 366 天)。
                該年分不是閏年 (有 365 天)。*/

            Console.WriteLine("請輸入中華民國年份：");       //輸入年份     
            //string input = Console.ReadLine();
            //string twYear = $"{input.PadLeft('0')}/01/01";
            //CultureInfo culture = new CultureInfo("zh-TW");
            //culture.DateTimeFormat.Calendar = new TaiwanCalendar();
            //var year = DateTime.Parse(twYear, culture);
            //Console.WriteLine(DateTime.IsLeapYear(year.Year) ? "是" : "不是");////判斷閏年

            //助教版本
            string input = Console.ReadLine();
            Calendar tc = new TaiwanCalendar();
            //DateTime theDay = new DateTime(int.Parse(input),1,11,tc); //依據月曆 產出 西元的日期時間 的 執行個體
            bool isLeep = tc.IsLeapYear(int.Parse(input));  //這個是tw Calender的方法，非靜態需要執行個體
            if (isLeep == true) { Console.WriteLine("是閏年"); }
            else { Console.WriteLine("不是閏年"); }




            Console.ReadLine();
        }
    }
}
