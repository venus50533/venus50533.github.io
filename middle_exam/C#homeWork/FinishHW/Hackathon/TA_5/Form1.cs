using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetResultBtnClick(object sender, EventArgs e)
        {
            string temp = $"{dateTimePicker1.Value.Year}" +
                          $"{dateTimePicker1.Value.Month}" +
                          $"{dateTimePicker1.Value.Day}";
            int num = int.Parse(temp);
            var result = CalculateLifeNumber_1(num);

            MessageBox.Show(result.ToString());
        }

        private int CalculateLifeNumber(int number)
        {
            //19921223 -> ->29 -> 11 -> 2
            int result = number;
            do
            {
                //[1,9,9,2,1,2,2,3]
                var t = result.ToString().Select(c => int.Parse(c.ToString()));
                result = t.Sum(x => x);
            }
            //while (!(result > 9);
            while (result / 10 != 0);
            return result;
        }
        private int CalculateLifeNumber_1(int number)
        {
            //方法2
            //19921223 -> 11 -> 2
            int result = 0;
            var temp = number.ToString();
            while (temp.Length > 1)
            {
                result = temp.Sum(c => int.Parse(c.ToString()));
                temp = result.ToString();
            }
            return result;
        }
        private int CalcuLifeNumByRecursion_2(int number)
        {
            //方法3
            //19921223 -> 11 -> 2
            //先設出口
            //if (number / 10 < 1)
            if (number / 10 < 1)
            {
                return number;
            }
            var temp = number.ToString();
            var sum = temp.Sum(c=>int.Parse(c.ToString()));
            return CalcuLifeNumByRecursion_2(sum);



        }
    }
}
