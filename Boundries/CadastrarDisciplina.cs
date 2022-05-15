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
    public partial class CadastrarDisciplina : Form
    {
        ControladorDisciplina controladorDisciplina = new ControladorDisciplina();

        //Provisoriamente
        TempDb context = TempDb.Instanse;

        public CadastrarDisciplina()
        {
            InitializeComponent();
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            controladorDisciplina.AddDisciplina(new FormularioDisciplina
            {
                Id = int.Parse(idTxtBox.Text),
                Nome = nomeTxtBox.Text
            });

            Close();            
        }

        // Provisoriamente
        private void CadastrarDisciplina_Load(object sender, EventArgs e)
        {
            context.Disciplinas.ForEach(d => comboBox1.Items.Add(d.Nome));
        }
    }
}
