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
            
        }

        // Provisoriamente
        private void CadastrarAluno_Load(object sender, EventArgs e)
        {
            controladorAluno.FindAll().ForEach(a => comboBox1.Items.Add(a.Nome));
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var form = new FormularioAluno
            {
                Id = int.Parse(idTxtBox.Text),
                Nome = nomeTxtBox.Text,
                Cpf = cpfTxtBox.Text,
                Rg = rgTxtBox.Text,
                TelefoneResidencial = telResTxtBox.Text,
                TelefoneCelular = telCelTxtBox.Text,
                Email = emailTxtBox.Text,
                NomeResponsavel = respTxtBox.Text,
                Matricula = matriculaTxtBox.Text
            };

            controladorAluno.Add(form);

            Close();
        }

        private void nomeTxtBox_Enter(object sender, EventArgs e)
        {
            if (nomeTxtBox.Text == "Nome")
            {
                nomeTxtBox.Text = "";

                nomeTxtBox.ForeColor = Color.Black;
            }
        }

        private void nomeTxtBox_Leave(object sender, EventArgs e)
        {
            if (nomeTxtBox.Text == "")
            {
                nomeTxtBox.Text = "Nome";

                nomeTxtBox.ForeColor = Color.LightSteelBlue;
            }
        }

        private void cpfTxtBox_Enter(object sender, EventArgs e)
        {
            if (cpfTxtBox.Text == "CPF")
            {
                cpfTxtBox.Text = "";

                cpfTxtBox.ForeColor = Color.Black;
            }
        }

        private void cpfTxtBox_Leave(object sender, EventArgs e)
        {
            if (cpfTxtBox.Text == "")
            {
                cpfTxtBox.Text = "CPF";

                cpfTxtBox.ForeColor = Color.LightSteelBlue;
            }
        }

        private void rgTxtBox_Enter(object sender, EventArgs e)
        {
            if (rgTxtBox.Text == "RG")
            {
                rgTxtBox.Text = "";

                rgTxtBox.ForeColor = Color.Black;
            }
        }

        private void rgTxtBox_Leave(object sender, EventArgs e)
        {
            if (rgTxtBox.Text == "")
            {
                rgTxtBox.Text = "RG";

                rgTxtBox.ForeColor = Color.LightSteelBlue;
            }
        }

        private void emailTxtBox_Enter(object sender, EventArgs e)
        {
            if (emailTxtBox.Text == "E-mail")
            {
                emailTxtBox.Text = "";

                emailTxtBox.ForeColor = Color.Black;
            }
        }

        private void emailTxtBox_Leave(object sender, EventArgs e)
        {
            if (emailTxtBox.Text == "")
            {
                emailTxtBox.Text = "E-mail";

                emailTxtBox.ForeColor = Color.LightSteelBlue;
            }
        }

        private void telResTxtBox_Enter(object sender, EventArgs e)
        {
            if (telResTxtBox.Text == "Telefone Residencial")
            {
                telResTxtBox.Text = "";

                telResTxtBox.ForeColor = Color.Black;
            }
        }

        private void telResTxtBox_Leave(object sender, EventArgs e)
        {
            if (telResTxtBox.Text == "")
            {
                telResTxtBox.Text = "Telefone Residencial";

                telResTxtBox.ForeColor = Color.LightSteelBlue;
            }
        }

        private void telCelTxtBox_Enter(object sender, EventArgs e)
        {
            if (telCelTxtBox.Text == "Telefone Celular")
            {
                telCelTxtBox.Text = "";

                telCelTxtBox.ForeColor = Color.Black;
            }
        }

        private void telCelTxtBox_Leave(object sender, EventArgs e)
        {
            if (telCelTxtBox.Text == "")
            {
                telCelTxtBox.Text = "Telefone Celular";

                telCelTxtBox.ForeColor = Color.LightSteelBlue;
            }
        }

        private void respTxtBox_Enter(object sender, EventArgs e)
        {
            if (respTxtBox.Text == "Nome do Responsável")
            {
                respTxtBox.Text = "";

                respTxtBox.ForeColor = Color.Black;
            }
        }

        private void respTxtBox_Leave(object sender, EventArgs e)
        {
            if (respTxtBox.Text == "")
            {
                respTxtBox.Text = "Nome do Responsável";

                respTxtBox.ForeColor = Color.LightSteelBlue;
            }
        }

        private void matriculaTxtBox_Enter(object sender, EventArgs e)
        {
            if (matriculaTxtBox.Text == "Matrícula")
            {
                matriculaTxtBox.Text = "";

                matriculaTxtBox.ForeColor = Color.Black;
            }
        }

        private void matriculaTxtBox_Leave(object sender, EventArgs e)
        {
            if (matriculaTxtBox.Text == "")
            {
                matriculaTxtBox.Text = "Matrícula";

                matriculaTxtBox.ForeColor = Color.LightSteelBlue;
            }
        }
    }
}
