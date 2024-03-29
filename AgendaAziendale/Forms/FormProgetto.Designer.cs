﻿namespace AgendaAziendale.Forms
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
            this.btMinimize = new System.Windows.Forms.Button();
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
            this.panelCentro = new System.Windows.Forms.Panel();
            this.lbErroreData = new System.Windows.Forms.Label();
            this.btGestioneObiettivi = new System.Windows.Forms.Button();
            this.lbErrore = new System.Windows.Forms.Label();
            this.mcDataFine = new System.Windows.Forms.MonthCalendar();
            this.mcDataInizio = new System.Windows.Forms.MonthCalendar();
            this.tbDataInizio = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelTop.Controls.Add(this.btMinimize);
            this.panelTop.Controls.Add(this.btChiudi);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(750, 40);
            this.panelTop.TabIndex = 67;
            // 
            // btMinimize
            // 
            this.btMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btMinimize.BackgroundImage = global::AgendaAziendale.Properties.Resources.Minimize;
            this.btMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMinimize.FlatAppearance.BorderSize = 0;
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.Location = new System.Drawing.Point(645, 5);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(45, 30);
            this.btMinimize.TabIndex = 69;
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.BtMinimize_Click);
            // 
            // btChiudi
            // 
            this.btChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btChiudi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btChiudi.BackgroundImage = global::AgendaAziendale.Properties.Resources.Chiudi;
            this.btChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btChiudi.FlatAppearance.BorderSize = 0;
            this.btChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChiudi.Location = new System.Drawing.Point(697, 5);
            this.btChiudi.Name = "btChiudi";
            this.btChiudi.Size = new System.Drawing.Size(45, 30);
            this.btChiudi.TabIndex = 3;
            this.btChiudi.UseVisualStyleBackColor = false;
            this.btChiudi.Click += new System.EventHandler(this.BtChiudi_Click);
            // 
            // tbCliente
            // 
            this.tbCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(119, 265);
            this.tbCliente.MaxLength = 50;
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCliente.Size = new System.Drawing.Size(181, 21);
            this.tbCliente.TabIndex = 66;
            this.tbCliente.TextChanged += new System.EventHandler(this.Tb_TextChanged);
            this.tbCliente.Enter += new System.EventHandler(this.TbEnter_Click);
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.lbCliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.ForeColor = System.Drawing.Color.White;
            this.lbCliente.Location = new System.Drawing.Point(12, 265);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(59, 18);
            this.lbCliente.TabIndex = 65;
            this.lbCliente.Text = "Cliente";
            // 
            // tbDataFine
            // 
            this.tbDataFine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDataFine.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataFine.Location = new System.Drawing.Point(119, 224);
            this.tbDataFine.MaxLength = 25;
            this.tbDataFine.Name = "tbDataFine";
            this.tbDataFine.Size = new System.Drawing.Size(110, 21);
            this.tbDataFine.TabIndex = 64;
            this.tbDataFine.Enter += new System.EventHandler(this.TbDataFine_Enter);
            // 
            // lbDataFine
            // 
            this.lbDataFine.AutoSize = true;
            this.lbDataFine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.lbDataFine.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataFine.ForeColor = System.Drawing.Color.White;
            this.lbDataFine.Location = new System.Drawing.Point(12, 224);
            this.lbDataFine.Name = "lbDataFine";
            this.lbDataFine.Size = new System.Drawing.Size(71, 18);
            this.lbDataFine.TabIndex = 63;
            this.lbDataFine.Text = "Data fine";
            // 
            // btAggiungiAggiorna
            // 
            this.btAggiungiAggiorna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btAggiungiAggiorna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAggiungiAggiorna.ForeColor = System.Drawing.Color.White;
            this.btAggiungiAggiorna.Location = new System.Drawing.Point(15, 347);
            this.btAggiungiAggiorna.Name = "btAggiungiAggiorna";
            this.btAggiungiAggiorna.Size = new System.Drawing.Size(75, 23);
            this.btAggiungiAggiorna.TabIndex = 55;
            this.btAggiungiAggiorna.Text = "Agg";
            this.btAggiungiAggiorna.UseVisualStyleBackColor = false;
            this.btAggiungiAggiorna.Click += new System.EventHandler(this.BtAggiungiAggiorna_Click);
            // 
            // lbDataInizio
            // 
            this.lbDataInizio.AutoSize = true;
            this.lbDataInizio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.lbDataInizio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataInizio.ForeColor = System.Drawing.Color.White;
            this.lbDataInizio.Location = new System.Drawing.Point(12, 181);
            this.lbDataInizio.Name = "lbDataInizio";
            this.lbDataInizio.Size = new System.Drawing.Size(82, 18);
            this.lbDataInizio.TabIndex = 62;
            this.lbDataInizio.Text = "Data inizio";
            // 
            // tbDescrizione
            // 
            this.tbDescrizione.AcceptsReturn = true;
            this.tbDescrizione.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDescrizione.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescrizione.Location = new System.Drawing.Point(119, 112);
            this.tbDescrizione.MaxLength = 500;
            this.tbDescrizione.Multiline = true;
            this.tbDescrizione.Name = "tbDescrizione";
            this.tbDescrizione.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDescrizione.Size = new System.Drawing.Size(246, 46);
            this.tbDescrizione.TabIndex = 61;
            this.tbDescrizione.TextChanged += new System.EventHandler(this.Tb_TextChanged);
            this.tbDescrizione.Enter += new System.EventHandler(this.TbEnter_Click);
            // 
            // lbDescrizione
            // 
            this.lbDescrizione.AutoSize = true;
            this.lbDescrizione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.lbDescrizione.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrizione.ForeColor = System.Drawing.Color.White;
            this.lbDescrizione.Location = new System.Drawing.Point(12, 112);
            this.lbDescrizione.Name = "lbDescrizione";
            this.lbDescrizione.Size = new System.Drawing.Size(93, 18);
            this.lbDescrizione.TabIndex = 60;
            this.lbDescrizione.Text = "Descrizione";
            // 
            // tbNome
            // 
            this.tbNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(119, 69);
            this.tbNome.MaxLength = 50;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(110, 21);
            this.tbNome.TabIndex = 57;
            this.tbNome.TextChanged += new System.EventHandler(this.Tb_TextChanged);
            this.tbNome.Enter += new System.EventHandler(this.TbEnter_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.lbNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(12, 69);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 18);
            this.lbNome.TabIndex = 56;
            this.lbNome.Text = "Nome";
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelCentro.Controls.Add(this.lbErroreData);
            this.panelCentro.Controls.Add(this.btGestioneObiettivi);
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
            // lbErroreData
            // 
            this.lbErroreData.AutoSize = true;
            this.lbErroreData.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErroreData.ForeColor = System.Drawing.Color.Red;
            this.lbErroreData.Location = new System.Drawing.Point(412, 365);
            this.lbErroreData.Name = "lbErroreData";
            this.lbErroreData.Size = new System.Drawing.Size(305, 24);
            this.lbErroreData.TabIndex = 72;
            this.lbErroreData.Text = "Inserisci una data di fine evento valida";
            this.lbErroreData.Visible = false;
            // 
            // btGestioneObiettivi
            // 
            this.btGestioneObiettivi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btGestioneObiettivi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGestioneObiettivi.ForeColor = System.Drawing.Color.White;
            this.btGestioneObiettivi.Location = new System.Drawing.Point(15, 402);
            this.btGestioneObiettivi.Name = "btGestioneObiettivi";
            this.btGestioneObiettivi.Size = new System.Drawing.Size(118, 23);
            this.btGestioneObiettivi.TabIndex = 69;
            this.btGestioneObiettivi.Text = "Gestione obiettivi";
            this.btGestioneObiettivi.UseVisualStyleBackColor = false;
            this.btGestioneObiettivi.Visible = false;
            this.btGestioneObiettivi.Click += new System.EventHandler(this.BtGestioneObiettivi_Click);
            // 
            // lbErrore
            // 
            this.lbErrore.AutoSize = true;
            this.lbErrore.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrore.ForeColor = System.Drawing.Color.Red;
            this.lbErrore.Location = new System.Drawing.Point(450, 125);
            this.lbErrore.Name = "lbErrore";
            this.lbErrore.Size = new System.Drawing.Size(172, 24);
            this.lbErrore.TabIndex = 69;
            this.lbErrore.Text = "Compila tutti i campi!";
            this.lbErrore.Visible = false;
            // 
            // mcDataFine
            // 
            this.mcDataFine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mcDataFine.Location = new System.Drawing.Point(451, 181);
            this.mcDataFine.Name = "mcDataFine";
            this.mcDataFine.TabIndex = 33;
            this.mcDataFine.Visible = false;
            this.mcDataFine.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McDataFine_DateSelected);
            // 
            // mcDataInizio
            // 
            this.mcDataInizio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mcDataInizio.Location = new System.Drawing.Point(451, 181);
            this.mcDataInizio.Name = "mcDataInizio";
            this.mcDataInizio.TabIndex = 30;
            this.mcDataInizio.Visible = false;
            this.mcDataInizio.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McDataInizio_DateSelected);
            // 
            // tbDataInizio
            // 
            this.tbDataInizio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDataInizio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataInizio.Location = new System.Drawing.Point(119, 179);
            this.tbDataInizio.MaxLength = 25;
            this.tbDataInizio.Name = "tbDataInizio";
            this.tbDataInizio.Size = new System.Drawing.Size(110, 21);
            this.tbDataInizio.TabIndex = 48;
            this.tbDataInizio.Enter += new System.EventHandler(this.TbDataInizio_Enter);
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
            this.Controls.Add(this.panelCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProgetto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.MonthCalendar mcDataFine;
        private System.Windows.Forms.MonthCalendar mcDataInizio;
        private System.Windows.Forms.TextBox tbDataInizio;
        private System.Windows.Forms.Label lbErrore;
        private System.Windows.Forms.Button btGestioneObiettivi;
        private System.Windows.Forms.Label lbErroreData;
        private System.Windows.Forms.Button btMinimize;
    }
}