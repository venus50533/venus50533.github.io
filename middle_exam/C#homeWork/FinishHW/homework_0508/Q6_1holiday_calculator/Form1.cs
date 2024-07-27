using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q6_1holiday_calculator
{
    public partial class Form1 : Form
    {
        public string _inputYear;
        public int _WeekDaySaturday;
        public int _WeekDaySunDay;


        public Form1()
        {
            InitializeComponent();

        }

        private void ShowData()
        {
            label4.Text = null;
            label4.Text = $"{_inputYear}年{Environment.NewLine}" +
                          $"星期六一共有{_WeekDaySaturday}天{Environment.NewLine}" +
                          $"星期天一共有{_WeekDaySunDay}天";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_inputYear == null)
            {
                MessageBox.Show("請輸入正確資料");
            }
            else
            {
                DayOfWeek_year();
                //DayOfWeek_year_Loop();
                DisplayResult(int.Parse(_inputYear));
                ShowData();
            }

        }


        private void DayOfWeek_year()
        {

            DateTime year = new DateTime(int.Parse(_inputYear), 12, 31);
            _WeekDaySaturday = ((int)year.DayOfYear) / 7;
            _WeekDaySunDay = ((int)year.DayOfYear) / 7;

            if (year.DayOfWeek == DayOfWeek.Saturday) //不管是否閏年，如果1/1等於星期六，代表我的多一天會落在星期六
            {
                _WeekDaySaturday += 1;
            }
            if (year.DayOfWeek == DayOfWeek.Sunday)  //不管是否閏年，如果1/1是星期天，代表我的多一天會落在星期天
            {
                _WeekDaySunDay += 1;

                if (year.DayOfYear == 366)   //但是閏年因為是52周+2天，如果1/1是星期天，代表我的多兩天，是落在六跟日，故星期六也要加一天(星期天上面加過了)
                {
                    _WeekDaySaturday += 1;
                }
            }
        }
        private void DayOfWeek_year_Loop()
        {
            //DateTime thisYear = new DateTime(int.Parse(_inputYear), 1, 1);
            //DateTime nextYear = new DateTime(int.Parse(_inputYear) + 1, 1, 1);
            //int sat = 0;
            //int sun = 0;
            //for (DateTime now = thisYear; now < nextYear; now = now.AddDays(1))
            //{
            //    if (now.DayOfWeek == DayOfWeek.Saturday) { sat++; }
            //    if (now.DayOfWeek == DayOfWeek.Sunday) { sun++; }
                
            //}
            //MessageBox.Show($"{_inputYear}年的{Environment.NewLine}" +
            //                    $"星期六一共有{sat}天{Environment.NewLine}" +
            //                    $"星期天一共有{sun}天");

            //第二版本
            DateTime thisYear = new DateTime(int.Parse(_inputYear), 1, 1);
            DateTime nextYear = new DateTime(int.Parse(_inputYear) + 1, 1, 1);
            int sat = 0;
            int sun = 0;
            while(thisYear < nextYear)
            {
                if (thisYear.DayOfWeek == DayOfWeek.Saturday) { sat++; }
                if (thisYear.DayOfWeek == DayOfWeek.Sunday) { sun++; }
                thisYear = thisYear.AddDays(1);

            }
            MessageBox.Show($"{_inputYear}年{Environment.NewLine}" +
                                $"星期六一共有{sat}天{Environment.NewLine}" +
                                $"星期天一共有{sun}天");



        }

        private void DisplayResult(int year)
        {
            int sat = CountWeekday(year, DayOfWeek.Saturday);
            int sun = CountWeekday(year, DayOfWeek.Sunday);
            MessageBox.Show($"星期六有{sat}天、星期天有{sun}天");
        }
        private int CountWeekday(int year, DayOfWeek dayOfWeek)
        {
            //可以參考引數的用法，助教方法
            if (!DateTime.IsLeapYear(year))
            {
                DateTime firstDay = new DateTime(year, 1, 1);
                if (firstDay.DayOfWeek == dayOfWeek)
                { return 53; }
                else
                { return 52; }
            }
            else
            {
                DateTime firstDay = new DateTime(year, 1, 1);
                DateTime lastDay = new DateTime(year, 12, 31);
                if (firstDay.DayOfWeek == dayOfWeek || lastDay.DayOfWeek == dayOfWeek)
                { return 53; }
                else { return 52; }
            }
        
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _inputYear = textBox1.Text;
        }


    }
}
