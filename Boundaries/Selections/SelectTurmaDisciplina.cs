using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;

namespace SistemaEscola
{
    public partial class SelectTurmaDisciplina : Form
    {
        readonly Home _mainForm;

        readonly ControladorTurma controladorTurma = new ControladorTurma();
        readonly ControladorDisciplina controladorDisciplina = new ControladorDisciplina();

        readonly List<FormularioTurma> turmas = new List<FormularioTurma>();
        readonly List<FormularioDisciplina> disciplinas = new List<FormularioDisciplina>();

        public SelectTurmaDisciplina(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void SelectTurmaDisciplina_Load(object sender, EventArgs e)
        {
            controladorTurma.FindAll().ForEach(t => turmas.Add(new FormularioTurma() 
            {
                Id = t.Id,
                Nome = t.Nome
            }));

            controladorDisciplina.FindAll().ForEach(d => disciplinas.Add(new FormularioDisciplina() 
            {
                Id = d.Id,
                Nome = d.Nome
            }));

            turmas.ForEach(t => turmaComboBox.Items.Add(t.Nome));
            disciplinas.ForEach(d => disciplinaComboBox.Items.Add(d.Nome));
        }

        private void advanceBtn_Click(object sender, EventArgs e)
        {
            if (turmaComboBox.SelectedItem != null && disciplinaComboBox.SelectedItem != null)
            {
                _mainForm.OpenNewForm(new Presenca(_mainForm, 
                    turmas.Where(t => t.Nome == turmaComboBox.SelectedItem.ToString()).First().Id,
                    disciplinas.Where(d => d.Nome == disciplinaComboBox.SelectedItem.ToString()).First().Id), sender);
            }
        }
    }
}
