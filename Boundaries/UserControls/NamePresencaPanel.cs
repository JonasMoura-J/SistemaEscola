using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class NamePresencaPanel : UserControl
    {
        public Label lb;

        public NamePresencaPanel(string text)
        {
            InitializeComponent();
            lb = nameLb;
            nameLb.MouseEnter += NamePresencaPanel_MouseEnter;
            nameLb.MouseLeave += NamePresencaPanel_MouseLeave;
            lb.Text = text;
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

        public void ClearSelection()
        {
            presenteRBtn.Checked = false;
            ausenteRBtn.Checked = false;
            justificadoRBtn.Checked = false;
        }
    }
}
