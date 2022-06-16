using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;

namespace SistemaEscola
{
    public partial class SelectAluno : Form
    {
        readonly Home _mainForm;

        readonly ControladorAluno controladorAluno = ControladorAluno.Instance;

        readonly List<FormularioAluno> alunos = new List<FormularioAluno>();

        public SelectAluno(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void SelectAluno_Load(object sender, EventArgs e)
        {
            controladorAluno.FindAll().ForEach(a => alunos.Add(new FormularioAluno()
            {
                Id = a.Id,
                Nome = a.Nome
            }));

            alunos.ForEach(a => alunoComboBox.Items.Add(a.Nome));
        }

        private void advanceBtn_Click(object sender, EventArgs e)
        {
            if (alunoComboBox.SelectedItem != null)
            {
                var selectedAluno = alunos.Where(a => alunoComboBox.SelectedItem.ToString() == a.Nome).First();

                //_mainForm.OpenNewForm(new EditarAluno(_mainForm, selectedAluno), sender);
            }
        }
    }
}
