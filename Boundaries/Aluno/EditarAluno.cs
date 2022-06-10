using System;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Parsers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class EditarAluno : Form
    {
        readonly Home _mainForm;
        readonly bool _returnPrevious;
        
        readonly ControladorAluno controladorAluno = ControladorAluno.Instance;
        readonly ControladorTurma controladorTurma = ControladorTurma.Instance;
        readonly ControladorDisciplina controladorDisciplina = ControladorDisciplina.Instance;
        
        readonly List<NamePanel> disciplinasPanels = new List<NamePanel>();
        readonly List<int> disciplinasPanelLengths = new List<int>();
        
        readonly List<TextBox> textBoxes = new List<TextBox>();
        readonly List<MaskedTextBox> maskedTextBoxes = new List<MaskedTextBox>();
        readonly List<TextBox> optionalTextBoxes = new List<TextBox>();
        readonly List<MaskedTextBox> optionalMaskedTextBoxes = new List<MaskedTextBox>();

        readonly FormularioAluno aluno;

        readonly List<FormularioTurma> turmas = new List<FormularioTurma>();
        readonly List<FormularioDisciplina> disciplinas = new List<FormularioDisciplina>();

        public List<string> selectedDisciplinas = new List<string>();

        public EditarAluno(Home mainForm, FormularioAluno form, bool returnPrevious = false)
        {
            InitializeComponent();
            _mainForm = mainForm;
            aluno = form;
            _returnPrevious = returnPrevious;
        }

        private void EditarAluno_Load(object sender, EventArgs e)
        {
            // Set up Aluno
            var tempAluno = controladorAluno.FindById(aluno.Id);

            aluno.Cpf = CpfParse.ToDigit(tempAluno.Cpf);
            aluno.Rg = tempAluno.Rg;
            aluno.DataNascimento = tempAluno.DataNascimento;
            aluno.TelefoneResidencial = PhoneNumberParse.ToDigit(tempAluno.TelefoneResidencial);
            aluno.TelefoneCelular = PhoneNumberParse.ToMobileDigit(tempAluno.TelefoneCelular);
            aluno.Email = tempAluno.Email;
            aluno.NomePai = tempAluno.NomePai;
            aluno.NomeMae = tempAluno.NomeMae;
            aluno.NomeResponsavel = tempAluno.NomeResponsavel;
            aluno.Matricula = tempAluno.Matricula;
            aluno.TurmaId = tempAluno.TurmaId;

            // Set up Turmas
            controladorTurma.FindAll().ForEach(t => turmas.Add(new FormularioTurma() 
            {
                Id = t.Id,
                Nome = t.Nome
            }));

            turmas.ForEach(t => turmaComboBox.Items.Add(t.Nome));

            if (aluno.TurmaId != null)
            {
                turmaComboBox.SelectedIndex = turmaComboBox.FindStringExact(turmas
                    .Where(t => t.Id == aluno.TurmaId)
                    .First()
                    .Nome);
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

            var alunoDisciplinas = controladorAluno.FindAllAlunoFaltaDisciplinaByAluno(aluno.Id);

            if (alunoDisciplinas.Any())
            {
                foreach (var disc in disciplinas)
                {
                    foreach (var aluDisc in alunoDisciplinas)
                    {
                        if (disc.Id == aluDisc.DisciplinaId)
                        {
                            selectedDisciplinas.Add(disc.Nome);
                        }
                    }
                } 

                foreach (var disc in selectedDisciplinas)
                {
                    var panel = new NamePanel(disc, disciplinasFlwLayPnl);

                    disciplinasPanels.Add(panel);
                    disciplinasFlwLayPnl.Controls.Add(panel);

                    disciplinasPanelLengths.Add(panel.Width);
                    panel.AutoSize = false;
                    disciplinasPanels.ForEach(p => p.Width = disciplinasPanelLengths.Max());
                }
            }

            // Set up TextBoxes
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    if (c.Name == "paiTxtBox" || c.Name == "maeTxtBox" || c.Name == "respTxtBox")
                    {
                        optionalTextBoxes.Add((TextBox)c);
                    }
                    else
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

            cpfTxtBox.Mask = "000.000.000-00";
            dataNascTxtBox.Mask = "00/00/0000";
            telResTxtBox.Mask = "(00) 0000-0000";
            telCelTxtBox.Mask = "(00) 0 0000-0000";

            // Required
            nomeTxtBox.Text = aluno.Nome;
            cpfTxtBox.Text = aluno.Cpf;
            rgTxtBox.Text = aluno.Rg;
            dataNascTxtBox.Text = aluno.DataNascimento.ToString("dd/MM/yyyy");
            emailTxtBox.Text = aluno.Email.ToLower();
            matriculaTxtBox.Text = aluno.Matricula;

            textBoxes.ForEach(tb => tb.ForeColor = Color.Black);
            maskedTextBoxes.ForEach(mtb => mtb.ForeColor = Color.Black);

            // Optional
            if (aluno.TelefoneResidencial != string.Empty)
            {
                telResTxtBox.Text = aluno.TelefoneResidencial;
                telResTxtBox.ForeColor = Color.Black;
            }

            if (aluno.TelefoneCelular != string.Empty)
            {
                telCelTxtBox.Text = aluno.TelefoneCelular;
                telCelTxtBox.ForeColor = Color.Black;
            }

            if (aluno.NomePai != string.Empty)
            {
                paiTxtBox.Text = aluno.NomePai;
                paiTxtBox.ForeColor = Color.Black;
            }

            if (aluno.NomeMae != string.Empty)
            {
                maeTxtBox.Text = aluno.NomeMae;
                maeTxtBox.ForeColor = Color.Black;
            }

            if (aluno.NomeResponsavel != string.Empty)
            {
                respTxtBox.Text = aluno.NomeResponsavel;
                respTxtBox.ForeColor = Color.Black;
            }
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

        private void concluirBtn_Click(object sender, EventArgs e)
        {
            // Check if any obligatory fields are empty
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
                            }
                            else
                            {
                                dataNascConverted = DateTime.ParseExact(dataNascTxtBox.Text, "dd/MM/yyyy", new CultureInfo("pt-BR"));
                            }

                            // Creates form to be sent to controller
                            var form = new FormularioAluno
                            {
                                Id = aluno.Id,
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
                                Matricula = matriculaTxtBox.Text.ToUpper(),
                                TurmaId = turmas.Where(t =>
                                    t.Nome == turmaComboBox.SelectedItem.ToString()).First().Id,
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
                                    controladorAluno.Update(form);

                                    if (_returnPrevious)
                                    {
                                        // Returns to previous form (always ListarAluno) (since could't fix error)
                                        _mainForm.OpenNewForm(new MenuAluno(_mainForm), sender, null, true);
                                        _mainForm.OpenNewForm(new ListarAlunos(_mainForm), sender, null);
                                    } else
                                    {
                                        // Returns to MenuAluno
                                        _mainForm.OpenNewForm(new MenuAluno(_mainForm), sender, null, true);
                                    }
                                    
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

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var confirmScreen = new ConfirmDeletion("aluno");
            confirmScreen.ShowDialog();

            if (confirmScreen.Confirmation)
            {
                controladorAluno.Delete(aluno.Id);

                if (_returnPrevious)
                {
                    // Returns to previous form (always ListarAluno)
                    _mainForm.OpenNewForm(new MenuAluno(_mainForm), sender, null, true);
                    _mainForm.OpenNewForm(new ListarAlunos(_mainForm), sender, null);
                }
                else
                {
                    // Returns to MenuAluno
                    _mainForm.OpenNewForm(new MenuAluno(_mainForm), sender, null, true);
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

        private void backPanel_Click(object sender, EventArgs e)
        {
            backPanel.Focus();
        }
    }
}
