using System;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class MenuDisciplina : Form
    {
        readonly Home _mainForm;

        public MenuDisciplina(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new CadastrarDisciplina(_mainForm), sender);
        }

        private void listButn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new ListarDisciplinas(_mainForm), sender);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new RemoverDisciplina(_mainForm), sender);
        }
    }
}
