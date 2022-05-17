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
                txtBox.Text = "";

                txtBox.ForeColor = Color.Black;
            }
        }

        public static void Fill(TextBox txtBox, string placeHolder)
        {
            if (txtBox.Text == "")
            {
                txtBox.Text = placeHolder;

                txtBox.ForeColor = Color.LightSteelBlue;
            }
        }

        public static void ClearPassword(TextBox txtBox, string placeHolder)
        {
            if (txtBox.Text == placeHolder)
            {
                txtBox.Text = "";

                txtBox.ForeColor = Color.Black;

                txtBox.PasswordChar = '•';
            }
        }

        public static void FillPassword(TextBox txtBox, string placeHolder)
        {
            if (txtBox.Text == "")
            {
                txtBox.Text = placeHolder;

                txtBox.ForeColor = Color.LightSteelBlue;

                txtBox.PasswordChar = '\0';
            }
        }
    }
}
