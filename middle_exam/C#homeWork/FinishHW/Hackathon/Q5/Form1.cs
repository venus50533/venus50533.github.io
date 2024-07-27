using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Q5
{
    public partial class Form1 : Form
    {
        private string filename;
        private string _LifeNumber;
        private string _Star;
        public Form1()
        {
            InitializeComponent();
            filename = "生命靈數.txt";
            LifeNumber();
            StarsSign();
            StarSign_2();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (File.Exists(filename))
            {
                List<string> allLines = new List<string>();


                var allText = File.ReadAllText(filename).Trim();  //讀取整個檔案，並將每行分割至清單(包含空白)
                char[] splits = { '\n' };
                allLines = allText.Split(splits).ToList();
                var lines = allLines.FindIndex((x) => x.Contains(StarsSign())); //抓取星座行
                var starLine = lines + int.Parse(LifeNumber()) * 2;             //生命靈數行

                label3.Text = string.Empty;
                label3.Text += $"您的星座是{_Star}{Environment.NewLine}{Environment.NewLine}{allLines.ElementAt(starLine)}";

            }
            else
            {
                MessageBox.Show("檔案不存在");
            }

        }
        private string LifeNumber()
        {
            //char[] day = dateTimePicker1.Value.ToString("yyyyMMdd").ToCharArray();
            //int[] ints = new int[day.Length];
            //int idx = 0;
            //int lifeNum = 0;
            //foreach (char c in day)
            //{
            //    ints[idx++] = int.Parse(c.ToString());
            //}
            //foreach (int a in ints)
            //{
            //    lifeNum += a;
            //}

            //while (lifeNum > 9)
            //{
            //    lifeNum = int.Parse(lifeNum.ToString().Substring(0, 1)) + int.Parse(lifeNum.ToString().Substring(1, 1));
            //}
            //版本二 
            var day = dateTimePicker1.Value.ToString("yyyyMMdd");
            while (day.Length>1 )
            {            
                int lifeNum = 0;
                foreach (var num in day)
                {
                    lifeNum += int.Parse(num.ToString());
                }
                day = lifeNum.ToString();
                _LifeNumber = day;
            }

            return _LifeNumber ;

        }
        private string StarsSign()
        {
            var date = dateTimePicker1.Value.ToString("MMdd");
            var month = int.Parse(date.Substring(0, 2));
            var day = int.Parse(date.Substring(2, 2));

            if ((month == 1 && day > 19) || (month == 2 && day < 19))
            {
                //水瓶座：1月20日~2月18日
                _Star = "水瓶座";

            }
            if ((month == 2 && day > 18) || (month == 3 && day < 21))
            {
                //雙魚座：2月19日~3月20日*/
                _Star = "雙魚座";


            }
            if ((month == 3 && day > 20) || (month == 4 && day < 20))
            {
                //牡羊座：3月21日~4月19日
                _Star = "牡羊座";


            }
            if ((month == 4 && day > 19) || (month == 5 && day < 21))
            {
                //金牛座：4月20日~5月20日
                _Star = "金牛座";
            }

            if ((month == 5 && day > 20) || (month == 6 && day < 22))
            {
                //雙子座：5月21日~6月21日
                _Star = "雙子座";



            }
            if ((month == 6 && day > 21) || (month == 7 && day < 23))
            {
                //巨蟹座：6月22日~7月22日
                _Star = "巨蟹座";


            }

            if ((month == 7 && day > 22) || (month == 8 && day < 23))
            {
                //獅子座：7月23日~8月22日
                _Star = "獅子座";


            }
            if ((month == 8 && day > 22) || (month == 9 && day < 21))
            {
                //處女座：8月23日~9月22日
                _Star = "處女座";


            }
            if ((month == 9 && day > 22) || (month == 10 && day < 24))
            {
                //天秤座：9月23日~10月23日
                _Star = "天秤座";


            }
            if ((month == 10 && day > 23) || (month == 11 && day < 23))
            {
                //天蠍座：10月24日~11月22日
                _Star = "天蠍座";


            }
            if ((month == 11 && day > 22) || (month == 12 && day < 22))
            {
                //射手座：11月23日~12月21日
                _Star = "射手座";


            }
            if ((month == 12 && day > 21) || (month == 1 && day < 20))
            {
                //摩羯座：12月22日~1月19日*/
                _Star = "摩羯座";
            }

            return _Star;
        }
        private string StarSign_2()
        {

            var date = dateTimePicker1.Value.ToString("MMdd");
            var month = int.Parse(date.Substring(0, 2));
            var day = int.Parse(date.Substring(2, 2));

            var starSigns = new List<(string Name, (int Month, int Day) Start, (int Month, int Day) End)>
             {
                ("水瓶座", (1, 20), (2, 18)),
                ("雙魚座", (2, 19), (3, 20)),
                ("牡羊座", (3, 21), (4, 19)),
                ("金牛座", (4, 20), (5, 20)),
                ("雙子座", (5, 21), (6, 21)),
                ("巨蟹座", (6, 22), (7, 22)),
                ("獅子座", (7, 23), (8, 22)),
                ("處女座", (8, 23), (9, 22)),
                ("天秤座", (9, 23), (10, 23)),
                ("天蠍座", (10, 24), (11, 22)),
                ("射手座", (11, 23), (12, 21)),
                ("摩羯座", (12, 22), (1, 19))
              };

            foreach (var sign in starSigns)
            {
                //if ((month == sign.Start.Month && day >= sign.Start.Day) ||
                //    (month == sign.End.Month && day <= sign.End.Day) ||
                //    (sign.Start.Month > sign.End.Month && ((month == sign.Start.Month && day >= sign.Start.Day) || (month == sign.End.Month && day <= sign.End.Day))))
                //{
                //    return sign.Name;
                //}
                if ((month == sign.Start.Month && day >= sign.Start.Day) ||
                    (month == sign.End.Month && day <= sign.End.Day) ||
                    ( sign.Start.Month > sign.End.Month && 
                    ((month == sign.Start.Month && day >= sign.Start.Day) ||
                     (month == sign.End.Month && day <= sign.End.Day))))
                {
                     _Star = sign.Name;
                }
            }
                return _Star;
        }


    }
}
