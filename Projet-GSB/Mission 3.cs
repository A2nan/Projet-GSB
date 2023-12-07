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
    public partial class Mission3 : Form
    {
        public Mission3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrainsEngages fEngages = new FrainsEngages();
            fEngages.Show();
        }

        private void DGVFiche_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Mission3_Load(object sender, EventArgs e)
        {
            BSFiche.DataSource = ModeleM3.LesListeFraisDuVisiteurConnec();
            DGVFiche.DataSource = BSFiche;

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
