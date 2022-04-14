namespace AgendaAziendale.Forms
{
    partial class FormModificaAttivita
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
            this.lbCampo = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.tbValore = new System.Windows.Forms.TextBox();
            this.lbValore = new System.Windows.Forms.Label();
            this.btModifica = new System.Windows.Forms.Button();
            this.mcModifica = new System.Windows.Forms.MonthCalendar();
            this.panelTop.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTop.Controls.Add(this.btChiudi);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(580, 40);
            this.panelTop.TabIndex = 37;
            // 
            // btChiudi
            // 
            this.btChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btChiudi.BackColor = System.Drawing.Color.Transparent;
            this.btChiudi.BackgroundImage = global::AgendaAziendale.Properties.Resources.Chiudi;
            this.btChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btChiudi.Location = new System.Drawing.Point(527, 5);
            this.btChiudi.Name = "btChiudi";
            this.btChiudi.Size = new System.Drawing.Size(45, 30);
            this.btChiudi.TabIndex = 3;
            this.btChiudi.UseVisualStyleBackColor = false;
            this.btChiudi.Click += new System.EventHandler(this.BtChiudi_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.mcModifica);
            this.panelCentro.Controls.Add(this.btModifica);
            this.panelCentro.Controls.Add(this.tbValore);
            this.panelCentro.Controls.Add(this.lbValore);
            this.panelCentro.Controls.Add(this.lbCampo);
            this.panelCentro.Controls.Add(this.cbCampo);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 40);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(580, 406);
            this.panelCentro.TabIndex = 38;
            // 
            // lbCampo
            // 
            this.lbCampo.AutoSize = true;
            this.lbCampo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampo.Location = new System.Drawing.Point(12, 37);
            this.lbCampo.Name = "lbCampo";
            this.lbCampo.Size = new System.Drawing.Size(57, 18);
            this.lbCampo.TabIndex = 40;
            this.lbCampo.Text = "Campo";
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(119, 36);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(110, 21);
            this.cbCampo.TabIndex = 39;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.CbCampo_SelectedIndexChanged);
            // 
            // tbValore
            // 
            this.tbValore.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValore.Location = new System.Drawing.Point(119, 79);
            this.tbValore.MaxLength = 50;
            this.tbValore.Name = "tbValore";
            this.tbValore.Size = new System.Drawing.Size(110, 21);
            this.tbValore.TabIndex = 42;
            this.tbValore.Visible = false;
            // 
            // lbValore
            // 
            this.lbValore.AutoSize = true;
            this.lbValore.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValore.Location = new System.Drawing.Point(12, 79);
            this.lbValore.Name = "lbValore";
            this.lbValore.Size = new System.Drawing.Size(52, 18);
            this.lbValore.TabIndex = 41;
            this.lbValore.Text = "Valore";
            this.lbValore.Visible = false;
            // 
            // btModifica
            // 
            this.btModifica.Location = new System.Drawing.Point(15, 131);
            this.btModifica.Name = "btModifica";
            this.btModifica.Size = new System.Drawing.Size(75, 23);
            this.btModifica.TabIndex = 43;
            this.btModifica.Text = "Modifica";
            this.btModifica.UseVisualStyleBackColor = true;
            this.btModifica.Click += new System.EventHandler(this.BtModifica_Click);
            // 
            // mcModifica
            // 
            this.mcModifica.Location = new System.Drawing.Point(282, 36);
            this.mcModifica.Name = "mcModifica";
            this.mcModifica.TabIndex = 44;
            this.mcModifica.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McModifica_DateSelected);
            // 
            // FormModificaAttivita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 446);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModificaAttivita";
            this.Text = "FormModificaAttivita";
            this.Load += new System.EventHandler(this.FormModificaAttivita_Load);
            this.panelTop.ResumeLayout(false);
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btChiudi;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Label lbCampo;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.TextBox tbValore;
        private System.Windows.Forms.Label lbValore;
        private System.Windows.Forms.Button btModifica;
        private System.Windows.Forms.MonthCalendar mcModifica;
    }
}