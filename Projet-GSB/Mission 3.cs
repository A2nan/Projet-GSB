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

        private void button2_Click(object sender, EventArgs e)
        {
            FicheActuel FficheActuel = new FicheActuel();
            FficheActuel.Show();
        }
    }
}
