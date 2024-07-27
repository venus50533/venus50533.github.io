using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        double num;
        double fTemp; //華氏f 
        double cTemp; //攝氏c
        public Form1()
        {
            InitializeComponent();
            BtnSetting();
        }

        private void NumberBtn_Click(object sender,EventArgs e) 
        { 
            Button button = sender as Button;
            if (button!=null) 
            {
               textBox1.Text += button.Text;
            }
        }
        private void BtnSetting()
        {
            List<Button> buttons = new List<Button>() 
            {
                button1,button2,button3,button4,button5
                ,button6,button7,button8,button9,button10,button13
            };
            foreach (Button btn in buttons) 
            {
                btn.Click += new System.EventHandler(this.NumberBtn_Click);
            }
        }



        private void Changebutton_Click(object sender, EventArgs e)
        {
            
            num = double.Parse(textBox1.Text);

            if (radioButton1.Checked) //攝氏至華氏換算
            {
                fTemp = num  * 9.0 / 5.0+32.0;
                resultLabel.Text +=$"{num}°C ={Math.Round(fTemp,2)}°F" ;
            }
            else if (radioButton2.Checked)
            {
                cTemp = (num-32)  * 5.0 / 9.0 ;
                resultLabel.Text += $"{num}°F={Math.Round(cTemp,2)}°C";
            }
            else
            {
                MessageBox.Show("請選擇想要的轉換方式");
            }
            //華氏f 攝氏c
            


            Console.WriteLine($"對應的攝氏溫度值為:{cTemp}");

            textBox1.Text = "";    //文本框清空
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //攝c 轉 華f 
            
                resultLabel.Text = "結果：" + string.Empty;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
                resultLabel.Text = "結果：" + string.Empty;


        }

        private void resultLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "結果：" + string.Empty;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
