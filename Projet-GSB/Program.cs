using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GSB
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            ModeleM1.init();
            ModeleM2.init();
            ModeleM3.init();
            ModeleConnexion.init();
            Application.Run(new Mission1());
            

        }
    }
}
