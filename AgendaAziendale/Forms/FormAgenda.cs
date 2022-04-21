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
    public partial class FormAgenda : Form
    {
        #region Attributi
        private Lavoratore lavoratore; ///Lavoratore che ha effettuato il login
        #endregion

        #region Getters & Setters
        public Lavoratore Lavoratore { get => lavoratore; set => lavoratore = value; }
        #endregion
        
        /// <summary>
        /// Metodo costruttore del FormAgenda
        /// </summary>
        /// <param name="lavoratore"></param>
        public FormAgenda(Lavoratore lavoratore)
        {
            InitializeComponent();
            Lavoratore = lavoratore;
        }

        #region Ascoltatori eventi
        private void FormAgenda_Load(object sender, EventArgs e)
        {
            ///Figli del form
            panelTop.Parent = this;
            panelSinistra.Parent = this;
            panelCentro.Parent = this;
            ///Figli del pannello top
            btChiudi.Parent = panelTop;
            ///Figli del pannello di sinistra
            btVisualizzaAgenda.Parent = panelSinistra;
            btLogout.Parent = panelSinistra;
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di chiusura 
        /// --> chiusura applicazione
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtChiudi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone per visualizzare evnti o progetti
        /// --> a seconda della tipologia di account loggato verranno visualizzati eventi (in tutti i casi) e progetti (PM, sviluppatore)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtVisualizzaAgenda_Click(object sender, EventArgs e)
        {
            //TODO: fai vedere il tutto
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone per operare su evnti o progetti, per segnarne la fine o gli step
        ///  --> a seconda della tipologia di account loggato si opera su eventi (segretario) e progetti (PM, sviluppatore)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtProgettiEventi_Click(object sender, EventArgs e)
        {
            //TODO: fai vedere il tutto
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone per visualizzare lo storico
        /// --> a seconda della tipologia di account loggato si visualizza lo storico di eventi (tutti) e progetti (PM, sviluppatore)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtVisualizzaStorico_Click(object sender, EventArgs e)
        {
            //TODO: fai vedere il tutto
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di logout
        /// --> effettua il logout, riporta alla schermata di login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtLogout_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            Close(); //Chiudo questo form
        }
        #endregion
    }
}
