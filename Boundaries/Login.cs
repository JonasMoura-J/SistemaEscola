using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SistemaEscola.Controllers;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola
{
    public partial class Login : Form
    {
        Thread th;
        ControladorLogin controladorLogin = new ControladorLogin();

        public Login()
        {
            InitializeComponent();
        }

        private void OpenNewForm(object obj)
        {
            Application.Run(new Form1());
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userTxtBox.Text != "Usuário" && senhaTxtBox.Text != "Senha")
            {
                if (userTxtBox.Text != null && senhaTxtBox.Text != null)
                {
                    var form = new FormularioLogin
                    {
                        Nome = userTxtBox.Text,
                        Senha = senhaTxtBox.Text
                    };

                    if (controladorLogin.ConfirmLogin(form))
                    {
                        Close();
                        th = new Thread(OpenNewForm);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                }
            }
        }

        private void userTxtBox_Enter(object sender, EventArgs e)
        {
            if (userTxtBox.Text == "Usuário")
            {
                userTxtBox.Text = "";

                userTxtBox.ForeColor = Color.Black;
            }
        }

        private void userTxtBox_Leave(object sender, EventArgs e)
        {
            if (userTxtBox.Text == "")
            {
                userTxtBox.Text = "Usuário";

                userTxtBox.ForeColor = Color.LightSteelBlue;
            }
        }

        private void senhaTxtBox_Enter(object sender, EventArgs e)
        {
            if (senhaTxtBox.Text == "Senha")
            {
                senhaTxtBox.Text = "";

                senhaTxtBox.ForeColor = Color.Black;

                senhaTxtBox.PasswordChar = '•';
            }
        }

        private void senhaTxtBox_Leave(object sender, EventArgs e)
        {
            if (senhaTxtBox.Text == "")
            {
                senhaTxtBox.Text = "Senha";

                senhaTxtBox.ForeColor = Color.LightSteelBlue;

                senhaTxtBox.PasswordChar = '\0';
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panel4.Focus();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void title1Lb_Click(object sender, EventArgs e)
        {
            title1Lb.Focus();
        }

        private void title2Lb_Click(object sender, EventArgs e)
        {
            title2Lb.Focus();
        }

        // Provisoriamente
        private void Login_Load(object sender, EventArgs e)
        {
            controladorLogin.FindAll().ForEach(u => comboBox1.Items.Add(u.Nome));
        }
    }
}
