using gestion_hotelier.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_hotelier
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            db context = new db();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //double.TryParse(textBox4.Text, out telephone) && double.TryParse(textBox2.Text, out numero) && double.TryParse(textBox1.Text, out id)
           //
        }
    }
}
