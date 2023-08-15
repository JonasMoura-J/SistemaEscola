using System.Windows.Forms;
using System.Drawing;

namespace SistemaEscola.Utils
{
    public static class TextBoxTools
    {
        public static void Clear(TextBox txtBox, string placeHolder)
        {
            if (txtBox.Text == placeHolder)
            {
                txtBox.Text = string.Empty;

                txtBox.ForeColor = Color.Black;
            }
        }

        public static void Clear(MaskedTextBox txtBox, string placeHolder)
        {
            if (txtBox.Text == placeHolder)
            {
                txtBox.Text = string.Empty;

                txtBox.ForeColor = Color.Black;
            }
        }

        public static void Clear(MaskedTextBox txtBox, string placeHolder, string mask)
        {
            if (txtBox.Text == placeHolder)
            {
                txtBox.Text = string.Empty;

                txtBox.ForeColor = Color.Black;

                txtBox.Mask = mask;
            }
        }

        public static void Fill(TextBox txtBox, string placeHolder)
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                txtBox.Text = placeHolder;

                txtBox.ForeColor = Color.LightSteelBlue;
            }
        }

        public static void Fill(MaskedTextBox txtBox, string placeHolder)
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                txtBox.Text = placeHolder;

                txtBox.ForeColor = Color.LightSteelBlue;
            }
        }
        public static void Fill(MaskedTextBox txtBox, string placeHolder, string maskEmpty)
        {
            if (txtBox.Text == maskEmpty || txtBox.Text == string.Empty)
            {
                txtBox.Mask = "";

                txtBox.Text = placeHolder;

                txtBox.ForeColor = Color.LightSteelBlue;
            }
        }
        public static void ClearPassword(TextBox txtBox, string placeHolder)
        {
            if (txtBox.Text == placeHolder)
            {
                txtBox.Text = string.Empty;

                txtBox.ForeColor = Color.Black;

                txtBox.PasswordChar = '•';
            }
        }

        public static void FillPassword(TextBox txtBox, string placeHolder)
        {
            if (txtBox.Text == string.Empty)
            {
                txtBox.Text = placeHolder;

                txtBox.ForeColor = Color.LightSteelBlue;

                txtBox.PasswordChar = '\0';
            }
        }
    }
}
