using System;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class CadastrarProfessor : Form
    {
        readonly Home _mainForm;

        readonly ControladorProfessor controladorProfessor = new ControladorProfessor();
        readonly ControladorDisciplina controladorDisciplina = new ControladorDisciplina();

        readonly List<TextBox> textBoxes = new List<TextBox>();
        readonly List<MaskedTextBox> maskedTextBoxes = new List<MaskedTextBox>();
        readonly List<MaskedTextBox> optionalMaskedTextBoxes = new List<MaskedTextBox>();

        readonly List<NamePanel> disciplinasPanels = new List<NamePanel>();
        readonly List<int> disciplinasPanelLengths = new List<int>();

        readonly List<FormularioDisciplina> disciplinas = new List<FormularioDisciplina>();

        readonly List<string> selectedDisciplinas = new List<string>();

        public CadastrarProfessor(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void CadastrarProfessor_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    textBoxes.Add((TextBox)c);
                }

                if (c is MaskedTextBox)
                {
                    if (c.Name == "telResTxtBox" || c.Name == "telCelTxtBox")
                    {
                        optionalMaskedTextBoxes.Add((MaskedTextBox)c);
                    }
                    else
                    {
                        maskedTextBoxes.Add((MaskedTextBox)c);
                    }
                }
            }

            // Set up Disciplinas
            disciplinasPanelLengths.Add(disciplinasFlwLayPnl.Width);
            disciplinasFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            disciplinasFlwLayPnl.AutoScroll = true;
            disciplinasFlwLayPnl.WrapContents = false;

            controladorDisciplina.FindAll().ForEach(d => disciplinas.Add(new FormularioDisciplina()
            {
                Id = d.Id,
                Nome = d.Nome
            }));
        }

        private void ResetPlaceHolders()
        {
            var emptyMaskedTextBoxes = optionalMaskedTextBoxes.Where(t => t.Text == string.Empty);

            foreach (var mtb in emptyMaskedTextBoxes)
            {
                if (mtb.Name == "telResTxtBox")
                {
                    TextBoxTools.Fill(telResTxtBox, "Telefone Residencial", "(00) 0000-0000");
                }
                else
                {
                    TextBoxTools.Fill(telCelTxtBox, "Telefone Celular", "(00) 0 0000-0000");
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Check is any obligatory fields are empty
            if (!maskedTextBoxes.Any(t => t.ForeColor == Color.LightSteelBlue))
            {
                if (!textBoxes.Any(t => t.ForeColor == Color.LightSteelBlue))
                {
                    // Check if at least 1 optional field is filled
                    if (optionalMaskedTextBoxes.Any(t => t.ForeColor == Color.Black))
                    {
                        // Removes placeholder from optional fields
                        optionalMaskedTextBoxes.Where(t => t.ForeColor == Color.LightSteelBlue).
                            ToList().ForEach(t => t.Text = string.Empty);

                        // Converts date to correct format (for dealing with errors)
                        DateTime dateResult;
                        DateTime dataNascConverted;

                        if (!DateTime.TryParseExact(dataNascTxtBox.Text, "dd/MM/yyyy", new CultureInfo("pt-BR"),
                            DateTimeStyles.None, out dateResult))
                        {
                            dataNascConverted = DateTime.MinValue;
                        }
                        else
                        {
                            dataNascConverted = DateTime.ParseExact(dataNascTxtBox.Text, "dd/MM/yyyy", new CultureInfo("pt-BR"));
                        }

                        // Creates form to be sent to controller
                        var form = new FormularioProfessor
                        {
                            Nome = nomeTxtBox.Text.ToUpper(),
                            Cpf = cpfTxtBox.Text,
                            Rg = rgTxtBox.Text.ToUpper(),
                            DataNascimento = dataNascConverted,
                            TelefoneResidencial = telResTxtBox.Text,
                            TelefoneCelular = telCelTxtBox.Text,
                            Email = emailTxtBox.Text.ToUpper(),
                            FormularioDisciplinas = disciplinas.Where(d =>
                                selectedDisciplinas.Any(sd => sd == d.Nome)).ToList()
                        };

                        // Validates form
                        ValidationContext validContext = new ValidationContext(form, null, null);
                        List<ValidationResult> errors = new List<ValidationResult>();

                        if (!Validator.TryValidateObject(form, validContext, errors, true))
                        {
                            foreach (ValidationResult result in errors)
                            {
                                // Returns placeholders to their text boxes
                                ResetPlaceHolders();

                                MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
                        {
                            try
                            {
                                // Sends validated form to the controller
                                controladorProfessor.Add(form);

                                // Returns to MenuAluno
                                _mainForm.OpenPreviousForm(sender);

                            }
                            catch (Exception error)
                            {
                                ResetPlaceHolders();
                                MessageBox.Show(error.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                //throw error.InnerException;
                            }
                        }
                    }
                }
            }
        }

        private void addDisciplinaBtn_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelTools.InsertItems(disciplinasFlwLayPnl, disciplinasPanels, disciplinasPanelLengths,
                disciplinas.Select(d => d.Nome).ToList(), selectedDisciplinas);
        }

        private void disciplinasFlwLayPnl_ControlRemoved(object sender, ControlEventArgs e)
        {
            FlowLayoutPanelTools.UpdateList(disciplinasFlwLayPnl, selectedDisciplinas);
        }

        private void nomeTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(nomeTxtBox, "Nome");
        }

        private void nomeTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(nomeTxtBox, "Nome");
        }

        private void cpfTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(cpfTxtBox, "CPF", "000.000.000-00");
        }

        private void cpfTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(cpfTxtBox, "CPF", "   .   .   -");
        }

        private void rgTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(rgTxtBox, "RG");
        }

        private void rgTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(rgTxtBox, "RG");
        }

        private void dataNascTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(dataNascTxtBox, "Data de Nascimento", "00/00/0000");
        }

        private void dataNascTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(dataNascTxtBox, "Data de Nascimento", "  /  /");
        }

        private void telResTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(telResTxtBox, "Telefone Residencial", "(00) 0000-0000");
        }

        private void telResTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(telResTxtBox, "Telefone Residencial", "(  )     -");
        }

        private void telCelTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(telCelTxtBox, "Telefone Celular", "(00) 0 0000-0000");
        }

        private void telCelTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(telCelTxtBox, "Telefone Celular", "(  )       -");
        }

        private void emailTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(emailTxtBox, "E-mail");
        }

        private void emailTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(emailTxtBox, "E-mail");
        }

        private void disciplinasLb_Click(object sender, EventArgs e)
        {
            disciplinasLb.Focus();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            panel5.Focus();
        }
    }
}
