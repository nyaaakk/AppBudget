namespace WindowsFormsApp1
{
    partial class frmTableau
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chargesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterLibelléToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphiqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerLibelléToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterDonnéesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.graphiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargesToolStripMenuItem,
            this.produitsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chargesToolStripMenuItem
            // 
            this.chargesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterLibelléToolStripMenuItem,
            this.ajouterDonnéesToolStripMenuItem,
            this.graphiqueToolStripMenuItem1});
            this.chargesToolStripMenuItem.Name = "chargesToolStripMenuItem";
            this.chargesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.chargesToolStripMenuItem.Text = "Charges";
            // 
            // ajouterLibelléToolStripMenuItem
            // 
            this.ajouterLibelléToolStripMenuItem.Name = "ajouterLibelléToolStripMenuItem";
            this.ajouterLibelléToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ajouterLibelléToolStripMenuItem.Text = "Gérer les libellés";
            this.ajouterLibelléToolStripMenuItem.Click += new System.EventHandler(this.ajouterLibelléToolStripMenuItem_Click);
            // 
            // ajouterDonnéesToolStripMenuItem
            // 
            this.ajouterDonnéesToolStripMenuItem.Name = "ajouterDonnéesToolStripMenuItem";
            this.ajouterDonnéesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ajouterDonnéesToolStripMenuItem.Text = "Ajouter des données";
            this.ajouterDonnéesToolStripMenuItem.Click += new System.EventHandler(this.ajouterDonnéesToolStripMenuItem_Click);
            // 
            // graphiqueToolStripMenuItem1
            // 
            this.graphiqueToolStripMenuItem1.Name = "graphiqueToolStripMenuItem1";
            this.graphiqueToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.graphiqueToolStripMenuItem1.Text = "Graphique";
            this.graphiqueToolStripMenuItem1.Click += new System.EventHandler(this.graphiqueToolStripMenuItem1_Click);
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerLibelléToolStripMenuItem,
            this.ajouterDonnéesToolStripMenuItem1,
            this.graphiqueToolStripMenuItem});
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.produitsToolStripMenuItem.Text = "Produits";
            // 
            // créerLibelléToolStripMenuItem
            // 
            this.créerLibelléToolStripMenuItem.Name = "créerLibelléToolStripMenuItem";
            this.créerLibelléToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.créerLibelléToolStripMenuItem.Text = "Gérer les libellés";
            this.créerLibelléToolStripMenuItem.Click += new System.EventHandler(this.créerLibelléToolStripMenuItem_Click);
            // 
            // ajouterDonnéesToolStripMenuItem1
            // 
            this.ajouterDonnéesToolStripMenuItem1.Name = "ajouterDonnéesToolStripMenuItem1";
            this.ajouterDonnéesToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.ajouterDonnéesToolStripMenuItem1.Text = "Ajouter des données";
            this.ajouterDonnéesToolStripMenuItem1.Click += new System.EventHandler(this.ajouterDonnéesToolStripMenuItem1_Click);
            // 
            // graphiqueToolStripMenuItem
            // 
            this.graphiqueToolStripMenuItem.Name = "graphiqueToolStripMenuItem";
            this.graphiqueToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.graphiqueToolStripMenuItem.Text = "Graphique";
            this.graphiqueToolStripMenuItem.Click += new System.EventHandler(this.graphiqueToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tableau de Bord";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(54, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 383);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(153, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 231);
            this.label2.TabIndex = 0;
            this.label2.Text = "-Naviguer avec le menu déroulant\r\n\r\n-Créer des libellés\r\n\r\n-Ajouter des valeurs\r\n" +
    "\r\n-Analyser les graphiques\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(877, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTableau";
            this.Text = "Tableau de bord";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chargesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterLibelléToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerLibelléToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterDonnéesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem graphiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphiqueToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}