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
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class CadastrarAluno : Form
    {
        Form1 _mainForm;
        ControladorAluno controladorAluno = new ControladorAluno();
        List<TextBox> textBoxes = new List<TextBox>();

        public CadastrarAluno(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        
        private void CadastrarAluno_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    textBoxes.Add((TextBox)c);
                }
            }

            // Provisoriamente
            controladorAluno.FindAll().ForEach(a => comboBox1.Items.Add(a.Nome));
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!textBoxes.Any(t => t.ForeColor == Color.LightSteelBlue))
            {
                if (!textBoxes.Any(t => t.Text == ""))
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

                    _mainForm.OpenChildForm(new MenuAluno(_mainForm), sender);
                }
            }
        }

        private void nomeTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(nomeTxtBox, "Nome");
        }

        private void nomeTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(nomeTxtBox, "Nome");
        }

        private void cpfTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(cpfTxtBox, "CPF");
        }

        private void cpfTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(cpfTxtBox, "CPF");
        }

        private void rgTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(rgTxtBox, "RG");
        }

        private void rgTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(rgTxtBox, "RG");
        }

        private void emailTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(emailTxtBox, "E-mail");
        }

        private void emailTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(emailTxtBox, "E-mail");
        }

        private void telResTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(telResTxtBox, "Telefone Residencial");
        }

        private void telResTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(telResTxtBox, "Telefone Residencial");
        }

        private void telCelTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(telCelTxtBox, "Telefone Celular");
        }

        private void telCelTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(telCelTxtBox, "Telefone Celular");
        }

        private void respTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(respTxtBox, "Nome do Responsável");
        }

        private void respTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(respTxtBox, "Nome do Responsável");
        }

        private void matriculaTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(matriculaTxtBox, "Matrícula");
        }

        private void matriculaTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(matriculaTxtBox, "Matrícula");
        }    
    }
}
