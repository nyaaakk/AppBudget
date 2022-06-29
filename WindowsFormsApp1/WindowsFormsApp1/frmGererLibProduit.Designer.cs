namespace WindowsFormsApp1
{
    partial class frmGererLibProduit
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
            this.libelleProduitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.lbxListeLib = new System.Windows.Forms.ListBox();
            this.lblErreur = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblListeLib = new System.Windows.Forms.Label();
            this.tbxNomLib = new System.Windows.Forms.TextBox();
            this.lblCreerLib = new System.Windows.Forms.Label();
            this.libelleProduitTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.LibelleProduitTableAdapter();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libelleProduitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(0, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(784, 561);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Gérer les libellés";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlForm.Controls.Add(this.lbxListeLib);
            this.pnlForm.Controls.Add(this.lblErreur);
            this.pnlForm.Controls.Add(this.btnAjouter);
            this.pnlForm.Controls.Add(this.btnSupprimer);
            this.pnlForm.Controls.Add(this.lblListeLib);
            this.pnlForm.Controls.Add(this.tbxNomLib);
            this.pnlForm.Controls.Add(this.lblCreerLib);
            this.pnlForm.Location = new System.Drawing.Point(12, 62);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(760, 487);
            this.pnlForm.TabIndex = 2;
            // 
            // libelleProduitBindingSource
            // 
            this.libelleProduitBindingSource.DataMember = "LibelleProduit";
            this.libelleProduitBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbxListeLib
            // 
            this.lbxListeLib.DataSource = this.libelleProduitBindingSource;
            this.lbxListeLib.DisplayMember = "lib";
            this.lbxListeLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxListeLib.FormattingEnabled = true;
            this.lbxListeLib.ItemHeight = 25;
            this.lbxListeLib.Location = new System.Drawing.Point(471, 53);
            this.lbxListeLib.Name = "lbxListeLib";
            this.lbxListeLib.Size = new System.Drawing.Size(266, 329);
            this.lbxListeLib.TabIndex = 7;
            this.lbxListeLib.ValueMember = "idLib";
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.BackColor = System.Drawing.Color.SlateBlue;
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.Indigo;
            this.lblErreur.Location = new System.Drawing.Point(44, 227);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(246, 29);
            this.lblErreur.TabIndex = 6;
            this.lblErreur.Text = "Le libellé existe déjà !";
            this.lblErreur.Visible = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(29, 158);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(270, 66);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(471, 406);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(266, 66);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lblListeLib
            // 
            this.lblListeLib.AutoSize = true;
            this.lblListeLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeLib.ForeColor = System.Drawing.Color.White;
            this.lblListeLib.Location = new System.Drawing.Point(466, 12);
            this.lblListeLib.Name = "lblListeLib";
            this.lblListeLib.Size = new System.Drawing.Size(271, 29);
            this.lblListeLib.TabIndex = 3;
            this.lblListeLib.Text = "Liste de tous les libellés";
            // 
            // tbxNomLib
            // 
            this.tbxNomLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNomLib.Location = new System.Drawing.Point(29, 82);
            this.tbxNomLib.Name = "tbxNomLib";
            this.tbxNomLib.Size = new System.Drawing.Size(270, 31);
            this.tbxNomLib.TabIndex = 2;
            this.tbxNomLib.Text = "Entrer le nom du libellé";
            // 
            // lblCreerLib
            // 
            this.lblCreerLib.AutoSize = true;
            this.lblCreerLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreerLib.ForeColor = System.Drawing.Color.White;
            this.lblCreerLib.Location = new System.Drawing.Point(24, 12);
            this.lblCreerLib.Name = "lblCreerLib";
            this.lblCreerLib.Size = new System.Drawing.Size(275, 29);
            this.lblCreerLib.TabIndex = 0;
            this.lblCreerLib.Text = "Créer un nouveau libellé";
            // 
            // libelleProduitTableAdapter
            // 
            this.libelleProduitTableAdapter.ClearBeforeFill = true;
            // 
            // frmGererLibProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGererLibProduit";
            this.Text = "Gérer produits";
            this.Load += new System.EventHandler(this.frmGererLibProduit_Load);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libelleProduitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblListeLib;
        private System.Windows.Forms.TextBox tbxNomLib;
        private System.Windows.Forms.Label lblCreerLib;
        private System.Windows.Forms.ListBox lbxListeLib;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource libelleProduitBindingSource;
        private Database1DataSetTableAdapters.LibelleProduitTableAdapter libelleProduitTableAdapter;
    }
}