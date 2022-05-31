using SistemaEscola.Controllers;
using SistemaEscola.Entities.Formularios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class RemoverProfessor : Form
    {
        private readonly Home _mainForm;

        ControladorProfessor controladorProfessor = new ControladorProfessor();

        List<FormularioProfessor> professores = new List<FormularioProfessor>();

        public RemoverProfessor(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }


        private void RemoverProfessor_Load(object sender, EventArgs e)
        {
            controladorProfessor.FindAll().ForEach(p => professores.Add(new FormularioProfessor
            {
                Id = p.Id,
                Nome = p.Nome
            }));

            professores.ForEach(p => professorComboBox.Items.Add(p.Nome));
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (professorComboBox.SelectedItem != null)
            {
                var confirmScreen = new ConfirmDeletion("professor");
                confirmScreen.ShowDialog();

                if (confirmScreen.Confirmation)
                {
                    controladorProfessor.Delete(professores.Where(p => p.Nome == professorComboBox.SelectedItem.ToString())
                        .First().Id);

                    _mainForm.OpenNewForm(new MenuProfessor(_mainForm), sender, null, true);
                }
            }
        }
    }
}
