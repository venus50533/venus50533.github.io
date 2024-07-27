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

namespace Farmer_crossing_the_river02
{
    public partial class Form2 : Form
    {
        public List<string> _Left;
        public List<string> _Right;
        public List<string> _Data;
        public const string FARMER ="農夫";
        public const string WOLF = "大灰狼";
        public const string SHEEP = "小綿羊";
        public const string VEGETABLE = "大白菜";

        public Form2()
        {
            InitializeComponent();
            CreatList();
            ChangeData();
            SetlistBox();
        }

        public void CreatList()
        {
            _Left = new List<string>() { FARMER,WOLF,SHEEP,VEGETABLE };
            _Right = new List<string>();
            _Data = new List<string>() { FARMER, WOLF, SHEEP, VEGETABLE };

        }
        public void ChangeData()
        {
            Left_listBox.DataSource = null;
            Right_listBox.DataSource = null;
            Left_listBox.DataSource = _Left;
            Right_listBox.DataSource = _Right;
        }
        public void SetlistBox()
        {
            Left_listBox.SelectionMode = SelectionMode.One;
            Right_listBox.SelectionMode = SelectionMode.One;

        }

        private bool Iswin() 
        {

            if (_Left.Count == 0 && _Right.Count == 4 && _Right.All(x=>_Data.Contains(x)))
            {
                return true;
            }
            return false;
        }
        private bool IsLose(List<string> source)
        {
            if (source.Contains(FARMER)) { return false; }
            if (source.Contains(SHEEP) && source.Contains(VEGETABLE)) { return true; }
            else if (source.Contains(WOLF) && source.Contains(SHEEP)) { return true; }
            else { return false; }
        }
        private void CheckGameState() 
        {
            if (Iswin())
            { 
                MessageBox.Show("遊戲勝利!!");
                GoButton.Enabled = false;

            }
            else if (IsLose(_Right)||IsLose(_Left))
            { 
                MessageBox.Show("遊戲失敗!!");
                GoButton.Enabled = false;

            }
        }

        private void GoButtonClick(object sender, EventArgs e)
        {
            ListBox sourceListBox;
            List<string> sourceList;
            List<string> targetList;
            if (_Left.Contains(FARMER))
            {
                sourceListBox = Left_listBox;
                sourceList = _Left;
                targetList = _Right;
            }
            else 
            { 
                sourceListBox = Right_listBox;
                sourceList = _Right;
                targetList = _Left;
            }
            if (sourceListBox.SelectedItem != null && sourceList.Contains(FARMER))
            {
                List<string> ship = new List<string>() 
                {
                    FARMER
                };
                var passenger = (string)sourceListBox.SelectedItem;
                if(passenger != FARMER )
                {
                    ship.Add(passenger);
                }
                sourceList.RemoveAll(x=>ship.Contains(x));
                targetList.AddRange(ship);

            }


            CheckGameState();
            ChangeData();
        }



        private void ResetButtonClick_1(object sender, EventArgs e)
        {
            CreatList();
            ChangeData();
            GoButton.Enabled = true;
        }
    }
}
