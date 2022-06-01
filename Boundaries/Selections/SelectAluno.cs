using SistemaEscola.Controllers;
using SistemaEscola.Entities.Formularios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class SelectAluno : Form
    {
        private readonly Home _mainForm;

        private readonly ControladorAluno controladorAluno = new ControladorAluno();

        List<FormularioAluno> alunos = new List<FormularioAluno>();

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

                _mainForm.OpenNewForm(new EditarAluno(_mainForm, selectedAluno), sender);
            }
        }
    }
}
