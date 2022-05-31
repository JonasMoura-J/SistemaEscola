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
            _mainForm.OpenNewForm(new CadastrarAluno(_mainForm), sender);
        }

        private void listButn_Click(object sender, EventArgs e)
        {
            AlunoTestForm form = new AlunoTestForm();
            form.Show();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new RemoverAluno(_mainForm), sender);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
