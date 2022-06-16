using System;
using System.Windows.Forms;
using SistemaEscola.Data;

namespace SistemaEscola
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var seedingService = new SeedingService();

            seedingService.Seed();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Application.Run(new Home());
        }
    }
}
