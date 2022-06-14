namespace AgendaAziendale.Forms.UserControls
{
    partial class UCEventi
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
        /// il contenuto del metodo con l'editor di id.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCentro = new System.Windows.Forms.Panel();
            this.dgvEventi = new System.Windows.Forms.DataGridView();
            this.codice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInizio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifica = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gestione_partecipanti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.elimina = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.dgvEventi);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(645, 445);
            this.panelCentro.TabIndex = 0;
            // 
            // dgvEventi
            // 
            this.dgvEventi.AllowUserToAddRows = false;
            this.dgvEventi.AllowUserToDeleteRows = false;
            this.dgvEventi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventi.BackgroundColor = System.Drawing.Color.White;
            this.dgvEventi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEventi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codice,
            this.nome,
            this.descrizione,
            this.dataInizio,
            this.dataFine,
            this.id,
            this.luogo,
            this.modifica,
            this.gestione_partecipanti,
            this.elimina});
            this.dgvEventi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventi.GridColor = System.Drawing.Color.White;
            this.dgvEventi.Location = new System.Drawing.Point(0, 0);
            this.dgvEventi.Name = "dgvEventi";
            this.dgvEventi.ReadOnly = true;
            this.dgvEventi.Size = new System.Drawing.Size(645, 445);
            this.dgvEventi.TabIndex = 0;
            this.dgvEventi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEventi_CellClick);
            // 
            // codice
            // 
            this.codice.HeaderText = "Codice";
            this.codice.Name = "codice";
            this.codice.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // descrizione
            // 
            this.descrizione.HeaderText = "Descrizione";
            this.descrizione.Name = "descrizione";
            this.descrizione.ReadOnly = true;
            // 
            // dataInizio
            // 
            this.dataInizio.HeaderText = "DataInizio";
            this.dataInizio.Name = "dataInizio";
            this.dataInizio.ReadOnly = true;
            // 
            // dataFine
            // 
            this.dataFine.HeaderText = "DataFine";
            this.dataFine.Name = "dataFine";
            this.dataFine.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // luogo
            // 
            this.luogo.HeaderText = "Luogo";
            this.luogo.Name = "luogo";
            this.luogo.ReadOnly = true;
            // 
            // modifica
            // 
            this.modifica.HeaderText = "";
            this.modifica.Name = "modifica";
            this.modifica.ReadOnly = true;
            this.modifica.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modifica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modifica.Text = "Modifica";
            this.modifica.UseColumnTextForButtonValue = true;
            // 
            // gestione_partecipanti
            // 
            this.gestione_partecipanti.HeaderText = "";
            this.gestione_partecipanti.Name = "gestione_partecipanti";
            this.gestione_partecipanti.ReadOnly = true;
            this.gestione_partecipanti.Text = "Partecipanti";
            this.gestione_partecipanti.UseColumnTextForButtonValue = true;
            // 
            // elimina
            // 
            this.elimina.HeaderText = "";
            this.elimina.Name = "elimina";
            this.elimina.ReadOnly = true;
            this.elimina.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.elimina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.elimina.Text = "Elimina";
            this.elimina.UseColumnTextForButtonValue = true;
            // 
            // UCEventi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCentro);
            this.Name = "UCEventi";
            this.Size = new System.Drawing.Size(645, 445);
            this.Load += new System.EventHandler(this.UCEventi_Load);
            this.panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.DataGridView dgvEventi;
        private System.Windows.Forms.DataGridViewTextBoxColumn codice;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInizio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn luogo;
        private System.Windows.Forms.DataGridViewButtonColumn modifica;
        private System.Windows.Forms.DataGridViewButtonColumn gestione_partecipanti;
        private System.Windows.Forms.DataGridViewButtonColumn elimina;
    }
}
