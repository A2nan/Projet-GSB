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
    public partial class FResponsable : Form
    {
        public FResponsable()
        {
            InitializeComponent();
        }

        private void FResponsable_Load(object sender, EventArgs e)
        {
            bsRegion.DataSource = ModeleConnexion.UtilisateurConnecte.Region.ToList();//region pour lesquel il est responsable
            dgvRegion.DataSource = bsRegion.DataSource;
            for(int i=0; i < dgvRegion.Columns.Count; i++)
            {
                dgvRegion.Columns[i].Visible = false;
            }
            dgvRegion.Columns[1].Visible = true;

            bsRegion1.DataSource = ModeleConnexion.UtilisateurConnecte.Region1.ToList();//region pour lesquel il travaille
            dgvRegion1.DataSource = bsRegion1.DataSource;
            for (int i = 0; i < dgvRegion1.Columns.Count; i++)
            {
                dgvRegion1.Columns[i].Visible = false;
            }
            dgvRegion1.Columns[1].Visible = true;
            txtboxnom.Text = ModeleConnexion.UtilisateurConnecte.nom.Trim().ToString() + " " + ModeleConnexion.UtilisateurConnecte.prenom.Trim().ToString();
        }

        private void dgvRegion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
