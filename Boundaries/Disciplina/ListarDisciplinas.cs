using System;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class ListarDisciplinas : Form
    {
        readonly Home _mainForm;

        readonly ControladorDisciplina controladorDisciplina = new ControladorDisciplina();

        readonly List<FormularioDisciplina> disciplinas = new List<FormularioDisciplina>();

        readonly List<NameEditListPanel> disciplinasPanels = new List<NameEditListPanel>();
        readonly List<int> disciplinasPanelLengths = new List<int>();

        public ListarDisciplinas(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void ListarDisciplinas_Load(object sender, EventArgs e)
        {
            // Flow Layout Panel Settings
            disciplinasPanelLengths.Add(disciplinasFlwLayPnl.Width);
            disciplinasFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            disciplinasFlwLayPnl.AutoScroll = true;
            disciplinasFlwLayPnl.WrapContents = false;

            controladorDisciplina.FindAll().ForEach(d => disciplinas.Add(new FormularioDisciplina()
            {
                Id = d.Id,
                Nome = d.Nome
            }));

            foreach (var disc in disciplinas)
            {
                FlowLayoutPanelTools.LoadNameEditListPanel(_mainForm, disc, disciplinasFlwLayPnl,
                    disciplinasPanels, disciplinasPanelLengths);
            }
        }

        private void concluirBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new MenuDisciplina(_mainForm), sender, null, true);
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
                TextBoxTools.FilterPanelList(searchTxtBox, disciplinasFlwLayPnl, _mainForm,
                disciplinas, disciplinasPanels, disciplinasPanelLengths);
            }
        }
    }
}
