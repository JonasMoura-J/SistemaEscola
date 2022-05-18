using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using SistemaEscola.Controllers;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Utils;

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
            Application.Run(new Home());
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!(userTxtBox.ForeColor == Color.LightSteelBlue || senhaTxtBox.ForeColor == Color.LightSteelBlue))
            {
                if (userTxtBox.Text != "" && senhaTxtBox.Text != "")
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
            TextBoxTools.Clear(userTxtBox, "Usuário");
        }

        private void userTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(userTxtBox, "Usuário");
        }

        private void senhaTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.ClearPassword(senhaTxtBox, "Senha");
        }

        private void senhaTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.FillPassword(senhaTxtBox, "Senha");
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
