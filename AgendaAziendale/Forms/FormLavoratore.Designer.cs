namespace AgendaAziendale.Forms
{
    partial class FormLavoratore
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
            this.btChiudi = new System.Windows.Forms.Button();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btAAggiornaAggiungi = new System.Windows.Forms.Button();
            this.lbCognome = new System.Windows.Forms.Label();
            this.mcDataNascita = new System.Windows.Forms.MonthCalendar();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.tbDataNascita = new System.Windows.Forms.TextBox();
            this.lbDataNascita = new System.Windows.Forms.Label();
            this.tbResidenza = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbResidenza = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.lbErrore = new System.Windows.Forms.Label();
            this.lbInfoPassword = new System.Windows.Forms.Label();
            this.btAggiornaPassowrd = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.SuspendLayout();
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
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(12, 370);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(77, 18);
            this.lbCategoria.TabIndex = 19;
            this.lbCategoria.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Project Manager",
            "Sviluppatore",
            "Segretario",
            "Admin"});
            this.cbCategoria.Location = new System.Drawing.Point(119, 370);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(110, 21);
            this.cbCategoria.TabIndex = 18;
            // 
            // btAAggiornaAggiungi
            // 
            this.btAAggiornaAggiungi.Location = new System.Drawing.Point(15, 436);
            this.btAAggiornaAggiungi.Name = "btAAggiornaAggiungi";
            this.btAAggiornaAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btAAggiornaAggiungi.TabIndex = 17;
            this.btAAggiornaAggiungi.Text = "Agg";
            this.btAAggiornaAggiungi.UseVisualStyleBackColor = true;
            this.btAAggiornaAggiungi.Click += new System.EventHandler(this.BtAAggiornaAggiungi_Click);
            // 
            // lbCognome
            // 
            this.lbCognome.AutoSize = true;
            this.lbCognome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCognome.Location = new System.Drawing.Point(12, 129);
            this.lbCognome.Name = "lbCognome";
            this.lbCognome.Size = new System.Drawing.Size(76, 18);
            this.lbCognome.TabIndex = 13;
            this.lbCognome.Text = "Cognome";
            // 
            // mcDataNascita
            // 
            this.mcDataNascita.Location = new System.Drawing.Point(292, 180);
            this.mcDataNascita.Name = "mcDataNascita";
            this.mcDataNascita.TabIndex = 16;
            this.mcDataNascita.Visible = false;
            this.mcDataNascita.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McDataNascita_DateSelected);
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(119, 85);
            this.tbNome.MaxLength = 50;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(110, 21);
            this.tbNome.TabIndex = 12;
            this.tbNome.Enter += new System.EventHandler(this.TbEnter_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 85);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 18);
            this.lbNome.TabIndex = 11;
            this.lbNome.Text = "Nome";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTop.Controls.Add(this.btChiudi);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(750, 40);
            this.panelTop.TabIndex = 10;
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
            this.tbResidenza.Enter += new System.EventHandler(this.TbEnter_Click);
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
            this.tbPassword.Enter += new System.EventHandler(this.TbEnter_Click);
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
            this.tbUsername.Enter += new System.EventHandler(this.TbEnter_Click);
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
            // tbCognome
            // 
            this.tbCognome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCognome.Location = new System.Drawing.Point(119, 129);
            this.tbCognome.MaxLength = 50;
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(110, 21);
            this.tbCognome.TabIndex = 14;
            this.tbCognome.Enter += new System.EventHandler(this.TbEnter_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.btAggiornaPassowrd);
            this.panelCentro.Controls.Add(this.lbInfoPassword);
            this.panelCentro.Controls.Add(this.lbErrore);
            this.panelCentro.Controls.Add(this.lbCategoria);
            this.panelCentro.Controls.Add(this.cbCategoria);
            this.panelCentro.Controls.Add(this.btAAggiornaAggiungi);
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
            this.panelCentro.TabIndex = 15;
            // 
            // lbErrore
            // 
            this.lbErrore.AutoSize = true;
            this.lbErrore.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrore.ForeColor = System.Drawing.Color.Red;
            this.lbErrore.Location = new System.Drawing.Point(289, 370);
            this.lbErrore.Name = "lbErrore";
            this.lbErrore.Size = new System.Drawing.Size(172, 24);
            this.lbErrore.TabIndex = 20;
            this.lbErrore.Text = "Compila tutti i campi!";
            this.lbErrore.Visible = false;
            // 
            // lbInfoPassword
            // 
            this.lbInfoPassword.AutoSize = true;
            this.lbInfoPassword.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoPassword.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbInfoPassword.Location = new System.Drawing.Point(427, 58);
            this.lbInfoPassword.Name = "lbInfoPassword";
            this.lbInfoPassword.Size = new System.Drawing.Size(311, 96);
            this.lbInfoPassword.TabIndex = 21;
            this.lbInfoPassword.Text = "Al fine di aggiornare la password\r\ne\' necesario cliccare l\'apposito bottone\r\ndopo" +
    " aver compilato il campo con la \r\nnuova password";
            this.lbInfoPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btAggiornaPassowrd
            // 
            this.btAggiornaPassowrd.Location = new System.Drawing.Point(15, 475);
            this.btAggiornaPassowrd.Name = "btAggiornaPassowrd";
            this.btAggiornaPassowrd.Size = new System.Drawing.Size(116, 23);
            this.btAggiornaPassowrd.TabIndex = 22;
            this.btAggiornaPassowrd.Text = "Aggiorna password";
            this.btAggiornaPassowrd.UseVisualStyleBackColor = true;
            this.btAggiornaPassowrd.Visible = false;
            this.btAggiornaPassowrd.Click += new System.EventHandler(this.BtAggiornaPassowrd_Click);
            // 
            // FormLavoratore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 525);
            this.Controls.Add(this.lbCognome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tbCognome);
            this.Controls.Add(this.panelCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLavoratore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModificaLavoratore";
            this.Load += new System.EventHandler(this.FormModificaLavoratore_Load);
            this.panelTop.ResumeLayout(false);
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btChiudi;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btAAggiornaAggiungi;
        private System.Windows.Forms.Label lbCognome;
        private System.Windows.Forms.MonthCalendar mcDataNascita;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox tbDataNascita;
        private System.Windows.Forms.Label lbDataNascita;
        private System.Windows.Forms.TextBox tbResidenza;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbResidenza;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbCognome;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Label lbErrore;
        private System.Windows.Forms.Label lbInfoPassword;
        private System.Windows.Forms.Button btAggiornaPassowrd;
    }
}