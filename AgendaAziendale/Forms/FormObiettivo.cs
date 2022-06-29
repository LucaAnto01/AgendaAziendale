using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AgendaAziendale.Forms.UserControls;
using AgendaAziendale.Modelli;

namespace AgendaAziendale.Forms
{
    public partial class FormObiettivo : Form
    {
        #region Attributi
        private Form formPadre;
        private readonly UCProgetti ucPadre;
        private readonly UCObiettivi ucObiettivi;
        private readonly Progetto progetto;
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
        /// <param name="progetto"></param>
        /// <param name="ucPadre"></param>
        /// <param name="azione"></param>
        public FormObiettivo(Form formPadre, Progetto progetto, UCProgetti ucPadre, string azione)
        {
            InitializeComponent();
            FormPadre = formPadre;
            this.progetto = progetto;
            this.ucPadre = ucPadre;
            ucObiettivi = null;
            obiettivo = null;
            this.azione = azione;
        }

        /// <summary>
        /// Metodo costruttore del FormObiettivo
        /// </summary>
        /// <param name="formPadre"></param>
        /// <param name="ucPadre"></param>
        /// <param name="progetto"></param>
        /// <param name="obiettivo"></param>
        /// <param name="azione"></param>
        public FormObiettivo(Form formPadre, UCProgetti ucPadre, Progetto progetto, Obiettivo obiettivo, string azione)
        {
            InitializeComponent();
            FormPadre = formPadre;
            this.ucPadre = ucPadre;
            ucObiettivi = null;
            this.progetto = progetto;
            this.obiettivo = obiettivo;
            this.azione = azione;
        }

        public FormObiettivo(Form formPadre, UCProgetti ucPadre, UCObiettivi ucObiettivi, Progetto progetto, Obiettivo obiettivo, string azione)
        {
            InitializeComponent();
            FormPadre = formPadre;
            this.ucPadre = ucPadre;
            this.ucObiettivi = ucObiettivi;
            this.progetto = progetto;
            this.obiettivo = obiettivo;
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
            FormPadre.Show();          
            Close();
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di minimizzazione
        /// --> riduzione ad icona dell'applicazione
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
        /// Ascoltatore click sul bottone adibito alla creazione o all'aggiornamento di un obiettivo e del relativo progetto di conseguenza
        /// --> effettuo l'azione di aggiunta o modifica
        /// --> aggiorno la dgv contenente i dati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAggiungiAggiorna_Click(object sender, EventArgs e)
        {
            if (tbDescrizione.Text != "")
            {
                if ((azione == "Aggiungi") || (azione == "aggiungi"))
                {
                    if (Controller.AggiungiObiettivo(progetto.Id.ToString(), tbDescrizione.Text, ckCompletato.Checked))
                    {
                        MessageBox.Show("Inserimento obiettivo " + tbDescrizione.Text + " avvenuto con successo!", "FormObiettivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbDescrizione.Text = "";
                    }
                        
                    else
                        MessageBox.Show("Errore in fase d'inserimento.", "FormObiettivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                if ((azione == "Aggiorna") || (azione == "aggiorna"))
                {
                    if (Controller.ModificaObiettivo(obiettivo.Id.ToString(), tbDescrizione.Text, ckCompletato.Checked)) ///Aggiorno l'obiettivo nel db
                    {
                        MessageBox.Show("Aggiornamento obiettivo avvenuto con successo!", "FormObiettivo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ucPadre.AggiornadgvProgetti();
                        formPadre.Show();
                        Close();
                    }
                    else
                        MessageBox.Show("Aggiornamento obiettivo fallito.", "FormObiettivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (ucPadre != null)
                    ucPadre.AggiornadgvProgetti();

                if (ucObiettivi != null)
                    ucObiettivi.AggiornadgvObiettivi();

                lbErrore.Visible = false;
            }

            else
                lbErrore.Visible = true;
        }
        #endregion
    }
}
