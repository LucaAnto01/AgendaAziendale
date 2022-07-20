using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaAziendale.Forms;
using AgendaAziendale.Modelli;

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
            try
            {
                ///Figli del form
                panelTop.Parent = this;
                panelSinistra.Parent = this;
                panelCentro.Parent = this;
                ///Figli del pannello top
                btChiudi.Parent = panelTop;
                btMinimize.Parent = panelTop;
                ///Figli del pannello di sinistra
                btGestioneLavoratori.Parent = panelSinistra;
                btGestioneEventi.Parent = panelSinistra;
                btLogout.Parent = panelSinistra;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormAdmin: errore caricamento interfaccia", "FormAdmin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di chiusura 
        /// --> chiusura applicazione
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtChiudi_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }

            catch
            {
                MessageBox.Show("ERRORE! FormAdmin: impossibile chiudere l'interfaccia", "FormAdmin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di minimizzazione
        /// --> riduzione ad icona dell'applicazione
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtMinimize_Click(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Minimized;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormAdmin: impossibile ridurre l'interfaccia", "FormAdmin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di gestione per lavoratori
        /// --> visualizzazione Form di gestione per gli lavoratori
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtGestioneLavoratori_Click(object sender, EventArgs e)
        {
            try
            {
                CaricaForm(new FormGestione(this, "lavoratore", false));
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormAdmin: impossibile aprire form lavoratore", "FormAdmin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di gestione degli eventi
        /// --> visualizzazione Form di gestione degli eventi
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtGestioneEventi_Click(object sender, EventArgs e)
        {
            try
            {
                CaricaForm(new FormGestione(this, "evento", false));
            }

            catch
            {
                MessageBox.Show("ERRORE! FormAdmin: impossibile aprire form evento", "FormAdmin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di gestione dei progetti
        /// --> visualizzazione Form di gestione dei progetti
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtGestioneProgetti_Click(object sender, EventArgs e)
        {
            try
            {

                CaricaForm(new FormGestione(this, "progetto", false));
            }

            catch
            {
                MessageBox.Show("ERRORE! FormAdmin: impossibile aprire form progetto", "FormAdmin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone per visualizzare lo storico di eventi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtVisualizzaStoricoEventi_Click(object sender, EventArgs e)
        {
            try
            {

                CaricaForm(new FormStorico(this, "eventi"));
            }

            catch
            {
                MessageBox.Show("ERRORE! FormAdmin: impossibile aprire form storico eventi", "FormAdmin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone per visualizzare lo storico dei progetti
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtStoricoProgetti_Click(object sender, EventArgs e)
        {
            try
            {
                CaricaForm(new FormStorico(this, "progetti"));
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormAdmin: impossibile aprire form storico progetti", "FormAdmin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di logout
        /// --> effettua il logout, riporta alla schermata di login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtLogout_Click(object sender, EventArgs e)
        {
            try
            {
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
                Close(); //Chiudo questo form
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormAdmin: impossibile effettuare il logout", "FormAdmin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
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
            try
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
            
            catch
            {
                MessageBox.Show("ERRORE! FormAdmin: caricamento form in PanelCentro", "FormAdmin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion       
    }
}
