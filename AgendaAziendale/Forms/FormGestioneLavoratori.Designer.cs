namespace AgendaAziendale.Forms
{
    partial class FormGestioneLavoratori
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
            this.btAggiungiLavoratore = new System.Windows.Forms.Button();
            this.btModificaLavoratore = new System.Windows.Forms.Button();
            this.btEliminaLavoratore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAggiungiLavoratore
            // 
            this.btAggiungiLavoratore.BackColor = System.Drawing.Color.DarkGray;
            this.btAggiungiLavoratore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAggiungiLavoratore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAggiungiLavoratore.ForeColor = System.Drawing.Color.White;
            this.btAggiungiLavoratore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAggiungiLavoratore.Location = new System.Drawing.Point(215, 129);
            this.btAggiungiLavoratore.Name = "btAggiungiLavoratore";
            this.btAggiungiLavoratore.Size = new System.Drawing.Size(265, 57);
            this.btAggiungiLavoratore.TabIndex = 1;
            this.btAggiungiLavoratore.Text = "Aggiungi lavoratore";
            this.btAggiungiLavoratore.UseVisualStyleBackColor = false;
            this.btAggiungiLavoratore.Click += new System.EventHandler(this.BtAggiungiLavoratore_Click);
            // 
            // btModificaLavoratore
            // 
            this.btModificaLavoratore.BackColor = System.Drawing.Color.DarkGray;
            this.btModificaLavoratore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btModificaLavoratore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificaLavoratore.ForeColor = System.Drawing.Color.White;
            this.btModificaLavoratore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btModificaLavoratore.Location = new System.Drawing.Point(215, 272);
            this.btModificaLavoratore.Name = "btModificaLavoratore";
            this.btModificaLavoratore.Size = new System.Drawing.Size(265, 57);
            this.btModificaLavoratore.TabIndex = 2;
            this.btModificaLavoratore.Text = "Modifica lavoratore";
            this.btModificaLavoratore.UseVisualStyleBackColor = false;
            this.btModificaLavoratore.Click += new System.EventHandler(this.BtModificaLavoratore_Click);
            // 
            // btEliminaLavoratore
            // 
            this.btEliminaLavoratore.BackColor = System.Drawing.Color.DarkGray;
            this.btEliminaLavoratore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEliminaLavoratore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminaLavoratore.ForeColor = System.Drawing.Color.White;
            this.btEliminaLavoratore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminaLavoratore.Location = new System.Drawing.Point(215, 415);
            this.btEliminaLavoratore.Name = "btEliminaLavoratore";
            this.btEliminaLavoratore.Size = new System.Drawing.Size(265, 57);
            this.btEliminaLavoratore.TabIndex = 3;
            this.btEliminaLavoratore.Text = "Elimina lavoratore";
            this.btEliminaLavoratore.UseVisualStyleBackColor = false;
            this.btEliminaLavoratore.Click += new System.EventHandler(this.BtEliminaLavoratore_Click);
            // 
            // FormGestioneLavoratori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 610);
            this.Controls.Add(this.btEliminaLavoratore);
            this.Controls.Add(this.btModificaLavoratore);
            this.Controls.Add(this.btAggiungiLavoratore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestioneLavoratori";
            this.Text = "FormGestioneUtenti";
            this.Load += new System.EventHandler(this.FormGestioneUtenti_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAggiungiLavoratore;
        private System.Windows.Forms.Button btModificaLavoratore;
        private System.Windows.Forms.Button btEliminaLavoratore;
    }
}