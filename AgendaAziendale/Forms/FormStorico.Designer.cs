namespace AgendaAziendale.Forms
{
    partial class FormStorico
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
            this.panelUCcontenitore = new System.Windows.Forms.Panel();
            this.panelCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.panelUCcontenitore);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(700, 610);
            this.panelCentro.TabIndex = 0;
            // 
            // panelUCcontenitore
            // 
            this.panelUCcontenitore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUCcontenitore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUCcontenitore.Location = new System.Drawing.Point(0, 0);
            this.panelUCcontenitore.Name = "panelUCcontenitore";
            this.panelUCcontenitore.Size = new System.Drawing.Size(700, 610);
            this.panelUCcontenitore.TabIndex = 4;
            // 
            // FormStorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 610);
            this.Controls.Add(this.panelCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStorico";
            this.Text = "FormStoricoEventi";
            this.Load += new System.EventHandler(this.FormStorico_Load);
            this.panelCentro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Panel panelUCcontenitore;
    }
}