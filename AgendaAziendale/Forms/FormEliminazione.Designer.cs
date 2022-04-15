namespace AgendaAziendale.Forms
{
    partial class FormEliminazione
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
            this.panelCentro = new System.Windows.Forms.Panel();
            this.btElimina = new System.Windows.Forms.Button();
            this.cbCampoEliminazione = new System.Windows.Forms.ComboBox();
            this.lbCampoEliminazione = new System.Windows.Forms.Label();
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
            this.panelTop.Size = new System.Drawing.Size(683, 40);
            this.panelTop.TabIndex = 37;
            // 
            // btChiudi
            // 
            this.btChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btChiudi.BackColor = System.Drawing.Color.Transparent;
            this.btChiudi.BackgroundImage = global::AgendaAziendale.Properties.Resources.Chiudi;
            this.btChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btChiudi.Location = new System.Drawing.Point(630, 5);
            this.btChiudi.Name = "btChiudi";
            this.btChiudi.Size = new System.Drawing.Size(45, 30);
            this.btChiudi.TabIndex = 3;
            this.btChiudi.UseVisualStyleBackColor = false;
            this.btChiudi.Click += new System.EventHandler(this.BtChiudi_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.btElimina);
            this.panelCentro.Controls.Add(this.cbCampoEliminazione);
            this.panelCentro.Controls.Add(this.lbCampoEliminazione);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 40);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(683, 502);
            this.panelCentro.TabIndex = 38;
            // 
            // btElimina
            // 
            this.btElimina.Location = new System.Drawing.Point(15, 95);
            this.btElimina.Name = "btElimina";
            this.btElimina.Size = new System.Drawing.Size(75, 23);
            this.btElimina.TabIndex = 41;
            this.btElimina.Text = "Elimina";
            this.btElimina.UseVisualStyleBackColor = true;
            this.btElimina.Click += new System.EventHandler(this.BtElimina_Click);
            // 
            // cbCampoEliminazione
            // 
            this.cbCampoEliminazione.FormattingEnabled = true;
            this.cbCampoEliminazione.Location = new System.Drawing.Point(171, 41);
            this.cbCampoEliminazione.Name = "cbCampoEliminazione";
            this.cbCampoEliminazione.Size = new System.Drawing.Size(177, 21);
            this.cbCampoEliminazione.TabIndex = 40;
            // 
            // lbCampoEliminazione
            // 
            this.lbCampoEliminazione.AutoSize = true;
            this.lbCampoEliminazione.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampoEliminazione.Location = new System.Drawing.Point(12, 41);
            this.lbCampoEliminazione.Name = "lbCampoEliminazione";
            this.lbCampoEliminazione.Size = new System.Drawing.Size(147, 18);
            this.lbCampoEliminazione.TabIndex = 39;
            this.lbCampoEliminazione.Text = "CampoEliminazione";
            // 
            // FormEliminazioneAttivita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 542);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEliminazioneAttivita";
            this.Text = "FormEliminazioneAttivita";
            this.Load += new System.EventHandler(this.FormEliminazioneAttivita_Load);
            this.panelTop.ResumeLayout(false);
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btChiudi;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.ComboBox cbCampoEliminazione;
        private System.Windows.Forms.Label lbCampoEliminazione;
        private System.Windows.Forms.Button btElimina;
    }
}