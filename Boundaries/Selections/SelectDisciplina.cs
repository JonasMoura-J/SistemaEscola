using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;

namespace SistemaEscola
{
    public partial class SelectDisciplina : Form
    {
        readonly Home _mainForm;

        readonly ControladorDisciplina controladorDisciplina = ControladorDisciplina.Instance;

        readonly List<FormularioDisciplina> disciplinas = new List<FormularioDisciplina>();

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

                //_mainForm.OpenNewForm(new EditarDisciplina(_mainForm, selectedDisciplina), sender);
            }
        }
    }
}
