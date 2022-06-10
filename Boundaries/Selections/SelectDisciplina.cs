using SistemaEscola.Controllers;
using SistemaEscola.Entities.Formularios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class SelectDisciplina : Form
    {
        private readonly Home _mainForm;

        private readonly ControladorDisciplina controladorDisciplina = new ControladorDisciplina();

        List<FormularioDisciplina> disciplinas = new List<FormularioDisciplina>();

        public SelectDisciplina(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void SelectDisciplina_Load(object sender, EventArgs e)
        {
            controladorDisciplina.FindAll().ForEach(d => disciplinas.Add(new FormularioDisciplina()
            {
                Id = d.Id,
                Nome = d.Nome
            }));

            disciplinas.ForEach(d => disciplinaComboBox.Items.Add(d.Nome));
        }

        private void advanceBtn_Click(object sender, EventArgs e)
        {
            if (disciplinaComboBox.SelectedItem != null)
            {
                var selectedDisciplina = disciplinas.Where(d => disciplinaComboBox.SelectedItem.ToString() == d.Nome).First();

                _mainForm.OpenNewForm(new EditarDisciplina(_mainForm, selectedDisciplina), sender);
            }
        }
    }
}
