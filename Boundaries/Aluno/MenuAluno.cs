using System;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class MenuAluno : Form
    {
        private readonly Home _mainForm;        

        public MenuAluno(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenChildForm(new CadastrarAluno(_mainForm), sender);
        }
    }
}
