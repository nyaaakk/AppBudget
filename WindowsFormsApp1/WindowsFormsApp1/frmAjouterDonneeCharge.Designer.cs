namespace WindowsFormsApp1
{
    partial class frmAjouterDonneeCharge
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
            this.chargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.cbxTrimestre = new System.Windows.Forms.ComboBox();
            this.trimestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxAnnee = new System.Windows.Forms.ComboBox();
            this.anneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxLib = new System.Windows.Forms.ComboBox();
            this.libelleChargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tbxVal = new System.Windows.Forms.TextBox();
            this.lblEntrerVal = new System.Windows.Forms.Label();
            this.lblChoisirAnnee = new System.Windows.Forms.Label();
            this.lblChoisirTrim = new System.Windows.Forms.Label();
            this.lblChoisirLib = new System.Windows.Forms.Label();
            this.dateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libelleChargeTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.LibelleChargeTableAdapter();
            this.dateTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.DateTableAdapter();
            this.chargeTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.ChargeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Database1DataSetTableAdapters.TableAdapterManager();
            this.anneeTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.AnneeTableAdapter();
            this.trimestreTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.TrimestreTableAdapter();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chargeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimestreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libelleChargeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBindingSource)).BeginInit();
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
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Ajouter des données";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.LightCoral;
            this.pnlForm.Controls.Add(this.cbxTrimestre);
            this.pnlForm.Controls.Add(this.cbxAnnee);
            this.pnlForm.Controls.Add(this.cbxLib);
            this.pnlForm.Controls.Add(this.btnAjouter);
            this.pnlForm.Controls.Add(this.tbxVal);
            this.pnlForm.Controls.Add(this.lblEntrerVal);
            this.pnlForm.Controls.Add(this.lblChoisirAnnee);
            this.pnlForm.Controls.Add(this.lblChoisirTrim);
            this.pnlForm.Controls.Add(this.lblChoisirLib);
            this.pnlForm.Location = new System.Drawing.Point(12, 60);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(760, 496);
            this.pnlForm.TabIndex = 2;
            // 
            // chargeBindingSource
            // 
            this.chargeBindingSource.DataMember = "Charge";
            this.chargeBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxTrimestre
            // 
            this.cbxTrimestre.DataSource = this.trimestreBindingSource;
            this.cbxTrimestre.DisplayMember = "trimestre";
            this.cbxTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTrimestre.FormattingEnabled = true;
            this.cbxTrimestre.Location = new System.Drawing.Point(379, 211);
            this.cbxTrimestre.Name = "cbxTrimestre";
            this.cbxTrimestre.Size = new System.Drawing.Size(301, 33);
            this.cbxTrimestre.TabIndex = 16;
            this.cbxTrimestre.ValueMember = "idTrimestre";
            // 
            // trimestreBindingSource
            // 
            this.trimestreBindingSource.DataMember = "Trimestre";
            this.trimestreBindingSource.DataSource = this.database1DataSet;
            // 
            // cbxAnnee
            // 
            this.cbxAnnee.DataSource = this.anneeBindingSource;
            this.cbxAnnee.DisplayMember = "annee";
            this.cbxAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnnee.FormattingEnabled = true;
            this.cbxAnnee.Location = new System.Drawing.Point(379, 130);
            this.cbxAnnee.Name = "cbxAnnee";
            this.cbxAnnee.Size = new System.Drawing.Size(301, 33);
            this.cbxAnnee.TabIndex = 15;
            this.cbxAnnee.ValueMember = "idAnnee";
            // 
            // anneeBindingSource
            // 
            this.anneeBindingSource.DataMember = "Annee";
            this.anneeBindingSource.DataSource = this.database1DataSet;
            // 
            // cbxLib
            // 
            this.cbxLib.DataSource = this.libelleChargeBindingSource;
            this.cbxLib.DisplayMember = "lib";
            this.cbxLib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLib.FormattingEnabled = true;
            this.cbxLib.Location = new System.Drawing.Point(379, 47);
            this.cbxLib.Name = "cbxLib";
            this.cbxLib.Size = new System.Drawing.Size(301, 33);
            this.cbxLib.TabIndex = 14;
            this.cbxLib.ValueMember = "idLib";
            this.cbxLib.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // libelleChargeBindingSource
            // 
            this.libelleChargeBindingSource.DataMember = "LibelleCharge";
            this.libelleChargeBindingSource.DataSource = this.database1DataSet;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.IndianRed;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(248, 410);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(270, 66);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // tbxVal
            // 
            this.tbxVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxVal.Location = new System.Drawing.Point(379, 294);
            this.tbxVal.Name = "tbxVal";
            this.tbxVal.Size = new System.Drawing.Size(301, 31);
            this.tbxVal.TabIndex = 9;
            // 
            // lblEntrerVal
            // 
            this.lblEntrerVal.AutoSize = true;
            this.lblEntrerVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrerVal.ForeColor = System.Drawing.Color.White;
            this.lblEntrerVal.Location = new System.Drawing.Point(199, 296);
            this.lblEntrerVal.Name = "lblEntrerVal";
            this.lblEntrerVal.Size = new System.Drawing.Size(174, 29);
            this.lblEntrerVal.TabIndex = 8;
            this.lblEntrerVal.Text = "Entrer la valeur";
            // 
            // lblChoisirAnnee
            // 
            this.lblChoisirAnnee.AutoSize = true;
            this.lblChoisirAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoisirAnnee.ForeColor = System.Drawing.Color.White;
            this.lblChoisirAnnee.Location = new System.Drawing.Point(141, 134);
            this.lblChoisirAnnee.Name = "lblChoisirAnnee";
            this.lblChoisirAnnee.Size = new System.Drawing.Size(232, 29);
            this.lblChoisirAnnee.TabIndex = 1;
            this.lblChoisirAnnee.Text = "Sélectionner l\'année";
            this.lblChoisirAnnee.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblChoisirTrim
            // 
            this.lblChoisirTrim.AutoSize = true;
            this.lblChoisirTrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoisirTrim.ForeColor = System.Drawing.Color.White;
            this.lblChoisirTrim.Location = new System.Drawing.Point(98, 215);
            this.lblChoisirTrim.Name = "lblChoisirTrim";
            this.lblChoisirTrim.Size = new System.Drawing.Size(275, 29);
            this.lblChoisirTrim.TabIndex = 1;
            this.lblChoisirTrim.Text = "Sélectionner le trimestre";
            // 
            // lblChoisirLib
            // 
            this.lblChoisirLib.AutoSize = true;
            this.lblChoisirLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoisirLib.ForeColor = System.Drawing.Color.White;
            this.lblChoisirLib.Location = new System.Drawing.Point(126, 51);
            this.lblChoisirLib.Name = "lblChoisirLib";
            this.lblChoisirLib.Size = new System.Drawing.Size(247, 29);
            this.lblChoisirLib.TabIndex = 0;
            this.lblChoisirLib.Text = "Sélectionner le libellé";
            // 
            // dateBindingSource
            // 
            this.dateBindingSource.DataMember = "Date";
            this.dateBindingSource.DataSource = this.database1DataSet;
            // 
            // libelleChargeTableAdapter
            // 
            this.libelleChargeTableAdapter.ClearBeforeFill = true;
            // 
            // dateTableAdapter
            // 
            this.dateTableAdapter.ClearBeforeFill = true;
            // 
            // chargeTableAdapter
            // 
            this.chargeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnneeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChargeTableAdapter = this.chargeTableAdapter;
            this.tableAdapterManager.DateTableAdapter = this.dateTableAdapter;
            this.tableAdapterManager.LibelleChargeTableAdapter = this.libelleChargeTableAdapter;
            this.tableAdapterManager.LibelleProduitTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = null;
            this.tableAdapterManager.TrimestreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // anneeTableAdapter
            // 
            this.anneeTableAdapter.ClearBeforeFill = true;
            // 
            // trimestreTableAdapter
            // 
            this.trimestreTableAdapter.ClearBeforeFill = true;
            // 
            // frmAjouterDonneeCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAjouterDonneeCharge";
            this.Text = "Ajouter charges";
            this.Load += new System.EventHandler(this.frmAjouterDonneeCharge_Load);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chargeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimestreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libelleChargeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblChoisirAnnee;
        private System.Windows.Forms.Label lblChoisirTrim;
        private System.Windows.Forms.Label lblChoisirLib;
        private System.Windows.Forms.TextBox tbxVal;
        private System.Windows.Forms.Label lblEntrerVal;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cbxTrimestre;
        private System.Windows.Forms.ComboBox cbxAnnee;
        private System.Windows.Forms.ComboBox cbxLib;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource libelleChargeBindingSource;
        private Database1DataSetTableAdapters.LibelleChargeTableAdapter libelleChargeTableAdapter;
        private System.Windows.Forms.BindingSource dateBindingSource;
        private Database1DataSetTableAdapters.DateTableAdapter dateTableAdapter;
        private System.Windows.Forms.BindingSource chargeBindingSource;
        private Database1DataSetTableAdapters.ChargeTableAdapter chargeTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource anneeBindingSource;
        private Database1DataSetTableAdapters.AnneeTableAdapter anneeTableAdapter;
        private System.Windows.Forms.BindingSource trimestreBindingSource;
        private Database1DataSetTableAdapters.TrimestreTableAdapter trimestreTableAdapter;
    }
}