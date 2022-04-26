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

namespace AgendaAziendale.Forms
{
    public partial class FormCreazioneAttivita : Form
    {
        #region Attributi
        private string tipologia;
        #endregion

        #region Getters & Setters
        public string Tipologia { get => tipologia; set => tipologia = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore del FormCreazioneAttivita
        /// --> permette la creazione di eventi o progetti
        /// --> a seconda dell'attività che si desidera creare: evento o progetto, viene caricata dinamicamente
        ///     la combobox con l'elenco di segretari o PM e durante l'azione di load viene assegnato un contenuto
        ///     testuale diverso alla label relativa al luogo o cliente
        /// </summary>
        /// <param name="tipologia"></param>
        public FormCreazioneAttivita(string tipologia)
        {
            InitializeComponent();
            Tipologia = tipologia;
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> settaggio valore lbLuogoCliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCreazioneEvento_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelTop.Parent = this;
            panelCentro.Parent = this;
            ///Figli del pannello top
            btChiudi.Parent = panelTop;
            ///Figli del pannello centrale
            lbCodice.Parent = panelCentro;
            lbReferente.Parent = panelCentro;
            lbNome.Parent = panelCentro;
            lbDescrizione.Parent = panelCentro;
            lbDataInizio.Parent = panelCentro;
            lbDataFine.Parent = panelCentro;
            lbLuogoCliente.Parent = panelCentro;
            tbCodice.Parent = panelCentro;
            cbReferente.Parent = panelCentro;
            tbNome.Parent = panelCentro;
            tbDescrizione.Parent = panelCentro;
            tbDataInizio.Parent = panelCentro;
            tbDataFine.Parent = panelCentro;
            tbLuogoCliente.Parent = panelCentro;
            mcDataInizio.Parent = panelCentro;
            mcDataFine.Parent = panelCentro;

            if (Tipologia.Equals("evento") || Tipologia.Equals("Evento"))
                lbLuogoCliente.Text = "Luogo";

            else if (Tipologia.Equals("progetto") || Tipologia.Equals("Progetto"))
                lbLuogoCliente.Text = "Cliente";

            else
            {
                MessageBox.Show("ERRORE valore FormCreazioneAttivita:tipologia --> controllare stack chiamate!");
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
        /// Ascoltatore click sul bottone di creazione di una nuova attività
        /// --> avvio procedura creazione nuova attività
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAggiungi_Click(object sender, EventArgs e)
        {
            if (Tipologia.Equals("evento") || Tipologia.Equals("Evento"))
                CreaEvento();

            else if (Tipologia.Equals("progetto") || Tipologia.Equals("Progetto"))
                CreaProgetto();

            else
            {
                MessageBox.Show("ERRORE valore FormCreazioneAttivita:tipologia --> controllare stack chiamate!");
                Application.Exit();
            }
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo adibito alla creazione di un evento
        /// </summary>
        private void CreaEvento()
        {
            string codice = tbCodice.Text;
            //Lavoratore referente = cbReferente.Text; --> ottieni il referente dal DB o vedi come fare, bisogna passare un Referente
            string descrizione = tbDescrizione.Text;
            DateTime dataInizio = mcDataInizio.SelectionRange.Start;
            DateTime dataFine = mcDataFine.SelectionRange.Start;    
            string luogo = tbLuogoCliente.Text;
            //Evento evento = new Evento(codice, referente, dataInizio, dataFine, luogo);
            //TODO: inserisci nel DB
        }

        /// <summary>
        /// Metodo adibito alla creazione di un progetto
        /// </summary>
        private void CreaProgetto()
        {
            string codice = tbCodice.Text;
            //Lavoratore referente = cbReferente.Text; --> ottieni il referente dal DB o vedi come fare, bisogna passare un Referente
            string descrizione = tbDescrizione.Text;
            DateTime dataInizio = mcDataInizio.SelectionRange.Start;
            DateTime dataFine = mcDataFine.SelectionRange.Start;
            string cliente = tbLuogoCliente.Text;
            //Progetto progetto = new Progetto(codice, referente, dataInizio, dataFine, cliente);
            //TODO: inserisci nel DB
        }
        #endregion
    }
}
