using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaAziendale.Modelli;
using AgendaAziendale.Forms.UserControls;

namespace AgendaAziendale.Forms
{
    public partial class FormEvento : Form
    {
        #region Attributi
        private readonly UCEventi ucPadre;
        private readonly Evento evento;
        private readonly string azione;
        #endregion

        #region Metodi costruttori
        /// <summary>
        /// Metodo costruttore del FormEvento
        /// </summary>
        /// <param name="ucPadre"></param>
        /// <param name="evento"></param>
        /// <param name="azione"></param>
        public FormEvento(UCEventi ucPadre, Evento evento, string azione)
        {
            InitializeComponent();
            this.ucPadre = ucPadre;
            this.evento = evento;
            this.azione = azione;
        }

        /// <summary>
        /// Metodo costruttore del FormEvento
        /// </summary>
        /// <param name="ucPadre"></param>
        /// <param name="azione"></param>
        public FormEvento(UCEventi ucPadre,string azione)
        {
            InitializeComponent();
            this.ucPadre = ucPadre;
            this.evento = null;
            this.azione = azione;
        }
        #endregion

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> settaggio testi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEvento_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelTop.Parent = this;
            panelCentro.Parent = this;
            ///Figli del pannello top
            btChiudi.Parent = panelTop;
            ///Figli del pannello centrale
            lbReferente.Parent = panelCentro;
            lbNome.Parent = panelCentro;
            lbDescrizione.Parent = panelCentro;
            lbDataInizio.Parent = panelCentro;
            lbDataFine.Parent = panelCentro;
            lbLuogo.Parent = panelCentro;
            cbReferente.Parent = panelCentro;
            tbNome.Parent = panelCentro;
            tbDescrizione.Parent = panelCentro;
            tbDataInizio.Parent = panelCentro;
            tbDataFine.Parent = panelCentro;
            tbLuogo.Parent = panelCentro;
            mcDataInizio.Parent = panelCentro;
            mcDataFine.Parent = panelCentro;
            btAggiungiAggiorna.Parent = panelCentro;

            cbReferente.DropDownStyle = ComboBoxStyle.DropDownList; ///Possibilità di selezionare solo elementi della cb, senza poter scrivere manaulmente, al fine di evitare errori

            if (evento != null) ///Se ho un evento da modificare
            {
                cbReferente.Text = evento.Referente.Username;
                tbNome.Text = evento.Nome;
                tbDescrizione.Text = evento.Descrizione;
                tbDataInizio.Text = evento.DataInizio.ToShortDateString();
                tbDataFine.Text = evento.DataFine.ToShortDateString();
                tbLuogo.Text = evento.Luogo;
            }

            if ((azione == "Aggiungi") || (azione == "aggiungi"))
                btAggiungiAggiorna.Text = "Aggiungi";

            else if ((azione == "Aggiorna") || (azione == "aggiorna"))
                btAggiungiAggiorna.Text = "Aggiorna";

            else
            {
                MessageBox.Show("ERRORE! Valore FormEvento:tipologia --> controllare stack chiamate!", "Compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di chiusura 
        /// --> chiusura form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///  Ascoltatore click sulla text box relativa all'inserimento della data d'inizio dell'evento
        /// --> apertura calendario
        /// --> bloccaggio possibilità di input al fine di evitare errori di scrittura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbDataInizio_Enter(object sender, EventArgs e)
        {
            mcDataInizio.Show();
            tbDataInizio.Enabled = false;
        }

        /// <summary>
        /// Ascoltatore selezione data calendario data d'inizio dell'evento
        /// --> chiusura calendario, settaggio della data e visualizzazione nella text box
        /// --> riabilitazione possibilità di input text box relativa all'inserimento della data d'inizio dell'evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void McDataInizio_DateSelected(object sender, DateRangeEventArgs e)
        {
            mcDataInizio.Hide();
            tbDataInizio.Enabled = true;
            tbDataInizio.Text = mcDataInizio.SelectionRange.Start.ToShortDateString();
        }

        /// <summary>
        /// Ascoltatore click sulla text box relativa all'inserimento della data di fine dell'evento
        /// --> apertura calendario
        /// --> bloccaggio possibilità di input al fine di evitare errori di scrittura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbDataFine_Enter(object sender, EventArgs e)
        {
            mcDataFine.Show();
            tbDataFine.Enabled = false;
        }

        /// <summary>
        /// Ascoltatore selezione data calendario data di fine dell'evento
        /// --> chiusura calendario, settaggio della data e visualizzazione nella text box
        /// --> riabilitazione possibilità di input text box relativa all'inserimento della data di fine dell'evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void McDataFine_DateSelected(object sender, DateRangeEventArgs e)
        {
            mcDataFine.Hide();
            tbDataFine.Enabled = true;
            tbDataFine.Text = mcDataInizio.SelectionRange.Start.ToShortDateString();
        }

        /// <summary>
        /// Ascoltatore click sul bottone adibito alla creazione o all'aggiornamento di un evento
        /// --> effettuo l'azione di aggiunta o modifica
        /// --> aggiorno la dgv contenente i dati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAggiungiAggiorna_Click(object sender, EventArgs e)
        {
            if ((azione == "Aggiungi") || (azione == "aggiungi"))
                //Richiama funzione aggiungi

            if ((azione == "Aggiorna") || (azione == "aggiorna"))
                //Richiama funzione aggiorna

            if(ucPadre != null)
                ucPadre.AggiornadgvEventi();
        }
        #endregion
    }
}
