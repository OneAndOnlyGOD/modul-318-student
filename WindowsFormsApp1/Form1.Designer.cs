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
            this.tabConnection = new System.Windows.Forms.TabControl();
            this.tabConn = new System.Windows.Forms.TabPage();
            this.btnMapZiel = new System.Windows.Forms.Button();
            this.btnMapStart = new System.Windows.Forms.Button();
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
            this.tabStationplan = new System.Windows.Forms.TabPage();
            this.btnMaps = new System.Windows.Forms.Button();
            this.listStationBoard = new System.Windows.Forms.ListBox();
            this.dgvStationboard = new System.Windows.Forms.DataGridView();
            this.colBis1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbfahrt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGleis1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStationSuche = new System.Windows.Forms.Button();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.tabConnection.SuspendLayout();
            this.tabConn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.tabStationplan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationboard)).BeginInit();
            this.SuspendLayout();
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.tabConn);
            this.tabConnection.Controls.Add(this.tabStationplan);
            this.tabConnection.Location = new System.Drawing.Point(12, 5);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.SelectedIndex = 0;
            this.tabConnection.Size = new System.Drawing.Size(1020, 481);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.TabStop = false;
            this.tabConnection.SelectedIndexChanged += new System.EventHandler(this.tabConnection_SelectedIndexChanged);
            // 
            // tabConn
            // 
            this.tabConn.Controls.Add(this.btnMapZiel);
            this.tabConn.Controls.Add(this.btnMapStart);
            this.tabConn.Controls.Add(this.listZiel);
            this.tabConn.Controls.Add(this.listStart);
            this.tabConn.Controls.Add(this.txtStart);
            this.tabConn.Controls.Add(this.txtZiel);
            this.tabConn.Controls.Add(this.dgvPlan);
            this.tabConn.Controls.Add(this.btnSuche);
            this.tabConn.Controls.Add(this.btnWechseln);
            this.tabConn.Location = new System.Drawing.Point(4, 25);
            this.tabConn.Name = "tabConn";
            this.tabConn.Padding = new System.Windows.Forms.Padding(3);
            this.tabConn.Size = new System.Drawing.Size(1012, 452);
            this.tabConn.TabIndex = 0;
            this.tabConn.Text = "Verbindungen";
            this.tabConn.UseVisualStyleBackColor = true;
            // 
            // btnMapZiel
            // 
            this.btnMapZiel.Image = ((System.Drawing.Image)(resources.GetObject("btnMapZiel.Image")));
            this.btnMapZiel.Location = new System.Drawing.Point(769, 21);
            this.btnMapZiel.Name = "btnMapZiel";
            this.btnMapZiel.Size = new System.Drawing.Size(50, 50);
            this.btnMapZiel.TabIndex = 25;
            this.btnMapZiel.TabStop = false;
            this.btnMapZiel.UseVisualStyleBackColor = true;
            this.btnMapZiel.Click += new System.EventHandler(this.btnMapZiel_Click);
            // 
            // btnMapStart
            // 
            this.btnMapStart.Image = ((System.Drawing.Image)(resources.GetObject("btnMapStart.Image")));
            this.btnMapStart.Location = new System.Drawing.Point(335, 21);
            this.btnMapStart.Name = "btnMapStart";
            this.btnMapStart.Size = new System.Drawing.Size(50, 50);
            this.btnMapStart.TabIndex = 24;
            this.btnMapStart.TabStop = false;
            this.btnMapStart.UseVisualStyleBackColor = true;
            this.btnMapStart.Click += new System.EventHandler(this.btnMapStart_Click);
            // 
            // listZiel
            // 
            this.listZiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listZiel.FormattingEnabled = true;
            this.listZiel.ItemHeight = 25;
            this.listZiel.Location = new System.Drawing.Point(440, 57);
            this.listZiel.Name = "listZiel";
            this.listZiel.Size = new System.Drawing.Size(323, 179);
            this.listZiel.TabIndex = 20;
            this.listZiel.TabStop = false;
            this.listZiel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listZiel_MouseDoubleClick);
            // 
            // listStart
            // 
            this.listStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listStart.FormattingEnabled = true;
            this.listStart.ItemHeight = 25;
            this.listStart.Location = new System.Drawing.Point(6, 58);
            this.listStart.Name = "listStart";
            this.listStart.Size = new System.Drawing.Size(323, 179);
            this.listStart.TabIndex = 19;
            this.listStart.TabStop = false;
            this.listStart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listStart_MouseDoubleClick);
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStart.Location = new System.Drawing.Point(6, 31);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(323, 30);
            this.txtStart.TabIndex = 1;
            this.txtStart.TextChanged += new System.EventHandler(this.txtStart_TextChanged);
            this.txtStart.Leave += new System.EventHandler(this.txtStart_Leave);
            this.txtStart.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtStart_PreviewKeyDown);
            // 
            // txtZiel
            // 
            this.txtZiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtZiel.Location = new System.Drawing.Point(440, 31);
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
            this.dgvPlan.RowHeadersVisible = false;
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
            this.btnSuche.Location = new System.Drawing.Point(825, 31);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(115, 30);
            this.btnSuche.TabIndex = 3;
            this.btnSuche.Text = "Suchen";
            this.btnSuche.UseVisualStyleBackColor = true;
            this.btnSuche.Click += new System.EventHandler(this.btnSuche_Click);
            // 
            // btnWechseln
            // 
            this.btnWechseln.Location = new System.Drawing.Point(391, 31);
            this.btnWechseln.Name = "btnWechseln";
            this.btnWechseln.Size = new System.Drawing.Size(43, 30);
            this.btnWechseln.TabIndex = 0;
            this.btnWechseln.TabStop = false;
            this.btnWechseln.Text = "<->";
            this.btnWechseln.UseVisualStyleBackColor = true;
            this.btnWechseln.Click += new System.EventHandler(this.btnWechseln_Click);
            // 
            // tabStationplan
            // 
            this.tabStationplan.Controls.Add(this.btnMaps);
            this.tabStationplan.Controls.Add(this.listStationBoard);
            this.tabStationplan.Controls.Add(this.dgvStationboard);
            this.tabStationplan.Controls.Add(this.btnStationSuche);
            this.tabStationplan.Controls.Add(this.txtStation);
            this.tabStationplan.Location = new System.Drawing.Point(4, 25);
            this.tabStationplan.Name = "tabStationplan";
            this.tabStationplan.Padding = new System.Windows.Forms.Padding(3);
            this.tabStationplan.Size = new System.Drawing.Size(1012, 452);
            this.tabStationplan.TabIndex = 1;
            this.tabStationplan.Text = "Stationsplan";
            this.tabStationplan.UseVisualStyleBackColor = true;
            // 
            // btnMaps
            // 
            this.btnMaps.Image = ((System.Drawing.Image)(resources.GetObject("btnMaps.Image")));
            this.btnMaps.Location = new System.Drawing.Point(335, 21);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(50, 50);
            this.btnMaps.TabIndex = 23;
            this.btnMaps.TabStop = false;
            this.btnMaps.UseVisualStyleBackColor = true;
            this.btnMaps.Click += new System.EventHandler(this.btnMaps_Click);
            // 
            // listStationBoard
            // 
            this.listStationBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listStationBoard.FormattingEnabled = true;
            this.listStationBoard.ItemHeight = 25;
            this.listStationBoard.Location = new System.Drawing.Point(6, 58);
            this.listStationBoard.Name = "listStationBoard";
            this.listStationBoard.Size = new System.Drawing.Size(323, 179);
            this.listStationBoard.TabIndex = 22;
            this.listStationBoard.TabStop = false;
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
            this.dgvStationboard.Location = new System.Drawing.Point(6, 92);
            this.dgvStationboard.Name = "dgvStationboard";
            this.dgvStationboard.ReadOnly = true;
            this.dgvStationboard.RowHeadersVisible = false;
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
            this.btnStationSuche.Location = new System.Drawing.Point(391, 31);
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
            this.txtStation.Location = new System.Drawing.Point(6, 31);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(323, 30);
            this.txtStation.TabIndex = 1;
            this.txtStation.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 498);
            this.Controls.Add(this.tabConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabConnection.ResumeLayout(false);
            this.tabConn.ResumeLayout(false);
            this.tabConn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.tabStationplan.ResumeLayout(false);
            this.tabStationplan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConnection;
        private System.Windows.Forms.TabPage tabConn;
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
        private System.Windows.Forms.TabPage tabStationplan;
        private System.Windows.Forms.DataGridView dgvStationboard;
        private System.Windows.Forms.Button btnStationSuche;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.ListBox listStationBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBis1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbfahrt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGleis1;
        private System.Windows.Forms.Button btnMaps;
        private System.Windows.Forms.Button btnMapZiel;
        private System.Windows.Forms.Button btnMapStart;
    }
}

