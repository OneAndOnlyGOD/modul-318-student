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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listZiel = new System.Windows.Forms.ListBox();
            this.listStart = new System.Windows.Forms.ListBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtZiel = new System.Windows.Forms.TextBox();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.colVon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnkunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuche = new System.Windows.Forms.Button();
            this.btnWechseln = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listStationBoard = new System.Windows.Forms.ListBox();
            this.dgvStationboard = new System.Windows.Forms.DataGridView();
            this.colBis1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbfahrt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGleis1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStationSuche = new System.Windows.Forms.Button();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.btnMaps = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationboard)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 481);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listZiel);
            this.tabPage1.Controls.Add(this.listStart);
            this.tabPage1.Controls.Add(this.txtStart);
            this.tabPage1.Controls.Add(this.txtZiel);
            this.tabPage1.Controls.Add(this.dgvPlan);
            this.tabPage1.Controls.Add(this.btnSuche);
            this.tabPage1.Controls.Add(this.btnWechseln);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1012, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listZiel
            // 
            this.listZiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listZiel.FormattingEnabled = true;
            this.listZiel.ItemHeight = 25;
            this.listZiel.Location = new System.Drawing.Point(384, 32);
            this.listZiel.Name = "listZiel";
            this.listZiel.Size = new System.Drawing.Size(323, 179);
            this.listZiel.TabIndex = 20;
            this.listZiel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listZiel_MouseDoubleClick);
            // 
            // listStart
            // 
            this.listStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listStart.FormattingEnabled = true;
            this.listStart.ItemHeight = 25;
            this.listStart.Location = new System.Drawing.Point(6, 32);
            this.listStart.Name = "listStart";
            this.listStart.Size = new System.Drawing.Size(323, 179);
            this.listStart.TabIndex = 19;
            this.listStart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listStart_MouseDoubleClick);
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStart.Location = new System.Drawing.Point(6, 6);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(323, 30);
            this.txtStart.TabIndex = 1;
            this.txtStart.TextChanged += new System.EventHandler(this.txtStart_TextChanged);
            this.txtStart.Leave += new System.EventHandler(this.txtStart_Leave);
            // 
            // txtZiel
            // 
            this.txtZiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtZiel.Location = new System.Drawing.Point(384, 6);
            this.txtZiel.Name = "txtZiel";
            this.txtZiel.Size = new System.Drawing.Size(323, 30);
            this.txtZiel.TabIndex = 2;
            this.txtZiel.TextChanged += new System.EventHandler(this.txtZiel_TextChanged);
            this.txtZiel.Leave += new System.EventHandler(this.txtZiel_Leave);
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
            this.dgvPlan.Location = new System.Drawing.Point(6, 96);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.ReadOnly = true;
            this.dgvPlan.RowTemplate.Height = 24;
            this.dgvPlan.Size = new System.Drawing.Size(1000, 326);
            this.dgvPlan.TabIndex = 16;
            // 
            // colVon
            // 
            this.colVon.HeaderText = "Von";
            this.colVon.Name = "colVon";
            this.colVon.ReadOnly = true;
            // 
            // colBis
            // 
            this.colBis.HeaderText = "Bis";
            this.colBis.Name = "colBis";
            this.colBis.ReadOnly = true;
            // 
            // colAbfahrt
            // 
            this.colAbfahrt.HeaderText = "Abfahrt";
            this.colAbfahrt.Name = "colAbfahrt";
            this.colAbfahrt.ReadOnly = true;
            // 
            // colAnkunft
            // 
            this.colAnkunft.HeaderText = "Ankunft";
            this.colAnkunft.Name = "colAnkunft";
            this.colAnkunft.ReadOnly = true;
            // 
            // colDauer
            // 
            this.colDauer.HeaderText = "Dauer";
            this.colDauer.Name = "colDauer";
            this.colDauer.ReadOnly = true;
            // 
            // colGleis
            // 
            this.colGleis.HeaderText = "Gleis";
            this.colGleis.Name = "colGleis";
            this.colGleis.ReadOnly = true;
            // 
            // btnSuche
            // 
            this.btnSuche.Location = new System.Drawing.Point(713, 6);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(115, 30);
            this.btnSuche.TabIndex = 3;
            this.btnSuche.Text = "Suchen";
            this.btnSuche.UseVisualStyleBackColor = true;
            this.btnSuche.Click += new System.EventHandler(this.btnSuche_Click);
            // 
            // btnWechseln
            // 
            this.btnWechseln.Location = new System.Drawing.Point(335, 6);
            this.btnWechseln.Name = "btnWechseln";
            this.btnWechseln.Size = new System.Drawing.Size(43, 30);
            this.btnWechseln.TabIndex = 0;
            this.btnWechseln.TabStop = false;
            this.btnWechseln.Text = "<->";
            this.btnWechseln.UseVisualStyleBackColor = true;
            this.btnWechseln.Click += new System.EventHandler(this.btnWechseln_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnMaps);
            this.tabPage2.Controls.Add(this.listStationBoard);
            this.tabPage2.Controls.Add(this.dgvStationboard);
            this.tabPage2.Controls.Add(this.btnStationSuche);
            this.tabPage2.Controls.Add(this.txtStation);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1012, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listStationBoard
            // 
            this.listStationBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listStationBoard.FormattingEnabled = true;
            this.listStationBoard.ItemHeight = 25;
            this.listStationBoard.Location = new System.Drawing.Point(6, 40);
            this.listStationBoard.Name = "listStationBoard";
            this.listStationBoard.Size = new System.Drawing.Size(323, 179);
            this.listStationBoard.TabIndex = 22;
            this.listStationBoard.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listStationBoard_MouseDoubleClick);
            // 
            // dgvStationboard
            // 
            this.dgvStationboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStationboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBis1,
            this.colName,
            this.colAbfahrt1,
            this.colGleis1});
            this.dgvStationboard.Location = new System.Drawing.Point(3, 92);
            this.dgvStationboard.Name = "dgvStationboard";
            this.dgvStationboard.ReadOnly = true;
            this.dgvStationboard.RowTemplate.Height = 24;
            this.dgvStationboard.Size = new System.Drawing.Size(1000, 354);
            this.dgvStationboard.TabIndex = 21;
            // 
            // colBis1
            // 
            this.colBis1.HeaderText = "Bis";
            this.colBis1.Name = "colBis1";
            this.colBis1.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Nummer";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colAbfahrt1
            // 
            this.colAbfahrt1.HeaderText = "Abfahrt";
            this.colAbfahrt1.Name = "colAbfahrt1";
            this.colAbfahrt1.ReadOnly = true;
            // 
            // colGleis1
            // 
            this.colGleis1.HeaderText = "Gleis";
            this.colGleis1.Name = "colGleis1";
            this.colGleis1.ReadOnly = true;
            // 
            // btnStationSuche
            // 
            this.btnStationSuche.Location = new System.Drawing.Point(390, 13);
            this.btnStationSuche.Name = "btnStationSuche";
            this.btnStationSuche.Size = new System.Drawing.Size(115, 30);
            this.btnStationSuche.TabIndex = 2;
            this.btnStationSuche.Text = "Suchen";
            this.btnStationSuche.UseVisualStyleBackColor = true;
            this.btnStationSuche.Click += new System.EventHandler(this.btnStationSuche_Click);
            // 
            // txtStation
            // 
            this.txtStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStation.Location = new System.Drawing.Point(6, 13);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(323, 30);
            this.txtStation.TabIndex = 1;
            this.txtStation.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
            // 
            // btnMaps
            // 
            this.btnMaps.Image = ((System.Drawing.Image)(resources.GetObject("btnMaps.Image")));
            this.btnMaps.Location = new System.Drawing.Point(335, 6);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(49, 45);
            this.btnMaps.TabIndex = 23;
            this.btnMaps.UseVisualStyleBackColor = true;
            this.btnMaps.Click += new System.EventHandler(this.btnMaps_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 505);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = " ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listZiel;
        private System.Windows.Forms.ListBox listStart;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtZiel;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnkunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGleis;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.Button btnWechseln;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvStationboard;
        private System.Windows.Forms.Button btnStationSuche;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.ListBox listStationBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBis1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbfahrt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGleis1;
        private System.Windows.Forms.Button btnMaps;
    }
}

