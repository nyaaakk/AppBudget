using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmGererLibProduit : Form
    {
        public frmGererLibProduit()
        {
            InitializeComponent();
        }

        private void frmGererLibProduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.LibelleProduit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.libelleProduitTableAdapter.Fill(this.database1DataSet.LibelleProduit);
            


        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bool test = true;

            string lib = tbxNomLib.Text.ToLower();
            int max = database1DataSet.LibelleProduit.Count -1;

            int id = int.Parse(database1DataSet.LibelleProduit.Rows[max]["idLib"].ToString()) + 1;

            for( int i = 0; i <= max; i++)
            {
                if(lib == database1DataSet.LibelleProduit.Rows[i]["lib"].ToString())
                {
                    lblErreur.Visible = true;
                    test = false;
                    break;
                }               
            }

            if (test)
            {
                lblErreur.Visible = false;
                libelleProduitTableAdapter.Insert(id, lib);
                this.libelleProduitTableAdapter.Fill(this.database1DataSet.LibelleProduit);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = (int)lbxListeLib.SelectedValue;
            string lib = "erreur";

            int max = database1DataSet.LibelleProduit.Count;
            for(int i = 0; i < max; i++)
            {
                if(id == int.Parse(database1DataSet.LibelleProduit.Rows[i]["idLib"].ToString()))
                {
                    lib = database1DataSet.LibelleProduit.Rows[i]["lib"].ToString();
                }
            }

            libelleProduitTableAdapter.Delete(id, lib);
            this.libelleProduitTableAdapter.Fill(this.database1DataSet.LibelleProduit);

        }
    }
}
