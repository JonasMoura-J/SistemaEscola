using SistemaEscola.Entities.Formularios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class NameEditListPanel : UserControl
    {
        Home _mainForm;
        IFormulario _entity;

        public Label lb;

        public NameEditListPanel(Home mainForm, IFormulario entity)
        {
            InitializeComponent();
            _mainForm = mainForm;
            
            lb = nameLb;
            nameLb.MouseEnter += NameEditPanel_MouseEnter;
            nameLb.MouseLeave += NameEditPanel_MouseLeave;
            editBtn.MouseEnter += NameEditPanel_MouseEnter;
            editBtn.MouseLeave += NameEditPanel_MouseLeave;
            detailsBtn.MouseEnter += NameEditPanel_MouseEnter;
            detailsBtn.MouseLeave += NameEditPanel_MouseLeave;

            _entity = entity;

            lb.Text = _entity.Nome;
        }

        private void HighlightPanel()
        {
            BackColor = ColorTranslator.FromHtml("#0484D4");
            editBtn.BackColor = BackColor;
        }

        private void ResetPanel()
        {
            BackColor = ColorTranslator.FromHtml("#005B96");
            editBtn.BackColor = BackColor;
        }

        private void NameEditPanel_MouseEnter(object sender, EventArgs e)
        {
            HighlightPanel();
        }

        private void NameEditPanel_MouseLeave(object sender, EventArgs e)
        {
            ResetPanel();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Form newForm = null;
            
            if (_entity is FormularioAluno)
            {
                newForm = new EditarAluno(_mainForm, (FormularioAluno)_entity, true);
            }
            else if (_entity is FormularioProfessor)
            {
                //newForm = new EditarProfessor(_mainForm, (FormularioProfessor)_entity);
            }
            else if (_entity is FormularioDisciplina)
            {
                newForm = new EditarDisciplina(_mainForm, (FormularioDisciplina)_entity, true);
            }
            else if (_entity is FormularioTurma)
            {
                //newForm = new EditarTurma(_mainForm, (FormularioTurma)_entity);
            }
            else if (_entity is FormularioUsuario)
            {
                //newForm = new EditarUsuario(_mainForm, (FormularioUsuario)_entity);
            }

            _mainForm.OpenNewForm(newForm, sender);
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            Form newForm = null;

            if (_entity is FormularioAluno)
            {
                newForm = new MostrarAluno(_mainForm, (FormularioAluno)_entity, true);
            }
            else if (_entity is FormularioProfessor)
            {
                //newForm = new MostrarProfessor(_mainForm, (FormularioProfessor)_entity);
            }
            else if (_entity is FormularioDisciplina)
            {
                newForm = new MostrarDisciplina(_mainForm, (FormularioDisciplina)_entity, true);
            }
            else if (_entity is FormularioTurma)
            {
                //newForm = new MostrarTurma(_mainForm, (FormularioTurma)_entity);
            }
            else if (_entity is FormularioUsuario)
            {
                //newForm = new MostrarUsuario(_mainForm, (FormularioUsuario)_entity);
            }

            _mainForm.OpenNewForm(newForm, sender);
        }
    }
}
