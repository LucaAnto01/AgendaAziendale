using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaAziendale.Forms.UserControls;
using AgendaAziendale.Modelli;

namespace AgendaAziendale.Forms
{
    public partial class FormObiettivo : Form
    {
        #region Attributi
        private Form formPadre;
        private readonly UCProgetti ucPadre;
        private readonly Obiettivo obiettivo;
        private readonly string azione;
        #endregion

        #region Getters & Setters
        public Form FormPadre { get => formPadre; set => formPadre = value; }
        #endregion

        #region Metodi costruttori
        /// <summary>
        /// Metodo costruttore del FormObiettivo
        /// </summary>
        /// <param name="formPadre"></param>
        /// <param name="ucPadre"></param>
        /// <param name="obiettivo"></param>
        /// <param name="azione"></param>
        public FormObiettivo(Form formPadre, UCProgetti ucPadre, Obiettivo obiettivo, string azione)
        {
            InitializeComponent();
            FormPadre = formPadre;
            this.ucPadre = ucPadre;
            this.obiettivo = obiettivo;
            this.azione = azione;
        }

        /// <summary>
        /// Metodo costruttore del FormObiettivo
        /// </summary>
        /// <param name="formPadre"></param>
        /// <param name="ucPadre"></param>
        /// <param name="azione"></param>
        public FormObiettivo(Form formPadre, UCProgetti ucPadre, string azione)
        {
            InitializeComponent();
            FormPadre = formPadre;
            this.ucPadre = ucPadre;
            this.obiettivo = null;
            this.azione = azione;
        }
        #endregion

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> settaggio testi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormObiettivo_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelTop.Parent = this;
            panelCentro.Parent = this;
            ///Figli del pannello top
            btChiudi.Parent = panelTop;
            ///Figli del pannello centrale
            lbDescrizione.Parent = panelCentro;
            lbCompletato.Parent = panelCentro;
            tbDescrizione.Parent = panelCentro;
            ckCompletato.Parent = panelCentro;
            btAggiungiAggiorna.Parent = panelCentro;

            if(obiettivo != null) //Se ho un obiettivo da modificare
            {
                tbDescrizione.Text = obiettivo.Desccrizione;

                if(obiettivo.Completato)
                    ckCompletato.Checked = true;
            }

            if ((azione == "Aggiungi") || (azione == "aggiungi"))
                btAggiungiAggiorna.Text = "Aggiungi";

            else if ((azione == "Aggiorna") || (azione == "aggiorna"))
                btAggiungiAggiorna.Text = "Aggiorna";

            else
            {
                MessageBox.Show("ERRORE! Valore FormObiettivo:tipologia --> controllare stack chiamate!", "Compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            FormPadre.Hide(); //Nascondo il FormPadre
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di chiusura 
        /// --> chiusura form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtChiudi_Click(object sender, EventArgs e)
        {
            FormPadre.ShowDialog();
            Close();
        }

        /// <summary>
        /// Ascoltatore click sul bottone adibito alla creazione o all'aggiornamento di un obiettivo e del relativo progetto di conseguenza
        /// --> effettuo l'azione di aggiunta o modifica
        /// --> aggiorno la dgv contenente i dati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAggiungiAggiorna_Click(object sender, EventArgs e)
        {
            if ((azione == "Aggiungi") || (azione == "aggiungi"))
                //Richiama funzione aggiungi

            if ((azione == "Aggiorna") || (azione == "aggiorna"))
                //Richiama funzione aggiorna

            if (ucPadre != null)
                ucPadre.AggiornadgvProgetti();
        }
        #endregion
    }
}
