using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace SistemaEscola
{
    public partial class CadastrarProfessor : Form
    {
        private readonly Home _mainForm;

        ControladorProfessor controladorProfessor = new ControladorProfessor();
        ControladorDisciplina controladorDisciplina = new ControladorDisciplina();

        List<TextBox> textBoxes = new List<TextBox>();
        List<MaskedTextBox> maskedTextBoxes = new List<MaskedTextBox>();
        List<MaskedTextBox> optionalMaskedTextBoxes = new List<MaskedTextBox>();

        List<NamePanel> disciplinasPanels = new List<NamePanel>();
        List<int> disciplinasPanelLengths = new List<int>();

        List<string> nomeDisciplinas = new List<string>();

        public List<string> selectedDisciplinas = new List<string>();

        public CadastrarProfessor(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        // Provisoriamente
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

            // Temporary
            controladorProfessor.FindAll().ForEach(p => comboBox1.Items.Add(p.Nome));

            // Flow Layout Panel Settings
            disciplinasPanelLengths.Add(disciplinasFlwLayPnl.Width);
            disciplinasFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            disciplinasFlwLayPnl.AutoScroll = true;
            disciplinasFlwLayPnl.WrapContents = false;

            // Busca disciplinas no DB
            controladorDisciplina.FindAll().ForEach(a => nomeDisciplinas.Add(a.Nome));
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
                            Id = controladorProfessor.FindAll().Count() + 1,
                            Nome = nomeTxtBox.Text.ToUpper(),
                            Cpf = cpfTxtBox.Text,
                            Rg = rgTxtBox.Text.ToUpper(),
                            DataNascimento = dataNascConverted,
                            TelefoneResidencial = telResTxtBox.Text,
                            TelefoneCelular = telCelTxtBox.Text,
                            Email = emailTxtBox.Text.ToUpper(),
                            Disciplinas = selectedDisciplinas
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
                                _mainForm.OpenNewForm(new MenuProfessor(_mainForm), sender, null, true);

                            }
                            catch (Exception error)
                            {
                                ResetPlaceHolders();
                                MessageBox.Show(error.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
        }

        private void addDisciplinaBtn_Click(object sender, EventArgs e)
        {
            ControlFlowLayoutPanel(disciplinasFlwLayPnl, disciplinasPanels, disciplinasPanelLengths,
                nomeDisciplinas, selectedDisciplinas);
        }

        private void ControlFlowLayoutPanel(FlowLayoutPanel flwLayPnl, List<NamePanel> panels,
            List<int> lengths, List<string> items, List<string> selectedItems)
        {
            // Reset selectedItems list to match FlowLayout
            selectedItems.Clear();

            foreach (NamePanel control in flwLayPnl.Controls)
            {
                selectedItems.Add(control.lb.Text);
            }

            // Open dialog
            AddFromList form = new AddFromList(items, selectedItems);
            form.ShowDialog();

            // Receive updated list
            selectedItems = form.ReturnCheckedItems();

            // Reset FlowLayout based on updated list
            flwLayPnl.Controls.Clear();

            foreach (string disc in selectedItems)
            {
                var panel = new NamePanel(disc, flwLayPnl);

                panels.Add(panel);
                flwLayPnl.Controls.Add(panel);

                lengths.Add(panel.Width);
                panel.AutoSize = false;
                panels.ForEach(p => p.Width = lengths.Max());
            }
        }

        private void disciplinasFlwLayPnl_ControlRemoved(object sender, ControlEventArgs e)
        {
            // Reset selectedItems list to match FlowLayout
            selectedDisciplinas.Clear();

            foreach (NamePanel control in disciplinasFlwLayPnl.Controls)
            {
                selectedDisciplinas.Add(control.lb.Text);
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
