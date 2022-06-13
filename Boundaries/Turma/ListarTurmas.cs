using System;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class ListarTurmas : Form
    {
        readonly Home _mainForm;

        readonly ControladorTurma controladorTurma = ControladorTurma.Instance;

        readonly List<FormularioTurma> turmas = new List<FormularioTurma>();

        readonly List<NameEditListPanel> turmasPanels = new List<NameEditListPanel>();
        readonly List<int> turmasPanelLengths = new List<int>();

        public ListarTurmas(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void ListarTurmas_Load(object sender, EventArgs e)
        {
            // Flow Layout Panel Settings
            turmasPanelLengths.Add(turmasFlwLayPnl.Width);
            turmasFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            turmasFlwLayPnl.AutoScroll = true;
            turmasFlwLayPnl.WrapContents = false;

            controladorTurma.FindAll().ForEach(t => turmas.Add(new FormularioTurma()
            {
                Id = t.Id,
                Nome = t.Nome
            }));

            foreach (var turma in turmas)
            {
                FlowLayoutPanelTools.LoadNameEditListPanel(_mainForm, turma, turmasFlwLayPnl,
                    turmasPanels, turmasPanelLengths);
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
                TextBoxTools.FilterPanelList(searchTxtBox, turmasFlwLayPnl, _mainForm,
                turmas, turmasPanels, turmasPanelLengths);
            }
        }
    }
}
