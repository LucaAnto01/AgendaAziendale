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
    public partial class FormGestioneAttivita : Form
    {
        #region Attributi
        private Lavoratore lavoratore;
        #endregion

        #region Getters & Setters
        public Lavoratore Lavoratore { get => lavoratore; set => lavoratore = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore del FormGestioneAttivita
        /// </summary>
        /// <param name="lavoratore"></param>
        public FormGestioneAttivita(Lavoratore lavoratore)
        {
            InitializeComponent();
            Lavoratore = lavoratore;
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> settaggio visibilità bottoni per relativa possibilità d'azione
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGestioneAttivita_Load(object sender, EventArgs e)
        {
            //TODO: controlla il tipo di lavoratore per rendere visibile o meno certi bottoni
        }

        /// <summary>
        /// Ascoltatore click sul bottone per creazione evento
        /// --> apertura Form adibito alla creazione dell'evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtCreaEvento_Click(object sender, EventArgs e)
        {
            FormCreazioneAttivita formCreaEvento = new FormCreazioneAttivita("Evento");
            formCreaEvento.Show();
        }

        /// <summary>
        /// Ascoltatore click sul bottone per creazione progetto
        /// --> apertura Form adibito alla creazione dell'progetto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtCreaProgetto_Click(object sender, EventArgs e)
        {
            FormCreazioneAttivita formCreaProgetto = new FormCreazioneAttivita("Progetto");
            formCreaProgetto.Show();
        }

        /// <summary>
        /// Ascoltatore click sul bottone per modifica evento
        /// --> apertura Form adibito alla modifica di un evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtModificaEvento_Click(object sender, EventArgs e)
        {
            FormModificaAttivita formModificaEvento = new FormModificaAttivita("Evento");
            formModificaEvento.Show();
        }

        /// <summary>
        /// Ascoltatore click sul bottone per modifica progetto
        /// --> apertura Form adibito alla modifica di un progetto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtModificaProgetto_Click(object sender, EventArgs e)
        {
            FormModificaAttivita formModificaProgetto = new FormModificaAttivita("Progetto");
            formModificaProgetto.Show();
        }

        /// <summary>
        ///  Ascoltatore click sul bottone per eliminazione evento
        /// --> apertura Form adibito all'eliminazione di un evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtEliminaEvento_Click(object sender, EventArgs e)
        {
            //TODO: crea form per eliminazione evento
        }

        /// <summary>
        /// Ascoltatore click sul bottone per eliminazione progetto
        /// --> apertura Form adibito all'eliminazione di un progetto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtEliminaProgetto_Click(object sender, EventArgs e)
        {
            //TODO: crea form per eliminazione progetto
        }
        #endregion
    }
}
