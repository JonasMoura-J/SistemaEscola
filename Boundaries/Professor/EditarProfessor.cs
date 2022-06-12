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
using SistemaEscola.Parsers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class EditarProfessor : Form
    {
        readonly Home _mainForm;
        readonly bool _returnPrevious;

        readonly ControladorProfessor controladorProfessor = ControladorProfessor.Instance;
        readonly ControladorDisciplina controladorDisciplina = ControladorDisciplina.Instance;
        readonly ControladorTurma controladorTurma = ControladorTurma.Instance;

        readonly List<NamePanel> disciplinasPanels = new List<NamePanel>();
        readonly List<int> disciplinasPanelLengths = new List<int>();
        readonly List<NamePanel> turmasPanels = new List<NamePanel>();
        readonly List<int> turmasPanelLengths = new List<int>();

        readonly List<TextBox> textBoxes = new List<TextBox>();
        readonly List<MaskedTextBox> maskedTextBoxes = new List<MaskedTextBox>();
        readonly List<MaskedTextBox> optionalMaskedTextBoxes = new List<MaskedTextBox>();

        readonly FormularioProfessor professor =  new FormularioProfessor();

        readonly List<FormularioDisciplina> disciplinas = new List<FormularioDisciplina>();
        readonly List<FormularioTurma> turmas = new List<FormularioTurma>();

        readonly List<string> selectedDisciplinas = new List<string>();
        readonly List<string> selectedTurmas = new List<string>();

        public EditarProfessor(Home mainForm, int professorId, bool returnPrevious = false)
        {
            InitializeComponent();
            _mainForm = mainForm;
            professor.Id = professorId;
            _returnPrevious = returnPrevious;
        }

        private void EditarProfessor_Load(object sender, EventArgs e)
        {
            // Set up Professor
            var tempProfessor = controladorProfessor.FindById(professor.Id);

            professor.Nome = tempProfessor.Nome;
            professor.Cpf = CpfParse.ToDigit(tempProfessor.Cpf);
            professor.Rg = tempProfessor.Rg;
            professor.DataNascimento = tempProfessor.DataNascimento;
            professor.TelefoneResidencial = PhoneNumberParse.ToDigit(tempProfessor.TelefoneResidencial);
            professor.TelefoneCelular = PhoneNumberParse.ToMobileDigit(tempProfessor.TelefoneCelular);
            professor.Email = tempProfessor.Email;

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

            var professorDisciplinas = controladorProfessor.FindAllProfessorDisciplinasByProfessor(professor.Id);

            if (professorDisciplinas.Any())
            {
                foreach (var disc in disciplinas)
                {
                    foreach (var profDisc in professorDisciplinas)
                    {
                        if (disc.Id == profDisc.DisciplinaId)
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

            // Set up Turmas
            turmasPanelLengths.Add(turmasFlwLayPnl.Width);
            turmasFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            turmasFlwLayPnl.AutoScroll = true;
            turmasFlwLayPnl.WrapContents = false;

            controladorTurma.FindAll().ForEach(t => turmas.Add(new FormularioTurma()
            {
                Id = t.Id,
                Nome = t.Nome
            }));

            var turmaProfessores = controladorProfessor.FindAllTurmaProfessoresByProfessor(professor.Id);

            if (turmaProfessores.Any())
            {
                foreach (var turma in turmas)
                {
                    foreach (var turmaProf in turmaProfessores)
                    {
                        if (turma.Id == turmaProf.TurmaId)
                        {
                            selectedTurmas.Add(turma.Nome);
                        }
                    }
                }

                foreach (var turma in selectedTurmas)
                {
                    var panel = new NamePanel(turma, turmasFlwLayPnl);

                    turmasPanels.Add(panel);
                    turmasFlwLayPnl.Controls.Add(panel);

                    turmasPanelLengths.Add(panel.Width);
                    panel.AutoSize = false;
                    turmasPanels.ForEach(p => p.Width = turmasPanelLengths.Max());
                }

            }

            // Set up TextBoxes
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

            cpfTxtBox.Mask = "000.000.000-00";
            dataNascTxtBox.Mask = "00/00/0000";            

            // Required
            nomeTxtBox.Text = professor.Nome;
            cpfTxtBox.Text = professor.Cpf;
            rgTxtBox.Text = professor.Rg;
            dataNascTxtBox.Text = professor.DataNascimento.ToString("dd/MM/yyyy");
            emailTxtBox.Text = professor.Email.ToLower();

            textBoxes.ForEach(tb => tb.ForeColor = Color.Black);
            maskedTextBoxes.ForEach(mtb => mtb.ForeColor = Color.Black);

            // Optional
            if (professor.TelefoneResidencial != string.Empty)
            {
                telResTxtBox.Mask = "(00) 0000-0000";
                telResTxtBox.Text = professor.TelefoneResidencial;
                telResTxtBox.ForeColor = Color.Black;
            }

            if (professor.TelefoneCelular != string.Empty)
            {
                telCelTxtBox.Mask = "(00) 0 0000-0000";
                telCelTxtBox.Text = professor.TelefoneCelular;
                telCelTxtBox.ForeColor = Color.Black;
            }
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
                            Id = professor.Id,
                            Nome = nomeTxtBox.Text.ToUpper(),
                            Cpf = cpfTxtBox.Text,
                            Rg = rgTxtBox.Text.ToUpper(),
                            DataNascimento = dataNascConverted,
                            TelefoneResidencial = telResTxtBox.Text,
                            TelefoneCelular = telCelTxtBox.Text,
                            Email = emailTxtBox.Text.ToUpper(),
                            FormularioDisciplinas = disciplinas.Where(d =>
                                selectedDisciplinas.Any(sd => sd == d.Nome)).ToList(),
                            FormularioTurmas = turmas.Where(t =>
                                selectedTurmas.Any(st => st == t.Nome)).ToList()
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
                                controladorProfessor.Update(form);

                                if (_returnPrevious)
                                {
                                    // Returns to MostrarProfessor
                                    _mainForm.OpenPreviousForm(sender);
                                    _mainForm.OpenPreviousForm(sender);
                                    _mainForm.OpenNewForm(new MostrarProfessor(_mainForm, professor.Id), sender, null);
                                } else
                                {
                                    // Returns to ListarProfessores
                                    _mainForm.OpenNewForm(new MenuProfessor(_mainForm), sender, null, true);
                                    _mainForm.OpenNewForm(new ListarProfessores(_mainForm), sender, null);
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

        private void addDisciplinaBtn_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelTools.InsertItems(disciplinasFlwLayPnl, disciplinasPanels, disciplinasPanelLengths,
                disciplinas.Select(d => d.Nome).ToList(), selectedDisciplinas);
        }

        private void addTurmaBtn_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelTools.InsertItems(turmasFlwLayPnl, turmasPanels, turmasPanelLengths,
                turmas.Select(t => t.Nome).ToList(), selectedTurmas);
        }

        private void disciplinasFlwLayPnl_ControlRemoved(object sender, ControlEventArgs e)
        {
            FlowLayoutPanelTools.UpdateList(disciplinasFlwLayPnl, selectedDisciplinas);
        }

        private void turmasFlwLayPnl_ControlRemoved(object sender, ControlEventArgs e)
        {
            FlowLayoutPanelTools.UpdateList(turmasFlwLayPnl, selectedTurmas);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var confirmScreen = new ConfirmDeletion("professor");
            confirmScreen.ShowDialog();

            if (confirmScreen.Confirmation)
            {
                controladorProfessor.Delete(professor.Id);

                // Returns to ListarProfessores
                _mainForm.OpenNewForm(new MenuProfessor(_mainForm), sender, null, true);
                _mainForm.OpenNewForm(new ListarProfessores(_mainForm), sender, null);
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

        private void backPanel_Click(object sender, EventArgs e)
        {
            backPanel.Focus();
        }
    }
}
