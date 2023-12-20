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
    public partial class AMrapport : Form
    {
        public AMrapport()
        {
            InitializeComponent();
        }
        private void AMrapport_Load(object sender, EventArgs e)
        {
           if(ModeleM2.Action == 2)
            {
                bsMotif.DataSource = ModeleM2.listeMotif();
                cboMotif.DisplayMember = "libMotif";
                cboMotif.DataSource = bsMotif;
                textBox1.Text = ModeleM2.RapportChoisi1.idRapport.ToString();
                textBox2.Text = ((DateTime)ModeleM2.RapportChoisi1.dateRapport).Date.ToString("dd/MM/yyyy");
                textBox3.Text = ModeleM2.RapportChoisi1.bilan.ToString();
                bsMedicament.DataSource = ModeleM2.listeMedicaments();
                dgvEchantillion.DataSource = bsMedicament;
                
            }

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bsRapport_CurrentChanged(object sender, EventArgs e)
        {
            RAPPORT leRapportChoisi = (RAPPORT)bsRapport.Current;
            textBox1.Text = leRapportChoisi.idRapport.ToString();
            

        }

        private void bsMotif_CurrentChanged(object sender, EventArgs e)
        {
            MOTIF leMotifChoisi = (MOTIF)bsMotif.Current;
            
        }
    }
}
