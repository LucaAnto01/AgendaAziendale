using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AgendaAziendale.Forms;
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
            lbErrore.Parent = panelCentro;
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
        /// Validazione caratteri durante l'inserimento nelle text box
        /// --> no lettere con accenti e caratteri strani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_TextChanged(object sender, EventArgs e)
        {
            if ((!Regex.IsMatch(((TextBox)sender).Text, Sessione.Regex)) && (((TextBox)sender).Text != ""))
            {
                MessageBox.Show("Non inserire lettere accentate o caratteri speciali!", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ((TextBox)sender).Text = "";
            }
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
            tbUsername.BackColor = Color.White;
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
            tbPassword.BackColor = Color.White;
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
            if (CheckCampi())
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                if (Controller.EffettuaLogin(username, password)) ///Effettuo il login
                {
                    Lavoratore lavoratore = Controller.GetInfoLavoratore(username, username);

                    if (lavoratore != null)
                        Sessione.Lavoratore = lavoratore;

                    CheckLavoraotre();
                }

                else
                    MessageBox.Show("Username o password non validi", "Errore compilazione campi",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
                lbErrore.Visible = true;
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo adibito al controllo del completamento dei campi d'inserimento
        /// </summary>
        /// <returns>bool</returns>
        private bool CheckCampi()
        {
            bool check = true; ///True, tutti i campi compilati

            if ((tbUsername.Text == "") || (tbUsername.Text == "Username"))
            {
                tbUsername.BackColor = Color.Red;
                check = false;
            }

            if ((tbPassword.Text == "") || (tbPassword.Text == "Password"))
            {
                tbPassword.BackColor = Color.Red;
                check = false;
            }

            return check;
        }

        /// <summary>
        /// Metodo adibito all'apertura del form in base alla categoria dell'account: se admin o normale
        /// </summary>
        private void CheckLavoraotre()
        {
            Form form;

            try
            {
                if (Sessione.Lavoratore.Categoria == "Admin") ///Se ha effettuato il login un Admin
                    form = new FormAdmin();

                else
                    form = new FormAgenda();

                this.Hide(); ///Nascondo questo form
                //Close(); ///Chiudo questo fomr
                form.ShowDialog(); ///Mostro il form creato a seguito del login
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERRORE! FormLogin: " + ex.Message, "FormLogin da funzione CheckLavoraotre()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }
        #endregion
    }
}
