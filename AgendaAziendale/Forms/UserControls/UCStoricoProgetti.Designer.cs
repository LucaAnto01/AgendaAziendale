namespace AgendaAziendale.Forms.UserControls
{
    partial class UCStoricoProgetti
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
            this.panelCentro = new System.Windows.Forms.Panel();
            this.dgvStoricoProgetti = new System.Windows.Forms.DataGridView();
            this.codice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInizio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avanzamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elimina = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoProgetti)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.dgvStoricoProgetti);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(700, 610);
            this.panelCentro.TabIndex = 0;
            // 
            // dgvStoricoProgetti
            // 
            this.dgvStoricoProgetti.AllowUserToAddRows = false;
            this.dgvStoricoProgetti.AllowUserToDeleteRows = false;
            this.dgvStoricoProgetti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStoricoProgetti.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStoricoProgetti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStoricoProgetti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoProgetti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codice,
            this.nome,
            this.descrizione,
            this.dataInizio,
            this.dataFine,
            this.id,
            this.cliente,
            this.avanzamento,
            this.elimina});
            this.dgvStoricoProgetti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStoricoProgetti.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStoricoProgetti.Location = new System.Drawing.Point(0, 0);
            this.dgvStoricoProgetti.Name = "dgvStoricoProgetti";
            this.dgvStoricoProgetti.ReadOnly = true;
            this.dgvStoricoProgetti.Size = new System.Drawing.Size(700, 610);
            this.dgvStoricoProgetti.TabIndex = 2;
            this.dgvStoricoProgetti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProgetti_CellClick);
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
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // avanzamento
            // 
            this.avanzamento.HeaderText = "Avanzamento";
            this.avanzamento.Name = "avanzamento";
            this.avanzamento.ReadOnly = true;
            // 
            // elimina
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.elimina.DefaultCellStyle = dataGridViewCellStyle1;
            this.elimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elimina.HeaderText = "";
            this.elimina.Name = "elimina";
            this.elimina.ReadOnly = true;
            this.elimina.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.elimina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.elimina.Text = "Elimina";
            this.elimina.UseColumnTextForButtonValue = true;
            // 
            // UCStoricoProgetti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCentro);
            this.Name = "UCStoricoProgetti";
            this.Size = new System.Drawing.Size(700, 610);
            this.Load += new System.EventHandler(this.UCStoricoProgetti_Load);
            this.panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoProgetti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.DataGridView dgvStoricoProgetti;
        private System.Windows.Forms.DataGridViewTextBoxColumn codice;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInizio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn avanzamento;
        private System.Windows.Forms.DataGridViewButtonColumn elimina;
    }
}
