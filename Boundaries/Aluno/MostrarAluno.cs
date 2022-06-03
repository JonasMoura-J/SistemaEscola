using SistemaEscola.Controllers;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Parsers;
using SistemaEscola.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class MostrarAluno : Form
    {
        private readonly Home _mainForm;
        bool _returnPrevious;

        ControladorAluno controladorAluno = new ControladorAluno();
        ControladorTurma controladorTurma = new ControladorTurma();
        ControladorDisciplina controladorDisciplina = new ControladorDisciplina();

        List<NamePanel> disciplinasPanels = new List<NamePanel>();
        List<int> disciplinasPanelLengths = new List<int>();

        FormularioAluno aluno;

        public MostrarAluno(Home mainForm, FormularioAluno form, bool returnPrevious = false)
        {
            InitializeComponent();
            _mainForm = mainForm;
            aluno = form;
            _returnPrevious = returnPrevious;
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
            } else
            {
                telResLb.ForeColor = Color.LightSteelBlue;
            }

            if (tempAluno.TelefoneCelular != string.Empty)
            {
                telCelLb.Text = PhoneNumberParse.ToMobileDigit(tempAluno.TelefoneCelular);
            } else
            {
                telCelLb.ForeColor = Color.LightSteelBlue;
            }

            if (tempAluno.NomePai != string.Empty)
            {
                paiLb.Text = tempAluno.NomePai;
            } else
            {
                paiLb.ForeColor = Color.LightSteelBlue;
            }

            if (tempAluno.NomeMae != string.Empty)
            {
                maeLb.Text = tempAluno.NomeMae;
            } else
            {
                maeLb.ForeColor = Color.LightSteelBlue;
            }

            if (tempAluno.NomeResponsavel != string.Empty)
            {
                respLb.Text = tempAluno.NomeResponsavel;
            } else
            {
                respLb.ForeColor = Color.LightSteelBlue;
            }

            // Set up Turma
            if (tempAluno.TurmaId != null)
            {
                var turma = controladorTurma.FindById((int)tempAluno.TurmaId);

                turmaLb.Text = turma.Nome;
            } else
            {
                turmaLb.ForeColor = Color.LightSteelBlue;
            }

            // Set up Disciplinas
            disciplinasPanelLengths.Add(disciplinasFlwLayPnl.Width);
            disciplinasFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            disciplinasFlwLayPnl.AutoScroll = true;
            disciplinasFlwLayPnl.WrapContents = false;

            var disciplinas = controladorDisciplina.FindAll();

            var alunoDisciplinas = controladorAluno.FindAllAlunoFaltaDisciplinaByAluno(aluno.Id);

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
            if (_returnPrevious)
            {
                // Returns to previous form
                _mainForm.OpenPreviousForm(sender);
            }
            else
            {
                // Returns to MenuAluno
                _mainForm.OpenNewForm(new MenuAluno(_mainForm), sender, null, true);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new EditarAluno(_mainForm, aluno, true), sender);
        }
    }
}
