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
    public partial class FicheActuel : Form
    {
        public FicheActuel()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public partial class LigneFraisForfait
        {
            public string idVisiteur { get; set; }
            public string mois { get; set; }
            public string idFraisForfait { get; set; }
            public Nullable<int> quantite { get; set; }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void bsFicheForfait_CurrentChanged(object sender, EventArgs e)
        {
            FicheActuel lesFicheActuel = (FicheActuel)bsFicheForfait.Current;
            //bsFicheForfait.DataSource = lesFicheActuel.
        }
    }
}
