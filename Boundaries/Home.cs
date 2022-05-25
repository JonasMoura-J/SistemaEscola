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
    public partial class Home : Form
    {
        private Form _currentForm;
        private List<Form> _activeForms = new List<Form>();
        private Button _currentBtn;

        public Home()
        {
            InitializeComponent();
        }


        public void OpenNewForm(Form newForm, object btnSender, string title = null, bool reset = false)
        {          
            if (reset)
            {
                _activeForms.Clear();
                returnBtn.Visible = false;
            }
            
            if (_currentForm != null)
            {
                _currentForm.Hide();
            }

            _activeForms.Add(newForm);

            _currentForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(newForm);
            panel1.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
            homeBtn.Visible = true;
            
            if (title != null)
            {
                titleLb.Text = title;
            }

            if (_activeForms.Count > 1)
            {
                returnBtn.Visible = true;
            }
        }

        public void OpenPreviousForm(object btnSender)
        {
            if (_currentForm != null)
            {
                _activeForms.Remove(_currentForm);
                _currentForm.Close();
            }

            _currentForm = _activeForms.Last();

            _currentForm.TopLevel = false;
            _currentForm.FormBorderStyle = FormBorderStyle.None;
            _currentForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(_currentForm);
            panel1.Tag = _currentForm;
            _currentForm.BringToFront();
            _currentForm.Show();
            homeBtn.Visible = true;

            if (_activeForms.Count <= 1)
            {
                returnBtn.Visible = false;
            }
        }

        public void OpenHomeForm(object btnSender)
        {
            if (_currentForm != null)
            {
                _currentForm.Close();
            }

            _activeForms.Clear();

            titleLb.Text = "HOME";

            homeBtn.Visible = false;
            returnBtn.Visible = false;
        }

        private void alunosBtn_Click(object sender, EventArgs e)
        {
            OpenNewForm(new MenuAluno(this), sender, "ALUNO", true);
        }

        private void disciplinaBtn_Click(object sender, EventArgs e)
        {
            OpenNewForm(new MenuDisciplina(this), sender, "DISCIPLINA", true);
        }

        private void turmaBtn_Click(object sender, EventArgs e)
        {
            OpenNewForm(new MenuTurma(this), sender, "TURMA", true);
        }

        private void professorBtn_Click(object sender, EventArgs e)
        {
            OpenNewForm(new MenuProfessor(this), sender, "PROFESSOR", true);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            OpenHomeForm(sender);
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            OpenPreviousForm(sender);
        }
    }
}
