using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer_crossing_the_river
{
    public partial class Form1 : Form
    {
        List<string> _LeftList;
        List<string> _RightList;


        public Form1()
        {
            InitializeComponent();
            CreateList(); //建立清單
            SetlistBox(); //設定清單為單選模式
            ChangeData(); //設定畫面更新
        }

        private void ChangeData() //針對畫面刷新
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _LeftList;
            listBox2.DataSource = _RightList;
        }

        private void SetlistBox()
        {

            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;
        }

        private void CreateList()
        {
            _LeftList = new List<string>()
            {
                "農夫","狼","羊","菜"
            };
            _RightList = new List<string>();

        }

        private void GoLeft_Button2_Click(object sender, EventArgs e)
        {
            string item = (string)listBox2.SelectedItem;
            if (item != null)
            {

                if (_RightList.Contains("農夫"))
                {

                    if ((item == "狼") && _RightList.Contains("羊") && _RightList.Contains("菜"))
                    {
                        
                        
                        ChangeData();
                        MessageBox.Show("羊吃掉菜了!!");
                        MessageBox.Show("遊戲結束");
                        CloseButton();
                    }

                    if ((item == "菜") && _RightList.Contains("羊") && _RightList.Contains("狼"))
                    {
                        ChangeData();
                        MessageBox.Show("狼吃掉了羊!!");
                        MessageBox.Show("遊戲結束");
                        CloseButton();
                    }

                    if (item == "農夫" && _RightList.Contains("狼") && _RightList.Contains("羊"))
                    {
                        ChangeData();
                        MessageBox.Show("狼吃掉了羊!!");
                        MessageBox.Show("遊戲結束");
                        CloseButton();


                    }
                    if (item == "農夫" && _RightList.Contains("菜") && _RightList.Contains("羊"))
                    {
                        ChangeData();
                        MessageBox.Show("羊吃掉菜了!!");
                        MessageBox.Show("遊戲結束");
                        CloseButton();

                    }

                    if (item == "農夫" || item == "羊" || item == "菜" || item == "狼")
                    {
                        Go_left_side(item);
                    }
                }
            }

        }

        private void GoRight_Button1_Click(object sender, EventArgs e)
        {

            string item = (string)listBox1.SelectedItem;

            if (listBox1.SelectedItem != null)
            {


                if (_LeftList.Contains("農夫"))
                {
                    if (item == "狼" && _LeftList.Contains("羊") && _LeftList.Contains("菜"))
                    {
                        MessageBox.Show("羊吃掉菜了!!");
                        MessageBox.Show("遊戲結束");
                        ChangeData();
                        CloseButton();

                    }

                    if (item == "菜" && _LeftList.Contains("羊") && _LeftList.Contains("狼"))
                    {
                        ChangeData();
                        MessageBox.Show("狼吃掉了羊!!");
                        MessageBox.Show("遊戲結束");
                        CloseButton();


                    }

                    if (item == "農夫" && _LeftList.Contains("羊") && _LeftList.Contains("菜") && _LeftList.Contains("狼"))
                    {
                        ChangeData();
                        MessageBox.Show("狼吃掉了羊!!");
                        MessageBox.Show("遊戲結束");
                        CloseButton();

                    }

                    if (item == "農夫" || item == "羊" || item == "菜" || item == "狼")
                    {
                        Go_right_side(item);

                    }

                }

            }

        }

        private void Go_right_side(string item)
        {
            if (item != "農夫")
            {
                _RightList.Add(item);
                _LeftList.Remove(item);
                _RightList.Add("農夫");
                _LeftList.Remove("農夫");
                MessageBox.Show($"農夫與{item}過河了~");
            }
            if (item == "農夫" && _LeftList.Contains("農夫"))
            {
                _RightList.Add("農夫");
                _LeftList.Remove("農夫");
                MessageBox.Show($"農夫過河了~");

            }

            ChangeData();
        }

        private void Go_left_side(string item)
        {
            if (item != "農夫")
            {
                _LeftList.Add(item);
                _RightList.Remove(item);
                _LeftList.Add("農夫");
                _RightList.Remove("農夫");
                MessageBox.Show($"農夫與{item}過河了~");
            }
            if (item == "農夫" && _RightList.Contains("農夫"))
            {
                _LeftList.Add("農夫");
                _RightList.Remove("農夫");
                MessageBox.Show($"農夫過河了~");

            }

            ChangeData();

        }

        private void CloseButton()
        {
            GoRight_button.Enabled = false;
            GoLeft_button.Enabled = false;
        }

        private void Reset(object sender, EventArgs e)
        {
            CreateList();
            GoLeft_button.Enabled = true;
            GoRight_button.Enabled = true;
            ChangeData();

        }
    }
}
