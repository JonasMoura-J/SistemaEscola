using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class MostrarTurma : Form
    {
        readonly Home _mainForm;

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

        public MostrarTurma(Home mainForm, int turmaId)
        {
            InitializeComponent();
            _mainForm = mainForm;
            turma.Id = turmaId;
        }

        private void MostrarTurma_Load(object sender, EventArgs e)
        {
            // Set up Fields
            var tempTurma = controladorTurma.FindById(turma.Id);

            nomeLb.Text = tempTurma.Nome;
            codigoLb.Text = tempTurma.Codigo;

            // Set up Alunos
            alunosPanelLengths.Add(disciplinasFlwLayPnl.Width);
            alunosFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            alunosFlwLayPnl.AutoScroll = true;
            alunosFlwLayPnl.WrapContents = false;

            var alunos = controladorAluno.FindAll();

            var alunoTurmas = controladorTurma.FindAllAlunoTurmasByTurma(turma.Id);

            if (alunoTurmas.Any())
            {
                foreach (var aluno in alunos)
                {
                    foreach (var alunoTurma in alunoTurmas)
                    {
                        if (aluno.Id == alunoTurma.AlunoId)
                        {
                            FlowLayoutPanelTools.LoadNamePanel(aluno.Nome, alunosFlwLayPnl,
                                alunosPanels, alunosPanelLengths, true);
                        }
                    }
                }
            }

            // Set up Disciplinas
            disciplinasPanelLengths.Add(disciplinasFlwLayPnl.Width);
            disciplinasFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            disciplinasFlwLayPnl.AutoScroll = true;
            disciplinasFlwLayPnl.WrapContents = false;

            var disciplinas = controladorDisciplina.FindAll();

            var turmaDisciplinas = controladorTurma.FindAllTurmaDisciplinasByTurma(turma.Id);

            if (turmaDisciplinas.Any())
            {
                foreach (var disc in disciplinas)
                {
                    foreach (var turmaDisc in turmaDisciplinas)
                    {
                        if (disc.Id == turmaDisc.DisciplinaId)
                        {
                            FlowLayoutPanelTools.LoadNamePanel(disc.Nome, disciplinasFlwLayPnl,
                                disciplinasPanels, disciplinasPanelLengths, true);
                        }
                    }
                }
            }

            // Set up Professores
            professoresPanelLengths.Add(disciplinasFlwLayPnl.Width);
            professoresFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            professoresFlwLayPnl.AutoScroll = true;
            professoresFlwLayPnl.WrapContents = false;

            var professores = controladorProfessor.FindAll();

            var turmaProfessores = controladorTurma.FindAllTurmaProfessoresByTurma(turma.Id);

            if (turmaProfessores.Any())
            {
                foreach (var prof in professores)
                {
                    foreach (var turmaProf in turmaProfessores)
                    {
                        if (prof.Id == turmaProf.ProfessorId)
                        {
                            FlowLayoutPanelTools.LoadNamePanel(prof.Nome, professoresFlwLayPnl,
                                professoresPanels, professoresPanelLengths, true);
                        }
                    }
                }
            }
        }

        private void concluirBtn_Click(object sender, EventArgs e)
        {
            // Returns to ListarTurmas
            _mainForm.OpenPreviousForm(sender);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new EditarTurma(_mainForm, turma.Id, true), sender);
        }
    }
}
