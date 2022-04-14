namespace AgendaAziendale.Forms
{
    partial class FormCreazioneAttivita
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbReferente = new System.Windows.Forms.Label();
            this.cbReferente = new System.Windows.Forms.ComboBox();
            this.tbCodice = new System.Windows.Forms.TextBox();
            this.lbCodice = new System.Windows.Forms.Label();
            this.tbDescrizione = new System.Windows.Forms.TextBox();
            this.lbDescrizione = new System.Windows.Forms.Label();
            this.tbDataInizio = new System.Windows.Forms.TextBox();
            this.lbDataInizio = new System.Windows.Forms.Label();
            this.mcDataInizio = new System.Windows.Forms.MonthCalendar();
            this.tbDataFine = new System.Windows.Forms.TextBox();
            this.lbDataFine = new System.Windows.Forms.Label();
            this.mcDataFine = new System.Windows.Forms.MonthCalendar();
            this.tbLuogoCliente = new System.Windows.Forms.TextBox();
            this.lbLuogoCliente = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btChiudi = new System.Windows.Forms.Button();
            this.btAggiungi = new System.Windows.Forms.Button();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(119, 139);
            this.tbNome.MaxLength = 50;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(110, 21);
            this.tbNome.TabIndex = 21;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 139);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 18);
            this.lbNome.TabIndex = 20;
            this.lbNome.Text = "Nome";
            // 
            // lbReferente
            // 
            this.lbReferente.AutoSize = true;
            this.lbReferente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReferente.Location = new System.Drawing.Point(12, 99);
            this.lbReferente.Name = "lbReferente";
            this.lbReferente.Size = new System.Drawing.Size(80, 18);
            this.lbReferente.TabIndex = 23;
            this.lbReferente.Text = "Referente";
            // 
            // cbReferente
            // 
            this.cbReferente.FormattingEnabled = true;
            this.cbReferente.Location = new System.Drawing.Point(119, 98);
            this.cbReferente.Name = "cbReferente";
            this.cbReferente.Size = new System.Drawing.Size(110, 21);
            this.cbReferente.TabIndex = 22;
            // 
            // tbCodice
            // 
            this.tbCodice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodice.Location = new System.Drawing.Point(119, 60);
            this.tbCodice.MaxLength = 10;
            this.tbCodice.Name = "tbCodice";
            this.tbCodice.Size = new System.Drawing.Size(110, 21);
            this.tbCodice.TabIndex = 25;
            // 
            // lbCodice
            // 
            this.lbCodice.AutoSize = true;
            this.lbCodice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodice.Location = new System.Drawing.Point(12, 60);
            this.lbCodice.Name = "lbCodice";
            this.lbCodice.Size = new System.Drawing.Size(58, 18);
            this.lbCodice.TabIndex = 24;
            this.lbCodice.Text = "Codice";
            // 
            // tbDescrizione
            // 
            this.tbDescrizione.AcceptsReturn = true;
            this.tbDescrizione.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescrizione.Location = new System.Drawing.Point(119, 182);
            this.tbDescrizione.MaxLength = 500;
            this.tbDescrizione.Multiline = true;
            this.tbDescrizione.Name = "tbDescrizione";
            this.tbDescrizione.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDescrizione.Size = new System.Drawing.Size(246, 46);
            this.tbDescrizione.TabIndex = 27;
            // 
            // lbDescrizione
            // 
            this.lbDescrizione.AutoSize = true;
            this.lbDescrizione.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrizione.Location = new System.Drawing.Point(12, 182);
            this.lbDescrizione.Name = "lbDescrizione";
            this.lbDescrizione.Size = new System.Drawing.Size(93, 18);
            this.lbDescrizione.TabIndex = 26;
            this.lbDescrizione.Text = "Descrizione";
            // 
            // tbDataInizio
            // 
            this.tbDataInizio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataInizio.Location = new System.Drawing.Point(119, 251);
            this.tbDataInizio.MaxLength = 25;
            this.tbDataInizio.Name = "tbDataInizio";
            this.tbDataInizio.Size = new System.Drawing.Size(110, 21);
            this.tbDataInizio.TabIndex = 29;
            this.tbDataInizio.Enter += new System.EventHandler(this.TbDataInizio_Enter);
            // 
            // lbDataInizio
            // 
            this.lbDataInizio.AutoSize = true;
            this.lbDataInizio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataInizio.Location = new System.Drawing.Point(12, 251);
            this.lbDataInizio.Name = "lbDataInizio";
            this.lbDataInizio.Size = new System.Drawing.Size(82, 18);
            this.lbDataInizio.TabIndex = 28;
            this.lbDataInizio.Text = "Data inizio";
            // 
            // mcDataInizio
            // 
            this.mcDataInizio.Location = new System.Drawing.Point(330, 240);
            this.mcDataInizio.Name = "mcDataInizio";
            this.mcDataInizio.TabIndex = 30;
            this.mcDataInizio.Visible = false;
            this.mcDataInizio.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McDataInizio_DateSelected);
            // 
            // tbDataFine
            // 
            this.tbDataFine.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataFine.Location = new System.Drawing.Point(119, 294);
            this.tbDataFine.MaxLength = 25;
            this.tbDataFine.Name = "tbDataFine";
            this.tbDataFine.Size = new System.Drawing.Size(110, 21);
            this.tbDataFine.TabIndex = 32;
            this.tbDataFine.Enter += new System.EventHandler(this.TbDataFine_Enter);
            // 
            // lbDataFine
            // 
            this.lbDataFine.AutoSize = true;
            this.lbDataFine.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataFine.Location = new System.Drawing.Point(12, 294);
            this.lbDataFine.Name = "lbDataFine";
            this.lbDataFine.Size = new System.Drawing.Size(71, 18);
            this.lbDataFine.TabIndex = 31;
            this.lbDataFine.Text = "Data fine";
            // 
            // mcDataFine
            // 
            this.mcDataFine.Location = new System.Drawing.Point(330, 240);
            this.mcDataFine.Name = "mcDataFine";
            this.mcDataFine.TabIndex = 33;
            this.mcDataFine.Visible = false;
            this.mcDataFine.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McDataFine_DateSelected);
            // 
            // tbLuogoCliente
            // 
            this.tbLuogoCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLuogoCliente.Location = new System.Drawing.Point(119, 335);
            this.tbLuogoCliente.MaxLength = 50;
            this.tbLuogoCliente.Name = "tbLuogoCliente";
            this.tbLuogoCliente.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbLuogoCliente.Size = new System.Drawing.Size(181, 21);
            this.tbLuogoCliente.TabIndex = 35;
            // 
            // lbLuogoCliente
            // 
            this.lbLuogoCliente.AutoSize = true;
            this.lbLuogoCliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuogoCliente.Location = new System.Drawing.Point(12, 335);
            this.lbLuogoCliente.Name = "lbLuogoCliente";
            this.lbLuogoCliente.Size = new System.Drawing.Size(104, 18);
            this.lbLuogoCliente.TabIndex = 34;
            this.lbLuogoCliente.Text = "LuogoCliente";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTop.Controls.Add(this.btChiudi);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(589, 40);
            this.panelTop.TabIndex = 36;
            // 
            // btChiudi
            // 
            this.btChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btChiudi.BackColor = System.Drawing.Color.Transparent;
            this.btChiudi.BackgroundImage = global::AgendaAziendale.Properties.Resources.Chiudi;
            this.btChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btChiudi.Location = new System.Drawing.Point(536, 5);
            this.btChiudi.Name = "btChiudi";
            this.btChiudi.Size = new System.Drawing.Size(45, 30);
            this.btChiudi.TabIndex = 3;
            this.btChiudi.UseVisualStyleBackColor = false;
            this.btChiudi.Click += new System.EventHandler(this.BtChiudi_Click);
            // 
            // btAggiungi
            // 
            this.btAggiungi.Location = new System.Drawing.Point(15, 417);
            this.btAggiungi.Name = "btAggiungi";
            this.btAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btAggiungi.TabIndex = 18;
            this.btAggiungi.Text = "Aggiungi";
            this.btAggiungi.UseVisualStyleBackColor = true;
            this.btAggiungi.Click += new System.EventHandler(this.BtAggiungi_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(589, 484);
            this.panelCentro.TabIndex = 37;
            // 
            // FormCreazioneEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 484);
            this.Controls.Add(this.btAggiungi);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tbLuogoCliente);
            this.Controls.Add(this.lbLuogoCliente);
            this.Controls.Add(this.mcDataFine);
            this.Controls.Add(this.tbDataFine);
            this.Controls.Add(this.lbDataFine);
            this.Controls.Add(this.mcDataInizio);
            this.Controls.Add(this.tbDataInizio);
            this.Controls.Add(this.lbDataInizio);
            this.Controls.Add(this.tbDescrizione);
            this.Controls.Add(this.lbDescrizione);
            this.Controls.Add(this.tbCodice);
            this.Controls.Add(this.lbCodice);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbReferente);
            this.Controls.Add(this.cbReferente);
            this.Controls.Add(this.panelCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreazioneEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreazioneEvento";
            this.Load += new System.EventHandler(this.FormCreazioneEvento_Load);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbReferente;
        private System.Windows.Forms.ComboBox cbReferente;
        private System.Windows.Forms.TextBox tbCodice;
        private System.Windows.Forms.Label lbCodice;
        private System.Windows.Forms.TextBox tbDescrizione;
        private System.Windows.Forms.Label lbDescrizione;
        private System.Windows.Forms.TextBox tbDataInizio;
        private System.Windows.Forms.Label lbDataInizio;
        private System.Windows.Forms.MonthCalendar mcDataInizio;
        private System.Windows.Forms.TextBox tbDataFine;
        private System.Windows.Forms.Label lbDataFine;
        private System.Windows.Forms.MonthCalendar mcDataFine;
        private System.Windows.Forms.TextBox tbLuogoCliente;
        private System.Windows.Forms.Label lbLuogoCliente;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btChiudi;
        private System.Windows.Forms.Button btAggiungi;
        private System.Windows.Forms.Panel panelCentro;
    }
}