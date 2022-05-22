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

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia 
        /// --> settaggio gerarchie interfaccia
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
            tbUsername.Parent = panelCentro;
            tbPassword.Parent = panelCentro;
            btAccedi.Parent = panelCentro;
            
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
        /// Ascoltatore click sulla text box adibita all'inserimento dell'username
        /// --> rimozione testo segnaposto e settaggio colore testo a nero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbUsername_Enter(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbUsername.ForeColor = Color.Black;
        }

        /// <summary>
        /// Ascoltatore click sulla text box adibita all'inserimento della password
        /// --> rimozione testo segnaposto, settaggio colore testo a nero e input di tipo password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbPassword_Enter(object sender, EventArgs e)
        {
            tbPassword.Text = "";
            tbPassword.ForeColor = Color.Black;
            tbPassword.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di login 
        /// --> avvio procedura autenticazione
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAccedi_Click(object sender, EventArgs e)
        {
            //TODO: avvia procedura di login --> setta i dati in sessione

            try
            {
                Sessione.ServerAziendale = new SRAgendaAziendale.ServiceAgendaAziendaleClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRORE! Istanziamento ServerAziendale da FormLogin", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            //DA RIMUOVERE SUCCESSIVAMENTE
            FormAdmin pippo = new FormAdmin();
            pippo.ShowDialog();
            //this.Hide();
            Close();
        }
        #endregion
    }
}
