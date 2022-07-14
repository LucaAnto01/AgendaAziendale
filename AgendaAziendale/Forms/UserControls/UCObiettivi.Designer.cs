namespace AgendaAziendale.Forms.UserControls
{
    partial class UCObiettivi
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.dgvObiettivi = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifica = new System.Windows.Forms.DataGridViewButtonColumn();
            this.elimina = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObiettivi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.dgvObiettivi);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(645, 445);
            this.panelCentro.TabIndex = 0;
            // 
            // dgvObiettivi
            // 
            this.dgvObiettivi.AllowUserToAddRows = false;
            this.dgvObiettivi.AllowUserToDeleteRows = false;
            this.dgvObiettivi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObiettivi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvObiettivi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvObiettivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObiettivi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descrizione,
            this.completato,
            this.modifica,
            this.elimina});
            this.dgvObiettivi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObiettivi.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvObiettivi.Location = new System.Drawing.Point(0, 0);
            this.dgvObiettivi.Name = "dgvObiettivi";
            this.dgvObiettivi.ReadOnly = true;
            this.dgvObiettivi.Size = new System.Drawing.Size(645, 445);
            this.dgvObiettivi.TabIndex = 0;
            this.dgvObiettivi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvObiettivi_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descrizione
            // 
            this.descrizione.HeaderText = "Descrizione";
            this.descrizione.Name = "descrizione";
            this.descrizione.ReadOnly = true;
            // 
            // completato
            // 
            this.completato.HeaderText = "Completato";
            this.completato.Name = "completato";
            this.completato.ReadOnly = true;
            // 
            // modifica
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.modifica.DefaultCellStyle = dataGridViewCellStyle1;
            this.modifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifica.HeaderText = "";
            this.modifica.Name = "modifica";
            this.modifica.ReadOnly = true;
            this.modifica.Text = "Modifica";
            this.modifica.UseColumnTextForButtonValue = true;
            // 
            // elimina
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.elimina.DefaultCellStyle = dataGridViewCellStyle2;
            this.elimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elimina.HeaderText = "";
            this.elimina.Name = "elimina";
            this.elimina.ReadOnly = true;
            this.elimina.Text = "Elimina";
            this.elimina.UseColumnTextForButtonValue = true;
            // 
            // UCObiettivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCentro);
            this.Name = "UCObiettivi";
            this.Size = new System.Drawing.Size(645, 445);
            this.Load += new System.EventHandler(this.UCObiettivi_Load);
            this.panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObiettivi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.DataGridView dgvObiettivi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn completato;
        private System.Windows.Forms.DataGridViewButtonColumn modifica;
        private System.Windows.Forms.DataGridViewButtonColumn elimina;
    }
}
