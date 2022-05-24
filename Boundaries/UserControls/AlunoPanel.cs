using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class AlunoPanel : UserControl
    {
        FlowLayoutPanel _panel;

        public Label lb;

        public AlunoPanel(string text, FlowLayoutPanel panel)
        {
            InitializeComponent();
            lb = nameLb;
            nameLb.MouseEnter += AlunoPanel_MouseEnter;
            nameLb.MouseLeave += AlunoPanel_MouseLeave;
            deleteBtn.MouseEnter += AlunoPanel_MouseEnter;
            deleteBtn.MouseLeave += AlunoPanel_MouseLeave;
            lb.Text = text;
            _panel = panel; 
        }

        private void AlunoPanel_MouseLeave(object sender, EventArgs e)
        {
            ResetPanel();
        }

        private void AlunoPanel_MouseEnter(object sender, EventArgs e)
        {
            HighlightPanel();
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
    }
}
