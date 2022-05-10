namespace AgendaAziendale.Forms
{
    partial class FormAgenda
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
            this.panelSinistra = new System.Windows.Forms.Panel();
            this.btGestione = new System.Windows.Forms.Button();
            this.btVisualizzaStorico = new System.Windows.Forms.Button();
            this.btProgettiEventi = new System.Windows.Forms.Button();
            this.btVisualizzaAgenda = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
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
            this.panelTop.TabIndex = 4;
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
            // panelCentro
            // 
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(300, 40);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(700, 610);
            this.panelCentro.TabIndex = 7;
            // 
            // panelSinistra
            // 
            this.panelSinistra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSinistra.Controls.Add(this.btGestione);
            this.panelSinistra.Controls.Add(this.btVisualizzaStorico);
            this.panelSinistra.Controls.Add(this.btProgettiEventi);
            this.panelSinistra.Controls.Add(this.btVisualizzaAgenda);
            this.panelSinistra.Controls.Add(this.btLogout);
            this.panelSinistra.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSinistra.Location = new System.Drawing.Point(0, 40);
            this.panelSinistra.Name = "panelSinistra";
            this.panelSinistra.Size = new System.Drawing.Size(300, 610);
            this.panelSinistra.TabIndex = 6;
            // 
            // btGestione
            // 
            this.btGestione.BackColor = System.Drawing.Color.DarkGray;
            this.btGestione.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGestione.ForeColor = System.Drawing.Color.White;
            this.btGestione.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGestione.Location = new System.Drawing.Point(50, 267);
            this.btGestione.Name = "btGestione";
            this.btGestione.Size = new System.Drawing.Size(200, 35);
            this.btGestione.TabIndex = 6;
            this.btGestione.Text = "Gestione EvProgetti";
            this.btGestione.UseVisualStyleBackColor = false;
            this.btGestione.Visible = false;
            this.btGestione.Click += new System.EventHandler(this.BtGestione_Click);
            // 
            // btVisualizzaStorico
            // 
            this.btVisualizzaStorico.BackColor = System.Drawing.Color.DarkGray;
            this.btVisualizzaStorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVisualizzaStorico.ForeColor = System.Drawing.Color.White;
            this.btVisualizzaStorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVisualizzaStorico.Location = new System.Drawing.Point(50, 358);
            this.btVisualizzaStorico.Name = "btVisualizzaStorico";
            this.btVisualizzaStorico.Size = new System.Drawing.Size(200, 35);
            this.btVisualizzaStorico.TabIndex = 5;
            this.btVisualizzaStorico.Text = "Storico";
            this.btVisualizzaStorico.UseVisualStyleBackColor = false;
            this.btVisualizzaStorico.Click += new System.EventHandler(this.BtVisualizzaStorico_Click);
            // 
            // btProgettiEventi
            // 
            this.btProgettiEventi.BackColor = System.Drawing.Color.DarkGray;
            this.btProgettiEventi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProgettiEventi.ForeColor = System.Drawing.Color.White;
            this.btProgettiEventi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProgettiEventi.Location = new System.Drawing.Point(50, 176);
            this.btProgettiEventi.Name = "btProgettiEventi";
            this.btProgettiEventi.Size = new System.Drawing.Size(200, 35);
            this.btProgettiEventi.TabIndex = 4;
            this.btProgettiEventi.Text = "ProgettiEventi";
            this.btProgettiEventi.UseVisualStyleBackColor = false;
            this.btProgettiEventi.Click += new System.EventHandler(this.BtProgettiEventi_Click);
            // 
            // btVisualizzaAgenda
            // 
            this.btVisualizzaAgenda.BackColor = System.Drawing.Color.DarkGray;
            this.btVisualizzaAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVisualizzaAgenda.ForeColor = System.Drawing.Color.White;
            this.btVisualizzaAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVisualizzaAgenda.Location = new System.Drawing.Point(50, 85);
            this.btVisualizzaAgenda.Name = "btVisualizzaAgenda";
            this.btVisualizzaAgenda.Size = new System.Drawing.Size(200, 35);
            this.btVisualizzaAgenda.TabIndex = 3;
            this.btVisualizzaAgenda.Text = "Agenda";
            this.btVisualizzaAgenda.UseVisualStyleBackColor = false;
            this.btVisualizzaAgenda.Click += new System.EventHandler(this.BtVisualizzaAgenda_Click);
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
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.panelSinistra);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgenda";
            this.Text = "FormAgenda";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            this.panelTop.ResumeLayout(false);
            this.panelSinistra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btChiudi;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Panel panelSinistra;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btVisualizzaAgenda;
        private System.Windows.Forms.Button btProgettiEventi;
        private System.Windows.Forms.Button btVisualizzaStorico;
        private System.Windows.Forms.Button btGestione;
    }
}