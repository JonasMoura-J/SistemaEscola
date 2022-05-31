using SistemaEscola.Controllers;
using SistemaEscola.Entities.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Parsers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class EditarAluno : Form
    {
        Home _mainForm;

        ControladorAluno controladorAluno = new ControladorAluno();
        ControladorTurma controladorTurma = new ControladorTurma();
        ControladorDisciplina controladorDisciplina = new ControladorDisciplina();

        List<NamePanel> disciplinasPanels = new List<NamePanel>();
        List<int> disciplinasPanelLengths = new List<int>();

        List<TextBox> textBoxes = new List<TextBox>();
        List<MaskedTextBox> maskedTextBoxes = new List<MaskedTextBox>();
        List<TextBox> optionalTextBoxes = new List<TextBox>();
        List<MaskedTextBox> optionalMaskedTextBoxes = new List<MaskedTextBox>();

        FormularioAluno aluno;
        
        List<FormularioTurma> turmas = new List<FormularioTurma>();
        List<FormularioDisciplina> disciplinas = new List<FormularioDisciplina>();

        public List<FormularioDisciplina> selectedDisciplinas = new List<FormularioDisciplina>();
        public List<string> nameSelectedDisciplinas = new List<string>();

        public EditarAluno(Home mainForm, FormularioAluno form)
        {
            InitializeComponent();
            _mainForm = mainForm;
            aluno = form;
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

            if (alunoDisciplinas.Count > 0)
            {
                foreach (var disc in disciplinas)
                {
                    foreach (var aluDisc in alunoDisciplinas)
                    {
                        if (disc.Id == aluDisc.DisciplinaId)
                        {
                            selectedDisciplinas.Add(disc);
                            nameSelectedDisciplinas.Add(disc.Nome);
                        }
                    }
                } 

                foreach (var disc in selectedDisciplinas)
                {
                    var panel = new NamePanel(disc.Nome, disciplinasFlwLayPnl);

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

        }

        private void addDisciplinaBtn_Click(object sender, EventArgs e)
        {
            ControlFlowLayoutPanel(disciplinasFlwLayPnl, disciplinasPanels, disciplinasPanelLengths,
                disciplinas.Select(d => d.Nome).ToList(), nameSelectedDisciplinas);
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

            foreach (string item in selectedItems)
            {
                var panel = new NamePanel(item, flwLayPnl);

                panels.Add(panel);
                flwLayPnl.Controls.Add(panel);

                lengths.Add(panel.Width);
                panel.AutoSize = false;
                panels.ForEach(p => p.Width = lengths.Max());
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
