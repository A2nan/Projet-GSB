using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GSB
{
    public partial class FConnection : Form
    {
        public FConnection()
        {
            InitializeComponent();
            

        }

        //et on ajoute la méthode:
        public static void ThreadProc()
        {
            Application.Run(new FMenu());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void connexion_Click(object sender, EventArgs e)
        {
            if()
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
                this.Close();
            }
        }
    }
}
