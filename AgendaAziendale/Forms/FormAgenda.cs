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
        
        /// <summary>
        /// Metodo costruttore del FormAgenda
        /// </summary>
        public FormAgenda()
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
            btProgettiEventi.Parent = panelSinistra;
            btGestione.Parent = panelSinistra;
            btStoricoProgetti.Parent = panelSinistra;
            btProgettiEventi.Parent= panelSinistra;
            btLogout.Parent = panelSinistra;

            SettaggioInterfaccia();
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
            CaricaForm(new FormVisualizzazioneAttivita(this));
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone per operare su eventi o progetti, per segnarne la fine o gli step
        ///  --> a seconda della tipologia di account loggato si opera su eventi (segretario) e progetti (PM, sviluppatore)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtProgettiEventi_Click(object sender, EventArgs e)
        {
            if ((Sessione.Lavoratore.Categoria == "Project Manager") || (Sessione.Lavoratore.Categoria == "Sviluppatore"))
                CaricaForm(new FormGestione(this, "Progetto", true));
        }

        /// <summary>
        /// Ascoltatore vento click sul bottone per creare e gestire eventi o progetti
        /// --> visibile SOLO se account loggato è segretario o PM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtGestione_Click(object sender, EventArgs e)
        {
            if (Sessione.Lavoratore.Categoria == "Project Manager")
                CaricaForm(new FormGestione(this, "Progetto", false));

            else if (Sessione.Lavoratore.Categoria == "Segretario")
                CaricaForm(new FormGestione(this, "Evento", false));
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone per visualizzare lo storico di eventi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtVisualizzaStoricoEvento_Click(object sender, EventArgs e)
        {
            CaricaForm(new FormStorico(this, "eventi"));
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone per visualizzare lo storico dei progetti
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtStoricoProgetti_Click(object sender, EventArgs e)
        {
            CaricaForm(new FormStorico(this, "progetti"));
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
            formLogin.ShowDialog();
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

        /// <summary>
        /// Metodo adibito al settaggio dei testi e visualizzazione dei button a seconda della tipologia di account loggato
        /// </summary>
        private void SettaggioInterfaccia()
        {
            if(Sessione.Lavoratore.Categoria == "Project Manager")
            {
                btGestione.Visible = true;
                btStoricoProgetti.Visible = true;
                btVisualizzaStoricoEvento.Visible = false;
                btGestione.Text = "Gestione progetti";
                btProgettiEventi.Text = "Progetti";
            }

            else if(Sessione.Lavoratore.Categoria == "Segretario")
            {
                btGestione.Visible = true;
                btGestione.Location = new Point(50, 205);
                btProgettiEventi.Visible = false;
                btVisualizzaStoricoEvento.Visible = true;
                btStoricoProgetti.Visible = false;
                btGestione.Text = "Gestione eventi";
                btProgettiEventi.Text = "Eventi";
            }

            else if (Sessione.Lavoratore.Categoria == "Sviluppatore")
            {
                btProgettiEventi.Text = "Progetti";
            }
        }
        #endregion
    }
}
