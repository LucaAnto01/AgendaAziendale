using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaAziendale.Forms
{
    public partial class FormAggiungiLavoratore : Form
    {
        /// <summary>
        /// Metodo costruttore FormAggiungiLavoratore
        /// </summary>
        public FormAggiungiLavoratore()
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAggiungi_Click(object sender, EventArgs e)
        {
            //TODO: implementa funzione per aggiungere un lavoratore
        }

        #endregion
    }
}
