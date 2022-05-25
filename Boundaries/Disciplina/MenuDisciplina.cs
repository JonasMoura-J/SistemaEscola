using System;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class MenuDisciplina : Form
    {
        private readonly Home _mainForm;

        public MenuDisciplina(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenChildForm(new CadastrarDisciplina(_mainForm), sender);
        }
    }
}
