namespace AgendaAziendale
{
    partial class FormLogin
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelSinistra = new System.Windows.Forms.Panel();
            this.lbIntestazioneSinistra = new System.Windows.Forms.Label();
            this.panelSinistraTop = new System.Windows.Forms.Panel();
            this.pctbxLogo = new System.Windows.Forms.PictureBox();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.btAccedi = new System.Windows.Forms.Button();
            this.btChiudi = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelSinistra.SuspendLayout();
            this.panelSinistraTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(1000, 40);
            this.panelTop.TabIndex = 2;
            // 
            // panelSinistra
            // 
            this.panelSinistra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSinistra.Controls.Add(this.lbIntestazioneSinistra);
            this.panelSinistra.Controls.Add(this.panelSinistraTop);
            this.panelSinistra.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSinistra.Location = new System.Drawing.Point(0, 40);
            this.panelSinistra.Name = "panelSinistra";
            this.panelSinistra.Size = new System.Drawing.Size(300, 610);
            this.panelSinistra.TabIndex = 3;
            // 
            // lbIntestazioneSinistra
            // 
            this.lbIntestazioneSinistra.AutoSize = true;
            this.lbIntestazioneSinistra.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntestazioneSinistra.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbIntestazioneSinistra.Location = new System.Drawing.Point(44, 275);
            this.lbIntestazioneSinistra.Name = "lbIntestazioneSinistra";
            this.lbIntestazioneSinistra.Size = new System.Drawing.Size(213, 66);
            this.lbIntestazioneSinistra.TabIndex = 1;
            this.lbIntestazioneSinistra.Text = "Effettua l\'accesso \r\nalla piattaforma";
            this.lbIntestazioneSinistra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelSinistraTop
            // 
            this.panelSinistraTop.Controls.Add(this.pctbxLogo);
            this.panelSinistraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSinistraTop.Location = new System.Drawing.Point(0, 0);
            this.panelSinistraTop.Name = "panelSinistraTop";
            this.panelSinistraTop.Size = new System.Drawing.Size(300, 200);
            this.panelSinistraTop.TabIndex = 2;
            // 
            // pctbxLogo
            // 
            this.pctbxLogo.Location = new System.Drawing.Point(50, 28);
            this.pctbxLogo.Name = "pctbxLogo";
            this.pctbxLogo.Size = new System.Drawing.Size(200, 145);
            this.pctbxLogo.TabIndex = 0;
            this.pctbxLogo.TabStop = false;
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.btAccedi);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(300, 40);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(700, 610);
            this.panelCentro.TabIndex = 4;
            // 
            // btAccedi
            // 
            this.btAccedi.Location = new System.Drawing.Point(318, 478);
            this.btAccedi.Name = "btAccedi";
            this.btAccedi.Size = new System.Drawing.Size(75, 23);
            this.btAccedi.TabIndex = 0;
            this.btAccedi.Text = "Accedi";
            this.btAccedi.UseVisualStyleBackColor = true;
            this.btAccedi.Click += new System.EventHandler(this.BtAccedi_Click);
            // 
            // btChiudi
            // 
            this.btChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btChiudi.BackColor = System.Drawing.Color.Transparent;
            this.btChiudi.BackgroundImage = global::AgendaAziendale.Properties.Resources.Chiudi;
            this.btChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btChiudi.Location = new System.Drawing.Point(947, 5);
            this.btChiudi.Name = "btChiudi";
            this.btChiudi.Size = new System.Drawing.Size(45, 30);
            this.btChiudi.TabIndex = 3;
            this.btChiudi.UseVisualStyleBackColor = false;
            this.btChiudi.Click += new System.EventHandler(this.BtChiudi_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.panelSinistra);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelTop.ResumeLayout(false);
            this.panelSinistra.ResumeLayout(false);
            this.panelSinistra.PerformLayout();
            this.panelSinistraTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).EndInit();
            this.panelCentro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSinistra;
        private System.Windows.Forms.Label lbIntestazioneSinistra;
        private System.Windows.Forms.Panel panelSinistraTop;
        private System.Windows.Forms.PictureBox pctbxLogo;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Button btAccedi;
        private System.Windows.Forms.Button btChiudi;
    }
}

