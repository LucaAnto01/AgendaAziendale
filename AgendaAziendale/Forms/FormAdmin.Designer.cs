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
            this.btVisualizzaStorico = new System.Windows.Forms.Button();
            this.btGestioneEventi = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btGestioneLavoratori = new System.Windows.Forms.Button();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.btGestioneProgetti = new System.Windows.Forms.Button();
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
            this.panelSinistra.Controls.Add(this.btGestioneProgetti);
            this.panelSinistra.Controls.Add(this.btVisualizzaStorico);
            this.panelSinistra.Controls.Add(this.btGestioneEventi);
            this.panelSinistra.Controls.Add(this.btLogout);
            this.panelSinistra.Controls.Add(this.btGestioneLavoratori);
            this.panelSinistra.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSinistra.Location = new System.Drawing.Point(0, 40);
            this.panelSinistra.Name = "panelSinistra";
            this.panelSinistra.Size = new System.Drawing.Size(300, 610);
            this.panelSinistra.TabIndex = 4;
            // 
            // btVisualizzaStorico
            // 
            this.btVisualizzaStorico.BackColor = System.Drawing.Color.DarkGray;
            this.btVisualizzaStorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVisualizzaStorico.ForeColor = System.Drawing.Color.White;
            this.btVisualizzaStorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVisualizzaStorico.Location = new System.Drawing.Point(50, 365);
            this.btVisualizzaStorico.Name = "btVisualizzaStorico";
            this.btVisualizzaStorico.Size = new System.Drawing.Size(200, 35);
            this.btVisualizzaStorico.TabIndex = 6;
            this.btVisualizzaStorico.Text = "Storico";
            this.btVisualizzaStorico.UseVisualStyleBackColor = false;
            this.btVisualizzaStorico.Click += new System.EventHandler(this.BtVisualizzaStorico_Click);
            // 
            // btGestioneEventi
            // 
            this.btGestioneEventi.BackColor = System.Drawing.Color.DarkGray;
            this.btGestioneEventi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGestioneEventi.ForeColor = System.Drawing.Color.White;
            this.btGestioneEventi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGestioneEventi.Location = new System.Drawing.Point(50, 185);
            this.btGestioneEventi.Name = "btGestioneEventi";
            this.btGestioneEventi.Size = new System.Drawing.Size(200, 35);
            this.btGestioneEventi.TabIndex = 3;
            this.btGestioneEventi.Text = "Gestione eventi";
            this.btGestioneEventi.UseVisualStyleBackColor = false;
            this.btGestioneEventi.Click += new System.EventHandler(this.BtGestioneEventi_Click);
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
            // btGestioneLavoratori
            // 
            this.btGestioneLavoratori.BackColor = System.Drawing.Color.DarkGray;
            this.btGestioneLavoratori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGestioneLavoratori.ForeColor = System.Drawing.Color.White;
            this.btGestioneLavoratori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGestioneLavoratori.Location = new System.Drawing.Point(50, 95);
            this.btGestioneLavoratori.Name = "btGestioneLavoratori";
            this.btGestioneLavoratori.Size = new System.Drawing.Size(200, 35);
            this.btGestioneLavoratori.TabIndex = 0;
            this.btGestioneLavoratori.Text = "Gestione lavoratori";
            this.btGestioneLavoratori.UseVisualStyleBackColor = false;
            this.btGestioneLavoratori.Click += new System.EventHandler(this.BtGestioneLavoratori_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(300, 40);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(700, 610);
            this.panelCentro.TabIndex = 5;
            // 
            // btGestioneProgetti
            // 
            this.btGestioneProgetti.BackColor = System.Drawing.Color.DarkGray;
            this.btGestioneProgetti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGestioneProgetti.ForeColor = System.Drawing.Color.White;
            this.btGestioneProgetti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGestioneProgetti.Location = new System.Drawing.Point(50, 275);
            this.btGestioneProgetti.Name = "btGestioneProgetti";
            this.btGestioneProgetti.Size = new System.Drawing.Size(200, 35);
            this.btGestioneProgetti.TabIndex = 7;
            this.btGestioneProgetti.Text = "Gestione progetti";
            this.btGestioneProgetti.UseVisualStyleBackColor = false;
            this.btGestioneProgetti.Click += new System.EventHandler(this.BtGestioneProgetti_Click);
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
        private System.Windows.Forms.Button btGestioneLavoratori;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btGestioneEventi;
        private System.Windows.Forms.Button btVisualizzaStorico;
        private System.Windows.Forms.Button btGestioneProgetti;
    }
}