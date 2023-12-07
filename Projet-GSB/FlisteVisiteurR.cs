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
    }
}
