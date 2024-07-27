using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
    public partial class Form1 : Form
    {
        public string _anser;
        public string _guess;
        public List<string> _showlist;
        public Form1()
        {
            InitializeComponent();
            ChangeData();
            CreatList();

        }
        private void CreateRandom()
        {
            Random r1 = new Random();
            int[] num = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] idx = new int[4];

            _anser = null;
            idx = num.OrderBy(a => r1.Next()).ToArray();

            for (int a = 0; a < 4; a++)
            {
                _anser += idx.GetValue(a);
            }
        }
        private void CreatList()
        {
            _showlist = new List<string>(); 
        }
        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _showlist;
        }

        private void GameStart_ButtonClick(object sender, EventArgs e)
        {

            /* 要求輸入，將輸入值存入 */
            MessageBox.Show("遊戲開始!! 請輸入猜測");
            CreateRandom();



        }
        private void IsWin()
        {
            MessageBox.Show("您猜對囉!! 恭喜你");
        }

        private void CheckANS_ButtonClick(object sender, EventArgs e)
        {

            /*電腦從 0~9 亂數挑選 4 的不重複的數字，讓使用者猜。
              如果玩家猜測的某一個數字和電腦挑選的相同，但順序不同，則以 B 表示；
              若是該數字連順序都相同則以 A 表示。4A 及代表遊戲成功結束。
              例如：電腦挑出的數字為 5461
              玩家猜 5038，則為 1A0B
              玩家猜 5048，則為 1A1B
              玩家猜 9872，則為 0A0B   */

            //判斷AB數量
            if (_guess != null)
            { 
                CreatList();
                BtnClickOpen();
                var countA = 0;
                var countB = _guess.Intersect(_anser).Count();
                for (int i = 0; i < 4; i++)
                {
                    if (_guess[i] == _anser[i])
                    {
                        countA++;
                        countB--;
                    }
                }
                button1.Enabled = false;
                _showlist.Add($"{_guess}：{countA}A{countB}B");
            }
            else
            {
                MessageBox.Show("請輸入4位數字!!");
            }

            ChangeData();
            

        }

        private void BtnClickOpen()
        {
            button2.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_ClickAns(object sender, EventArgs e)
        {

            MessageBox.Show($"答案是{_anser}");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            _guess = textBox2.Text;
        }



        private void ReStart_ButtonClick(object sender, EventArgs e)
        {
            
            _showlist = null;
            textBox2.Clear();
            listBox1.DataSource = _showlist;
            MessageBox.Show("遊戲開始!! 請輸入猜測");
            button1.Enabled = true;
            button2.Enabled = false;
            CreateRandom();
            ChangeData();

        }
    }
}
