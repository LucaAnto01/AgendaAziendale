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
            this.flpCentro = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpCentro
            // 
            this.flpCentro.BackColor = System.Drawing.Color.White;
            this.flpCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCentro.Location = new System.Drawing.Point(0, 0);
            this.flpCentro.Name = "flpCentro";
            this.flpCentro.Size = new System.Drawing.Size(700, 610);
            this.flpCentro.TabIndex = 0;
            // 
            // FormVisualizzazioneAttivita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 610);
            this.Controls.Add(this.flpCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVisualizzazioneAttivita";
            this.Text = "FormVisualizzazioneAttivita";
            this.Load += new System.EventHandler(this.FormVisualizzazioneAttivita_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCentro;
    }
}