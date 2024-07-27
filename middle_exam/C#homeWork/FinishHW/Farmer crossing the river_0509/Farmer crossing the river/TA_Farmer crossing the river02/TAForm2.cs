using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_Farmer_crossing_the_river02
{
    public partial class TAForm2 : Form
    {
        private List<string> _left;
        private List<string> _right;
        public const string FARMER = "農夫"; //通常public 全大寫
        public const string WOLF = "狼";
        public const string SHEEP = "小綿羊";
        public const string VEGETABLE = "大白菜";
        public TAForm2()
        {
            InitializeComponent();
            CreateList();
            ChangeDataHandler();
            SetListBoxSelectionMode();
        }

        private void SetListBoxSelectionMode()
        {
            leftlistBox.SelectionMode = SelectionMode.One;
            rightlistBox.SelectionMode = SelectionMode.One;
        }

        private void ChangeDataHandler()
        {
            leftlistBox.DataSource = null;
            rightlistBox.DataSource = null;

            leftlistBox.DataSource = _left;
            rightlistBox.DataSource = _right;
        }

        private void CreateList()
        {
            _left = new List<string>()
            {
                FARMER,WOLF,SHEEP, VEGETABLE,
            };
            _right = new List<string>();
        }

        private void CrossRiverButtonClick(object sender, EventArgs e)
        {
            //移動(農夫的那邊)
            ListBox sourceListbox;
            List<string> sourceList;
            List<string> targetList;

            if (_left.Contains(FARMER))
            {
                sourceListbox = leftlistBox;
                sourceList = _left; 
                targetList = _right;
            }
            else
            {
                sourceListbox = rightlistBox;
                sourceList = _right;
                targetList = _left;
            }
            //要移動的項目
            if (sourceListbox.SelectedItem != null && sourceList.Contains(FARMER))
            { 
                var ship =new List<string>()
                { 
                    FARMER
                };
                var passenger =(string)sourceListbox.SelectedItem;
                if (passenger != FARMER)
                { 
                    ship.Add(passenger);
                }
                sourceList.RemoveAll(x => ship.Contains(x));
                targetList.AddRange(ship);
                //畫面處理
                ChangeDataHandler();
            }

            CheckGameState();

        }
        private bool IsWin()
        {
            var initData = new List<string>()
            {
                FARMER,WOLF,SHEEP,VEGETABLE
            };
            if (_left.Count == 0 && _right.Count == 4
                && initData.All(x => _right.Contains(x)))
            {
                return true;
            }
            else

                return false;
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
                return true;
            }
            else
            {
                return false;
            }
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

        private void reset_Click(object sender, EventArgs e)
        {
            CreateList();
            ChangeDataHandler();
        }
    }
}
