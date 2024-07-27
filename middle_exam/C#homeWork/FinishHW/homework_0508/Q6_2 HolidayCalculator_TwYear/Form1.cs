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

namespace Q6_2_HolidayCalculator_TwYear
{
    public partial class Form1 : Form
    {
        public string _inputTwYear;
        public int _WeekDaySaturday;
        public int _WeekDaySunDay;

        public Form1()
        {
            InitializeComponent();
        }
        private void ShowData()
        {
            label4.Text = null;
            label4.Text = $"{_inputTwYear}年{Environment.NewLine}" +
                          $"星期六一共有{_WeekDaySaturday}天{Environment.NewLine}" +
                          $"星期天一共有{_WeekDaySunDay}天";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_inputTwYear == null)
            {
                MessageBox.Show("請輸入正確資料");
            }
            else
            {
                DayOfWeek_TWyear();
                ShowData();
            }
        }
        private void DayOfWeek_TWyear()
        {
            CultureInfo curr = new CultureInfo("zh-TW");
            curr.DateTimeFormat.Calendar = new TaiwanCalendar();
            DateTime year = new DateTime(int.Parse(_inputTwYear), 12, 31);
            year = DateTime.Parse(year.ToString(), curr);

            _WeekDaySaturday = ((int)year.DayOfYear) / 7;
            _WeekDaySunDay = ((int)year.DayOfYear) / 7;

            if (year.DayOfWeek == DayOfWeek.Saturday)
            {
                _WeekDaySaturday += 1;
            }
            if (year.DayOfWeek == DayOfWeek.Sunday)
            {
                _WeekDaySunDay += 1;

                if (year.DayOfYear == 366)
                {
                    _WeekDaySaturday += 1;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _inputTwYear = textBox2.Text;

        }
    }
}
