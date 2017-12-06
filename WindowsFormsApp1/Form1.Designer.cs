namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWechseln = new System.Windows.Forms.Button();
            this.btnSuche = new System.Windows.Forms.Button();
            this.btnFrüher = new System.Windows.Forms.Button();
            this.btnSpäter = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtZiel = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtZeit = new System.Windows.Forms.TextBox();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.colVon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnkunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWechseln
            // 
            this.btnWechseln.Location = new System.Drawing.Point(37, 44);
            this.btnWechseln.Name = "btnWechseln";
            this.btnWechseln.Size = new System.Drawing.Size(75, 23);
            this.btnWechseln.TabIndex = 0;
            this.btnWechseln.Text = "Tausch";
            this.btnWechseln.UseVisualStyleBackColor = true;
            // 
            // btnSuche
            // 
            this.btnSuche.Location = new System.Drawing.Point(385, 45);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(75, 23);
            this.btnSuche.TabIndex = 1;
            this.btnSuche.Text = "Suchen";
            this.btnSuche.UseVisualStyleBackColor = true;
            this.btnSuche.Click += new System.EventHandler(this.btnSuche_Click);
            // 
            // btnFrüher
            // 
            this.btnFrüher.Location = new System.Drawing.Point(497, 99);
            this.btnFrüher.Name = "btnFrüher";
            this.btnFrüher.Size = new System.Drawing.Size(75, 23);
            this.btnFrüher.TabIndex = 2;
            this.btnFrüher.Text = "Früher";
            this.btnFrüher.UseVisualStyleBackColor = true;
            // 
            // btnSpäter
            // 
            this.btnSpäter.Location = new System.Drawing.Point(578, 99);
            this.btnSpäter.Name = "btnSpäter";
            this.btnSpäter.Size = new System.Drawing.Size(75, 23);
            this.btnSpäter.TabIndex = 3;
            this.btnSpäter.Text = "Später";
            this.btnSpäter.UseVisualStyleBackColor = true;
            // 
            // txtStart
            // 
            this.txtStart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStart.Location = new System.Drawing.Point(24, 16);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 22);
            this.txtStart.TabIndex = 4;
            this.txtStart.TextChanged += new System.EventHandler(this.txtStart_TextChanged);
            // 
            // txtZiel
            // 
            this.txtZiel.Location = new System.Drawing.Point(24, 73);
            this.txtZiel.Name = "txtZiel";
            this.txtZiel.Size = new System.Drawing.Size(100, 22);
            this.txtZiel.TabIndex = 5;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(173, 45);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(100, 22);
            this.txtDatum.TabIndex = 6;
            // 
            // txtZeit
            // 
            this.txtZeit.Location = new System.Drawing.Point(279, 45);
            this.txtZeit.Name = "txtZeit";
            this.txtZeit.Size = new System.Drawing.Size(100, 22);
            this.txtZeit.TabIndex = 7;
            // 
            // dgvPlan
            // 
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVon,
            this.colBis,
            this.colAbfahrt,
            this.colAnkunft,
            this.colDauer,
            this.colGleis});
            this.dgvPlan.Location = new System.Drawing.Point(12, 128);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.RowTemplate.Height = 24;
            this.dgvPlan.Size = new System.Drawing.Size(1020, 365);
            this.dgvPlan.TabIndex = 8;
            // 
            // colVon
            // 
            this.colVon.HeaderText = "Von";
            this.colVon.Name = "colVon";
            // 
            // colBis
            // 
            this.colBis.HeaderText = "Bis";
            this.colBis.Name = "colBis";
            // 
            // colAbfahrt
            // 
            this.colAbfahrt.HeaderText = "Abfahrt";
            this.colAbfahrt.Name = "colAbfahrt";
            // 
            // colAnkunft
            // 
            this.colAnkunft.HeaderText = "Ankunft";
            this.colAnkunft.Name = "colAnkunft";
            // 
            // colDauer
            // 
            this.colDauer.HeaderText = "Dauer";
            this.colDauer.Name = "colDauer";
            // 
            // colGleis
            // 
            this.colGleis.HeaderText = "Gleis";
            this.colGleis.Name = "colGleis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 505);
            this.Controls.Add(this.dgvPlan);
            this.Controls.Add(this.txtZeit);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtZiel);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.btnSpäter);
            this.Controls.Add(this.btnFrüher);
            this.Controls.Add(this.btnSuche);
            this.Controls.Add(this.btnWechseln);
            this.Name = "Form1";
            this.Text = "Fahrplan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWechseln;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.Button btnFrüher;
        private System.Windows.Forms.Button btnSpäter;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtZiel;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtZeit;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnkunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGleis;
    }
}

