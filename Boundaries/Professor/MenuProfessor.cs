using System;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class MenuProfessor : Form
    {
        private readonly Home _mainForm;

        public MenuProfessor(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new CadastrarProfessor(_mainForm), sender);
        }
    }
}
