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
    public partial class FormGestioneLavoratori : Form
    {
        /// <summary>
        /// Metodo costruttore del FormGestioneUtenti
        /// </summary>
        public FormGestioneLavoratori()
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
            btAggiungiLavoratore.Parent = this;
            btModificaLavoratore.Parent = this; 
            btEliminaLavoratore.Parent = this;
        }

        /// <summary>
        /// Ascoltatore click sul bottone di aggiunta di un lavoratore
        /// --> apertura form specifico per creazione nuovo lavoratore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAggiungiLavoratore_Click(object sender, EventArgs e)
        {
            FormCreazioneLavoratore formAggiungi = new FormCreazioneLavoratore();
            formAggiungi.Show();
        }

        /// <summary>
        /// Ascoltatore click sul bottone di modifica di un lavoratore
        /// --> apertura form specifico per modifica lavoratore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtModificaLavoratore_Click(object sender, EventArgs e)
        {
            FormModifica formModifica = new FormModifica("Lavoratore");
            formModifica.Show();
        }

        /// <summary>
        /// Ascoltatore click sul bottone di eliminazione di un lavoratore
        /// --> apertura form specifico per eliminazione lavoratore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtEliminaLavoratore_Click(object sender, EventArgs e)
        {
            //TODO: apri il form per l'eliminazione di un utente
        }
        #endregion
    }
}
