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
    public partial class CadastrarDisciplina : Form
    {
        ControladorDisciplina controladorDisciplina = new ControladorDisciplina();
        ControladorProfessor controladorProfessor = new ControladorProfessor();

        public CadastrarDisciplina()
        {
            InitializeComponent();
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            var form = new FormularioDisciplina
            {
                Id = int.Parse(idTxtBox.Text),
                Nome = nomeTxtBox.Text
            };

            controladorDisciplina.Add(form);

            Close();            
        }

        // Provisoriamente
        private void CadastrarDisciplina_Load(object sender, EventArgs e)
        {
            controladorDisciplina.FindAll().ForEach(d => comboBox1.Items.Add(d.Nome));
            
            controladorProfessor.FindAll().ForEach(p => comboBox2.Items.Add(p.Nome));
        }
    }
}
