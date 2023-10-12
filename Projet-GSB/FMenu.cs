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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void mission1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mission1 fMission1 = new Mission1();
            fMission1.Show();
        }

        private void mission2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mission2 fMission2 = new Mission2();
            fMission2.Show();
        }

        private void mission3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mission3 fMission3 = new Mission3();
            fMission3.Show();
        }
    }
}
