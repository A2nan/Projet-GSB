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
    public partial class Mission2 : Form
    {
        public Mission2()
        {
            InitializeComponent();
        }

        private void Mission2_Load(object sender, EventArgs e)
        {
            bsVisiteur.DataSource = ModeleM2.listeVisiteur();
        }

        private void bsVisiteur_CurrentChanged(object sender, EventArgs e)
        {
            Visiteur leVisiteurChoisi = (Visiteur)bsVisiteur.Current;
            textBox1.Text = leVisiteurChoisi.nom;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                
            }
        }
    }
}
