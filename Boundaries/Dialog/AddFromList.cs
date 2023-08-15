using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class AddFromList : Form
    {
        List<string> _items;
        List<string> _checkedList = new List<string>();

        public AddFromList(List<string> items, List<string> checkedList)
        {
            InitializeComponent();

            _checkedList = checkedList;

            _items = items;
            _items.Sort();
        }

        private void AddFromList_Load(object sender, EventArgs e)
        {
            _items.ForEach(i => checkedListBox.Items.Add(i));

            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (_checkedList.Any(item => item == checkedListBox.Items[i].ToString()))
                {
                    checkedListBox.SetItemCheckState(i, CheckState.Checked);
                } else
                {
                    checkedListBox.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _checkedList.Clear();

            foreach (var item in checkedListBox.CheckedItems)
            {
                _checkedList.Add(item.ToString());
            }

            Close();
        }

        public List<string> ReturnCheckedItems()
        {
            _checkedList.Sort();
            return _checkedList;
        }
    }
}
