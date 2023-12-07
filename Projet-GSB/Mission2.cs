using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

            cboPraticien.DisplayMember = "nom";
            bsMedecin.DataSource = ModeleM2.listeMedecin();
            bsVisiteur.DataSource = ModeleM2.listeVisiteur();
            cboPraticien.DataSource = bsMedecin;
            bsRapport.DataSource = ModeleM2.listeRapport();
            
        }

        private void bsVisiteur_CurrentChanged(object sender, EventArgs e)
        {
            if(ModeleM2.Action == 2)
            {
                Visiteur leVisiteurChoisi = (Visiteur)bsVisiteur.Current;

                textBox7.Text = leVisiteurChoisi.nom.ToString();
                textBox5.Text = leVisiteurChoisi.prenom.ToString();
            }
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;  
            }
            else
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
        }

        private void ChangeDGV()
        {
            
        }

        private void bsMedecin_CurrentChanged(object sender, EventArgs e)
        {
            MEDECIN leMedecinChoisi = (MEDECIN)bsMedecin.Current;
            List<RAPPORT> leRapportChoisi = leMedecinChoisi.RAPPORT.ToList();
            bsRapport.DataSource = leRapportChoisi;
            DgvRapport.DataSource = bsRapport;

        }

     

        private void cboPraticien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModeleM2.Action = 2;
            System.Type type = bsRapport.Current.GetType();
            int id = (int)type.GetProperty("idRapport").GetValue(bsRapport.Current, null);
            ModeleM2.RapportChoisi1 = ModeleM2.recupRapport(id);
            AMrapport aMrapport = new AMrapport();
            aMrapport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModeleM2.Action = 1;
            AMrapport aMrapport = new AMrapport();
            aMrapport.Show();
        }
    }
}
