using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Utils
{
    public static class FlowLayoutPanelTools
    {
        private static bool _resetSelectedList = true;

        public static void InsertItems(FlowLayoutPanel flwLayPnl, List<NamePanel> panels,
            List<int> lengths, List<string> items, List<string> selectedItems)
        {
            // Reset selectedItems list to match FlowLayout
            UpdateList(flwLayPnl, selectedItems);

            // Open dialog
            AddFromList form = new AddFromList(items, selectedItems);
            form.ShowDialog();

            // Receive updated list
            selectedItems = form.ReturnCheckedItems();

            // Reset FlowLayout based on updated list
            _resetSelectedList = false; // For avoiding conflic with UpdateList()

            flwLayPnl.Controls.Clear();

            foreach (string item in selectedItems)
            {
                var panel = new NamePanel(item, flwLayPnl);

                panels.Add(panel);
                flwLayPnl.Controls.Add(panel);

                lengths.Add(panel.Width);
                panel.AutoSize = false;
                panels.ForEach(p => p.Width = lengths.Max());
            }

            _resetSelectedList = true;
        }

        public static void UpdateList(FlowLayoutPanel flwLayPnl, List<string> selectedItems)
        {
            if (_resetSelectedList)
            {
                // Reset selectedItems list to match FlowLayout
                selectedItems.Clear();

                foreach (NamePanel control in flwLayPnl.Controls)
                {
                    selectedItems.Add(control.lb.Text);
                }
            }
        }

        public static void LoadNameEditListPanel(Home mainForm, IFormulario form, FlowLayoutPanel flwLayPnl,
            List<NameEditListPanel> panels, List<int> lengths)
        {
            var newPanel = new NameEditListPanel(mainForm, form);

            panels.Add(newPanel);
            flwLayPnl.Controls.Add(newPanel);

            lengths.Add(newPanel.Width);
            newPanel.AutoSize = false;
            panels.ForEach(p => p.Width = lengths.Max());
        }
        public static void LoadNamePanel(string name, FlowLayoutPanel flwLayPnl,
            List<NamePanel> panels, List<int> lengths, bool readOnly = false)
        {
            var newPanel = new NamePanel(name, flwLayPnl, readOnly);

            panels.Add(newPanel);
            flwLayPnl.Controls.Add(newPanel);

            lengths.Add(newPanel.Width);
            newPanel.AutoSize = false;
            panels.ForEach(p => p.Width = lengths.Max());
        }

        public static void ResetNamePanels(FlowLayoutPanel flwLayPnl, List<NameEditListPanel> panels,
            List<int> lengths)
        {
            flwLayPnl.Controls.Clear();
            panels.Clear();
            lengths.Clear();
            lengths.Add(flwLayPnl.Width);
        }
    }
}
