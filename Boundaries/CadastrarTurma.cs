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
        private readonly Home _mainForm;
        
        ControladorTurma controladorTurma = new ControladorTurma();
        
        List<AlunoPanel> panels = new List<AlunoPanel>();
        List<int> lengths = new List<int>();

        int c = 0;

        public CadastrarTurma(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            lengths.Add(273);
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            /*
            var form = new FormularioTurma
            {
                Id = int.Parse(idTxtBox.Text),
                Nome = nomeTxtBox.Text,
                Codigo = codigoTxtBox.Text,
                QuantidadeAlunos = int.Parse(quantTxtBox.Text)
            };*/

            //controladorTurma.Add(form);

            Close();
        }

        private void CadastrarTurma_Load(object sender, EventArgs e)
        {
            controladorTurma.FindAll().ForEach(t => comboBox1.Items.Add(t.Nome));
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (panels.Count == 0)
            {
                panels.Add(new AlunoPanel("Wilsonson"));
                flowLayoutPanel1.Controls.Add(panels[0]);

                lengths.Add(panels[0].Width);
                panels[0].AutoSize = false;
                panels[0].Width = lengths.Max();

                c++;
            } else
            {
                panels.Add(new AlunoPanel(textBox2.Text));
                flowLayoutPanel1.Controls.Add(panels[c]);

                lengths.Add(panels[c].Width);
                panels[c].AutoSize = false;
                panels.ForEach(p => p.Width = lengths.Max());
                c++;
            }

            


            //panels.Add(new AlunoPanel());
            //panels.Add(new AlunoPanel());

            //panels[2].lb.Text = "Willson";
            //panels[1].lb.Text = "Wilsonson";
            //panels[0].lb.Text = "Wilsonsonson";
            //lengths.Add(panels[0].Width.ToString());
            //lengths.Add(panels[1].Width.ToString());
            //lengths.Add(panels[2].Width.ToString());
            //var lb = new Label();
            //lb.Text = "Hello, World!";
            
            /*
            foreach (AlunoPanel p in panels)
            {
                flowLayoutPanel1.Controls.Add(p);
                lengths.Add(p.Width);
                if (c != 0)
                {
                    p.AutoSize = false;
                    p.Width = lengths.Max();
                }
                c++;
            }
            */
            //flowLayoutPanel1.Controls.Add(panels[0]);
            //flowLayoutPanel1.Controls.Add(panels[1]);
            //flowLayoutPanel1.Controls.Add(panels[2]);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
            //panels[1].lb.Text = "sdsdof";
            //panels.ForEach(p => p.Width = lengths.Max());
            //label1.Text = lengths.Max().ToString();
            label1.Text = lengths.Max().ToString();
            //flowLayoutPanel1.Controls[1].BackColor = "sadsausdahu asduhdasuh uhsad";
            //flowLayoutPanel1.Controls[2].Text = "sadsau asd uhsad";
        }
    }
}
