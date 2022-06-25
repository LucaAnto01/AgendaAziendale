namespace AgendaAziendale.Forms
{
    partial class FormVisualizzazioneAttivita
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
            this.panelCentro = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.flpSinistra = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDestra = new System.Windows.Forms.FlowLayoutPanel();
            this.lbEventi = new System.Windows.Forms.Label();
            this.lbProgetti = new System.Windows.Forms.Label();
            this.panelCentro.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.flpDestra);
            this.panelCentro.Controls.Add(this.flpSinistra);
            this.panelCentro.Controls.Add(this.panelTop);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(700, 610);
            this.panelCentro.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lbProgetti);
            this.panelTop.Controls.Add(this.lbEventi);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(700, 45);
            this.panelTop.TabIndex = 0;
            // 
            // flpSinistra
            // 
            this.flpSinistra.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSinistra.Location = new System.Drawing.Point(0, 45);
            this.flpSinistra.Name = "flpSinistra";
            this.flpSinistra.Size = new System.Drawing.Size(350, 565);
            this.flpSinistra.TabIndex = 1;
            // 
            // flpDestra
            // 
            this.flpDestra.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpDestra.Location = new System.Drawing.Point(350, 45);
            this.flpDestra.Name = "flpDestra";
            this.flpDestra.Size = new System.Drawing.Size(350, 565);
            this.flpDestra.TabIndex = 2;
            // 
            // lbEventi
            // 
            this.lbEventi.AutoSize = true;
            this.lbEventi.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventi.Location = new System.Drawing.Point(141, 10);
            this.lbEventi.Name = "lbEventi";
            this.lbEventi.Size = new System.Drawing.Size(69, 24);
            this.lbEventi.TabIndex = 0;
            this.lbEventi.Text = "Eventi";
            // 
            // lbProgetti
            // 
            this.lbProgetti.AutoSize = true;
            this.lbProgetti.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgetti.Location = new System.Drawing.Point(483, 10);
            this.lbProgetti.Name = "lbProgetti";
            this.lbProgetti.Size = new System.Drawing.Size(85, 24);
            this.lbProgetti.TabIndex = 1;
            this.lbProgetti.Text = "Progetti";
            // 
            // FormVisualizzazioneAttivita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 610);
            this.Controls.Add(this.panelCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVisualizzazioneAttivita";
            this.Text = "FormVisualizzazioneAttivita";
            this.Load += new System.EventHandler(this.FormVisualizzazioneAttivita_Load);
            this.panelCentro.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.FlowLayoutPanel flpDestra;
        private System.Windows.Forms.FlowLayoutPanel flpSinistra;
        private System.Windows.Forms.Label lbProgetti;
        private System.Windows.Forms.Label lbEventi;
    }
}