using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer_crossing_the_river03
{
    public partial class Form3 : Form
    {
        public List<string> _Left;
        public List<string> _Right;
        public List<string> _Data = new List<string>
        {
            FARMER, WOLF, SHEEP, VEGETABLE
        };
        public const string FARMER = "農夫";
        public const string WOLF = "大灰狼";
        public const string SHEEP = "小綿羊";
        public const string VEGETABLE = "大白菜";
        public Stack<List<string>> _back ;

        public Form3()
        {
            InitializeComponent();
            CreatList();
            ChangeData();
            SetlistBox();
            _back = new Stack<List<string>>(); //為什麼建立物件在form3?

        }

        private void CreatList()
        {
            _Left = new List<string>()
            {
                FARMER, WOLF, SHEEP, VEGETABLE
            };
            _Right = new List<string>();

        }

        private void ChangeData()
        {
            leftlistBox.DataSource = null;
            rightlistBox.DataSource = null;
            leftlistBox.DataSource = _Left;
            rightlistBox.DataSource = _Right;

        }

        private void SetlistBox()
        {
            leftlistBox.SelectedItem = SelectionMode.One;
            rightlistBox.SelectedItem = SelectionMode.One;
        }

        private bool IsWin()
        {
            if (_Left.Count == 0 && _Right.Count == 4 && _Right.All(x => _Data.Contains(x)))
            {
                return true;
            }
            return false;
        }
        private bool IsLose(List<string> source)
        {
            if (source.Contains(FARMER)) { return false; }
            if (source.Contains(SHEEP) && (source.Contains(WOLF)))
            {
                return true;
            }
            else if (source.Contains(SHEEP) && source.Contains(VEGETABLE))
            {
                return true;
                    }
            else
                return false;

        }
        private void CheckGameState() 
        {
            if (IsWin())
            {
                MessageBox.Show("恭喜~遊戲勝利!!");
                Gobutton.Enabled = false;
            }
            else if (IsLose(_Right) || IsLose(_Left))
            {
                MessageBox.Show("遊戲失敗!! 再接再厲~");
                Gobutton.Enabled = false;
            }
        }

        private void GobuttonClick(object sender, EventArgs e)
        {
            //儲存過河前左岸的資料
            StoreData();
            ListBox sourceListBox;
            List<string> sourceList;
            List<string> targetList;
            if (_Left.Contains(FARMER))
            {
                sourceListBox = leftlistBox;
                sourceList = _Left;
                targetList = _Right;
            }
            else
            {
                sourceListBox = rightlistBox;
                sourceList = _Right;
                targetList = _Left;

            }
            if (sourceListBox.SelectedItem != null && sourceList.Contains(FARMER))
            {
                List<string> ship = new List<string>() { FARMER };
                var passenger = (string)sourceListBox.SelectedItem;
                if (passenger != FARMER)
                {
                    ship.Add(passenger);
                }
                sourceList.RemoveAll(x => ship.Contains(x));
                targetList.AddRange(ship);
                ChangeData();
                
                
            }
                CheckGameState();

        }
        private void StoreData()
        {
            _back.Push(_Left.ToList());
        }

        private void RestbuttonClick(object sender, EventArgs e)
        {
            CreatList();
            ChangeData();
            Gobutton.Enabled = true;
        }

        private void ReStoreButtonClick(object sender, EventArgs e)
        {

            if (_back.Count > 0)
            { 
                var leftItem = _back.Pop();
                var rightItem =_Data.Except(leftItem).ToList();
                _Left = leftItem;
                _Right = rightItem;
            }
            ChangeData();
            CheckGameState() ;

        }
    }
}
