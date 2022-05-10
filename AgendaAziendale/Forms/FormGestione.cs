using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaAziendale.Forms.UserControls;

namespace AgendaAziendale.Forms
{
    public partial class FormGestione : Form
    {
        #region Attributi
        private readonly string tipologia;
        private UserControl ucContenitore;
        #endregion

        #region Gettrs & Setters
        public UserControl UcContenitore { get => ucContenitore; set => ucContenitore = value; }
        #endregion

        public FormGestione(string tipologia)
        {
            InitializeComponent();
            this.tipologia = tipologia;
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> settaggio testi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGestione_Load(object sender, EventArgs e)
        {
            ///Figli del form
            panelCentro.Parent = this;
            ///Figli del panelCentro
            btAggiungi.Parent = panelCentro;
            panelUCcontenitore.Parent = panelCentro;

            if((tipologia == "Lavoratore") || (tipologia == "lavoratore"))
            {
                btAggiungi.Text = "Aggiungi lavoratore";
                UcContenitore = new UCLavoratori();
            }

            else if ((tipologia == "Evento") || (tipologia == "evento"))
            {
                btAggiungi.Text = "Aggiungi evento";
                UcContenitore = new UCEventi();
            }

            else if ((tipologia == "Progetto") || (tipologia == "progetto"))
            {
                btAggiungi.Text = "Aggiungi progetto";
                UcContenitore = new UCProgetti();
            }

            else
            {
                MessageBox.Show("ERRORE! Valore FormGestione:tipologia --> controllare stack chiamate!", "Compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            panelUCcontenitore.Controls.Add(UcContenitore); ///Aggiungo l'UC all'interfaccia
        }

        private void BtAggiungi_Click(object sender, EventArgs e)
        {
            if ((tipologia == "Lavoratore") || (tipologia == "lavoratore"))
            {
                FormLavoratore formAggiungi = new FormLavoratore((UCLavoratori)UcContenitore, "aggiungi");
                formAggiungi.Show();
            }

            else if ((tipologia == "Evento") || (tipologia == "evento"))
            {
                FormEvento formAggiungi = new FormEvento((UCEventi)UcContenitore, "aggiungi");
                formAggiungi.Show();
            }

            else if ((tipologia == "Progetto") || (tipologia == "progetto"))
            {
                FormProgetto formAggiungi = new FormProgetto((UCProgetti)UcContenitore, "aggiungi");
                formAggiungi.Show();
            }

            else
            {
                MessageBox.Show("ERRORE! Valore FormGestione:tipologia --> controllare stack chiamate!", "Compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo per aggiornare l'interfaccia
        /// </summary>
        public void Aggiorna()
        {
            //TODO: pensa a come aggiornare la dgv
        }
        #endregion
    }
}
