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
    public partial class FormModifica : Form
    {
        #region Attributi
        private string tipologia;
        #endregion

        #region Getters & Setters
        public string Tipologia { get => tipologia; set => tipologia = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore del FormModificaAttivita
        /// --> permette la modifica di eventi, progetti o lavoratori
        /// --> a seconda della tipologia passata come parametro vengono popolate le combobox relative ai campi di modifica ed elenchi di eventi/progetti/lavoratori
        /// </summary>
        /// <param name="tipologia"></param>
        public FormModifica(string tipologia)
        {
            InitializeComponent();
            Tipologia = tipologia;
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormModificaAttivita_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelTop.Parent = this;
            panelCentro.Parent = this;
            ///Figli del pannello top
            btChiudi.Parent = panelTop;
            ///Figli del pannello centro
            lbCampo.Parent = panelCentro;
            lbValore.Parent = panelCentro;
            cbCampo.Parent = panelCentro;
            tbValore.Parent = panelCentro;
            mcModifica.Parent = panelCentro;
            btModifica.Parent = panelCentro;
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
        /// Ascoltatore evento sulla combobox per il campo da modificare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbValore.Visible = true;
            tbValore.Visible = true;
            //TODO: AZIONE PERSONALIZZATA NEL CASO DELLE DATA --> FAI COMPARIRE IL CALENDARIO
        }

        /// <summary>
        /// Ascoltatore click sul bottone di modifica 
        /// --> effettua la modifica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtModifica_Click(object sender, EventArgs e)
        {
            //TODO: avvia la procedura di modifica
        }

        /// <summary>
        /// Ascoltatore selezione data calendario
        /// --> chiusura calendario, settaggio della data e visualizzazione nella text box
        /// --> riabilitazione possibilità di input text box relativa all'inserimento della data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void McModifica_DateSelected(object sender, DateRangeEventArgs e)
        {
            mcModifica.Hide();
            tbValore.Enabled = true;
            tbValore.Text = mcModifica.SelectionRange.Start.ToShortDateString();
        }
        #endregion


    }
}
