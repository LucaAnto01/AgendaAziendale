namespace AgendaAziendale.Forms
{
    partial class FormObiettivi
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
            this.btMinimize = new System.Windows.Forms.Button();
            this.btChiudi = new System.Windows.Forms.Button();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.panelContenitore = new System.Windows.Forms.Panel();
            this.btAggiugniObiettivo = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelTop.Controls.Add(this.btMinimize);
            this.panelTop.Controls.Add(this.btChiudi);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(750, 40);
            this.panelTop.TabIndex = 69;
            // 
            // btMinimize
            // 
            this.btMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btMinimize.BackgroundImage = global::AgendaAziendale.Properties.Resources.Minimize;
            this.btMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMinimize.FlatAppearance.BorderSize = 0;
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.Location = new System.Drawing.Point(645, 5);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(45, 30);
            this.btMinimize.TabIndex = 71;
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.BtMinimize_Click);
            // 
            // btChiudi
            // 
            this.btChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btChiudi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btChiudi.BackgroundImage = global::AgendaAziendale.Properties.Resources.Chiudi;
            this.btChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btChiudi.FlatAppearance.BorderSize = 0;
            this.btChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChiudi.Location = new System.Drawing.Point(697, 5);
            this.btChiudi.Name = "btChiudi";
            this.btChiudi.Size = new System.Drawing.Size(45, 30);
            this.btChiudi.TabIndex = 3;
            this.btChiudi.UseVisualStyleBackColor = false;
            this.btChiudi.Click += new System.EventHandler(this.BtChiudi_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelCentro.Controls.Add(this.panelContenitore);
            this.panelCentro.Controls.Add(this.btAggiugniObiettivo);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(750, 525);
            this.panelCentro.TabIndex = 70;
            // 
            // panelContenitore
            // 
            this.panelContenitore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenitore.Location = new System.Drawing.Point(53, 75);
            this.panelContenitore.Name = "panelContenitore";
            this.panelContenitore.Size = new System.Drawing.Size(645, 445);
            this.panelContenitore.TabIndex = 70;
            // 
            // btAggiugniObiettivo
            // 
            this.btAggiugniObiettivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btAggiugniObiettivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAggiugniObiettivo.ForeColor = System.Drawing.Color.White;
            this.btAggiugniObiettivo.Location = new System.Drawing.Point(316, 46);
            this.btAggiugniObiettivo.Name = "btAggiugniObiettivo";
            this.btAggiugniObiettivo.Size = new System.Drawing.Size(118, 23);
            this.btAggiugniObiettivo.TabIndex = 69;
            this.btAggiugniObiettivo.Text = "Aggiungi obiettivo";
            this.btAggiugniObiettivo.UseVisualStyleBackColor = false;
            this.btAggiugniObiettivo.Click += new System.EventHandler(this.BtAggiugniObiettivo_Click);
            // 
            // FormObiettivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 525);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormObiettivi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormObiettivi";
            this.Load += new System.EventHandler(this.FormObiettivi_Load);
            this.panelTop.ResumeLayout(false);
            this.panelCentro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btChiudi;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Button btAggiugniObiettivo;
        private System.Windows.Forms.Panel panelContenitore;
        private System.Windows.Forms.Button btMinimize;
    }
}