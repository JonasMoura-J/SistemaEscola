using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SistemaEscola.Controllers;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class CadastrarTurma : Form
    {
        private readonly Home _mainForm;
        
        ControladorTurma controladorTurma = new ControladorTurma();
        ControladorAluno controladorAluno = new ControladorAluno();
        
        List<AlunoPanel> panels = new List<AlunoPanel>();
        List<int> panelLengths = new List<int>();

        List<TextBox> textBoxes = new List<TextBox>();

        List<string> nomeAlunos = new List<string>();
        
        public List<string> selectedAlunos = new List<string>();

        public CadastrarTurma(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void CadastrarTurma_Load(object sender, EventArgs e)
        {
            // Temporario
            controladorTurma.FindAll().ForEach(t => comboBox1.Items.Add(t.Nome));

            // Set up textboxes            
            foreach (var c in Controls)
            {
                if (c is TextBox)
                {
                    textBoxes.Add((TextBox)c);
                }               
            }

            // Flow Layout Panel Settings
            panelLengths.Add(alunosFlwLayPnl.Width);
            alunosFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            alunosFlwLayPnl.AutoScroll = true;
            alunosFlwLayPnl.WrapContents = false;

            // Busca alunos no DB
            controladorAluno.FindAll().ForEach(a => nomeAlunos.Add(a.Nome));
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!textBoxes.Any(t => t.ForeColor == Color.LightSteelBlue))
            {
                var form = new FormularioTurma
                {
                    Id = controladorTurma.FindAll().Count() + 1,
                    Nome = nomeTxtBox.Text.ToUpper(),
                    Codigo = codigoTxtBox.Text.ToUpper(),
                    Alunos = selectedAlunos,
                    QuantidadeAlunos = selectedAlunos.Count
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
                        controladorTurma.Add(form);

                        // Returns to MenuDisciplina
                        _mainForm.OpenChildForm(new MenuTurma(_mainForm), sender);

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void addAlunoBtn_Click(object sender, EventArgs e)
        {
            // Reset selectedAlunos list to match FlowLayout
            selectedAlunos.Clear();

            foreach (AlunoPanel control in alunosFlwLayPnl.Controls)
            {
                selectedAlunos.Add(control.lb.Text);
            }

            // Open dialog
            AddFromList form = new AddFromList(nomeAlunos, selectedAlunos);
            form.ShowDialog();

            // Receive updated list
            selectedAlunos = form.ReturnCheckedItems();

            // Reset FlowLayout based on updated list
            alunosFlwLayPnl.Controls.Clear();

            foreach (string aluno in selectedAlunos)
            {
                var panel = new AlunoPanel(aluno, alunosFlwLayPnl);

                panels.Add(panel);
                alunosFlwLayPnl.Controls.Add(panel);

                panelLengths.Add(panel.Width);
                panel.AutoSize = false;
                panels.ForEach(p => p.Width = panelLengths.Max());
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

        private void codigoTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(codigoTxtBox, "Código");
        }

        private void codigoTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(codigoTxtBox, "Código");
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            panel2.Focus();
        }

        private void alunosLb_Click(object sender, EventArgs e)
        {
            alunosLb.Focus();
        }
    }
}
