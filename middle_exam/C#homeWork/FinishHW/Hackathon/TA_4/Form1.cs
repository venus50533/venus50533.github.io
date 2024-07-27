using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_4
{
    public partial class Form1 : Form
    {
        private string _answer;
        private List<string> _history;

        private int _a;
        private int _b;
        public Form1()
        {
            InitializeComponent();
            SetListBox();
            ChangeDataHandler();
        }

        private void SetListBox()
        {
            _history= new List<string>();
            //listBox1.DataSource = _history;

        }

        private void ChangeDataHandler()
        {
            listBox1.DataSource = null; ;
            listBox1.DataSource = _history;
        }

        private void GamestartBtnClick(object sender, EventArgs e)
        {
            
            InitGameAnswer();
        }
        private void InitGameAnswer()
        {
            var random = new Random();
            var ansResult = Enumerable.Range(0, 10).OrderBy(x => random.Next()).Take(4);
            _answer = string.Join(string.Empty, ansResult);
            //_answer = string.Concaat(ansResult);
        }


        private void ShowAnswerBtnClick(object sender, EventArgs e)
        {
            MessageBox.Show($"答案是{_answer}");
        }

        private void ChickAnswerBtnClick(object sender, EventArgs e)
        {
            var input = textBox2.Text;
            //if (!IsValidInput(input))
            //{
            //    MessageBox.Show("輸入錯誤!");
            //}

            if (!TryIsValidInput(input, out string errMsg))
            {
                MessageBox.Show($"輸入錯誤!{errMsg}");
            }

            GuessResultHandler(input);
            GameHistoryHandler(input);
            textBox2.Text = string.Empty;

            if (_a == 4)
            {
                MessageBox.Show("過關");
            };

        }

        private void GameHistoryHandler(string input)
        {
            string displayResult = $"{input} : {_a}A{_b}B";
            _history.Add(displayResult);
            ChangeDataHandler();
        }

        private void GuessResultHandler(string input)
        {
            _a = input.Count(c=>input.IndexOf(c) == _answer.IndexOf(c));
            _b = input.Intersect(_answer).Count()-_a;

            //_a = 0; //出現過且位置相同
            //_b = 0; //出現過或位置不同

            //for (int i = 0; i < 4; i++)
            //{
            //    if (_answer[i] == input[i])
            //    {
            //        _a++;
            //    }
            //    else if (_answer.Contains(input[i]))
            //    {
            //        _b++;
            //    }
            //}
        }

        private bool TryIsValidInput(string input, out string errMsg)
        {
            //輸入判斷
            if (string.IsNullOrEmpty(input))
            {
                errMsg = "需要輸入數字!";
                return false;
            };
            //11111長度不對
            if (input.Length !=4) 
            {
                errMsg = "長度不對!必須為4個數字";
                return false;
            };
            //1111
            if (input.Distinct().Count() != 4)
            {
                errMsg = "輸入的數字不可以重複";
                return false;
            }

            //檢查輸入的是不是數字
            //if (input.Any(c=> !char.IsDigit(c)))
            if (!int.TryParse(input,out _))  //_捨棄
            {
                errMsg = "需要輸入數字";
                return false;
            };


            errMsg = string.Empty;
            return true;
        }

        private void ReSarttBtnClick(object sender, EventArgs e)
        {
            InitGameAnswer();
            SetListBox();
            ChangeDataHandler();
        }

        
    }
}
