using SistemaEscola.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola
{
    // FIX LATER (WORKS WITH LIST, BUT NOT DB)

    public partial class Presenca : Form
    {
        private readonly Home _mainForm;

        private readonly ControladorTurma controladorTurma = new ControladorTurma();
        private readonly ControladorDisciplina controladorDisciplina = new ControladorDisciplina();
        private readonly ControladorAluno controladorAluno = ControladorAluno.Instance;

        string _nomeTurma;
        string _nomeDisciplina;

        List<string> alunos = new List<string>();

        List<NamePresencaPanel> alunosPanels = new List<NamePresencaPanel>();
        List<int> alunosPanelLengths = new List<int>();

        public Presenca(Home mainForm, string nomeTurma, string nomeDisciplina)
        {
            InitializeComponent();

            _mainForm = mainForm;

            _nomeTurma = nomeTurma;
            _nomeDisciplina = nomeDisciplina;
        }

        private void Presenca_Load(object sender, EventArgs e)
        {
            // Flow Layout Panel Settings
            alunosPanelLengths.Add(alunosFlwLayPnl.Width);
            alunosFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            alunosFlwLayPnl.AutoScroll = true;
            alunosFlwLayPnl.WrapContents = false;

            var turma = controladorTurma.FindByName(_nomeTurma);

            //turma.Alunos.ForEach(a => alunos.Add(a.Nome));

            foreach (string aluno in alunos)
            {
                var panel = new NamePresencaPanel(aluno, alunosFlwLayPnl);

                alunosPanels.Add(panel);
                alunosFlwLayPnl.Controls.Add(panel);

                alunosPanelLengths.Add(panel.Width);
                panel.AutoSize = false;
                alunosPanels.ForEach(p => p.Width = alunosPanelLengths.Max());
            }

            //Datetimepicker Settings
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void concluirBtn_Click(object sender, EventArgs e)
        {
            List<string> absentStudans = new List<string>();
            var disciplina = controladorDisciplina.FindByName(_nomeDisciplina);

            foreach (NamePresencaPanel panel in alunosPanels)
            {
                var checkedItem = panel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                if (checkedItem.Text == "Ausente")
                {
                    controladorAluno.AddFaltas(panel.lb.Text, disciplina);
                }
            }

            _mainForm.OpenNewForm(new MenuTurma(_mainForm), sender, null, true);
        }
    }
}
