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
    public partial class Modif : Form
    {
        public Modif()
        {
            InitializeComponent();
        }
        

       

        private void Modif_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vos modification on était annulé");
            this.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vos modification on bien était modifié");
            this.Close();
        }

        private void Modifi_load(object sender, EventArgs e)
        {
            BSModif.DataSource = ModeleM3.LesListeFraisDuVisiteurConnec();
            DGVModif.DataSource = BSModif;
            
            DGVModif.Columns[1].Visible = true;
            DGVModif.Columns[1].HeaderText = "Mois:";
            DGVModif.Columns[2].Visible = true;
            DGVModif.Columns[2].HeaderText = "nbJusificatifs";
            DGVModif.Columns[3].Visible = true;
            DGVModif.Columns[3].HeaderText = "MotantValide";
            DGVModif.Columns[4].Visible = true;
            DGVModif.Columns[4].HeaderText = "DateModif";
            DGVModif.Columns[5].Visible = true;
            DGVModif.Columns[5].HeaderText = "idEtat";
        }

    }
}
