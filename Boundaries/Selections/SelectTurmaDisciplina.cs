using SistemaEscola.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class SelectTurmaDisciplina : Form
    {
        private readonly Home _mainForm;

        private readonly ControladorTurma controladorTurma = new ControladorTurma();
        private readonly ControladorDisciplina controladorDisciplina = new ControladorDisciplina();

        public SelectTurmaDisciplina(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void SelectTurmaDisciplina_Load(object sender, EventArgs e)
        {
            List<string> turmas = new List<string>();
            List<string> disciplinas = new List<string>();

            controladorTurma.FindAll().ForEach(t => turmas.Add(t.Nome));
            controladorDisciplina.FindAll().ForEach(d => disciplinas.Add(d.Nome));

            turmas.Sort();
            disciplinas.Sort();

            turmas.ForEach(t => turmaComboBox.Items.Add(t));
            disciplinas.ForEach(d => disciplinaComboBox.Items.Add(d));
        }

        private void advanceBtn_Click(object sender, EventArgs e)
        {
            if (turmaComboBox.SelectedItem != null && disciplinaComboBox.SelectedItem != null)
            {
                _mainForm.OpenNewForm(new Presenca(_mainForm, turmaComboBox.SelectedItem.ToString(),
                    disciplinaComboBox.SelectedItem.ToString()), sender);
            }
        }
    }
}
