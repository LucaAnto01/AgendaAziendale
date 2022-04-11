﻿namespace AgendaAziendale.Forms
{
    partial class FormAggiungiLavoratore
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
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.lbCognome = new System.Windows.Forms.Label();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.mcDataNascita = new System.Windows.Forms.MonthCalendar();
            this.tbDataNascita = new System.Windows.Forms.TextBox();
            this.lbDataNascita = new System.Windows.Forms.Label();
            this.tbResidenza = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbResidenza = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btAggiungi = new System.Windows.Forms.Button();
            this.cbTipologia = new System.Windows.Forms.ComboBox();
            this.lbTipologia = new System.Windows.Forms.Label();
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
            this.panelTop.TabIndex = 4;
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
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 85);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 18);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(119, 85);
            this.tbNome.MaxLength = 50;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(110, 21);
            this.tbNome.TabIndex = 6;
            // 
            // tbCognome
            // 
            this.tbCognome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCognome.Location = new System.Drawing.Point(119, 129);
            this.tbCognome.MaxLength = 50;
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(110, 21);
            this.tbCognome.TabIndex = 8;
            // 
            // lbCognome
            // 
            this.lbCognome.AutoSize = true;
            this.lbCognome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCognome.Location = new System.Drawing.Point(12, 129);
            this.lbCognome.Name = "lbCognome";
            this.lbCognome.Size = new System.Drawing.Size(76, 18);
            this.lbCognome.TabIndex = 7;
            this.lbCognome.Text = "Cognome";
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.lbTipologia);
            this.panelCentro.Controls.Add(this.cbTipologia);
            this.panelCentro.Controls.Add(this.btAggiungi);
            this.panelCentro.Controls.Add(this.mcDataNascita);
            this.panelCentro.Controls.Add(this.tbDataNascita);
            this.panelCentro.Controls.Add(this.lbDataNascita);
            this.panelCentro.Controls.Add(this.tbResidenza);
            this.panelCentro.Controls.Add(this.tbPassword);
            this.panelCentro.Controls.Add(this.lbResidenza);
            this.panelCentro.Controls.Add(this.lbPassword);
            this.panelCentro.Controls.Add(this.tbUsername);
            this.panelCentro.Controls.Add(this.lbUsername);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(750, 525);
            this.panelCentro.TabIndex = 9;
            // 
            // mcDataNascita
            // 
            this.mcDataNascita.Location = new System.Drawing.Point(292, 158);
            this.mcDataNascita.Name = "mcDataNascita";
            this.mcDataNascita.TabIndex = 16;
            this.mcDataNascita.Visible = false;
            this.mcDataNascita.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McDataNascita_DateSelected);
            // 
            // tbDataNascita
            // 
            this.tbDataNascita.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataNascita.Location = new System.Drawing.Point(119, 216);
            this.tbDataNascita.MaxLength = 100;
            this.tbDataNascita.Name = "tbDataNascita";
            this.tbDataNascita.Size = new System.Drawing.Size(110, 21);
            this.tbDataNascita.TabIndex = 15;
            this.tbDataNascita.Enter += new System.EventHandler(this.TbDataNascita_Enter);
            // 
            // lbDataNascita
            // 
            this.lbDataNascita.AutoSize = true;
            this.lbDataNascita.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascita.Location = new System.Drawing.Point(12, 216);
            this.lbDataNascita.Name = "lbDataNascita";
            this.lbDataNascita.Size = new System.Drawing.Size(94, 18);
            this.lbDataNascita.TabIndex = 14;
            this.lbDataNascita.Text = "Data nascita";
            // 
            // tbResidenza
            // 
            this.tbResidenza.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResidenza.Location = new System.Drawing.Point(119, 182);
            this.tbResidenza.MaxLength = 100;
            this.tbResidenza.Name = "tbResidenza";
            this.tbResidenza.Size = new System.Drawing.Size(110, 21);
            this.tbResidenza.TabIndex = 11;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(119, 314);
            this.tbPassword.MaxLength = 25;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(110, 21);
            this.tbPassword.TabIndex = 13;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lbResidenza
            // 
            this.lbResidenza.AutoSize = true;
            this.lbResidenza.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResidenza.Location = new System.Drawing.Point(12, 182);
            this.lbResidenza.Name = "lbResidenza";
            this.lbResidenza.Size = new System.Drawing.Size(83, 18);
            this.lbResidenza.TabIndex = 10;
            this.lbResidenza.Text = "Residenza";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(12, 314);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 18);
            this.lbPassword.TabIndex = 12;
            this.lbPassword.Text = "Password";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(119, 265);
            this.tbUsername.MaxLength = 25;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(110, 21);
            this.tbUsername.TabIndex = 11;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(12, 265);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(80, 18);
            this.lbUsername.TabIndex = 10;
            this.lbUsername.Text = "Username";
            // 
            // btAggiungi
            // 
            this.btAggiungi.Location = new System.Drawing.Point(67, 437);
            this.btAggiungi.Name = "btAggiungi";
            this.btAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btAggiungi.TabIndex = 17;
            this.btAggiungi.Text = "Aggiungi";
            this.btAggiungi.UseVisualStyleBackColor = true;
            this.btAggiungi.Click += new System.EventHandler(this.BtAggiungi_Click);
            // 
            // cbTipologia
            // 
            this.cbTipologia.FormattingEnabled = true;
            this.cbTipologia.Items.AddRange(new object[] {
            "Project Manager",
            "Sviluppatore",
            "Segretario"});
            this.cbTipologia.Location = new System.Drawing.Point(119, 370);
            this.cbTipologia.Name = "cbTipologia";
            this.cbTipologia.Size = new System.Drawing.Size(110, 21);
            this.cbTipologia.TabIndex = 18;
            // 
            // lbTipologia
            // 
            this.lbTipologia.AutoSize = true;
            this.lbTipologia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipologia.Location = new System.Drawing.Point(12, 370);
            this.lbTipologia.Name = "lbTipologia";
            this.lbTipologia.Size = new System.Drawing.Size(74, 18);
            this.lbTipologia.TabIndex = 19;
            this.lbTipologia.Text = "Tipologia";
            // 
            // FormAggiungiLavoratore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 525);
            this.Controls.Add(this.tbCognome);
            this.Controls.Add(this.lbCognome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAggiungiLavoratore";
            this.Text = "FormAggiungiUtente";
            this.panelTop.ResumeLayout(false);
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btChiudi;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCognome;
        private System.Windows.Forms.Label lbCognome;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.MonthCalendar mcDataNascita;
        private System.Windows.Forms.TextBox tbDataNascita;
        private System.Windows.Forms.Label lbDataNascita;
        private System.Windows.Forms.TextBox tbResidenza;
        private System.Windows.Forms.Label lbResidenza;
        private System.Windows.Forms.Button btAggiungi;
        private System.Windows.Forms.Label lbTipologia;
        private System.Windows.Forms.ComboBox cbTipologia;
    }
}