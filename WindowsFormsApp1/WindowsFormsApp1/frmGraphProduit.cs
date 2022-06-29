using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmGraphProduit : Form


    {

        private string name ="Series1";
        public frmGraphProduit()
        {
            InitializeComponent();
        }

        private void frmGraphProduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.database1DataSet.Produit);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Date'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.dateTableAdapter.Fill(this.database1DataSet.Date);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Annee'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.anneeTableAdapter.Fill(this.database1DataSet.Annee);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.LibelleProduit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.libelleProduitTableAdapter.Fill(this.database1DataSet.LibelleProduit);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            chart1.Series[name].Points.Clear();
            string annee = cbxAnnee.SelectedValue.ToString();
            chart1.Series[name].Name = annee;
            name = annee;

            int max = database1DataSet.Annee.Count;
            int id = -1;
            for(int i = 0; i < max; i++)
            {
                if(annee == database1DataSet.Annee.Rows[i]["annee"].ToString())
                {
                    id = int.Parse(database1DataSet.Annee.Rows[i]["idAnnee"].ToString());
                }
            }
            
            int idT1 = -1, idT2 = -1, idT3 = -1, idT4 = -1;
            int cpt = 0;
            max = database1DataSet.Date.Count;
            for (int i = 0; i < max; i++)
            {
                if (id == int.Parse(database1DataSet.Date.Rows[i]["annee"].ToString()))
                {
                    if (cpt == 0)
                    {
                        idT1 = int.Parse(database1DataSet.Date.Rows[i]["idDate"].ToString());
                    }
                    else if(cpt == 1)
                    {
                        idT2 = int.Parse(database1DataSet.Date.Rows[i]["idDate"].ToString());
                    }
                    else if(cpt == 2)
                    {
                        idT3 = int.Parse(database1DataSet.Date.Rows[i]["idDate"].ToString());
                    }
                    else if( cpt == 3)
                    {
                        idT4 = int.Parse(database1DataSet.Date.Rows[i]["idDate"].ToString());
                    }
                    cpt++;
                }
            }

            float valT1 = -1, valT2 = -1, valT3 = -1, valT4 = -1;
            max = database1DataSet.Produit.Count;
            int idLib = int.Parse(cbxLib.SelectedValue.ToString());
            for ( int i = 0; i < max; i++)
            {
                if (int.Parse(database1DataSet.Produit.Rows[i]["idProduit"].ToString()) == idLib)
                {
                    if (idT1 == int.Parse(database1DataSet.Produit.Rows[i]["idDate"].ToString()))
                    {
                        valT1 = float.Parse(database1DataSet.Produit.Rows[i]["valProduit"].ToString());
                    }
                    else if (idT2 == int.Parse(database1DataSet.Produit.Rows[i]["idDate"].ToString()))
                    {
                        valT2 = float.Parse(database1DataSet.Produit.Rows[i]["valProduit"].ToString());
                    }
                    else if (idT3 == int.Parse(database1DataSet.Produit.Rows[i]["idDate"].ToString()))
                    {
                        valT3 = float.Parse(database1DataSet.Produit.Rows[i]["valProduit"].ToString());
                    }
                    else if (idT4 == int.Parse(database1DataSet.Produit.Rows[i]["idDate"].ToString()))
                    {
                        valT4 = float.Parse(database1DataSet.Produit.Rows[i]["valProduit"].ToString());
                    }
                }
            }

            chart1.Series[name].Points.AddXY("Trim-1", valT1);
            chart1.Series[name].Points.AddXY("Trim-2", valT2);
            chart1.Series[name].Points.AddXY("Trim-3", valT3);
            chart1.Series[name].Points.AddXY("Trim-4", valT4);
        }
    }
}
