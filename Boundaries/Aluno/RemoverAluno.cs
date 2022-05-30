using SistemaEscola.Controllers;
using SistemaEscola.Entities.Formularios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class RemoverAluno : Form
    {
        private readonly Home _mainForm;

        ControladorAluno controladorAluno = new ControladorAluno();

        List<FormularioAluno> alunos = new List<FormularioAluno>();

        public RemoverAluno(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void RemoverAluno_Load(object sender, EventArgs e)
        {
            controladorAluno.FindAll().ForEach(a => alunos.Add(new FormularioAluno
            {
                Id = a.Id,
                Nome = a.Nome
            }));

            alunos.ForEach(a => alunoComboBox.Items.Add(a.Nome));
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (alunoComboBox.SelectedItem != null)
            {
                var confirmScreen = new ConfirmDeletion("aluno");
                confirmScreen.ShowDialog();

                if (confirmScreen.Confirmation)
                {
                    controladorAluno.Delete(alunos.Where(a => a.Nome == alunoComboBox.SelectedItem.ToString())
                        .First().Id);

                    _mainForm.OpenNewForm(new MenuAluno(_mainForm), sender, null, true);
                }
            }
        }
    }
}
