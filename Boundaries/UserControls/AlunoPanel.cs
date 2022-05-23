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
    public partial class AlunoPanel : UserControl
    {
        public Label lb;

        public AlunoPanel(string text)
        {
            InitializeComponent();
            lb = label1;
            label1.MouseEnter += AlunoPanel_MouseEnter;
            label1.MouseLeave += AlunoPanel_MouseLeave;
            button1.MouseEnter += AlunoPanel_MouseEnter;
            button1.MouseLeave += AlunoPanel_MouseLeave;
            lb.Text = text;
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
            button1.BackColor = BackColor;
        }

        private void ResetPanel()
        {
            BackColor = ColorTranslator.FromHtml("#005B96");
            button1.BackColor = BackColor;
        }
    }
}
