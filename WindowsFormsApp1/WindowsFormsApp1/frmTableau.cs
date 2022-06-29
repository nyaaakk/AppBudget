using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmTableau : Form
    {
        public frmTableau()
        {
            InitializeComponent();
        }

        private void ajouterLibelléToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGererLibCharge frmAjoutLibCharge = new frmGererLibCharge();
            frmAjoutLibCharge.ShowDialog();
        }

        private void créerLibelléToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGererLibProduit frmAjoutLibProduit = new frmGererLibProduit();
            frmAjoutLibProduit.ShowDialog();
        }

        private void ajouterDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjouterDonneeCharge frmAjouterDonneeCharge = new frmAjouterDonneeCharge();
            frmAjouterDonneeCharge.ShowDialog();
        }

        private void ajouterDonnéesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAjouterDonneeProduit frmAjouterDonneeProduit = new frmAjouterDonneeProduit();
            frmAjouterDonneeProduit.ShowDialog();
        }

    

        private void graphiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraphProduit frmGraphProduit = new frmGraphProduit();
            frmGraphProduit.ShowDialog();
        }

        private void graphiqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGraphCharge frmGraphCharge = new frmGraphCharge();
            frmGraphCharge.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
