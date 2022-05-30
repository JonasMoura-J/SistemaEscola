using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class CadastrarAluno : Form
    {
        private readonly Home _mainForm;

        ControladorAluno controladorAluno = new ControladorAluno();

        List<TextBox> textBoxes = new List<TextBox>();
        List<MaskedTextBox> maskedTextBoxes = new List<MaskedTextBox>();
        List<TextBox> optionalTextBoxes = new List<TextBox>();
        List<MaskedTextBox> optionalMaskedTextBoxes = new List<MaskedTextBox>();

        public CadastrarAluno(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void CadastrarAluno_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    if (c.Name == "paiTxtBox" || c.Name == "maeTxtBox" || c.Name == "respTxtBox")
                    {
                        optionalTextBoxes.Add((TextBox)c);
                    } else
                    {
                        textBoxes.Add((TextBox)c);
                    }
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

            // Provisoriamente
            controladorAluno.FindAll().ForEach(a => comboBox1.Items.Add(a.Nome));
        }

        private void ResetPlaceHolders()
        {
            var emptyMaskedTextBoxes = optionalMaskedTextBoxes.Where(t => t.Text == string.Empty);
            var emptyTextBoxes = optionalTextBoxes.Where(t => t.Text == string.Empty);

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

            foreach (var tb in emptyTextBoxes)
            {
                if (tb.Name == "paiTxtBox")
                {
                    TextBoxTools.Fill(paiTxtBox, "Nome do Pai");
                }
                else if (tb.Name == "maeTxtBox")
                {
                    TextBoxTools.Fill(maeTxtBox, "Nome da Mãe");
                }
                else
                {
                    TextBoxTools.Fill(respTxtBox, "Nome do Responsável");
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
                        if (optionalTextBoxes.Any(t => t.ForeColor == Color.Black))
                        {
                            // Removes placeholder from optional fields
                            optionalMaskedTextBoxes.Where(t => t.ForeColor == Color.LightSteelBlue).
                                ToList().ForEach(t => t.Text = string.Empty);

                            optionalTextBoxes.Where(t => t.ForeColor == Color.LightSteelBlue).
                                ToList().ForEach(t => t.Text = string.Empty);

                            // Converts date to correct format (for dealing with errors)
                            DateTime dateResult;
                            DateTime dataNascConverted;

                            if (!DateTime.TryParseExact(dataNascTxtBox.Text, "dd/MM/yyyy", new CultureInfo("pt-BR"),
                                DateTimeStyles.None, out dateResult))
                            {
                                dataNascConverted = DateTime.MinValue;
                            } else
                            {
                                dataNascConverted = DateTime.ParseExact(dataNascTxtBox.Text, "dd/MM/yyyy", new CultureInfo("pt-BR"));
                            }

                            // Creates form to be sent to controller
                            var form = new FormularioAluno
                            {
                                Nome = nomeTxtBox.Text.ToUpper(),
                                Cpf = cpfTxtBox.Text,
                                Rg = rgTxtBox.Text.ToUpper(),
                                DataNascimento = dataNascConverted,
                                TelefoneResidencial = telResTxtBox.Text,
                                TelefoneCelular = telCelTxtBox.Text,
                                Email = emailTxtBox.Text.ToUpper(),
                                NomePai = paiTxtBox.Text.ToUpper(),
                                NomeMae = maeTxtBox.Text.ToUpper(),
                                NomeResponsavel = respTxtBox.Text.ToUpper(),
                                Matricula = matriculaTxtBox.Text.ToUpper()
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
                            } else {
                                try
                                {
                                    // Sends validated form to the controller
                                    controladorAluno.Add(form);

                                    // Returns to MenuAluno
                                    _mainForm.OpenNewForm(new MenuAluno(_mainForm), sender, null, true);
                                
                                } catch (Exception error)
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
            //TextBoxTools.ClearMask(rgTxtBox, "RG", "00.000.000-0");
            TextBoxTools.Clear(rgTxtBox, "RG");
        }

        private void rgTxtBox_Leave(object sender, EventArgs e)
        {
            //TextBoxTools.FillMask(rgTxtBox, "RG", "  .   .   -");
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

        private void paiTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(paiTxtBox, "Nome do Pai");
        }

        private void paiTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(paiTxtBox, "Nome do Pai");
        }

        private void maeTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(maeTxtBox, "Nome da Mãe");
        }

        private void maeTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(maeTxtBox, "Nome da Mãe");
        }

        private void respTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(respTxtBox, "Nome do Responsável");
        }

        private void respTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(respTxtBox, "Nome do Responsável");
        }

        private void matriculaTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(matriculaTxtBox, "Matrícula");
        }

        private void matriculaTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(matriculaTxtBox, "Matrícula");
        }

        private void cadAluBackPanel_Click(object sender, EventArgs e)
        {
            cadAluBackPanel.Focus();
        }
    }
}
