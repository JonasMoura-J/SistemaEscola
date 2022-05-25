using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class NamePresencaPanel : UserControl
    {
        FlowLayoutPanel _panel;

        public Label lb;

        public NamePresencaPanel(string text, FlowLayoutPanel panel)
        {
            InitializeComponent();
            lb = nameLb;
            nameLb.MouseEnter += NamePresencaPanel_MouseEnter;
            nameLb.MouseLeave += NamePresencaPanel_MouseLeave;
            lb.Text = text;
            _panel = panel;
        }

        private void HighlightPanel()
        {
            BackColor = ColorTranslator.FromHtml("#0484D4");
        }

        private void ResetPanel()
        {
            BackColor = ColorTranslator.FromHtml("#005B96");
        }

        private void NamePresencaPanel_MouseEnter(object sender, EventArgs e)
        {
            HighlightPanel();
        }

        private void NamePresencaPanel_MouseLeave(object sender, EventArgs e)
        {
            ResetPanel();
        }
    }
}
