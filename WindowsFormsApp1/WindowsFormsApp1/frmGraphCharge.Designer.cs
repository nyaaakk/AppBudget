namespace WindowsFormsApp1
{
    partial class frmGraphCharge
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cbxLib = new System.Windows.Forms.ComboBox();
            this.libelleChargeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.cbxAnnee = new System.Windows.Forms.ComboBox();
            this.anneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.libelleChargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libelleChargeTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.LibelleChargeTableAdapter();
            this.chargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chargeTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.ChargeTableAdapter();
            this.dateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.DateTableAdapter();
            this.anneeTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.AnneeTableAdapter();
            this.lblCreerLib = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libelleChargeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libelleChargeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.IndianRed;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(578, 22);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(136, 66);
            this.btnAjouter.TabIndex = 18;
            this.btnAjouter.Text = "Actualiser";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cbxLib
            // 
            this.cbxLib.DataSource = this.libelleChargeBindingSource1;
            this.cbxLib.DisplayMember = "lib";
            this.cbxLib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLib.FormattingEnabled = true;
            this.cbxLib.Location = new System.Drawing.Point(291, 13);
            this.cbxLib.Name = "cbxLib";
            this.cbxLib.Size = new System.Drawing.Size(271, 33);
            this.cbxLib.TabIndex = 17;
            this.cbxLib.ValueMember = "idLib";
            // 
            // libelleChargeBindingSource1
            // 
            this.libelleChargeBindingSource1.DataMember = "LibelleCharge";
            this.libelleChargeBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxAnnee
            // 
            this.cbxAnnee.DataSource = this.anneeBindingSource;
            this.cbxAnnee.DisplayMember = "annee";
            this.cbxAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnnee.FormattingEnabled = true;
            this.cbxAnnee.Location = new System.Drawing.Point(291, 64);
            this.cbxAnnee.Name = "cbxAnnee";
            this.cbxAnnee.Size = new System.Drawing.Size(271, 33);
            this.cbxAnnee.TabIndex = 16;
            this.cbxAnnee.ValueMember = "annee";
            // 
            // anneeBindingSource
            // 
            this.anneeBindingSource.DataMember = "Annee";
            this.anneeBindingSource.DataSource = this.database1DataSet;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 113);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(760, 436);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // libelleChargeBindingSource
            // 
            this.libelleChargeBindingSource.DataMember = "LibelleCharge";
            this.libelleChargeBindingSource.DataSource = this.database1DataSet;
            // 
            // libelleChargeTableAdapter
            // 
            this.libelleChargeTableAdapter.ClearBeforeFill = true;
            // 
            // chargeBindingSource
            // 
            this.chargeBindingSource.DataMember = "Charge";
            this.chargeBindingSource.DataSource = this.database1DataSet;
            // 
            // chargeTableAdapter
            // 
            this.chargeTableAdapter.ClearBeforeFill = true;
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
            // anneeTableAdapter
            // 
            this.anneeTableAdapter.ClearBeforeFill = true;
            // 
            // lblCreerLib
            // 
            this.lblCreerLib.AutoSize = true;
            this.lblCreerLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreerLib.ForeColor = System.Drawing.Color.White;
            this.lblCreerLib.Location = new System.Drawing.Point(92, 17);
            this.lblCreerLib.Name = "lblCreerLib";
            this.lblCreerLib.Size = new System.Drawing.Size(193, 29);
            this.lblCreerLib.TabIndex = 19;
            this.lblCreerLib.Text = "Choisir un libellé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Choisir une année";
            // 
            // frmGraphCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreerLib);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbxLib);
            this.Controls.Add(this.cbxAnnee);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGraphCharge";
            this.Text = "frmGraphCharge";
            this.Load += new System.EventHandler(this.frmGraphCharge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libelleChargeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anneeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libelleChargeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cbxLib;
        private System.Windows.Forms.ComboBox cbxAnnee;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource libelleChargeBindingSource;
        private Database1DataSetTableAdapters.LibelleChargeTableAdapter libelleChargeTableAdapter;
        private System.Windows.Forms.BindingSource chargeBindingSource;
        private Database1DataSetTableAdapters.ChargeTableAdapter chargeTableAdapter;
        private System.Windows.Forms.BindingSource dateBindingSource;
        private Database1DataSetTableAdapters.DateTableAdapter dateTableAdapter;
        private System.Windows.Forms.BindingSource libelleChargeBindingSource1;
        private System.Windows.Forms.BindingSource anneeBindingSource;
        private Database1DataSetTableAdapters.AnneeTableAdapter anneeTableAdapter;
        private System.Windows.Forms.Label lblCreerLib;
        private System.Windows.Forms.Label label1;
    }
}