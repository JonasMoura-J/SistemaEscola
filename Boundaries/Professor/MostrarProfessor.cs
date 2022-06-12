using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Parsers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class MostrarProfessor : Form
    {
        readonly Home _mainForm;

        readonly ControladorProfessor controladorProfessor = ControladorProfessor.Instance;
        readonly ControladorDisciplina controladorDisciplina = ControladorDisciplina.Instance;
        readonly ControladorTurma controladorTurma = ControladorTurma.Instance;

        readonly List<NamePanel> disciplinasPanels = new List<NamePanel>();
        readonly List<int> disciplinasPanelLengths = new List<int>();
        readonly List<NamePanel> turmasPanels = new List<NamePanel>();
        readonly List<int> turmasPanelLengths = new List<int>();

        readonly FormularioProfessor professor = new FormularioProfessor();

        public MostrarProfessor(Home mainForm, int professorId)
        {
            InitializeComponent();
            _mainForm = mainForm;
            professor.Id = professorId;
        }

        private void MostrarProfessor_Load(object sender, EventArgs e)
        {
            // Set up Fields
            var tempProfessor = controladorProfessor.FindById(professor.Id);

            // Required
            nomeLb.Text = tempProfessor.Nome;
            cpfLb.Text = CpfParse.ToDigit(tempProfessor.Cpf);
            rgLb.Text = tempProfessor.Rg;
            dataNascLb.Text = tempProfessor.DataNascimento.ToString("dd/MM/yyyy");
            emailLb.Text = tempProfessor.Email.ToLower();

            // Optional
            if (tempProfessor.TelefoneResidencial != string.Empty)
            {
                telResLb.Text = PhoneNumberParse.ToDigit(tempProfessor.TelefoneResidencial);
            }
            else
            {
                telResLb.ForeColor = Color.LightSteelBlue;
            }

            if (tempProfessor.TelefoneCelular != string.Empty)
            {
                telCelLb.Text = PhoneNumberParse.ToMobileDigit(tempProfessor.TelefoneCelular);
            }
            else
            {
                telCelLb.ForeColor = Color.LightSteelBlue;
            }

            // Set up Disciplinas
            disciplinasPanelLengths.Add(disciplinasFlwLayPnl.Width);
            disciplinasFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            disciplinasFlwLayPnl.AutoScroll = true;
            disciplinasFlwLayPnl.WrapContents = false;

            var disciplinas = controladorDisciplina.FindAll();

            var professorDisciplinas = controladorProfessor.FindAllProfessorDisciplinasByProfessor(professor.Id);

            if (professorDisciplinas.Any())
            {
                foreach (var disc in disciplinas)
                {
                    foreach (var profDisc in professorDisciplinas)
                    {
                        if (disc.Id == profDisc.DisciplinaId)
                        {
                            FlowLayoutPanelTools.LoadNamePanel(disc.Nome, disciplinasFlwLayPnl,
                                disciplinasPanels, disciplinasPanelLengths, true);
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

            var turmaProfessores = controladorProfessor.FindAllTurmaProfessoresByProfessor(professor.Id);

            if (turmaProfessores.Any())
            {
                foreach (var turma in turmas)
                {
                    foreach (var turmaProf in turmaProfessores)
                    {
                        if (turma.Id == turmaProf.TurmaId)
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
            // Returns to ListarProfessores
            _mainForm.OpenPreviousForm(sender);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new EditarProfessor(_mainForm, professor.Id, true), sender);
        }
    }
}
