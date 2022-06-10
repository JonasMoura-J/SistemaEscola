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
        ControladorAluno controladorAluno = ControladorAluno.Instance;
        ControladorDisciplina controladorDisciplina = new ControladorDisciplina();
        
        List<NamePanel> alunosPanels = new List<NamePanel>();
        List<int> alunosPanelLengths = new List<int>();
        List<NamePanel> disciplinasPanels = new List<NamePanel>();
        List<int> disciplinasPanelLengths = new List<int>();

        List<TextBox> textBoxes = new List<TextBox>();

        List<string> nomeAlunos = new List<string>();
        List<string> nomeDisciplinas = new List<string>();
        
        public List<string> selectedAlunos = new List<string>();
        public List<string> selectedDisciplinas = new List<string>();

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
            alunosPanelLengths.Add(alunosFlwLayPnl.Width);
            alunosFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            alunosFlwLayPnl.AutoScroll = true;
            alunosFlwLayPnl.WrapContents = false;

            disciplinasPanelLengths.Add(disciplinasFlwLayPnl.Width);
            disciplinasFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            disciplinasFlwLayPnl.AutoScroll = true;
            disciplinasFlwLayPnl.WrapContents = false;

            // Busca alunos no DB
            controladorAluno.FindAll().ForEach(a => nomeAlunos.Add(a.Nome));

            // Busca disciplinas no DB
            controladorDisciplina.FindAll().ForEach(a => nomeDisciplinas.Add(a.Nome));
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
                    Disciplinas = selectedDisciplinas,
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
                        _mainForm.OpenNewForm(new MenuTurma(_mainForm), sender, null, true);

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        throw error.InnerException;
                    }
                }
            }
        }

        private void addAlunoBtn_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelTools.InsertItems(alunosFlwLayPnl, alunosPanels, alunosPanelLengths,
                nomeAlunos, selectedAlunos);
        }

        private void addDisciplinaBtn_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelTools.InsertItems(disciplinasFlwLayPnl, disciplinasPanels, disciplinasPanelLengths,
                nomeDisciplinas, selectedDisciplinas);
        }

        private void disciplinasFlwLayPnl_ControlRemoved(object sender, ControlEventArgs e)
        {
            FlowLayoutPanelTools.UpdateList(disciplinasFlwLayPnl, selectedDisciplinas);
        }

        private void alunosFlwLayPnl_ControlRemoved(object sender, ControlEventArgs e)
        {
            FlowLayoutPanelTools.UpdateList(alunosFlwLayPnl, selectedAlunos);
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

        private void disciplinasLb_Click(object sender, EventArgs e)
        {
            disciplinasLb.Focus();
        }
    }
}
