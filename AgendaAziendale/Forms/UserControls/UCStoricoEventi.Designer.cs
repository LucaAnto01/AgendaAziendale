namespace AgendaAziendale.Forms.UserControls
{
    partial class UCStoricoEventi
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
            this.dgvStoricoEventi = new System.Windows.Forms.DataGridView();
            this.codice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInizio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelCentro = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoEventi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStoricoEventi
            // 
            this.dgvStoricoEventi.AllowUserToAddRows = false;
            this.dgvStoricoEventi.AllowUserToDeleteRows = false;
            this.dgvStoricoEventi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStoricoEventi.BackgroundColor = System.Drawing.Color.White;
            this.dgvStoricoEventi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStoricoEventi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoEventi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codice,
            this.referente,
            this.nome,
            this.descrizione,
            this.dataInizio,
            this.dataFine,
            this.id,
            this.luogo,
            this.info});
            this.dgvStoricoEventi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStoricoEventi.GridColor = System.Drawing.Color.White;
            this.dgvStoricoEventi.Location = new System.Drawing.Point(0, 0);
            this.dgvStoricoEventi.Name = "dgvStoricoEventi";
            this.dgvStoricoEventi.ReadOnly = true;
            this.dgvStoricoEventi.Size = new System.Drawing.Size(700, 610);
            this.dgvStoricoEventi.TabIndex = 1;
            this.dgvStoricoEventi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStoricoEventi_CellClick);
            // 
            // codice
            // 
            this.codice.HeaderText = "Codice";
            this.codice.Name = "codice";
            this.codice.ReadOnly = true;
            // 
            // referente
            // 
            this.referente.HeaderText = "Referente";
            this.referente.Name = "referente";
            this.referente.ReadOnly = true;
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
            // info
            // 
            this.info.HeaderText = "";
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.info.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.info.UseColumnTextForButtonValue = true;
            // 
            // panelCentro
            // 
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(700, 610);
            this.panelCentro.TabIndex = 2;
            // 
            // UCStoricoEventi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvStoricoEventi);
            this.Controls.Add(this.panelCentro);
            this.Name = "UCStoricoEventi";
            this.Size = new System.Drawing.Size(700, 610);
            this.Load += new System.EventHandler(this.UCStoricoEventi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoEventi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStoricoEventi;
        private System.Windows.Forms.DataGridViewTextBoxColumn codice;
        private System.Windows.Forms.DataGridViewTextBoxColumn referente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInizio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn luogo;
        private System.Windows.Forms.DataGridViewButtonColumn info;
        private System.Windows.Forms.Panel panelCentro;
    }
}
