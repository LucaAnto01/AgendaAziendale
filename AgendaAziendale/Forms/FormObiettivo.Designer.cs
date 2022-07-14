namespace AgendaAziendale.Forms
{
    partial class FormObiettivo
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
            this.btChiudi = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btMinimize = new System.Windows.Forms.Button();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.lbErrore = new System.Windows.Forms.Label();
            this.btAggiungiAggiorna = new System.Windows.Forms.Button();
            this.ckCompletato = new System.Windows.Forms.CheckBox();
            this.lbCompletato = new System.Windows.Forms.Label();
            this.tbDescrizione = new System.Windows.Forms.TextBox();
            this.lbDescrizione = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.SuspendLayout();
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
            this.btChiudi.Location = new System.Drawing.Point(461, 5);
            this.btChiudi.Name = "btChiudi";
            this.btChiudi.Size = new System.Drawing.Size(45, 30);
            this.btChiudi.TabIndex = 3;
            this.btChiudi.UseVisualStyleBackColor = false;
            this.btChiudi.Click += new System.EventHandler(this.BtChiudi_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelTop.Controls.Add(this.btMinimize);
            this.panelTop.Controls.Add(this.btChiudi);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(514, 40);
            this.panelTop.TabIndex = 68;
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
            this.btMinimize.Location = new System.Drawing.Point(409, 5);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(45, 30);
            this.btMinimize.TabIndex = 70;
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.BtMinimize_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelCentro.Controls.Add(this.lbErrore);
            this.panelCentro.Controls.Add(this.btAggiungiAggiorna);
            this.panelCentro.Controls.Add(this.ckCompletato);
            this.panelCentro.Controls.Add(this.lbCompletato);
            this.panelCentro.Controls.Add(this.tbDescrizione);
            this.panelCentro.Controls.Add(this.lbDescrizione);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 40);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(514, 402);
            this.panelCentro.TabIndex = 69;
            // 
            // lbErrore
            // 
            this.lbErrore.AutoSize = true;
            this.lbErrore.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrore.ForeColor = System.Drawing.Color.Red;
            this.lbErrore.Location = new System.Drawing.Point(12, 299);
            this.lbErrore.Name = "lbErrore";
            this.lbErrore.Size = new System.Drawing.Size(189, 24);
            this.lbErrore.TabIndex = 76;
            this.lbErrore.Text = "Compila la descrizione!";
            this.lbErrore.Visible = false;
            // 
            // btAggiungiAggiorna
            // 
            this.btAggiungiAggiorna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAggiungiAggiorna.ForeColor = System.Drawing.Color.White;
            this.btAggiungiAggiorna.Location = new System.Drawing.Point(15, 227);
            this.btAggiungiAggiorna.Name = "btAggiungiAggiorna";
            this.btAggiungiAggiorna.Size = new System.Drawing.Size(75, 23);
            this.btAggiungiAggiorna.TabIndex = 75;
            this.btAggiungiAggiorna.Text = "Agg";
            this.btAggiungiAggiorna.UseVisualStyleBackColor = true;
            this.btAggiungiAggiorna.Click += new System.EventHandler(this.BtAggiungiAggiorna_Click);
            // 
            // ckCompletato
            // 
            this.ckCompletato.AutoSize = true;
            this.ckCompletato.ForeColor = System.Drawing.Color.White;
            this.ckCompletato.Location = new System.Drawing.Point(119, 158);
            this.ckCompletato.Name = "ckCompletato";
            this.ckCompletato.Size = new System.Drawing.Size(79, 17);
            this.ckCompletato.TabIndex = 74;
            this.ckCompletato.Text = "Completato";
            this.ckCompletato.UseVisualStyleBackColor = true;
            // 
            // lbCompletato
            // 
            this.lbCompletato.AutoSize = true;
            this.lbCompletato.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompletato.ForeColor = System.Drawing.Color.White;
            this.lbCompletato.Location = new System.Drawing.Point(12, 156);
            this.lbCompletato.Name = "lbCompletato";
            this.lbCompletato.Size = new System.Drawing.Size(89, 18);
            this.lbCompletato.TabIndex = 73;
            this.lbCompletato.Text = "Completato";
            // 
            // tbDescrizione
            // 
            this.tbDescrizione.AcceptsReturn = true;
            this.tbDescrizione.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDescrizione.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescrizione.Location = new System.Drawing.Point(119, 48);
            this.tbDescrizione.MaxLength = 500;
            this.tbDescrizione.Multiline = true;
            this.tbDescrizione.Name = "tbDescrizione";
            this.tbDescrizione.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDescrizione.Size = new System.Drawing.Size(246, 46);
            this.tbDescrizione.TabIndex = 72;
            this.tbDescrizione.TextChanged += new System.EventHandler(this.Tb_TextChanged);
            // 
            // lbDescrizione
            // 
            this.lbDescrizione.AutoSize = true;
            this.lbDescrizione.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrizione.ForeColor = System.Drawing.Color.White;
            this.lbDescrizione.Location = new System.Drawing.Point(12, 48);
            this.lbDescrizione.Name = "lbDescrizione";
            this.lbDescrizione.Size = new System.Drawing.Size(93, 18);
            this.lbDescrizione.TabIndex = 71;
            this.lbDescrizione.Text = "Descrizione";
            // 
            // FormObiettivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 442);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormObiettivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormObiettivo";
            this.Load += new System.EventHandler(this.FormObiettivo_Load);
            this.panelTop.ResumeLayout(false);
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btChiudi;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.TextBox tbDescrizione;
        private System.Windows.Forms.Label lbDescrizione;
        private System.Windows.Forms.CheckBox ckCompletato;
        private System.Windows.Forms.Label lbCompletato;
        private System.Windows.Forms.Button btAggiungiAggiorna;
        private System.Windows.Forms.Label lbErrore;
        private System.Windows.Forms.Button btMinimize;
    }
}