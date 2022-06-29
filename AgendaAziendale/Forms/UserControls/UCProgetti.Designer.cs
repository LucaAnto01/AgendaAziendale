namespace AgendaAziendale.Forms.UserControls
{
    partial class UCProgetti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.dgvProgetti = new System.Windows.Forms.DataGridView();
            this.codice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInizio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avanzamento = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gestione_lavoratori = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modifica = new System.Windows.Forms.DataGridViewButtonColumn();
            this.elimina = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgetti)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.dgvProgetti);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(645, 445);
            this.panelCentro.TabIndex = 0;
            // 
            // dgvProgetti
            // 
            this.dgvProgetti.AllowUserToAddRows = false;
            this.dgvProgetti.AllowUserToDeleteRows = false;
            this.dgvProgetti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProgetti.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProgetti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProgetti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgetti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codice,
            this.nome,
            this.descrizione,
            this.dataInizio,
            this.dataFine,
            this.id,
            this.cliente,
            this.avanzamento,
            this.gestione_lavoratori,
            this.modifica,
            this.elimina});
            this.dgvProgetti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProgetti.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProgetti.Location = new System.Drawing.Point(0, 0);
            this.dgvProgetti.Name = "dgvProgetti";
            this.dgvProgetti.ReadOnly = true;
            this.dgvProgetti.Size = new System.Drawing.Size(645, 445);
            this.dgvProgetti.TabIndex = 1;
            this.dgvProgetti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProgetti_CellClick);
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
            // gestione_lavoratori
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.gestione_lavoratori.DefaultCellStyle = dataGridViewCellStyle1;
            this.gestione_lavoratori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestione_lavoratori.HeaderText = "";
            this.gestione_lavoratori.Name = "gestione_lavoratori";
            this.gestione_lavoratori.ReadOnly = true;
            this.gestione_lavoratori.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gestione_lavoratori.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gestione_lavoratori.Text = "Lavoratori";
            this.gestione_lavoratori.UseColumnTextForButtonValue = true;
            // 
            // modifica
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.modifica.DefaultCellStyle = dataGridViewCellStyle2;
            this.modifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifica.HeaderText = "";
            this.modifica.Name = "modifica";
            this.modifica.ReadOnly = true;
            this.modifica.Text = "Modifica";
            this.modifica.UseColumnTextForButtonValue = true;
            // 
            // elimina
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.elimina.DefaultCellStyle = dataGridViewCellStyle3;
            this.elimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elimina.HeaderText = "";
            this.elimina.Name = "elimina";
            this.elimina.ReadOnly = true;
            this.elimina.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.elimina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.elimina.Text = "Elimina";
            this.elimina.UseColumnTextForButtonValue = true;
            // 
            // UCProgetti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCentro);
            this.Name = "UCProgetti";
            this.Size = new System.Drawing.Size(645, 445);
            this.Load += new System.EventHandler(this.UCProgetti_Load);
            this.panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgetti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.DataGridView dgvProgetti;
        private System.Windows.Forms.DataGridViewTextBoxColumn codice;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInizio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewButtonColumn avanzamento;
        private System.Windows.Forms.DataGridViewButtonColumn gestione_lavoratori;
        private System.Windows.Forms.DataGridViewButtonColumn modifica;
        private System.Windows.Forms.DataGridViewButtonColumn elimina;
    }
}
