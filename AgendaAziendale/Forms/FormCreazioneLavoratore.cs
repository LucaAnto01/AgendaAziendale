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
    public partial class FormCreazioneLavoratore : Form
    {
        /// <summary>
        /// Metodo costruttore FormAggiungiLavoratore
        /// </summary>
        public FormCreazioneLavoratore()
        {
            InitializeComponent();
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAggiungiLavoratore_Load(object sender, EventArgs e)
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
        /// Ascoltatore click sulla text box relativa all'inserimento della data di nascita
        /// --> apertura calendario
        /// --> bloccaggio possibilità di input al fine di evitare errori di scrittura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbDataNascita_Enter(object sender, EventArgs e)
        {
            mcDataNascita.Show();
            tbDataNascita.Enabled = false;
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
        /// Ascoltatore click sul bottone adibito alla creazione di un lavoratore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAggiungi_Click(object sender, EventArgs e)
        {
            if((tbNome.Text != null) && (tbCognome.Text != null) && (tbResidenza.Text != null) && (tbDataNascita.Text != null) && (tbUsername.Text != null) && (tbPassword.Text != null) && (cbCategoria.Text != null))
                CreaLavoratore();

            else
                MessageBox.Show("ERRORE! Compila tutti i campi", "Compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo adibito alla creazione di un lavoratore
        /// </summary>
        private void CreaLavoratore()
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string nome = tbNome.Text;
            string cognome = tbCognome.Text;
            string residenza = tbResidenza.Text;
            DateTime dataNascita = mcDataNascita.SelectionRange.Start;
            string categoria = cbCategoria.Text;

            Lavoratore lavoratore = new Lavoratore(username, password, nome, cognome, residenza, dataNascita, categoria);

            //TODO: inseriscilo nel DB e controlla che non esista già
        }
        #endregion
    }
}
