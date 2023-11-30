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
    public partial class FrainsEngages : Form
    {
        public FrainsEngages()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        public partial class LigneFraisForfait
        {
            public string idVisiteur { get; set; }
            public string mois { get; set; }
            public string idFraisForfait { get; set; }
            public Nullable<int> quantite { get; set; }

            
        }
    }
}
}
