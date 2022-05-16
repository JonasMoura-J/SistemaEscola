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
    public partial class Form1 : Form
    {
        private Form _activeForm;
        private Button _currentBtn;

        public Form1()
        {
            InitializeComponent();
        }


        private void OpenChildForm(Form childForm, object btnSender)
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
        }

        private void alunosBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MenuAluno(), sender);
            titleLb.Text = "ALUNO";
        }
    }
}
