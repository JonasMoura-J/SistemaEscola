using System;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class ListarAlunos : Form
    {
        readonly Home _mainForm;

        readonly ControladorAluno controladorAluno = ControladorAluno.Instance;

        readonly List<FormularioAluno> alunos = new List<FormularioAluno>();

        readonly List<NameEditListPanel> alunosPanels = new List<NameEditListPanel>();
        readonly List<int> alunosPanelLengths = new List<int>();

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
                FlowLayoutPanelTools.LoadNameEditListPanel(_mainForm, aluno, alunosFlwLayPnl,
                    alunosPanels, alunosPanelLengths);
            }
        }

        private void concluirBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenPreviousForm(sender);
        }

        private void searchTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(searchTxtBox, "Buscar");
        }

        private void searchTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(searchTxtBox, "Buscar");
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTxtBox.Text != "Buscar")
            {
                TextBoxTools.FilterPanelList(searchTxtBox, alunosFlwLayPnl, _mainForm,
                alunos, alunosPanels, alunosPanelLengths);
            }
        }
    }
}
