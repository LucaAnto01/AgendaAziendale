namespace AgendaAziendale.Forms
{
    partial class FormGestione
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
            this.btAggiungi = new System.Windows.Forms.Button();
            this.panelCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.panelUCcontenitore);
            this.panelCentro.Controls.Add(this.btAggiungi);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(700, 610);
            this.panelCentro.TabIndex = 0;
            // 
            // panelUCcontenitore
            // 
            this.panelUCcontenitore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUCcontenitore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUCcontenitore.Location = new System.Drawing.Point(27, 151);
            this.panelUCcontenitore.Name = "panelUCcontenitore";
            this.panelUCcontenitore.Size = new System.Drawing.Size(645, 445);
            this.panelUCcontenitore.TabIndex = 3;
            // 
            // btAggiungi
            // 
            this.btAggiungi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAggiungi.BackColor = System.Drawing.Color.DarkGray;
            this.btAggiungi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAggiungi.ForeColor = System.Drawing.Color.White;
            this.btAggiungi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAggiungi.Location = new System.Drawing.Point(215, 55);
            this.btAggiungi.Name = "btAggiungi";
            this.btAggiungi.Size = new System.Drawing.Size(265, 57);
            this.btAggiungi.TabIndex = 2;
            this.btAggiungi.Text = "Testo azione";
            this.btAggiungi.UseVisualStyleBackColor = false;
            this.btAggiungi.Click += new System.EventHandler(this.BtAggiungi_Click);
            // 
            // FormGestione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 610);
            this.Controls.Add(this.panelCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestione";
            this.Text = "FormGestione";
            this.Load += new System.EventHandler(this.FormGestione_Load);
            this.panelCentro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Button btAggiungi;
        private System.Windows.Forms.Panel panelUCcontenitore;
    }
}