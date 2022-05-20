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
using AgendaAziendale.Forms.UserControls;

namespace AgendaAziendale.Forms
{
    public partial class FormPartecipanti : Form
    {
        #region Attributi
        private Form formPadre;
        private UserControl ucPadre;
        private Attivita att;
        private readonly string tipologia;
        #endregion

        #region Getters & Setters
        public Form FormPadre { get => formPadre; set => formPadre = value; }
        public UserControl UcPadre { get => ucPadre; set => ucPadre = value; }
        public Attivita Att { get => att; set => att = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore del form FormPartecipanti
        /// </summary>
        /// <param name="formPadre"></param>
        /// <param name="ucPadre"></param>
        /// <param name="att"></param>
        /// <param name="tipologia"></param>
        public FormPartecipanti(Form formPadre, UserControl ucPadre, Attivita att, string tipologia)
        {
            InitializeComponent();
            FormPadre = formPadre;
            UcPadre = ucPadre;
            Att = att;
            this.tipologia = tipologia;
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> settaggio attributi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPartecipanti_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelTop.Parent = this;
            panelCentro.Parent = this;
            ///Figli del pannello top
            btChiudi.Parent = panelTop;
            ///Figli del pannello centrale
            lbLavoratore.Parent = panelCentro;
            btAggiungi.Parent = panelCentro;
            btRimuovi.Parent = panelCentro;

            if ((tipologia == "Evento") || (tipologia == "evento"))
            {
                UcPadre = (UCEventi)UcPadre;
                Att = (Evento)Att;
            }

            else if ((tipologia == "Progetto") || (tipologia == "progetto"))
            {
                UcPadre = (UCProgetti)UcPadre;
                Att = (Progetto)Att;
            }

            else
            {
                MessageBox.Show("ERRORE! Valore FormPartecipanti:tipologia --> controllare stack chiamate!", "Compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Ascoltatore click sul bottone di aggiunta ad un'attività
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAggiungi_Click(object sender, EventArgs e)
        {
            //TODO: aggiungi il lavoratore come partecipante nel DB
        }

        /// <summary>
        /// Ascoltatore click sul bottone di rimozione da un'attività
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtRimuovi_Click(object sender, EventArgs e)
        {
            //TODO: rimuovi il lavoratore come partecipante nel DB
        }
        #endregion
    }
}
