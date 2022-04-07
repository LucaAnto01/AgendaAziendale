using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaAziendale
{
    public partial class FormLogin : Form
    {
        /// <summary>
        /// Metodo costruttore del FormLogin
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia --> settaggio gerarchie interfaccia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_Load(object sender, EventArgs e)
        {
            //Setto le "gerarchie" del form, così da averne una visualizzazione quanto più corretta possibile
            ///Figli del form
            panelTop.Parent = this;
            panelSinistra.Parent = this;
            panelCentro.Parent = this;
            ///Figli del pannello top
            btChiudi.Parent = panelTop;
            ///Figli del pannello di sinistra
            panelSinistraTop.Parent = panelSinistra;
            lbIntestazioneSinistra.Parent = panelSinistra;
            ///Figli del pannello di sinistra top
            pctbxLogo.Parent = panelSinistraTop;
            ///Figli del pannello centrale
            btAccedi.Parent = panelCentro;
            
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di chiusura --> chiusura applicazione
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btChiudi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di login --> avvio procedura autenticazione
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAccedi_Click(object sender, EventArgs e)
        {
            //TODO: avvia procedura di login
        }
    }
}
