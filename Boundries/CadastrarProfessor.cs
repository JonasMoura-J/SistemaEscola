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
    public partial class CadastrarProfessor : Form
    {
        ControladorProfessor controladorProfessor = new ControladorProfessor();

        //Provisoriamente
        TempDb context = TempDb.Instanse;

        public CadastrarProfessor()
        {
            InitializeComponent();
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            controladorProfessor.AddProfessor(new FormularioProfessor
            {
                Id = int.Parse(idTxtBox.Text),
                Nome = nomeTxtBox.Text,
                Cpf = cpfTxtBox.Text,
                Rg = rgTxtBox.Text,
                TelefoneResidencial = teleResTxtBox.Text,
                TelefoneCelular = teleCelTxtBox.Text,
                Email = emailTxtBox.Text
            });

            Close();
        }

        // Provisoriamente
        private void CadastrarProfessor_Load(object sender, EventArgs e)
        {
            context.Professores.ForEach(d => comboBox1.Items.Add(d.Nome));
        }
    }
}
