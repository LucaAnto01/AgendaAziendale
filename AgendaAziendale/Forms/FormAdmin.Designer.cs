namespace AgendaAziendale
{
    partial class FormAdmin
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
            this.panelSinistra = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.btGestioneUtenti = new System.Windows.Forms.Button();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.btGestioneAttivita = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelSinistra.SuspendLayout();
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
            this.panelTop.TabIndex = 3;
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
            // panelSinistra
            // 
            this.panelSinistra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSinistra.Controls.Add(this.btGestioneAttivita);
            this.panelSinistra.Controls.Add(this.btLogout);
            this.panelSinistra.Controls.Add(this.btGestioneUtenti);
            this.panelSinistra.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSinistra.Location = new System.Drawing.Point(0, 40);
            this.panelSinistra.Name = "panelSinistra";
            this.panelSinistra.Size = new System.Drawing.Size(300, 610);
            this.panelSinistra.TabIndex = 4;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.DarkGray;
            this.btLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(25, 500);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(255, 55);
            this.btLogout.TabIndex = 2;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.BtLogout_Click);
            // 
            // btGestioneUtenti
            // 
            this.btGestioneUtenti.BackColor = System.Drawing.Color.DarkGray;
            this.btGestioneUtenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGestioneUtenti.ForeColor = System.Drawing.Color.White;
            this.btGestioneUtenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGestioneUtenti.Location = new System.Drawing.Point(50, 85);
            this.btGestioneUtenti.Name = "btGestioneUtenti";
            this.btGestioneUtenti.Size = new System.Drawing.Size(200, 35);
            this.btGestioneUtenti.TabIndex = 0;
            this.btGestioneUtenti.Text = "Gestione utenti";
            this.btGestioneUtenti.UseVisualStyleBackColor = false;
            this.btGestioneUtenti.Click += new System.EventHandler(this.BtGestioneUtenti_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(300, 40);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(700, 610);
            this.panelCentro.TabIndex = 5;
            // 
            // btGestioneAttivita
            // 
            this.btGestioneAttivita.BackColor = System.Drawing.Color.DarkGray;
            this.btGestioneAttivita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGestioneAttivita.ForeColor = System.Drawing.Color.White;
            this.btGestioneAttivita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGestioneAttivita.Location = new System.Drawing.Point(50, 222);
            this.btGestioneAttivita.Name = "btGestioneAttivita";
            this.btGestioneAttivita.Size = new System.Drawing.Size(200, 35);
            this.btGestioneAttivita.TabIndex = 3;
            this.btGestioneAttivita.Text = "Gestione attività";
            this.btGestioneAttivita.UseVisualStyleBackColor = false;
            this.btGestioneAttivita.Click += new System.EventHandler(this.BtGestioneAttivita_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.panelSinistra);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panelTop.ResumeLayout(false);
            this.panelSinistra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btChiudi;
        private System.Windows.Forms.Panel panelSinistra;
        private System.Windows.Forms.Button btGestioneUtenti;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btGestioneAttivita;
    }
}