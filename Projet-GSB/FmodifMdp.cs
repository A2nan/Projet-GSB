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
    public partial class FmodifMdp : Form
    {
        public FmodifMdp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void mdpcurrent_Click(object sender, EventArgs e)
        {

        }

        private void currentmdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {
            string message = ModeleM1.modifMdp(currentmdp.Text, mdpnew.Text, mdpverif.Text);
            MessageBox.Show(message);
            this.Close();
        }

        private void FmodifMdp_Load(object sender, EventArgs e)
        {

        }
    }
}
