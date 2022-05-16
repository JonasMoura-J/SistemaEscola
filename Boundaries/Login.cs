using System;
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

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            if (usuarioTxtBox.Text != null && senhaTxtBox.Text != null)
            {
                var form = new FormularioLogin
                {
                    Nome = usuarioTxtBox.Text,
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

        private void OpenNewForm(object obj)
        {
            Application.Run(new Home());
        }

        // Provisoriamente
        private void Login_Load(object sender, EventArgs e)
        {
            controladorLogin.FindAll().ForEach(u => comboBox1.Items.Add(u.Nome));
        }        
    }
}
