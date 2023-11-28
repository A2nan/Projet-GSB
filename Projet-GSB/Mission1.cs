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
    public partial class Mission1 : Form
    {
        public Mission1()
        {
            InitializeComponent();
        }

        private void consulterEtMàjInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FConsultInfo fConsultInfo = new FConsultInfo();
            fConsultInfo.Show();
        }

        private void consulterSesRésponsabilitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void modifierMdpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmodifMdp FmodifMdp = new FmodifMdp();
            FmodifMdp.Show();
        }

        private void Mission1_Load(object sender, EventArgs e)
        {

        }
    }
}
