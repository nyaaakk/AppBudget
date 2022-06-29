namespace WindowsFormsApp1
{
    partial class frmGraphProduit
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxAnnee = new System.Windows.Forms.ComboBox();
            this.anneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.cbxLib = new System.Windows.Forms.ComboBox();
            this.libelleProduitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjouter = new System.Windows.Forms.Button();
            this.libelleProduitTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.LibelleProduitTableAdapter();
            this.anneeTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.AnneeTableAdapter();
            this.dateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.DateTableAdapter();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.ProduitTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCreerLib = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libelleProduitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(12, 113);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(760, 436);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // cbxAnnee
            // 
            this.cbxAnnee.DataSource = this.anneeBindingSource;
            this.cbxAnnee.DisplayMember = "annee";
            this.cbxAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnnee.FormattingEnabled = true;
            this.cbxAnnee.Location = new System.Drawing.Point(292, 65);
            this.cbxAnnee.Name = "cbxAnnee";
            this.cbxAnnee.Size = new System.Drawing.Size(271, 33);
            this.cbxAnnee.TabIndex = 12;
            this.cbxAnnee.ValueMember = "annee";
            // 
            // anneeBindingSource
            // 
            this.anneeBindingSource.DataMember = "Annee";
            this.anneeBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxLib
            // 
            this.cbxLib.DataSource = this.libelleProduitBindingSource;
            this.cbxLib.DisplayMember = "lib";
            this.cbxLib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLib.FormattingEnabled = true;
            this.cbxLib.Location = new System.Drawing.Point(292, 12);
            this.cbxLib.Name = "cbxLib";
            this.cbxLib.Size = new System.Drawing.Size(271, 33);
            this.cbxLib.TabIndex = 13;
            this.cbxLib.ValueMember = "idLib";
            // 
            // libelleProduitBindingSource
            // 
            this.libelleProduitBindingSource.DataMember = "LibelleProduit";
            this.libelleProduitBindingSource.DataSource = this.database1DataSet;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(578, 22);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(136, 66);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Actualiser";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // libelleProduitTableAdapter
            // 
            this.libelleProduitTableAdapter.ClearBeforeFill = true;
            // 
            // anneeTableAdapter
            // 
            this.anneeTableAdapter.ClearBeforeFill = true;
            // 
            // dateBindingSource
            // 
            this.dateBindingSource.DataMember = "Date";
            this.dateBindingSource.DataSource = this.database1DataSet;
            // 
            // dateTableAdapter
            // 
            this.dateTableAdapter.ClearBeforeFill = true;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.database1DataSet;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Choisir une année";
            // 
            // lblCreerLib
            // 
            this.lblCreerLib.AutoSize = true;
            this.lblCreerLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreerLib.ForeColor = System.Drawing.Color.White;
            this.lblCreerLib.Location = new System.Drawing.Point(93, 16);
            this.lblCreerLib.Name = "lblCreerLib";
            this.lblCreerLib.Size = new System.Drawing.Size(193, 29);
            this.lblCreerLib.TabIndex = 21;
            this.lblCreerLib.Text = "Choisir un libellé";
            // 
            // frmGraphProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreerLib);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbxLib);
            this.Controls.Add(this.cbxAnnee);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGraphProduit";
            this.Text = "frmGraphProduit";
            this.Load += new System.EventHandler(this.frmGraphProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libelleProduitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cbxAnnee;
        private System.Windows.Forms.ComboBox cbxLib;
        private System.Windows.Forms.Button btnAjouter;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource libelleProduitBindingSource;
        private Database1DataSetTableAdapters.LibelleProduitTableAdapter libelleProduitTableAdapter;
        private System.Windows.Forms.BindingSource anneeBindingSource;
        private Database1DataSetTableAdapters.AnneeTableAdapter anneeTableAdapter;
        private System.Windows.Forms.BindingSource dateBindingSource;
        private Database1DataSetTableAdapters.DateTableAdapter dateTableAdapter;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private Database1DataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreerLib;
    }
}