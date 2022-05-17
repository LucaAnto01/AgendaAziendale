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
    public partial class FormLavoratore : Form
    {
        #region Attributi
        private readonly UCLavoratori ucPadre;
        private readonly Lavoratore lavoratore;
        private readonly string azione;
        #endregion

        /// <summary>
        /// Metodo costruttore del FormLavoratore
        /// </summary>
        /// <param name="ucPadre"></param>
        /// <param name="lavoratore"></param>
        /// <param name="azione"></param> aggiungi | modifica
        public FormLavoratore(UCLavoratori ucPadre, Lavoratore lavoratore, string azione)
        {
            InitializeComponent();
            this.ucPadre = ucPadre;
            this.lavoratore = lavoratore;
            this.azione = azione;
        }

        /// <summary>
        /// Metodo costruttore del FormLavoratore
        /// </summary>
        /// <param name="ucPadre"></param>
        /// <param name="azione"></param>
        public FormLavoratore(UCLavoratori ucPadre, string azione)
        {
            InitializeComponent();
            this.ucPadre = ucPadre;
            this.lavoratore = null;
            this.azione = azione;
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> settaggio testi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormModificaLavoratore_Load(object sender, EventArgs e)
        {
            ///Figli del form
            panelTop.Parent = this;
            panelCentro.Parent = this;
            ///Figli del pannello top
            btChiudi.Parent = panelTop;
            ///Figli del pannello centrale
            lbUsername.Parent = panelCentro;
            lbPassword.Parent = panelCentro;
            lbNome.Parent = panelCentro;
            lbCognome.Parent = panelCentro;
            lbResidenza.Parent = panelCentro;
            lbDataNascita.Parent = panelCentro;
            lbCategoria.Parent = panelCentro;
            tbUsername.Parent = panelCentro;
            tbPassword.Parent = panelCentro;
            tbNome.Parent = panelCentro;
            tbCognome.Parent = panelCentro;
            tbResidenza.Parent = panelCentro;
            tbDataNascita.Parent = panelCentro;
            cbCategoria.Parent = panelCentro;
            mcDataNascita.Parent = panelCentro;
            btAAggiornaAggiungi.Parent = panelCentro;
            lbErrore.Parent = panelCentro;

            cbCategoria.SelectedIndex = 0;

            if(lavoratore != null) ///Se ho un lavoratore da modificare
            {
                tbNome.Text = lavoratore.Nome;
                tbCognome.Text = lavoratore.Cognome;
                tbResidenza.Text = lavoratore.Residenza;
                tbDataNascita.Text = lavoratore.DataNascita.ToShortDateString();
                tbUsername.Text = lavoratore.Username;
                tbPassword.Text = lavoratore.Password;
                cbCategoria.Text = lavoratore.Categoria;
            }
            
            if ((azione == "Aggiungi") || (azione == "aggiungi"))
                btAAggiornaAggiungi.Text = "Aggiungi";

            else if ((azione == "Aggiorna") || (azione == "aggiorna"))
                btAAggiornaAggiungi.Text = "Aggiorna";

            else
            {
                MessageBox.Show("ERRORE! Valore FormLavoratore:tipologia --> controllare stack chiamate!", "Compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Ascoltatore selezione data calendario data nascita
        /// --> chiusura calendario, settaggio della data e visualizzazione nella text box
        /// --> riabilitazione possibilità di input text box relativa all'inserimento della data di nascita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void McDataNascita_DateSelected(object sender, DateRangeEventArgs e)
        {
            mcDataNascita.Hide();
            tbDataNascita.Enabled = true;
            tbDataNascita.Text = mcDataNascita.SelectionRange.Start.ToShortDateString();
        }

        /// <summary>
        /// Ascoltatore click sulla text box relativa all'inserimento della data di nascita
        /// --> apertura calendario
        /// --> bloccaggio possibilità di input al fine di evitare errori di scrittura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbDataNascita_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
            mcDataNascita.Show();
            tbDataNascita.Enabled = false;
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
        /// Ascoltatore click sul bottone adibito alla creazione o all'aggiornamento di un lavoratore
        /// --> effettuo l'azione di aggiunta o modifica
        /// --> aggiorno la dgv contenente i dati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAAggiornaAggiungi_Click(object sender, EventArgs e)
        {
            if (CheckCampi())
            {
                lbErrore.Visible = false;

                if ((azione == "Aggiungi") || (azione == "aggiungi"))
                    //Richiama funzione aggiungi

                if ((azione == "Aggiorna") || (azione == "aggiorna"))
                    //Richiama funzione aggiorna

                    ucPadre.AggiornadgvLavoratori();
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

            if(tbNome.Text == "")
            {
                tbNome.BackColor = Color.Red;
                check = false;
            }

            if (tbCognome.Text == "")
            {
                tbCognome.BackColor = Color.Red;
                check = false;
            }

            if (tbResidenza.Text == "")
            {
                tbResidenza.BackColor = Color.Red;
                check = false;
            }

            if (tbDataNascita.Text == "")
            {
                tbDataNascita.BackColor = Color.Red;
                check = false;
            }

            if (tbUsername.Text == "")
            {
                tbUsername.BackColor = Color.Red;
                check = false;
            }

            if (tbPassword.Text == "")
            {
                tbPassword.BackColor = Color.Red;
                check = false;
            }

            /*if (cbCategoria.Text == "")
            {
                cbCategoria.BackColor = Color.Red;
                check = false;
            }*/

            return check;
        }
        #endregion
    }
}
