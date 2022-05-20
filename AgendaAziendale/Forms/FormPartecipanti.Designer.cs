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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btChiudi = new System.Windows.Forms.Button();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.btRimuovi = new System.Windows.Forms.Button();
            this.btAggiungi = new System.Windows.Forms.Button();
            this.cbLavoratore = new System.Windows.Forms.ComboBox();
            this.lbLavoratore = new System.Windows.Forms.Label();
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
            this.panelTop.Size = new System.Drawing.Size(598, 40);
            this.panelTop.TabIndex = 69;
            // 
            // btChiudi
            // 
            this.btChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btChiudi.BackColor = System.Drawing.Color.Transparent;
            this.btChiudi.BackgroundImage = global::AgendaAziendale.Properties.Resources.Chiudi;
            this.btChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btChiudi.Location = new System.Drawing.Point(545, 5);
            this.btChiudi.Name = "btChiudi";
            this.btChiudi.Size = new System.Drawing.Size(45, 30);
            this.btChiudi.TabIndex = 3;
            this.btChiudi.UseVisualStyleBackColor = false;
            this.btChiudi.Click += new System.EventHandler(this.BtChiudi_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.btRimuovi);
            this.panelCentro.Controls.Add(this.btAggiungi);
            this.panelCentro.Controls.Add(this.cbLavoratore);
            this.panelCentro.Controls.Add(this.lbLavoratore);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 40);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(598, 434);
            this.panelCentro.TabIndex = 70;
            // 
            // btRimuovi
            // 
            this.btRimuovi.Location = new System.Drawing.Point(124, 142);
            this.btRimuovi.Name = "btRimuovi";
            this.btRimuovi.Size = new System.Drawing.Size(75, 23);
            this.btRimuovi.TabIndex = 75;
            this.btRimuovi.Text = "Rimuovi";
            this.btRimuovi.UseVisualStyleBackColor = true;
            this.btRimuovi.Click += new System.EventHandler(this.BtRimuovi_Click);
            // 
            // btAggiungi
            // 
            this.btAggiungi.Location = new System.Drawing.Point(15, 142);
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
            this.cbLavoratore.Size = new System.Drawing.Size(172, 21);
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
            this.ClientSize = new System.Drawing.Size(598, 474);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btChiudi;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Label lbLavoratore;
        private System.Windows.Forms.Button btRimuovi;
        private System.Windows.Forms.Button btAggiungi;
        private System.Windows.Forms.ComboBox cbLavoratore;
    }
}