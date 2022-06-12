using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class Login : Form
    {
        Thread th;
        
        readonly ControladorUsuario controladorLogin = new ControladorUsuario();

        public Login()
        {
            InitializeComponent();
        }

        private void OpenHomeForm(object obj)
        {
            Application.Run(new Home());
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!(userTxtBox.ForeColor == Color.LightSteelBlue || senhaTxtBox.ForeColor == Color.LightSteelBlue))
            {
                var form = new FormularioUsuario
                {
                    Nome = userTxtBox.Text.ToUpper(),
                    Senha = senhaTxtBox.Text
                };

                // Validates form (just for safety)
                ValidationContext validContext = new ValidationContext(form, null, null);
                List<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(form, validContext, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    if (controladorLogin.ConfirmLogin(form))
                    {
                        Close();
                        th = new Thread(OpenHomeForm);
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
    }
}
