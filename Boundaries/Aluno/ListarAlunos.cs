using SistemaEscola.Controllers;
using SistemaEscola.Entities.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class ListarAlunos : Form
    {
        private readonly Home _mainForm;

        private readonly ControladorAluno controladorAluno = new ControladorAluno();

        List<FormularioAluno> alunos = new List<FormularioAluno>();

        List<NameEditPanel> alunosPanels = new List<NameEditPanel>();
        List<int> alunosPanelLengths = new List<int>();

        public ListarAlunos(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void ListarAlunos_Load(object sender, EventArgs e)
        {
            // Flow Layout Panel Settings
            alunosPanelLengths.Add(alunosFlwLayPnl.Width);
            alunosFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            alunosFlwLayPnl.AutoScroll = true;
            alunosFlwLayPnl.WrapContents = false;

            controladorAluno.FindAll().ForEach(a => alunos.Add(new FormularioAluno()
            { 
                Id = a.Id,
                Nome = a.Nome
            }));

            foreach (var aluno in alunos)
            {
                var panel = new NameEditPanel(_mainForm, aluno, alunosFlwLayPnl);

                alunosPanels.Add(panel);
                alunosFlwLayPnl.Controls.Add(panel);

                alunosPanelLengths.Add(panel.Width);
                panel.AutoSize = false;
                alunosPanels.ForEach(p => p.Width = alunosPanelLengths.Max());
            }
        }

        private void concluirBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new MenuAluno(_mainForm), sender, null, true);
        }
    }
}
