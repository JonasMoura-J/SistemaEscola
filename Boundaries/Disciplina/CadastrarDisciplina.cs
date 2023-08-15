using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class CadastrarDisciplina : Form
    {
        private readonly Home _mainForm;

        ControladorDisciplina controladorDisciplina = new ControladorDisciplina();

        public CadastrarDisciplina(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        // Provisoriamente
        private void CadastrarDisciplina_Load(object sender, EventArgs e)
        {
            controladorDisciplina.FindAll().ForEach(d => comboBox1.Items.Add(d.Nome));
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nomeTxtBox.ForeColor == Color.Black)
            {
                var form = new FormularioDisciplina
                {
                    Id = controladorDisciplina.FindAll().Count() + 1,
                    Nome = nomeTxtBox.Text.ToUpper()
                };

                // Validates form
                ValidationContext validContext = new ValidationContext(form, null, null);
                List<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(form, validContext, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    try
                    {
                        // Sends validated form to the controller
                        controladorDisciplina.Add(form);
                        
                        // Returns to MenuDisciplina
                        _mainForm.OpenNewForm(new MenuDisciplina(_mainForm), sender);
                    
                    } catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }  
                }
            }                    
        }

        private void nomeTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(nomeTxtBox, "Nome");
        }

        private void nomeTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(nomeTxtBox, "Nome");
        }

        private void cadDisBackPanel_Click(object sender, EventArgs e)
        {
            cadDisBackPanel.Focus();
        }
    }
}
