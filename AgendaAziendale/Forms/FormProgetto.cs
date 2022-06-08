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
    public partial class FormProgetto : Form
    {
        #region Attributi
        private readonly UCProgetti ucPadre;
        private readonly Progetto progetto;
        private readonly string azione;
        #endregion

        #region Metodi costruttori
        /// <summary>
        /// Metodo costruttore del FormProgetto
        /// </summary>
        /// <param name="ucPadre"></param>
        /// <param name="progetto"></param>
        /// <param name="azione"></param>
        public FormProgetto(UCProgetti ucPadre, Progetto progetto, string azione)
        {
            InitializeComponent();
            this.ucPadre = ucPadre;
            this.progetto = progetto;
            this.azione = azione;
        }

        /// <summary>
        /// Metodo costruttore del FormProgetto
        /// </summary>
        /// <param name="ucPadre"></param>
        /// <param name="azione"></param>
        public FormProgetto(UCProgetti ucPadre, string azione)
        {
            InitializeComponent();
            this.ucPadre = ucPadre;
            this.progetto = null;
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
        private void FormProgetto_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelTop.Parent = this;
            panelCentro.Parent = this;
            ///Figli del pannello top
            btChiudi.Parent = panelTop;
            ///Figli del pannello centrale
            lbNome.Parent = panelCentro;
            lbDescrizione.Parent = panelCentro;
            lbDataInizio.Parent = panelCentro;
            lbDataFine.Parent = panelCentro;
            lbCliente.Parent = panelCentro;
            tbNome.Parent = panelCentro;
            tbDescrizione.Parent = panelCentro;
            tbDataInizio.Parent = panelCentro;
            tbDataFine.Parent = panelCentro;
            tbCliente.Parent = panelCentro;
            mcDataInizio.Parent = panelCentro;
            mcDataFine.Parent = panelCentro;
            btAggiungiAggiorna.Parent = panelCentro;

            if (progetto != null) ///Se ho un evento da modificare
            {
                tbNome.Text = progetto.Nome;
                tbDescrizione.Text = progetto.Descrizione;
                tbDataInizio.Text = progetto.DataInizio.ToShortDateString();
                tbDataFine.Text = progetto.DataFine.ToShortDateString();
                tbCliente.Text = progetto.Cliente;
            }

            if ((azione == "Aggiungi") || (azione == "aggiungi"))
                btAggiungiAggiorna.Text = "Aggiungi";

            else if ((azione == "Aggiorna") || (azione == "aggiorna"))
                btAggiungiAggiorna.Text = "Aggiorna";

            else
            {
                MessageBox.Show("ERRORE! Valore FormProgetto:tipologia --> controllare stack chiamate!", "Compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        ///  Ascoltatore click sulla text box relativa all'inserimento della data d'inizio del progetto
        /// --> apertura calendario
        /// --> bloccaggio possibilità di input al fine di evitare errori di scrittura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbDataInizio_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
            mcDataInizio.Show();
            tbDataInizio.Enabled = false;
        }

        /// <summary>
        /// Ascoltatore selezione data calendario data d'inizio del progetto
        /// --> chiusura calendario, settaggio della data e visualizzazione nella text box
        /// --> riabilitazione possibilità di input text box relativa all'inserimento della data d'inizio del progetto
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
        /// Ascoltatore click sulla text box relativa all'inserimento della data di fine del progetto
        /// --> apertura calendario
        /// --> bloccaggio possibilità di input al fine di evitare errori di scrittura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbDataFine_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
            mcDataFine.Show();
            tbDataFine.Enabled = false;
        }

        /// <summary>
        /// Ascoltatore selezione data calendario data di fine del progetto
        /// --> chiusura calendario, settaggio della data e visualizzazione nella text box
        /// --> riabilitazione possibilità di input text box relativa all'inserimento della data di fine del progetto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void McDataFine_DateSelected(object sender, DateRangeEventArgs e)
        {
            mcDataFine.Hide();
            tbDataFine.Enabled = true;
            tbDataFine.Text = mcDataFine.SelectionRange.Start.ToShortDateString();
        }

        /// <summary>
        /// Ascoltatore evento click text box
        /// --> settaggio background color --> white
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbEnter_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        /// <summary>
        /// Ascoltatore click sul bottone adibito alla creazione o all'aggiornamento di un progetto
        /// --> effettuo l'azione di aggiunta o modifica
        /// --> aggiorno la dgv contenente i dati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAggiungiAggiorna_Click(object sender, EventArgs e)
        {
            if (CheckCampi())
            {
                if ((azione == "Aggiungi") || (azione == "aggiungi"))
                {
                    if (Controller.CreaProgetto(tbNome.Text, tbDescrizione.Text, DateTime.Parse(tbDataInizio.Text), DateTime.Parse(tbDataFine.Text), tbCliente.Text))
                        MessageBox.Show("Inserimento progetto " + tbNome.Text + " avvenuto con successo!", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    else
                        MessageBox.Show("Errore in fase d'inserimento.", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if ((azione == "Aggiorna") || (azione == "aggiorna"))
                    //Richiama funzione aggiorna

                if (ucPadre != null)
                    ucPadre.AggiornadgvProgetti();
            }

            else
                lbErrore.Visible = true;
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Funzione adibita al controllo del completamento dei campi d'inserimento
        /// </summary>
        /// <returns>bool</returns>
        private bool CheckCampi()
        {
            bool check = true; ///True, tutti i campi compilati

            if (tbNome.Text == "")
            {
                tbNome.BackColor = Color.Red;
                check = false;
            }

            if (tbDescrizione.Text == "")
            {
                tbDescrizione.BackColor = Color.Red;
                check = false;
            }

            if (tbDataInizio.Text == "")
            {
                tbDataInizio.BackColor = Color.Red;
                check = false;
            }

            if (tbDataFine.Text == "")
            {
                tbDataFine.BackColor = Color.Red;
                check = false;
            }

            if (tbCliente.Text == "")
            {
                tbCliente.BackColor = Color.Red;
                check = false;
            }

            return check;
        }
        #endregion
    }
}
