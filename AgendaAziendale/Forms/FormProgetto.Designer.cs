namespace AgendaAziendale.Forms
{
    partial class FormProgetto
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btChiudi = new System.Windows.Forms.Button();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.tbDataFine = new System.Windows.Forms.TextBox();
            this.lbDataFine = new System.Windows.Forms.Label();
            this.btAggiungiAggiorna = new System.Windows.Forms.Button();
            this.lbDataInizio = new System.Windows.Forms.Label();
            this.tbDescrizione = new System.Windows.Forms.TextBox();
            this.lbDescrizione = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbReferente = new System.Windows.Forms.Label();
            this.cbReferente = new System.Windows.Forms.ComboBox();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.lbErrore = new System.Windows.Forms.Label();
            this.mcDataFine = new System.Windows.Forms.MonthCalendar();
            this.mcDataInizio = new System.Windows.Forms.MonthCalendar();
            this.tbDataInizio = new System.Windows.Forms.TextBox();
            this.btAggiungiPartecipante = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTop.Controls.Add(this.btChiudi);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(750, 40);
            this.panelTop.TabIndex = 67;
            // 
            // btChiudi
            // 
            this.btChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btChiudi.BackColor = System.Drawing.Color.Transparent;
            this.btChiudi.BackgroundImage = global::AgendaAziendale.Properties.Resources.Chiudi;
            this.btChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btChiudi.Location = new System.Drawing.Point(697, 5);
            this.btChiudi.Name = "btChiudi";
            this.btChiudi.Size = new System.Drawing.Size(45, 30);
            this.btChiudi.TabIndex = 3;
            this.btChiudi.UseVisualStyleBackColor = false;
            this.btChiudi.Click += new System.EventHandler(this.BtChiudi_Click);
            // 
            // tbCliente
            // 
            this.tbCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(119, 321);
            this.tbCliente.MaxLength = 50;
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCliente.Size = new System.Drawing.Size(181, 21);
            this.tbCliente.TabIndex = 66;
            this.tbCliente.Enter += new System.EventHandler(this.TbEnter_Click);
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(12, 321);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(59, 18);
            this.lbCliente.TabIndex = 65;
            this.lbCliente.Text = "Cliente";
            // 
            // tbDataFine
            // 
            this.tbDataFine.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataFine.Location = new System.Drawing.Point(119, 280);
            this.tbDataFine.MaxLength = 25;
            this.tbDataFine.Name = "tbDataFine";
            this.tbDataFine.Size = new System.Drawing.Size(110, 21);
            this.tbDataFine.TabIndex = 64;
            this.tbDataFine.Enter += new System.EventHandler(this.TbDataFine_Enter);
            // 
            // lbDataFine
            // 
            this.lbDataFine.AutoSize = true;
            this.lbDataFine.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataFine.Location = new System.Drawing.Point(12, 280);
            this.lbDataFine.Name = "lbDataFine";
            this.lbDataFine.Size = new System.Drawing.Size(71, 18);
            this.lbDataFine.TabIndex = 63;
            this.lbDataFine.Text = "Data fine";
            // 
            // btAggiungiAggiorna
            // 
            this.btAggiungiAggiorna.Location = new System.Drawing.Point(15, 403);
            this.btAggiungiAggiorna.Name = "btAggiungiAggiorna";
            this.btAggiungiAggiorna.Size = new System.Drawing.Size(75, 23);
            this.btAggiungiAggiorna.TabIndex = 55;
            this.btAggiungiAggiorna.Text = "Agg";
            this.btAggiungiAggiorna.UseVisualStyleBackColor = true;
            this.btAggiungiAggiorna.Click += new System.EventHandler(this.BtAggiungiAggiorna_Click);
            // 
            // lbDataInizio
            // 
            this.lbDataInizio.AutoSize = true;
            this.lbDataInizio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataInizio.Location = new System.Drawing.Point(12, 237);
            this.lbDataInizio.Name = "lbDataInizio";
            this.lbDataInizio.Size = new System.Drawing.Size(82, 18);
            this.lbDataInizio.TabIndex = 62;
            this.lbDataInizio.Text = "Data inizio";
            // 
            // tbDescrizione
            // 
            this.tbDescrizione.AcceptsReturn = true;
            this.tbDescrizione.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescrizione.Location = new System.Drawing.Point(119, 168);
            this.tbDescrizione.MaxLength = 500;
            this.tbDescrizione.Multiline = true;
            this.tbDescrizione.Name = "tbDescrizione";
            this.tbDescrizione.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDescrizione.Size = new System.Drawing.Size(246, 46);
            this.tbDescrizione.TabIndex = 61;
            this.tbDescrizione.Enter += new System.EventHandler(this.TbEnter_Click);
            // 
            // lbDescrizione
            // 
            this.lbDescrizione.AutoSize = true;
            this.lbDescrizione.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrizione.Location = new System.Drawing.Point(12, 168);
            this.lbDescrizione.Name = "lbDescrizione";
            this.lbDescrizione.Size = new System.Drawing.Size(93, 18);
            this.lbDescrizione.TabIndex = 60;
            this.lbDescrizione.Text = "Descrizione";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(119, 125);
            this.tbNome.MaxLength = 50;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(110, 21);
            this.tbNome.TabIndex = 57;
            this.tbNome.Enter += new System.EventHandler(this.TbEnter_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 125);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 18);
            this.lbNome.TabIndex = 56;
            this.lbNome.Text = "Nome";
            // 
            // lbReferente
            // 
            this.lbReferente.AutoSize = true;
            this.lbReferente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReferente.Location = new System.Drawing.Point(12, 85);
            this.lbReferente.Name = "lbReferente";
            this.lbReferente.Size = new System.Drawing.Size(80, 18);
            this.lbReferente.TabIndex = 59;
            this.lbReferente.Text = "Referente";
            // 
            // cbReferente
            // 
            this.cbReferente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReferente.FormattingEnabled = true;
            this.cbReferente.Location = new System.Drawing.Point(119, 84);
            this.cbReferente.Name = "cbReferente";
            this.cbReferente.Size = new System.Drawing.Size(110, 21);
            this.cbReferente.TabIndex = 58;
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.btAggiungiPartecipante);
            this.panelCentro.Controls.Add(this.lbErrore);
            this.panelCentro.Controls.Add(this.mcDataFine);
            this.panelCentro.Controls.Add(this.mcDataInizio);
            this.panelCentro.Controls.Add(this.tbDataInizio);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(750, 525);
            this.panelCentro.TabIndex = 68;
            // 
            // lbErrore
            // 
            this.lbErrore.AutoSize = true;
            this.lbErrore.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrore.ForeColor = System.Drawing.Color.Red;
            this.lbErrore.Location = new System.Drawing.Point(451, 168);
            this.lbErrore.Name = "lbErrore";
            this.lbErrore.Size = new System.Drawing.Size(172, 24);
            this.lbErrore.TabIndex = 69;
            this.lbErrore.Text = "Compila tutti i campi!";
            this.lbErrore.Visible = false;
            // 
            // mcDataFine
            // 
            this.mcDataFine.Location = new System.Drawing.Point(451, 237);
            this.mcDataFine.Name = "mcDataFine";
            this.mcDataFine.TabIndex = 33;
            this.mcDataFine.Visible = false;
            this.mcDataFine.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McDataFine_DateSelected);
            // 
            // mcDataInizio
            // 
            this.mcDataInizio.Location = new System.Drawing.Point(451, 237);
            this.mcDataInizio.Name = "mcDataInizio";
            this.mcDataInizio.TabIndex = 30;
            this.mcDataInizio.Visible = false;
            this.mcDataInizio.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McDataInizio_DateSelected);
            // 
            // tbDataInizio
            // 
            this.tbDataInizio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataInizio.Location = new System.Drawing.Point(119, 235);
            this.tbDataInizio.MaxLength = 25;
            this.tbDataInizio.Name = "tbDataInizio";
            this.tbDataInizio.Size = new System.Drawing.Size(110, 21);
            this.tbDataInizio.TabIndex = 48;
            this.tbDataInizio.Enter += new System.EventHandler(this.TbDataInizio_Enter);
            // 
            // btAggiungiPartecipante
            // 
            this.btAggiungiPartecipante.Location = new System.Drawing.Point(15, 460);
            this.btAggiungiPartecipante.Name = "btAggiungiPartecipante";
            this.btAggiungiPartecipante.Size = new System.Drawing.Size(143, 23);
            this.btAggiungiPartecipante.TabIndex = 69;
            this.btAggiungiPartecipante.Text = "Aggiungi partecipante";
            this.btAggiungiPartecipante.UseVisualStyleBackColor = true;
            // 
            // FormProgetto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 525);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.tbDataFine);
            this.Controls.Add(this.lbDataFine);
            this.Controls.Add(this.btAggiungiAggiorna);
            this.Controls.Add(this.lbDataInizio);
            this.Controls.Add(this.tbDescrizione);
            this.Controls.Add(this.lbDescrizione);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbReferente);
            this.Controls.Add(this.cbReferente);
            this.Controls.Add(this.panelCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProgetto";
            this.Text = "FormProgetto";
            this.Load += new System.EventHandler(this.FormProgetto_Load);
            this.panelTop.ResumeLayout(false);
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btChiudi;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.TextBox tbDataFine;
        private System.Windows.Forms.Label lbDataFine;
        private System.Windows.Forms.Button btAggiungiAggiorna;
        private System.Windows.Forms.Label lbDataInizio;
        private System.Windows.Forms.TextBox tbDescrizione;
        private System.Windows.Forms.Label lbDescrizione;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbReferente;
        private System.Windows.Forms.ComboBox cbReferente;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.MonthCalendar mcDataFine;
        private System.Windows.Forms.MonthCalendar mcDataInizio;
        private System.Windows.Forms.TextBox tbDataInizio;
        private System.Windows.Forms.Label lbErrore;
        private System.Windows.Forms.Button btAggiungiPartecipante;
    }
}