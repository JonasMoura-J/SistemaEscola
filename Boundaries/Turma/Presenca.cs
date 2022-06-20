using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class Presenca : Form
    {
        readonly Home _mainForm;

        readonly ControladorTurma controladorTurma = ControladorTurma.Instance;
        readonly ControladorDisciplina controladorDisciplina = ControladorDisciplina.Instance;
        readonly ControladorAluno controladorAluno = ControladorAluno.Instance;

        readonly int _turmaId;
        readonly int _disciplinaId;

        readonly List<FormularioAluno> alunos = new List<FormularioAluno>();

        readonly List<NamePresencaPanel> alunosPanels = new List<NamePresencaPanel>();
        readonly List<int> alunosPanelLengths = new List<int>();

        public Presenca(Home mainForm, int turmaId, int disciplinaId)
        {
            InitializeComponent();

            _mainForm = mainForm;
            _turmaId = turmaId;
            _disciplinaId = disciplinaId;
        }

        private void Presenca_Load(object sender, EventArgs e)
        {
            // Flow Layout Panel Settings
            alunosPanelLengths.Add(alunosFlwLayPnl.Width);
            alunosFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            alunosFlwLayPnl.AutoScroll = true;
            alunosFlwLayPnl.WrapContents = false;

            var alunoTurmas = controladorTurma.FindAllAlunoTurmasByTurma(_turmaId);
            var alunoFaltaDisciplinas = controladorDisciplina.FindAllAlunoFaltaDisciplinasByDisciplina(_disciplinaId);

            var tempAlunos = controladorAluno.FindAll();

            foreach (var aluno in tempAlunos)
            {
                foreach (var at in alunoTurmas)
                {
                    foreach (var afd in alunoFaltaDisciplinas)
                    {
                        if (aluno.Id == at.AlunoId && aluno.Id == afd.AlunoId)
                        {
                            alunos.Add(new FormularioAluno()
                            {
                                Id = aluno.Id,
                                Nome = aluno.Nome
                            });
                        }
                    }
                }
            }

            foreach (var aluno in alunos)
            {
                FlowLayoutPanelTools.LoadNamePresencaPanel(aluno.Nome, alunosFlwLayPnl,
                    alunosPanels, alunosPanelLengths);
            }

            // Datetimepicker Settings (currently not doing anything)
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void concluirBtn_Click(object sender, EventArgs e)
        {
            foreach (NamePresencaPanel panel in alunosPanels)
            {
                var checkedItem = panel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                if (checkedItem == null)
                {
                    return;
                }

                if (checkedItem.Text == "Ausente")
                {
                    controladorAluno.AddFaltas(alunos.Where(a => a.Nome == panel.lb.Text).First().Id,
                        _disciplinaId);
                }
            }

            _mainForm.OpenNewForm(new MenuTurma(_mainForm), sender, null, true);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelTools.ClearRadioBtnSelection(alunosFlwLayPnl);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FlowLayoutPanelTools.ClearRadioBtnSelection(alunosFlwLayPnl);
        }
    }
}
