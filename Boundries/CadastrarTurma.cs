using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Controllers;
using SistemaEscola.Entities.Formularios;

// Provisoriamente
using SistemaEscola.Db;


namespace SistemaEscola
{
    public partial class CadastrarTurma : Form
    {
        ControladorTurma controladorTurma = new ControladorTurma();

        // Provisoriamente
        TempDb context = TempDb.Instanse;

        public CadastrarTurma()
        {
            InitializeComponent();
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            controladorTurma.AddTurma(new FormularioTurma
            {
                Id = int.Parse(idTxtBox.Text),
                Nome = nomeTxtBox.Text,
                Codigo = codigoTxtBox.Text,
                QuantidadeAlunos = int.Parse(quantTxtBox.Text)
            });

            Close();
        }

        private void CadastrarTurma_Load(object sender, EventArgs e)
        {
            context.Turmas.ForEach(d => comboBox1.Items.Add(d.Nome));
        }
    }
}
