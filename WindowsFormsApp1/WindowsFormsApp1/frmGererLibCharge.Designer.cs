namespace WindowsFormsApp1
{
    partial class frmGererLibCharge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.libelleChargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.lblErreur = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblListeLib = new System.Windows.Forms.Label();
            this.tbxNomLib = new System.Windows.Forms.TextBox();
            this.lbxListeLib = new System.Windows.Forms.ListBox();
            this.lblCreerLib = new System.Windows.Forms.Label();
            this.libelleChargeTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.LibelleChargeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Database1DataSetTableAdapters.TableAdapterManager();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libelleChargeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(0, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(784, 561);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gérer les libellés";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.LightCoral;
            this.pnlForm.Controls.Add(this.lblErreur);
            this.pnlForm.Controls.Add(this.btnAjouter);
            this.pnlForm.Controls.Add(this.btnSupprimer);
            this.pnlForm.Controls.Add(this.lblListeLib);
            this.pnlForm.Controls.Add(this.tbxNomLib);
            this.pnlForm.Controls.Add(this.lbxListeLib);
            this.pnlForm.Controls.Add(this.lblCreerLib);
            this.pnlForm.Location = new System.Drawing.Point(12, 66);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(762, 487);
            this.pnlForm.TabIndex = 1;
            // 
            // libelleChargeBindingSource
            // 
            this.libelleChargeBindingSource.DataMember = "LibelleCharge";
            this.libelleChargeBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.BackColor = System.Drawing.Color.LightCoral;
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.Brown;
            this.lblErreur.Location = new System.Drawing.Point(39, 227);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(246, 29);
            this.lblErreur.TabIndex = 6;
            this.lblErreur.Text = "Le libellé existe déjà !";
            this.lblErreur.Visible = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.IndianRed;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(24, 158);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(270, 66);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.IndianRed;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(476, 400);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(266, 66);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // lblListeLib
            // 
            this.lblListeLib.AutoSize = true;
            this.lblListeLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeLib.ForeColor = System.Drawing.Color.White;
            this.lblListeLib.Location = new System.Drawing.Point(471, 11);
            this.lblListeLib.Name = "lblListeLib";
            this.lblListeLib.Size = new System.Drawing.Size(271, 29);
            this.lblListeLib.TabIndex = 3;
            this.lblListeLib.Text = "Liste de tous les libellés";
            // 
            // tbxNomLib
            // 
            this.tbxNomLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNomLib.Location = new System.Drawing.Point(24, 82);
            this.tbxNomLib.Name = "tbxNomLib";
            this.tbxNomLib.Size = new System.Drawing.Size(270, 31);
            this.tbxNomLib.TabIndex = 2;
            this.tbxNomLib.Text = "Entrer le nom du libellé";
            // 
            // lbxListeLib
            // 
            this.lbxListeLib.DataSource = this.libelleChargeBindingSource;
            this.lbxListeLib.DisplayMember = "lib";
            this.lbxListeLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxListeLib.FormattingEnabled = true;
            this.lbxListeLib.ItemHeight = 25;
            this.lbxListeLib.Location = new System.Drawing.Point(476, 43);
            this.lbxListeLib.Name = "lbxListeLib";
            this.lbxListeLib.Size = new System.Drawing.Size(266, 329);
            this.lbxListeLib.TabIndex = 1;
            this.lbxListeLib.ValueMember = "idLib";
            // 
            // lblCreerLib
            // 
            this.lblCreerLib.AutoSize = true;
            this.lblCreerLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreerLib.ForeColor = System.Drawing.Color.White;
            this.lblCreerLib.Location = new System.Drawing.Point(19, 12);
            this.lblCreerLib.Name = "lblCreerLib";
            this.lblCreerLib.Size = new System.Drawing.Size(275, 29);
            this.lblCreerLib.TabIndex = 0;
            this.lblCreerLib.Text = "Créer un nouveau libellé";
            // 
            // libelleChargeTableAdapter
            // 
            this.libelleChargeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnneeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChargeTableAdapter = null;
            this.tableAdapterManager.DateTableAdapter = null;
            this.tableAdapterManager.LibelleChargeTableAdapter = this.libelleChargeTableAdapter;
            this.tableAdapterManager.LibelleProduitTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = null;
            this.tableAdapterManager.TrimestreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmGererLibCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGererLibCharge";
            this.Text = "frmAjoutLibCharge";
            this.Load += new System.EventHandler(this.frmAjoutLibCharge_Load);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libelleChargeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblCreerLib;
        private System.Windows.Forms.Label lblListeLib;
        private System.Windows.Forms.TextBox tbxNomLib;
        private System.Windows.Forms.ListBox lbxListeLib;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource libelleChargeBindingSource;
        private Database1DataSetTableAdapters.LibelleChargeTableAdapter libelleChargeTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}