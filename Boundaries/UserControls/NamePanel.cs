using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class NamePanel : UserControl
    {
        readonly FlowLayoutPanel _panel;

        public Label lb;

        public NamePanel(string text, FlowLayoutPanel panel, bool readOnly = false)
        {
            InitializeComponent();
            lb = nameLb;
            nameLb.MouseEnter += NamePanel_MouseEnter;
            nameLb.MouseLeave += NamePanel_MouseLeave;
            deleteBtn.MouseEnter += NamePanel_MouseEnter;
            deleteBtn.MouseLeave += NamePanel_MouseLeave;
            lb.Text = text;
            _panel = panel;
            
            if (readOnly)
            {
                deleteBtn.Visible = false;
            }
        }

        private void HighlightPanel()
        {
            BackColor = ColorTranslator.FromHtml("#0484D4");
            deleteBtn.BackColor = BackColor;
        }

        private void ResetPanel()
        {
            BackColor = ColorTranslator.FromHtml("#005B96");
            deleteBtn.BackColor = BackColor;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            _panel.Controls.Remove(this);
        }

        private void NamePanel_MouseEnter(object sender, EventArgs e)
        {
            HighlightPanel();
        }

        private void NamePanel_MouseLeave(object sender, EventArgs e)
        {
            ResetPanel();
        }
    }
}
