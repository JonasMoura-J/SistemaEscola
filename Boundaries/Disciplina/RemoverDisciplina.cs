using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;

namespace SistemaEscola
{
    public partial class RemoverDisciplina : Form
    {
        readonly Home _mainForm;

        readonly ControladorDisciplina controladorDisciplina = new ControladorDisciplina();

        readonly List<FormularioDisciplina> disciplinas = new List<FormularioDisciplina>();

        public RemoverDisciplina(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void RemoverDisciplina_Load(object sender, EventArgs e)
        {
            controladorDisciplina.FindAll().ForEach(d => disciplinas.Add(new FormularioDisciplina
            {
                Id = d.Id,
                Nome = d.Nome
            }));

            disciplinas.ForEach(d => disciplinaComboBox.Items.Add(d.Nome));
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (disciplinaComboBox.SelectedItem != null)
            {
                var confirmScreen = new ConfirmDeletion("disciplina");
                confirmScreen.ShowDialog();

                if (confirmScreen.Confirmation)
                {
                    controladorDisciplina.Delete(disciplinas.Where(d => d.Nome == disciplinaComboBox.SelectedItem.ToString())
                        .First().Id);

                    _mainForm.OpenNewForm(new MenuDisciplina(_mainForm), sender, null, true);
                }
            }
        }
    }
}
