using System;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class MenuTurma : Form
    {
        readonly Home _mainForm;

        public MenuTurma(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new CadastrarTurma(_mainForm), sender);
        }

        private void presencaBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new SelectTurmaDisciplina(_mainForm), sender);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new RemoverTurma(_mainForm), sender);
        }

        private void listButn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new ListarTurmas(_mainForm), sender);
        }
    }
}
