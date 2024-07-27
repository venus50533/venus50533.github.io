using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_Farmer_crossing_the_river03
{
    
    public partial class TAForm3 : Form
    {
        private List<string> _left;
        private List<string> _right;
        public const string FARMER = "農夫"; //通常public 全大寫
        public const string WOLF = "狼";
        public const string SHEEP = "小綿羊";
        public const string VEGETABLE = "大白菜";
        public static List<string> _initData = new List<string>()
        {
            FARMER, WOLF, SHEEP, VEGETABLE,
        };
        private static Stack<List<string>> _stack;

        public TAForm3()
        {
            InitializeComponent();
            SetListBoxSelectionMode();
            CreateList();
            ChangeDataHandler();
            _stack = new Stack<List<string>>();
        }

        private void SetListBoxSelectionMode()
        {
            leftlistBox.SelectionMode = SelectionMode.One;
            rightlistBox.SelectionMode = SelectionMode.One;
        }

        private void CreateList()
        {
            _left = _initData.ToList();
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
            
            if (_left.Count == 0 && _right.Count == 4
                && _initData.All(x => _right.Contains(x)))
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



        private void Back_button_Click(object sender, EventArgs e)
        {

        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            CreateList();
            ChangeDataHandler();

        }

        private void CrossRiverBtnClick(object sender, EventArgs e)
        {
            //儲存過河前左岸資料
            StoreData();    
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
                    var ship = new List<string>()
                {
                    FARMER
                };
                    var passenger = (string)sourceListbox.SelectedItem;
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

        private void StoreData()
        {
            _stack.Push(_left.ToList());
        }

        private void RestorebuttonClick(object sender, EventArgs e)
        {
            if (_stack.Count > 0)
            { 
                var leftItems =_stack.Pop();
                var rightItems = _initData.Except(leftItems).ToList();
                _left = leftItems;
                _right = rightItems;
                ChangeDataHandler();
                CheckGameState() ;

            }
        }
    }
}
