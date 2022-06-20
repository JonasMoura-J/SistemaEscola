using System;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class EditarTurma : Form
    {
        readonly Home _mainForm;
        readonly bool _returnPrevious;

        readonly ControladorTurma controladorTurma = ControladorTurma.Instance;
        readonly ControladorDisciplina controladorDisciplina = ControladorDisciplina.Instance;
        readonly ControladorProfessor controladorProfessor = ControladorProfessor.Instance;
        readonly ControladorAluno controladorAluno = ControladorAluno.Instance;

        readonly List<NamePanel> alunosPanels = new List<NamePanel>();
        readonly List<int> alunosPanelLengths = new List<int>();
        readonly List<NamePanel> disciplinasPanels = new List<NamePanel>();
        readonly List<int> disciplinasPanelLengths = new List<int>();
        readonly List<NamePanel> professoresPanels = new List<NamePanel>();
        readonly List<int> professoresPanelLengths = new List<int>();

        readonly FormularioTurma turma = new FormularioTurma();

        readonly List<FormularioAluno> alunos = new List<FormularioAluno>();
        readonly List<FormularioDisciplina> disciplinas = new List<FormularioDisciplina>();
        readonly List<FormularioProfessor> professores = new List<FormularioProfessor>();

        readonly List<string> selectedAlunos = new List<string>();
        readonly List<string> selectedDisciplinas = new List<string>();
        readonly List<string> selectedProfessores = new List<string>();

        public EditarTurma(Home mainForm, int turmaId, bool returnPrevious = false)
        {
            InitializeComponent();
            _mainForm = mainForm;
            turma.Id = turmaId;
            _returnPrevious = returnPrevious;
        }

        private void EditarTurma_Load(object sender, EventArgs e)
        {
            // Set up Turma
            var tempTurma = controladorTurma.FindById(turma.Id);

            turma.Nome = tempTurma.Nome;
            turma.Codigo = tempTurma.Codigo;

            // Set up Alunos
            alunosPanelLengths.Add(disciplinasFlwLayPnl.Width);
            alunosFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            alunosFlwLayPnl.AutoScroll = true;
            alunosFlwLayPnl.WrapContents = false;

            controladorAluno.FindAll().ForEach(a => alunos.Add(new FormularioAluno()
            {
                Id = a.Id,
                Nome = a.Nome
            }));

            var alunoTurmas = controladorTurma.FindAllAlunoTurmasByTurma(turma.Id);

            if (alunoTurmas.Any())
            {
                foreach (var aluno in alunos)
                {
                    foreach (var alunoTurma in alunoTurmas)
                    {
                        if (aluno.Id == alunoTurma.AlunoId)
                        {
                            selectedAlunos.Add(aluno.Nome);
                        }
                    }
                }

                foreach (var aluno in selectedAlunos)
                {
                    FlowLayoutPanelTools.LoadNamePanel(aluno, alunosFlwLayPnl,
                        alunosPanels, alunosPanelLengths);
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

            var turmaDisciplinas = controladorTurma.FindAllTurmaDisciplinasByTurma(turma.Id);

            if (turmaDisciplinas.Any())
            {
                foreach (var disc in disciplinas)
                {
                    foreach (var turmaDisc in turmaDisciplinas)
                    {
                        if (disc.Id == turmaDisc.DisciplinaId)
                        {
                            selectedDisciplinas.Add(disc.Nome);
                        }
                    }
                }

                foreach (var disc in selectedDisciplinas)
                {
                    FlowLayoutPanelTools.LoadNamePanel(disc, disciplinasFlwLayPnl,
                        disciplinasPanels, disciplinasPanelLengths);
                }
            }

            // Set up Professores
            professoresPanelLengths.Add(disciplinasFlwLayPnl.Width);
            professoresFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            professoresFlwLayPnl.AutoScroll = true;
            professoresFlwLayPnl.WrapContents = false;

            controladorProfessor.FindAll().ForEach(p => professores.Add(new FormularioProfessor()
            {
                Id = p.Id,
                Nome = p.Nome
            }));

            var turmaProfessores = controladorTurma.FindAllTurmaProfessoresByTurma(turma.Id);

            if (turmaProfessores.Any())
            {
                foreach (var prof in professores)
                {
                    foreach (var turmaProf in turmaProfessores)
                    {
                        if (prof.Id == turmaProf.ProfessorId)
                        {
                            selectedProfessores.Add(prof.Nome);
                        }
                    }
                }

                foreach (var prof in selectedProfessores)
                {
                    FlowLayoutPanelTools.LoadNamePanel(prof, professoresFlwLayPnl,
                        professoresPanels, professoresPanelLengths);
                }
            }

            // Text box
            nomeTxtBox.Text = turma.Nome;
            nomeTxtBox.ForeColor = Color.Black;

            codigoTxtBox.Text = turma.Codigo;
            codigoTxtBox.ForeColor = Color.Black;
        }

        private void concluirBtn_Click(object sender, EventArgs e)
        {
            // Check if any obligatory fields are empty
            if (nomeTxtBox.ForeColor != Color.LightSteelBlue
                && codigoTxtBox.ForeColor != Color.LightSteelBlue)
            {
                // Creates form to be sent to controller
                var form = new FormularioTurma
                {
                    Id = turma.Id,
                    Nome = nomeTxtBox.Text.ToUpper(),
                    Codigo = codigoTxtBox.Text.ToUpper(),
                    FormularioAlunos = alunos.Where(a =>
                        selectedAlunos.Any(sa => sa == a.Nome)).ToList(),
                    FormularioDisciplinas = disciplinas.Where(d =>
                        selectedDisciplinas.Any(sd => sd == d.Nome)).ToList(),
                    FormularioProfessores = professores.Where(p =>
                        selectedProfessores.Any(sp => sp == p.Nome)).ToList(),
                    QuantidadeAlunos = selectedAlunos.Count
                };

                // Validates form
                ValidationContext validContext = new ValidationContext(form, null, null);
                List<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(form, validContext, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Erro de edição", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    try
                    {
                        // Sends validated form to the controller
                        controladorTurma.Update(form);

                        if (_returnPrevious)
                        {
                            // Returns to MostrarTurma
                            _mainForm.OpenPreviousForm(sender);
                            _mainForm.OpenPreviousForm(sender);
                            _mainForm.OpenNewForm(new MostrarTurma(_mainForm, turma.Id), sender);
                        }
                        else
                        {
                            // Returns to ListarTurmas
                            _mainForm.OpenNewForm(new MenuTurma(_mainForm), sender, null, true);
                            _mainForm.OpenNewForm(new ListarTurmas(_mainForm), sender);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Erro de edição", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nome e Código obrigatórios.",
                    "Erro de edição", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addAlunoBtn_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelTools.InsertItems(alunosFlwLayPnl, alunosPanels, alunosPanelLengths,
                alunos.Select(a => a.Nome).ToList(), selectedAlunos);
        }

        private void addDisciplinaBtn_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelTools.InsertItems(disciplinasFlwLayPnl, disciplinasPanels, disciplinasPanelLengths,
                disciplinas.Select(d => d.Nome).ToList(), selectedDisciplinas);
        }

        private void addProfessorBtn_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelTools.InsertItems(professoresFlwLayPnl, professoresPanels, professoresPanelLengths,
                professores.Select(p => p.Nome).ToList(), selectedProfessores);
        }

        private void alunosFlwLayPnl_ControlRemoved(object sender, ControlEventArgs e)
        {
            FlowLayoutPanelTools.UpdateList(alunosFlwLayPnl, selectedAlunos);
        }

        private void disciplinasFlwLayPnl_ControlRemoved(object sender, ControlEventArgs e)
        {
            FlowLayoutPanelTools.UpdateList(disciplinasFlwLayPnl, selectedDisciplinas);
        }

        private void professoresFlwLayPnl_ControlRemoved(object sender, ControlEventArgs e)
        {
            FlowLayoutPanelTools.UpdateList(professoresFlwLayPnl, selectedProfessores);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var confirmScreen = new ConfirmDeletion("turma");
            confirmScreen.ShowDialog();

            if (confirmScreen.Confirmation)
            {
                controladorTurma.Delete(turma.Id);

                // Returns to ListarTurmas
                _mainForm.OpenNewForm(new MenuTurma(_mainForm), sender, null, true);
                _mainForm.OpenNewForm(new ListarTurmas(_mainForm), sender, null);
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
            TextBoxTools.Clear(nomeTxtBox, "Código");
        }

        private void codigoTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(nomeTxtBox, "Código");
        }

        private void backPanel_Click(object sender, EventArgs e)
        {
            backPanel.Focus();
        }
    }
}
