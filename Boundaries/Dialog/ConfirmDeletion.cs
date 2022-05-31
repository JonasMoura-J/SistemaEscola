using System;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class ConfirmDeletion : Form
    {
        public bool Confirmation;

        public ConfirmDeletion(string customText)
        {
            InitializeComponent();
            titleCustom.Text = customText;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            Confirmation = true;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Confirmation = false;
            Close();
        }
    }
}
