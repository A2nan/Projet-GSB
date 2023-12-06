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
            bsVisiteur.DataSource = ModeleM2.listeVisiteur();
            bsRapport.DataSource = ModeleM2.listeRapport();
            cboPraticien.ValueMember = "idMedecin";
            cboPraticien.DisplayMember = "nom";
            cboPraticien.DataSource = bsMedecin;
            bsMedecin.DataSource = ModeleM2.listeMedecin();
        }

        private void bsVisiteur_CurrentChanged(object sender, EventArgs e)
        {
            Visiteur leVisiteurChoisi = (Visiteur)bsVisiteur.Current;
            textBox7.Text = leVisiteurChoisi.nom.ToString();
            textBox5.Text = leVisiteurChoisi.prenom.ToString();
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

        private void bsMedecin_CurrentChanged(object sender, EventArgs e)
        {
            MEDECIN leMedecinChoisi = (MEDECIN)bsMedecin.Current;
            bsMedecin.DataSource = leMedecinChoisi.nom.ToString();
        }

        private void ChangeDGV()
        {
           
        }

        private void cboPraticien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
