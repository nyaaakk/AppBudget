using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAjouterDonneeProduit : Form
    {
        public frmAjouterDonneeProduit()
        {
            InitializeComponent();
        }

        private void frmAjouterDonneeProduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Trimestre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.trimestreTableAdapter.Fill(this.database1DataSet.Trimestre);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Annee'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.anneeTableAdapter.Fill(this.database1DataSet.Annee);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.database1DataSet.Produit);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Date'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.dateTableAdapter.Fill(this.database1DataSet.Date);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.LibelleProduit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.libelleProduitTableAdapter.Fill(this.database1DataSet.LibelleProduit);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int lib = (int)cbxLib.SelectedValue;
            int annee = (int)cbxAnnee.SelectedValue;
            int trimestre = (int)cbxTrimestre.SelectedValue;
            int val = int.Parse(tbxVal.Text);

            int i;
            int max = database1DataSet.Date.Count;

            for(i = 0; i < max; i++)
            {
                if (int.Parse(database1DataSet.Date.Rows[i]["annee"].ToString()) == annee)
                {
                    if (int.Parse(database1DataSet.Date.Rows[i]["trimestre"].ToString()) == trimestre)
                    {
                        break;
                    }
                }
            }

            int idDate = int.Parse(database1DataSet.Date.Rows[i]["idDate"].ToString());



            /*int j;
            int max2 = database1DataSet.LibelleProduit.Count;

            for(j = 0; j < max2; j++)
            {
                if (database1DataSet.LibelleProduit.Rows[j]["lib"].ToString() == lib)
                {
                    break;
                }
            }

            int idLib = int.Parse(database1DataSet.LibelleProduit.Rows[j]["idLib"].ToString());*/

            produitTableAdapter.Insert(lib, idDate, val);
            this.produitTableAdapter.Fill(this.database1DataSet.Produit);

        }
    }
}
