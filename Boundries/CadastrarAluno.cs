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

//Provisoriamente
using SistemaEscola.Db;

namespace SistemaEscola
{
    public partial class CadastrarAluno : Form
    {
        ControladorAluno controladorAluno = new ControladorAluno();

        //Provisoriamente
        TempDb context = TempDb.Instanse;

        public CadastrarAluno()
        {
            InitializeComponent();
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            controladorAluno.AddAluno(new FormularioAluno
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
            });

            Close();
        }

        // Provisoriamente
        private void CadastrarAluno_Load(object sender, EventArgs e)
        {
            context.Alunos.ForEach(d => comboBox1.Items.Add(d.Nome));
        }
    }
}
