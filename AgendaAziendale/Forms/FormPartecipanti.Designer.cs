namespace AgendaAziendale.Forms
{
    partial class FormPartecipanti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btChiudi = new System.Windows.Forms.Button();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.dgvPartecipanti = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codice_attivita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rimuovi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btAggiungi = new System.Windows.Forms.Button();
            this.cbLavoratore = new System.Windows.Forms.ComboBox();
            this.lbLavoratore = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartecipanti)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTop.Controls.Add(this.btChiudi);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(811, 40);
            this.panelTop.TabIndex = 69;
            // 
            // btChiudi
            // 
            this.btChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btChiudi.BackColor = System.Drawing.Color.Transparent;
            this.btChiudi.BackgroundImage = global::AgendaAziendale.Properties.Resources.Chiudi;
            this.btChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btChiudi.Location = new System.Drawing.Point(758, 5);
            this.btChiudi.Name = "btChiudi";
            this.btChiudi.Size = new System.Drawing.Size(45, 30);
            this.btChiudi.TabIndex = 3;
            this.btChiudi.UseVisualStyleBackColor = false;
            this.btChiudi.Click += new System.EventHandler(this.BtChiudi_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.dgvPartecipanti);
            this.panelCentro.Controls.Add(this.btAggiungi);
            this.panelCentro.Controls.Add(this.cbLavoratore);
            this.panelCentro.Controls.Add(this.lbLavoratore);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 40);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(811, 418);
            this.panelCentro.TabIndex = 70;
            // 
            // dgvPartecipanti
            // 
            this.dgvPartecipanti.AllowUserToAddRows = false;
            this.dgvPartecipanti.AllowUserToDeleteRows = false;
            this.dgvPartecipanti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartecipanti.BackgroundColor = System.Drawing.Color.White;
            this.dgvPartecipanti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPartecipanti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartecipanti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.codice_attivita,
            this.ruolo,
            this.rimuovi});
            this.dgvPartecipanti.GridColor = System.Drawing.Color.White;
            this.dgvPartecipanti.Location = new System.Drawing.Point(378, 43);
            this.dgvPartecipanti.Name = "dgvPartecipanti";
            this.dgvPartecipanti.ReadOnly = true;
            this.dgvPartecipanti.Size = new System.Drawing.Size(407, 198);
            this.dgvPartecipanti.TabIndex = 75;
            this.dgvPartecipanti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPartecipanti_CellClick);
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // codice_attivita
            // 
            this.codice_attivita.HeaderText = "Codice attivita";
            this.codice_attivita.Name = "codice_attivita";
            this.codice_attivita.ReadOnly = true;
            // 
            // ruolo
            // 
            this.ruolo.HeaderText = "Ruolo";
            this.ruolo.Name = "ruolo";
            this.ruolo.ReadOnly = true;
            // 
            // rimuovi
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.rimuovi.DefaultCellStyle = dataGridViewCellStyle2;
            this.rimuovi.HeaderText = "";
            this.rimuovi.Name = "rimuovi";
            this.rimuovi.ReadOnly = true;
            this.rimuovi.Text = "Rimuovi";
            this.rimuovi.UseColumnTextForButtonValue = true;
            // 
            // btAggiungi
            // 
            this.btAggiungi.Location = new System.Drawing.Point(15, 218);
            this.btAggiungi.Name = "btAggiungi";
            this.btAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btAggiungi.TabIndex = 74;
            this.btAggiungi.Text = "Aggiungi";
            this.btAggiungi.UseVisualStyleBackColor = true;
            this.btAggiungi.Click += new System.EventHandler(this.BtAggiungi_Click);
            // 
            // cbLavoratore
            // 
            this.cbLavoratore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLavoratore.FormattingEnabled = true;
            this.cbLavoratore.Location = new System.Drawing.Point(124, 43);
            this.cbLavoratore.Name = "cbLavoratore";
            this.cbLavoratore.Size = new System.Drawing.Size(182, 21);
            this.cbLavoratore.TabIndex = 73;
            // 
            // lbLavoratore
            // 
            this.lbLavoratore.AutoSize = true;
            this.lbLavoratore.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLavoratore.Location = new System.Drawing.Point(12, 42);
            this.lbLavoratore.Name = "lbLavoratore";
            this.lbLavoratore.Size = new System.Drawing.Size(86, 18);
            this.lbLavoratore.TabIndex = 72;
            this.lbLavoratore.Text = "Lavoratore";
            // 
            // FormPartecipanti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 458);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPartecipanti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPartecipanti";
            this.Load += new System.EventHandler(this.FormPartecipanti_Load);
            this.panelTop.ResumeLayout(false);
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartecipanti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btChiudi;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Label lbLavoratore;
        private System.Windows.Forms.Button btAggiungi;
        private System.Windows.Forms.ComboBox cbLavoratore;
        private System.Windows.Forms.DataGridView dgvPartecipanti;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn codice_attivita;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruolo;
        private System.Windows.Forms.DataGridViewButtonColumn rimuovi;
    }
}