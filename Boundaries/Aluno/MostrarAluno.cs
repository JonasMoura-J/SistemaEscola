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
    public partial class MostrarAluno : Form
    {
        readonly Home _mainForm;

        readonly ControladorAluno controladorAluno = ControladorAluno.Instance;
        readonly ControladorTurma controladorTurma = ControladorTurma.Instance;
        readonly ControladorDisciplina controladorDisciplina = ControladorDisciplina.Instance;

        readonly List<NamePanel> disciplinasPanels = new List<NamePanel>();
        readonly List<int> disciplinasPanelLengths = new List<int>();

        readonly FormularioAluno aluno = new FormularioAluno();

        public MostrarAluno(Home mainForm, int alunoId)
        {
            InitializeComponent();
            _mainForm = mainForm;
            aluno.Id = alunoId;
        }

        private void MostrarAluno_Load(object sender, EventArgs e)
        {
            // Set up fields
            var tempAluno = controladorAluno.FindById(aluno.Id);

            // Obligatory
            nomeLb.Text = tempAluno.Nome;
            cpfLb.Text = CpfParse.ToDigit(tempAluno.Cpf);
            rgLb.Text = tempAluno.Rg;
            dataNascLb.Text = tempAluno.DataNascimento.ToString("dd/MM/yyyy");
            emailLb.Text = tempAluno.Email.ToLower();
            matriculaLb.Text = tempAluno.Matricula;

            // Optional
            if (tempAluno.TelefoneResidencial != string.Empty)
            {
                telResLb.Text = PhoneNumberParse.ToDigit(tempAluno.TelefoneResidencial);
            }
            else
            {
                telResLb.ForeColor = Color.LightSteelBlue;
            }

            if (tempAluno.TelefoneCelular != string.Empty)
            {
                telCelLb.Text = PhoneNumberParse.ToMobileDigit(tempAluno.TelefoneCelular);
            }
            else
            {
                telCelLb.ForeColor = Color.LightSteelBlue;
            }

            if (tempAluno.NomePai != string.Empty)
            {
                paiLb.Text = tempAluno.NomePai;
            }
            else
            {
                paiLb.ForeColor = Color.LightSteelBlue;
            }

            if (tempAluno.NomeMae != string.Empty)
            {
                maeLb.Text = tempAluno.NomeMae;
            }
            else
            {
                maeLb.ForeColor = Color.LightSteelBlue;
            }

            if (tempAluno.NomeResponsavel != string.Empty)
            {
                respLb.Text = tempAluno.NomeResponsavel;
            }
            else
            {
                respLb.ForeColor = Color.LightSteelBlue;
            }

            // Set up Turma
            if (tempAluno.TurmaId != null)
            {
                var turma = controladorTurma.FindById((int)tempAluno.TurmaId);

                turmaLb.Text = turma.Nome;
            }
            else
            {
                turmaLb.ForeColor = Color.LightSteelBlue;
            }

            // Set up Disciplinas
            disciplinasPanelLengths.Add(disciplinasFlwLayPnl.Width);
            disciplinasFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            disciplinasFlwLayPnl.AutoScroll = true;
            disciplinasFlwLayPnl.WrapContents = false;

            var disciplinas = controladorDisciplina.FindAll();

            var alunoDisciplinas = controladorAluno.FindAllAlunoFaltaDisciplinasByAluno(aluno.Id);

            if (alunoDisciplinas.Any())
            {
                foreach (var disc in disciplinas)
                {
                    foreach (var aluDisc in alunoDisciplinas)
                    {
                        if (disc.Id == aluDisc.DisciplinaId)
                        {
                            FlowLayoutPanelTools.LoadNamePanel(disc.Nome, disciplinasFlwLayPnl,
                                disciplinasPanels, disciplinasPanelLengths, true);
                        }
                    }
                }
            }
        }

        private void concluirBtn_Click(object sender, EventArgs e)
        {
            // Returns to ListarAlunos
            _mainForm.OpenPreviousForm(sender);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new EditarAluno(_mainForm, aluno.Id, true), sender);
        }
    }
}
