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
    public partial class FormGestioneUtenti : Form
    {
        /// <summary>
        /// Metodo costruttore del FormGestioneUtenti
        /// </summary>
        public FormGestioneUtenti()
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
        private void FormGestioneUtenti_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            btAggiungiUtente.Parent = this;
            btModificaUtente.Parent = this; 
            btEliminaUtente.Parent = this;
        }

        /// <summary>
        /// Ascoltatore click sul bottone di aggiunta di un utente
        /// --> apertura form specifico per creazione nuovo utente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAggiungiUtente_Click(object sender, EventArgs e)
        {
            FormCreazioneLavoratore formAggiungi = new FormCreazioneLavoratore();
            formAggiungi.Show();
        }

        /// <summary>
        /// Ascoltatore click sul bottone di modifica di un utente
        /// --> apertura form specifico per modifica utente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtModificaUtente_Click(object sender, EventArgs e)
        {
            FormModifica formModifica = new FormModifica("Lavoratore");
            formModifica.Show();
        }

        /// <summary>
        /// Ascoltatore click sul bottone di eliminazione di un utente
        /// --> apertura form specifico per eliminazione utente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtEliminaUtente_Click(object sender, EventArgs e)
        {
            //TODO: apri il form per l'eliminazione di un utente
        }
        #endregion
    }
}
