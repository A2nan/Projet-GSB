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
    public partial class FConsultInfo : Form
    {
        public FConsultInfo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FConsultInfo_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = ModeleM1.listeVisiteur();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            Visiteur visiteurconnecte = (Visiteur)bindingSource1.Current;
            textBoxNom.Text = visiteurconnecte.nom.ToString(); 
            textBoxPrenom.Text = visiteurconnecte.prenom.ToString();
            textBoxRue.Text = visiteurconnecte.rue.ToString(); 
            textBoxCp.Text = visiteurconnecte.cp.ToString();
            textBoxVille.Text = visiteurconnecte.ville.ToString(); 
            textBoxEmbauche.Text = visiteurconnecte.dateEmbauche.ToString(); 
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (ModeleM1.modifInfo(textBoxNom.Text, textBoxPrenom.Text,textBoxVille.Text, textBoxRue.Text, textBoxCp.Text, textBoxEmbauche.Text))
            {
                labelinfo.Text = "Information mis à jour";
                MessageBox.Show("Infomations mis à juor avec succès");

            }
            else
            {
                labelinfo.Text = "Une erreur est survenu";
            }

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
