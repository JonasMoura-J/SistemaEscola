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
        private Form _activeForm;
        private Button _currentBtn;

        public Home()
        {
            InitializeComponent();
        }


        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            homeBtn.Visible = true;
        }

        private void alunosBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MenuAluno(this), sender);
            titleLb.Text = "ALUNO";
            
        }

        private void disciplinaBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MenuDisciplina(this), sender);
            titleLb.Text = "DISCIPLINA";
        }

        private void turmaBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MenuTurma(this), sender);
            titleLb.Text = "TURMA";
        }

        private void professorBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MenuProfessor(this), sender);
            titleLb.Text = "PROFESSOR";
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            _activeForm.Close();
            titleLb.Text = "HOME";
            homeBtn.Visible = false;
        }
    }
}
