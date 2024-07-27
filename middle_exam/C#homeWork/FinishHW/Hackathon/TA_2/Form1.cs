using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_2
{
    public partial class Form1 : Form
    {
        private bool _isToF;
        public Form1()
        {
            InitializeComponent();
        }

        private void PanelButtonClick (object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!IsValidIpunt(btn)) 
            { //點的判斷，不讓點有多個，有多個就停止輸入
                return;
            }
            textBox1.Text += btn.Text; 
        }

        /// <summary>
        /// 合法輸入
        /// </summary>
        /// <param name="btn"></param>
        /// <returns></returns>
        private bool IsValidIpunt(Button btn)
        {
            if (btn == null) { return false; }
            if (btn.Text == ".")
            { 
                return textBox1.Text.Contains(".") == false;
            }
            return true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
               _isToF = radioButton1.Checked;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text =string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(textBox1.Text, out double temp))
            {

                MessageBox.Show("請輸入正確數字");
                return;
            }
            
            resultLabel.Text = string.Empty;
            if (_isToF)
            {
                resultLabel.Text = $"結果:{textBox1.Text}C = {MyTmpeConvert.ConventToF(temp)}F";
            }
            else 
            {
                resultLabel.Text = $"結果:{textBox1.Text}F = {MyTmpeConvert.ConventToF(temp)}C";

            }

            //寫結果
        }
    }

}
