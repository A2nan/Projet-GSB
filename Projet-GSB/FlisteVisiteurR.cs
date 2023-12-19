using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GSB
{
    public partial class FlisteVisiteurR : Form
    {
        public FlisteVisiteurR()
        {
            InitializeComponent();
        }

        private void bsRegion_CurrentChanged(object sender, EventArgs e)
        {
            Region laRegionChoisie = (Region)bsRegion.Current;
            bsVisiteur.DataSource = laRegionChoisie.Visiteur1.Select(x => new { x.nom, x.prenom, x.rue, x.cp, x.ville, x.dateEmbauche });
            dgvVisiteur.DataSource = bsVisiteur;
            txtRegion.Text = ((Region)bsRegion.Current).Visiteur.nom.Trim().ToString() + " " + ((Region)bsRegion.Current).Visiteur.prenom.Trim().ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FlisteVisiteurR_Load(object sender, EventArgs e)
        {
            
            cboRegion.DisplayMember = "libRegion";
            bsRegion.DataSource = ModeleM1.listeRegion();
            cboRegion.DataSource = bsRegion;
            
            cboSecteur.DisplayMember = "libSecteur";
            bsSecteur.DataSource = ModeleM1.ListeSecteur();
            cboSecteur.DataSource = bsSecteur;
        }

        private void bsSecteur_CurrentChanged(object sender, EventArgs e)
        {
            bsRegion.DataSource = ((Secteur)bsSecteur.Current).Region.ToList();
            cboRegion.DisplayMember = "libRegion"; 
            cboRegion.DataSource = bsRegion;
            txtSecteur.Text = ((Secteur)bsSecteur.Current).Visiteur.nom.Trim().ToString() + " " + ((Secteur)bsSecteur.Current).Visiteur.prenom.Trim().ToString();
        }
    }
}
