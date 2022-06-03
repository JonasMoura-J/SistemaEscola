using SistemaEscola.Controllers;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class ListarAlunos : Form
    {
        private readonly Home _mainForm;

        private readonly ControladorAluno controladorAluno = new ControladorAluno();

        List<FormularioAluno> alunos = new List<FormularioAluno>();

        List<NameEditListPanel> alunosPanels = new List<NameEditListPanel>();
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
                FlowLayoutPanelTools.LoadNameEditListPanel(_mainForm, aluno, alunosFlwLayPnl,
                    alunosPanels, alunosPanelLengths);
            }
        }

        private void concluirBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new MenuAluno(_mainForm), sender, null, true);
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
