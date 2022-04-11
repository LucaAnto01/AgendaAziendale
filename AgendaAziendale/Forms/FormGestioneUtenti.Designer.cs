namespace AgendaAziendale.Forms
{
    partial class FormGestioneUtenti
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
            this.btAggiungiUtente = new System.Windows.Forms.Button();
            this.btModificaUtente = new System.Windows.Forms.Button();
            this.btEliminaUtente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAggiungiUtente
            // 
            this.btAggiungiUtente.BackColor = System.Drawing.Color.DarkGray;
            this.btAggiungiUtente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAggiungiUtente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAggiungiUtente.ForeColor = System.Drawing.Color.White;
            this.btAggiungiUtente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAggiungiUtente.Location = new System.Drawing.Point(225, 129);
            this.btAggiungiUtente.Name = "btAggiungiUtente";
            this.btAggiungiUtente.Size = new System.Drawing.Size(265, 57);
            this.btAggiungiUtente.TabIndex = 1;
            this.btAggiungiUtente.Text = "Aggiungi utente";
            this.btAggiungiUtente.UseVisualStyleBackColor = false;
            this.btAggiungiUtente.Click += new System.EventHandler(this.BtAggiungiUtente_Click);
            // 
            // btModificaUtente
            // 
            this.btModificaUtente.BackColor = System.Drawing.Color.DarkGray;
            this.btModificaUtente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btModificaUtente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificaUtente.ForeColor = System.Drawing.Color.White;
            this.btModificaUtente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btModificaUtente.Location = new System.Drawing.Point(225, 272);
            this.btModificaUtente.Name = "btModificaUtente";
            this.btModificaUtente.Size = new System.Drawing.Size(265, 57);
            this.btModificaUtente.TabIndex = 2;
            this.btModificaUtente.Text = "Modifica utente";
            this.btModificaUtente.UseVisualStyleBackColor = false;
            this.btModificaUtente.Click += new System.EventHandler(this.BtModificaUtente_Click);
            // 
            // btEliminaUtente
            // 
            this.btEliminaUtente.BackColor = System.Drawing.Color.DarkGray;
            this.btEliminaUtente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEliminaUtente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminaUtente.ForeColor = System.Drawing.Color.White;
            this.btEliminaUtente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminaUtente.Location = new System.Drawing.Point(225, 415);
            this.btEliminaUtente.Name = "btEliminaUtente";
            this.btEliminaUtente.Size = new System.Drawing.Size(265, 57);
            this.btEliminaUtente.TabIndex = 3;
            this.btEliminaUtente.Text = "Elimina utente";
            this.btEliminaUtente.UseVisualStyleBackColor = false;
            this.btEliminaUtente.Click += new System.EventHandler(this.BtEliminaUtente_Click);
            // 
            // FormGestioneUtenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 610);
            this.Controls.Add(this.btEliminaUtente);
            this.Controls.Add(this.btModificaUtente);
            this.Controls.Add(this.btAggiungiUtente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestioneUtenti";
            this.Text = "FormGestioneUtenti";
            this.Load += new System.EventHandler(this.FormGestioneUtenti_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAggiungiUtente;
        private System.Windows.Forms.Button btModificaUtente;
        private System.Windows.Forms.Button btEliminaUtente;
    }
}