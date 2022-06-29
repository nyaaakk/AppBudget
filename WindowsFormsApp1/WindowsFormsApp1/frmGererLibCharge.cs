using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmGererLibCharge : Form
    {
        public frmGererLibCharge()
        {
            InitializeComponent();
        }

        private void frmAjoutLibCharge_Load(object sender, EventArgs e)
        {
            
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.LibelleCharge'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.libelleChargeTableAdapter.Fill(this.database1DataSet.LibelleCharge);

        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            bool test = true;

            string lib = tbxNomLib.Text.ToLower();
            int max = database1DataSet.LibelleCharge.Count - 1;

            int id = int.Parse(database1DataSet.LibelleCharge.Rows[max]["idLib"].ToString()) + 1;

            for (int i = 0; i <= max; i++)
            {
                if (lib == database1DataSet.LibelleCharge.Rows[i]["lib"].ToString())
                {
                    lblErreur.Visible = true;
                    test = false;
                    break;
                }
            }

            if (test)
            {
                lblErreur.Visible = false;
                libelleChargeTableAdapter.Insert(id, lib);
                this.libelleChargeTableAdapter.Fill(this.database1DataSet.LibelleCharge);
            }
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            int id = (int)lbxListeLib.SelectedValue;
            string lib = "erreur";

            int max = database1DataSet.LibelleCharge.Count;
            for (int i = 0; i < max; i++)
            {
                if (id == int.Parse(database1DataSet.LibelleCharge.Rows[i]["idLib"].ToString()))
                {
                    lib = database1DataSet.LibelleCharge.Rows[i]["lib"].ToString();
                }
            }

            libelleChargeTableAdapter.Delete(id, lib);
            this.libelleChargeTableAdapter.Fill(this.database1DataSet.LibelleCharge);
        }
    }
}
