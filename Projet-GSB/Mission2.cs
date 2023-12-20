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
            DgvRapport.AutoGenerateColumns = false;
        }

        private void bsVisiteur_CurrentChanged(object sender, EventArgs e)
        {
            
            Visiteur leVisiteurChoisi = (Visiteur)bsVisiteur.Current;

            textBox7.Text = leVisiteurChoisi.nom.ToString();
            textBox5.Text = leVisiteurChoisi.prenom.ToString();
            textBox6.Text = $"{leVisiteurChoisi.rue.ToString()}, {leVisiteurChoisi.ville.ToString()}";
            textBox3.Text = leVisiteurChoisi.dateEmbauche.ToString();
            textBox4.Text = leVisiteurChoisi.idVisiteur.ToString();
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
            cboPraticien_SelectedIndexChanged(sender, e);

        }

     

        private void cboPraticien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPraticien.SelectedItem != null)
            {
                MEDECIN leMedecinChoisi = (MEDECIN)cboPraticien.SelectedItem;

                // Obtenez la liste des rapports associés au médecin choisi
                List<RAPPORT> leRapportChoisi = leMedecinChoisi.RAPPORT.ToList();

                // Mettez à jour la source de données du BindingSource des rapports
                bsRapport.DataSource = leRapportChoisi;

                // Mettez à jour la source de données du DataGridView
                DgvRapport.DataSource = bsRapport;
            }
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
