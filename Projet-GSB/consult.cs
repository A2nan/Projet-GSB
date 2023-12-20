using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projet_GSB
{
    public partial class consult : Form
    {
        public consult()
        {
            InitializeComponent();
        }

       
        private void DGVFiche_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            bsFiche.DataSource = ModeleM3.LesListeFraisDuVisiteurConnec();
            DGVFiche.DataSource = bsFiche;

            DGVFiche.Columns[1].Visible = true;
            DGVFiche.Columns[1].HeaderText = "Mois:";
            DGVFiche.Columns[2].Visible = true;
            DGVFiche.Columns[2].HeaderText = "nbJusificatifs";
            DGVFiche.Columns[3].Visible = true;
            DGVFiche.Columns[3].HeaderText = "MotantValide";
            DGVFiche.Columns[4].Visible = true;
            DGVFiche.Columns[4].HeaderText = "DateModif";
            DGVFiche.Columns[5].Visible = true;
            DGVFiche.Columns[5].HeaderText = "idEtat";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = checkBox1.Checked;
        }

        private void consult_Load(object sender, EventArgs e)
        {
            List<DateTime> dates = new List<DateTime>();
            // Ajoutez des dates à votre liste
            CBOMois.DataSource = dates;
            CBOMois.DisplayMember = "ToShortDateString()";
            CBOMois.DisplayMember = "LibMois";
            bsFiche.DataSource = ModeleM3.listeFraisForfaits();
            CBOMois.DataSource = bsFiche;
            bsFiche.DataSource = ModeleM3.LesListeFraisDuVisiteurConnec();
            DGVFiche.DataSource = bsFiche;
            

            DGVFiche.Columns[1].Visible = true;
            DGVFiche.Columns[1].HeaderText = "Mois:";
            DGVFiche.Columns[2].Visible = true;
            DGVFiche.Columns[2].HeaderText = "nbJusificatifs";
            DGVFiche.Columns[3].Visible = true;
            DGVFiche.Columns[3].HeaderText = "MotantValide";
            DGVFiche.Columns[4].Visible = true;
            DGVFiche.Columns[4].HeaderText = "DateModif";
            DGVFiche.Columns[5].Visible = true;
            DGVFiche.Columns[5].HeaderText = "idEtat";

        }


       
    }
}
