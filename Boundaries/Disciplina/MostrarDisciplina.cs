using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class MostrarDisciplina : Form
    {
        readonly Home _mainForm;
        readonly bool _returnPrevious;

        readonly ControladorDisciplina controladorDisciplina = ControladorDisciplina.Instance;
        readonly ControladorProfessor controladorProfessor = ControladorProfessor.Instance;
        readonly ControladorTurma controladorTurma = ControladorTurma.Instance;

        readonly List<NamePanel> professoresPanels = new List<NamePanel>();
        readonly List<int> professoresPanelLengths = new List<int>();
        readonly List<NamePanel> turmasPanels = new List<NamePanel>();
        readonly List<int> turmasPanelLengths = new List<int>();

        readonly FormularioDisciplina disciplina;

        public MostrarDisciplina(Home mainForm, FormularioDisciplina form, bool returnPrevious = false)
        {
            InitializeComponent();
            _mainForm = mainForm;
            disciplina = form;
            _returnPrevious = returnPrevious;
        }

        private void MostrarDisciplina_Load(object sender, EventArgs e)
        {
            // Set up Fields
            var tempDisciplina = controladorDisciplina.FindById(disciplina.Id);

            nomeLb.Text = tempDisciplina.Nome;


            // Set up Professores
            professoresPanelLengths.Add(professoresFlwLayPnl.Width);
            professoresFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            professoresFlwLayPnl.AutoScroll = true;
            professoresFlwLayPnl.WrapContents = false;

            var professores = controladorProfessor.FindAll();

            var professorDisciplinas = controladorDisciplina
                .FindAllProfessorDisciplinaByDisciplina(disciplina.Id);

            if (professorDisciplinas.Any())
            {
                foreach (var prof in professores)
                {
                    foreach (var profDisc in professorDisciplinas)
                    {
                        if (prof.Id == profDisc.ProfessorId)
                        {
                            FlowLayoutPanelTools.LoadNamePanel(prof.Nome, professoresFlwLayPnl,
                                professoresPanels, professoresPanelLengths, true);
                        }
                    }
                }
            }

            // Set up Turmas
            turmasPanelLengths.Add(turmasFlwLayPnl.Width);
            turmasFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            turmasFlwLayPnl.AutoScroll = true;
            turmasFlwLayPnl.WrapContents = false;

            var turmas = controladorTurma.FindAll();

            var turmaDisciplinas = controladorDisciplina
                .FindAllTurmaDisciplinaByDisciplina(disciplina.Id);

            if (turmaDisciplinas.Any())
            {
                foreach (var turma in turmas)
                {
                    foreach (var turmaDisc in turmaDisciplinas)
                    {
                        if (turma.Id == turmaDisc.TurmaId)
                        {
                            FlowLayoutPanelTools.LoadNamePanel(turma.Nome, turmasFlwLayPnl,
                                turmasPanels, turmasPanelLengths, true);
                        }
                    }
                }
            }
        }

        private void concluirBtn_Click(object sender, EventArgs e)
        {
            if (_returnPrevious)
            {
                // Returns to previous form
                _mainForm.OpenPreviousForm(sender);
            }
            else
            {
                // Returns to MenuDisciplina
                _mainForm.OpenNewForm(new MenuDisciplina(_mainForm), sender, null, true);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new EditarDisciplina(_mainForm, disciplina, true), sender);
        }
    }
}
