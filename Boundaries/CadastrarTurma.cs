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

namespace SistemaEscola
{
    public partial class CadastrarTurma : Form
    {
        ControladorTurma controladorTurma = new ControladorTurma();

        public CadastrarTurma()
        {
            InitializeComponent();
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            var form = new FormularioTurma
            {
                Id = int.Parse(idTxtBox.Text),
                Nome = nomeTxtBox.Text,
                Codigo = codigoTxtBox.Text,
                QuantidadeAlunos = int.Parse(quantTxtBox.Text)
            };

            controladorTurma.Add(form);

            Close();
        }

        private void CadastrarTurma_Load(object sender, EventArgs e)
        {
            controladorTurma.FindAll().ForEach(t => comboBox1.Items.Add(t.Nome));
        }
    }
}
