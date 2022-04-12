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
    public partial class FormCreazioneEvento : Form
    {
        public FormCreazioneEvento()
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
            lbLuogo.Parent = panelCentro;
            tbCodice.Parent = panelCentro;
            cbReferente.Parent = panelCentro;
            tbNome.Parent = panelCentro;
            tbDescrizione.Parent = panelCentro;
            tbDataInizio.Parent = panelCentro;
            tbDataFine.Parent = panelCentro;
            tbLuogo.Parent = panelCentro;
            mcDataInizio.Parent = panelCentro;
            mcDataFine.Parent = panelCentro;
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAggiungi_Click(object sender, EventArgs e)
        {
            //TODO: implementa funzione per aggiungere un evento
        }
        #endregion
    }
}
