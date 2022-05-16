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
        public Home()
        {
            InitializeComponent();
        }

        private void disciplinaBtn_Click(object sender, EventArgs e)
        {
            CadastrarDisciplina cd = new CadastrarDisciplina();
            cd.Show();
        }

        private void turmaBtn_Click(object sender, EventArgs e)
        {
            CadastrarTurma ct = new CadastrarTurma();
            ct.Show();
        }

        private void professorBtn_Click(object sender, EventArgs e)
        {
            CadastrarProfessor cp = new CadastrarProfessor();
            cp.Show();
        }

        private void alunoBtn_Click(object sender, EventArgs e)
        {
            CadastrarAluno ca = new CadastrarAluno();
            ca.Show();
        }
    }
}
