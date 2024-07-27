using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_Farmer_crossing_the_river01
{
    public partial class TAForm1 : Form
    {
        private List<string> _left;
        private List<string> _right;
        public const string FARMER = "農夫"; //通常public 全大寫
        public const string WOLF = "狼";
        public const string SHEEP = "小綿羊";
        public const string VEGETABLE = "大白菜";
        private static List<string> _initData =new List<string> {  FARMER,WOLF,SHEEP,VEGETABLE  };
        private static Stack<List<string>> _Stack;
        public TAForm1()
        {
            InitializeComponent();
            CreateList(); //初始化清單 以及塞他本來的資料
            ChangeDataHandler();
            SetlListBoxSelectionMode();
        }

        private void SetlListBoxSelectionMode()
        {
            leftlistBox.SelectionMode = SelectionMode.One;
            rightlistBox.SelectionMode = SelectionMode.One;
        }

        private void CreateList()
        {
            _left = new List<string>()
            {
                FARMER,WOLF,SHEEP, VEGETABLE,
            };
            _right = new List<string>();
        }

        private void ChangeDataHandler()
        {
            leftlistBox.DataSource = null;
            rightlistBox.DataSource = null;

            leftlistBox.DataSource = _left;
            rightlistBox.DataSource = _right;
        }
        private bool IsWin()

        {
            var initData = new List<string>()
            {
                FARMER,WOLF,SHEEP,VEGETABLE
            };
            if (_left.Count == 0  && 
                _right.Count == 4 && 
                _initData.All(x => _right.Contains(x)) &&
                _right.Contains(FARMER) && _right.Contains(WOLF) && _right.Contains(SHEEP) && _right.Contains(VEGETABLE))

            {
                return true;
            }
            else
            { 
                return false;
            }

        }
        private bool IsLose(List<string> source)
        {
            if (source.Contains(FARMER))
            { return false; }

            if (source.Contains(WOLF) && source.Contains(SHEEP))
            {
                return true;
            }
            else if (source.Contains(VEGETABLE) && source.Contains(SHEEP))
            {
                return false;
            }
            return false;
        }

        private void CheckGameState()
        {
            if (IsWin())
            { MessageBox.Show("Win!!!"); }
            if (IsLose(_right) || IsLose(_left))
            {
                MessageBox.Show("you lose!!!");
            }
        }

        private void ToRight_button_Click(object sender, EventArgs e)
        {
            //1.左邊要有東西、而且要有農夫
            if (leftlistBox.SelectedItems != null && _left.Contains(FARMER))
            {
                //2.移動的項目
                var tempList = new List<string>()
                {
                    FARMER                };
                var passenger = (string)leftlistBox.SelectedItem;
                if (passenger != FARMER)
                {
                    tempList.Add(passenger);
                }
                //3.移動資料
                _left.RemoveAll(x => tempList.Contains(x));
                _right.AddRange(tempList);
                //foreach( var item in tempList)
                //{
                //  _left.Remove(item);
                //  _right.Add(item);
                //}

                //4.刷新畫面
                ChangeDataHandler();
                CheckGameState();



            }
        }

        private void ToLeft_button_Click(object sender, EventArgs e)
        {
            if (rightlistBox.SelectedItems != null && _right.Contains(FARMER))
            {
                //2.移動的項目
                var tempList = new List<string>() 
                { 
                    FARMER 
                };
                var passenger = (string)rightlistBox.SelectedItem;
                if (passenger != FARMER)
                {
                    tempList.Add(passenger);
                }
                //3.移動資料
                _right.RemoveAll(x => tempList.Contains(x));
                _left.AddRange(tempList);

                //4.刷新畫面
                ChangeDataHandler();
            }

        }


        private void ResetbuttonClick(object sender, EventArgs e)
        {
            CreateList();
            ChangeDataHandler();
        }
    }
}
