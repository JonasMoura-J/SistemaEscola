using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;

namespace SistemaEscola
{
    public partial class CadastrarAluno : Form
    {
        ControladorAluno controladorAluno = new ControladorAluno();

        public CadastrarAluno()
        {
            InitializeComponent();
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            var form = new FormularioAluno
            {
                Id = int.Parse(idTxtBox.Text),
                Nome = nomeTxtBox.Text,
                Cpf = cpfTxtBox.Text,
                Rg = rgTxtBox.Text,
                TelefoneResidencial = teleResTxtBox.Text,
                TelefoneCelular = teleCelTxtBox.Text,
                Email = emailTxtBox.Text,
                NomeResponsavel = nomeRespTxtBox.Text,
                Matricula = matriculaTxtBox.Text
            };

            controladorAluno.Add(form);

            Close();
        }

        // Provisoriamente
        private void CadastrarAluno_Load(object sender, EventArgs e)
        {
            controladorAluno.FindAll().ForEach(a => comboBox1.Items.Add(a.Nome));
        }
    }
}
