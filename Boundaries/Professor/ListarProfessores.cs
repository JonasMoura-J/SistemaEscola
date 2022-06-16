using System;
using System.Windows.Forms;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class ListarProfessores : Form
    {
        readonly Home _mainForm;

        readonly ControladorProfessor controladorProfessor = ControladorProfessor.Instance;

        readonly List<FormularioProfessor> professores = new List<FormularioProfessor>();

        readonly List<NameEditListPanel> professoresPanels = new List<NameEditListPanel>();
        readonly List<int> professoresPanelLengths = new List<int>();

        public ListarProfessores(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void ListarProfessores_Load(object sender, EventArgs e)
        {
            // Flow Layout Panel Settings
            professoresPanelLengths.Add(professoresFlwLayPnl.Width);
            professoresFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            professoresFlwLayPnl.AutoScroll = true;
            professoresFlwLayPnl.WrapContents = false;

            controladorProfessor.FindAll().ForEach(p => professores.Add(new FormularioProfessor()
            {
                Id = p.Id,
                Nome = p.Nome
            }));

            foreach (var prof in professores)
            {
                FlowLayoutPanelTools.LoadNameEditListPanel(_mainForm, prof, professoresFlwLayPnl,
                    professoresPanels, professoresPanelLengths);
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
                TextBoxTools.FilterPanelList(searchTxtBox, professoresFlwLayPnl, _mainForm,
                    professores, professoresPanels, professoresPanelLengths);
            }
        }
    }
}
