namespace AgendaAziendale.Forms.UserControls
{
    partial class UCAttivita
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitolo = new System.Windows.Forms.Label();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.lbClienteLuogo = new System.Windows.Forms.Label();
            this.lbDataInizioFine = new System.Windows.Forms.Label();
            this.pbProgetto = new System.Windows.Forms.ProgressBar();
            this.panelCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitolo
            // 
            this.lbTitolo.AutoSize = true;
            this.lbTitolo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitolo.Location = new System.Drawing.Point(3, 15);
            this.lbTitolo.Name = "lbTitolo";
            this.lbTitolo.Size = new System.Drawing.Size(64, 24);
            this.lbTitolo.TabIndex = 0;
            this.lbTitolo.Text = "Titolo";
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCentro.Controls.Add(this.pbProgetto);
            this.panelCentro.Controls.Add(this.lbDataInizioFine);
            this.panelCentro.Controls.Add(this.lbClienteLuogo);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(256, 138);
            this.panelCentro.TabIndex = 1;
            // 
            // lbClienteLuogo
            // 
            this.lbClienteLuogo.AutoSize = true;
            this.lbClienteLuogo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteLuogo.Location = new System.Drawing.Point(3, 49);
            this.lbClienteLuogo.Name = "lbClienteLuogo";
            this.lbClienteLuogo.Size = new System.Drawing.Size(93, 17);
            this.lbClienteLuogo.TabIndex = 2;
            this.lbClienteLuogo.Text = "ClienteLuogo";
            // 
            // lbDataInizioFine
            // 
            this.lbDataInizioFine.AutoSize = true;
            this.lbDataInizioFine.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataInizioFine.Location = new System.Drawing.Point(3, 69);
            this.lbDataInizioFine.Name = "lbDataInizioFine";
            this.lbDataInizioFine.Size = new System.Drawing.Size(144, 17);
            this.lbDataInizioFine.TabIndex = 3;
            this.lbDataInizioFine.Text = "DataInizio - DataFine";
            // 
            // pbProgetto
            // 
            this.pbProgetto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgetto.Location = new System.Drawing.Point(5, 103);
            this.pbProgetto.Name = "pbProgetto";
            this.pbProgetto.Size = new System.Drawing.Size(246, 23);
            this.pbProgetto.TabIndex = 4;
            // 
            // UCAttivita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbTitolo);
            this.Controls.Add(this.panelCentro);
            this.Name = "UCAttivita";
            this.Size = new System.Drawing.Size(256, 138);
            this.Load += new System.EventHandler(this.UCAttivita_Load);
            this.MouseEnter += new System.EventHandler(this.UCAttivita_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCAttivita_MouseLeave);
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitolo;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Label lbClienteLuogo;
        private System.Windows.Forms.Label lbDataInizioFine;
        private System.Windows.Forms.ProgressBar pbProgetto;
    }
}
