using AgendaAziendale.Forms;
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
    public partial class FormAdmin : Form
    {

        /// <summary>
        /// Metodo costruttore del FormLogin
        /// </summary>
        public FormAdmin()
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
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            ///Figli del form
            panelTop.Parent = this;
            panelSinistra.Parent = this;
            panelCentro.Parent = this;
            ///Figli del pannello top
            btChiudi.Parent = panelTop;
            ///Figli del pannello di sinistra
            btGestioneUtenti.Parent = panelSinistra;
            btGestioneAttivita.Parent = panelSinistra;
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
        /// Ascoltatore evento click sul bottone di gestione per utenti
        /// --> visualizzazione Form di gestione per gli utenti
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtGestioneUtenti_Click(object sender, EventArgs e)
        {
            CaricaForm(new FormGestioneUtenti());
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di gestione delle attività
        /// --> visualizzazione Form di gestione delle attivita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtGestioneAttivita_Click(object sender, EventArgs e)
        {
            //TODO: apri il form relativo alla gestione dell'interfaccia
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

        #region Metodi
        /// <summary>
        /// Metodo adibito al caricamento dinamico dell'interfaccia d'azione nel pannello centrale
        /// sulla base della selezione dell'utente
        /// </summary>
        /// <param name="formIn"></param>
        public void CaricaForm(object formIn)
        {

            if (panelCentro.Controls.Count > 0) //Controllo che non ci siano altri form già all'interno dell'interfaccia
                panelCentro.Controls.RemoveAt(0); //Elimino i controlli relativi al form precedentemente inserito nell'interfaccia

            Form f = formIn as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill; //Mi assicuro che occupi tutto lo spazio disponibile, se fosse troppo grande lo ridimensionerebbe
            panelCentro.Controls.Add(f); //Asssegno i controlli al form "dinamico" creato
            panelCentro.Tag = f;
            f.Show();
        }


        #endregion

        
    }
}
