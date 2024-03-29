﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AgendaAziendale.Modelli;
using AgendaAziendale.Forms.UserControls;

namespace AgendaAziendale.Forms
{
    public partial class FormProgetto : Form
    {
        #region Attributi
        private readonly Form formPadre;
        private readonly UCProgetti ucPadre;
        private readonly Progetto progetto;
        private readonly string azione;
        #endregion

        #region Metodi costruttori
        /// <summary>
        /// Metodo costruttore del FormProgetto
        /// </summary>
        /// <param name="formPadre"></param>
        /// <param name="ucPadre"></param>
        /// <param name="progetto"></param>
        /// <param name="azione"></param>
        public FormProgetto(Form formPadre, UCProgetti ucPadre, Progetto progetto, string azione)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            this.ucPadre = ucPadre;
            this.progetto = progetto;
            this.azione = azione;
        }

        /// <summary>
        /// Metodo costruttore del FormProgetto
        /// </summary>
        /// <param name="formPadre"></param>
        /// <param name="ucPadre"></param>
        /// <param name="azione"></param>
        public FormProgetto(Form formPadre, UCProgetti ucPadre, string azione)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            this.ucPadre = ucPadre;
            this.progetto = null;
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
        private void FormProgetto_Load(object sender, EventArgs e)
        {
            try
            {
                ///Figli del Form
                panelTop.Parent = this;
                panelCentro.Parent = this;
                ///Figli del pannello top
                btChiudi.Parent = panelTop;
                ///Figli del pannello centrale
                lbNome.Parent = panelCentro;
                lbDescrizione.Parent = panelCentro;
                lbDataInizio.Parent = panelCentro;
                lbDataFine.Parent = panelCentro;
                lbCliente.Parent = panelCentro;
                tbNome.Parent = panelCentro;
                tbDescrizione.Parent = panelCentro;
                tbDataInizio.Parent = panelCentro;
                tbDataFine.Parent = panelCentro;
                tbCliente.Parent = panelCentro;
                mcDataInizio.Parent = panelCentro;
                mcDataFine.Parent = panelCentro;
                lbErrore.Parent = panelCentro;
                lbErroreData.Parent = panelCentro;
                btAggiungiAggiorna.Parent = panelCentro;
                btGestioneObiettivi.Parent = panelCentro;

                ///Setto un minimo valido per il settaggio delle date di un nuovo Progetto
                mcDataInizio.MinDate = DateTime.Now;
                mcDataFine.MinDate = DateTime.Now.AddDays(1);

                if (progetto != null) ///Se ho un evento da modificare
                {
                    tbNome.Text = progetto.Nome;
                    tbDescrizione.Text = progetto.Descrizione;
                    tbDataInizio.Text = progetto.DataInizio.ToShortDateString();
                    tbDataFine.Text = progetto.DataFine.ToShortDateString();
                    tbCliente.Text = progetto.Cliente;
                }

                if ((azione == "Aggiungi") || (azione == "aggiungi"))
                    btAggiungiAggiorna.Text = "Aggiungi";

                else if ((azione == "Aggiorna") || (azione == "aggiorna"))
                {
                    btAggiungiAggiorna.Text = "Aggiorna";
                    btGestioneObiettivi.Visible = true;
                }


                else
                {
                    MessageBox.Show("ERRORE! Valore FormProgetto:tipologia --> controllare stack chiamate!", "Compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormProgetto: errore caricamento interfaccia", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di chiusura 
        /// --> chiusura form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtChiudi_Click(object sender, EventArgs e)
        {
            try
            {
                formPadre.Show();
                Close();
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormProgetto: errore chiusura interfaccia", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ERRORE! FormProgetto: errore minimizzazione interfaccia", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Validazione caratteri durante l'inserimento nelle text box
        /// --> no lettere con accenti e caratteri strani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((!Regex.IsMatch(((TextBox)sender).Text, Sessione.Regex)) && (((TextBox)sender).Text != ""))
                {
                    MessageBox.Show("Non inserire lettere accentate o caratteri speciali!", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ((TextBox)sender).Text = "";
                }
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormProgetto: errore controllo inserimento testo per caratteri speciale", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        ///  Ascoltatore click sulla text box relativa all'inserimento della data d'inizio del progetto
        /// --> apertura calendario
        /// --> bloccaggio possibilità di input al fine di evitare errori di scrittura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbDataInizio_Enter(object sender, EventArgs e)
        {
            try
            {
                ((TextBox)sender).BackColor = Color.White;
                mcDataInizio.Show();
                tbDataInizio.Enabled = false;
                tbDataFine.Enabled = false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormProgetto: errore visualizzazione calendario per input data inizio", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore selezione data calendario data d'inizio del progetto
        /// --> chiusura calendario, settaggio della data e visualizzazione nella text box
        /// --> riabilitazione possibilità di input text box relativa all'inserimento della data d'inizio del progetto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void McDataInizio_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {
                mcDataInizio.Hide();
                tbDataInizio.Enabled = true;
                tbDataFine.Enabled = true;
                tbDataInizio.Text = mcDataInizio.SelectionRange.Start.ToShortDateString();
            }          

            catch
            {
                MessageBox.Show("ERRORE! FormProgetto: errore chiusura calendario per input data inizio", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore click sulla text box relativa all'inserimento della data di fine del progetto
        /// --> apertura calendario
        /// --> bloccaggio possibilità di input al fine di evitare errori di scrittura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbDataFine_Enter(object sender, EventArgs e)
        {
            try
            {
                ((TextBox)sender).BackColor = Color.White;
                lbErroreData.Visible = false;
                mcDataFine.Show();
                tbDataFine.Enabled = false;
                tbDataInizio.Enabled = false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormProgetto: errore visualizzazione calendario per input data fine", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore selezione data calendario data di fine del progetto
        /// --> chiusura calendario, settaggio della data e visualizzazione nella text box
        /// --> riabilitazione possibilità di input text box relativa all'inserimento della data di fine del progetto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void McDataFine_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {
                mcDataFine.Hide();
                tbDataFine.Enabled = true;
                tbDataInizio.Enabled = true;
                tbDataFine.Text = mcDataFine.SelectionRange.Start.ToShortDateString();
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormProgetto: errore chiusura calendario per input data fine", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click text box
        /// --> settaggio background color --> white
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbEnter_Click(object sender, EventArgs e)
        {
            try
            {
                ((TextBox)sender).BackColor = Color.White;
            }

            catch
            {
                MessageBox.Show("ERRORE! FormProgetto: errore pulizia campo input", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore click sul bottone adibito alla creazione o all'aggiornamento di un progetto
        /// --> effettuo l'azione di aggiunta o modifica
        /// --> aggiorno la dgv contenente i dati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAggiungiAggiorna_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckCampi())
                {
                    if ((azione == "Aggiungi") || (azione == "aggiungi"))
                    {
                        Progetto nuovoProgetto = new Progetto("", tbNome.Text, tbDescrizione.Text, DateTime.Parse(tbDataInizio.Text), DateTime.Parse(tbDataFine.Text), 0, tbCliente.Text);
                        if (Controller.CreaProgetto(nuovoProgetto))
                        {
                            PulisciCampiInserimento();
                            MessageBox.Show("Inserimento progetto " + tbNome.Text + " avvenuto con successo!", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        else
                            MessageBox.Show("Errore in fase d'inserimento.", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if ((azione == "Aggiorna") || (azione == "aggiorna"))
                    {
                        Progetto aggiornaProgetto = new Progetto(progetto.Codice, tbNome.Text, tbDescrizione.Text, DateTime.Parse(tbDataInizio.Text), DateTime.Parse(tbDataFine.Text), progetto.Id, tbCliente.Text);
                        if (Controller.AggiornaProgetto(aggiornaProgetto))
                        {
                            MessageBox.Show("Aggiornamento progetto " + tbNome.Text + " avvenuto con successo!", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            formPadre.Show();
                            Close();
                        }

                        else
                            MessageBox.Show("Errore in fase di aggiornamento.", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (ucPadre != null)
                        ucPadre.AggiornadgvProgetti();
                }

                else
                    lbErrore.Visible = true;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormProgetto: errore click aggiornamento/inserimento dati", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Click sul bottone di aggiunta di un Obiettivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtGestioneObiettivi_Click(object sender, EventArgs e)
        {
            try
            {
                FormObiettivi formObiettivi = new FormObiettivi(this, ucPadre, progetto);
                formObiettivi.Show();
                Hide();
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormProgetto: errore click gestione obiettivi", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        #endregion

        #region Metodi
        /// <summary>
        /// Funzione adibita al controllo del completamento dei campi d'inserimento
        /// </summary>
        /// <returns>bool</returns>
        private bool CheckCampi()
        {
            bool check = true; ///True, tutti i campi compilati

            try
            {
                if (tbNome.Text == "")
                {
                    tbNome.BackColor = Color.Red;
                    check = false;
                }

                if (tbDescrizione.Text == "")
                {
                    tbDescrizione.BackColor = Color.Red;
                    check = false;
                }

                if (tbDataInizio.Text == "")
                {
                    tbDataInizio.BackColor = Color.Red;
                    check = false;
                }

                if (tbDataFine.Text == "")
                {
                    tbDataFine.BackColor = Color.Red;
                    check = false;
                }

                if (DateTime.Parse(tbDataFine.Text) < DateTime.Parse(tbDataInizio.Text)) ///Controllo validità data fine
                {
                    lbErroreData.Visible = true;
                    check = false;
                }

                if (tbCliente.Text == "")
                {
                    tbCliente.BackColor = Color.Red;
                    check = false;
                }
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormProgetto: errore check campi intput", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return check;
        }

        /// <summary>
        /// Metodo adibito alla pulizia di tutti i campi d'inserimento
        /// </summary>
        private void PulisciCampiInserimento()
        {
            try
            {
                tbNome.Text = "";
                tbDescrizione.Text = "";
                tbDataInizio.Text = "";
                tbDataFine.Text = "";
                tbCliente.Text = "";
                lbErrore.Visible = false;
                lbErroreData.Visible = false;
            }            

            catch
            {
                MessageBox.Show("ERRORE! FormProgetto: errore pulizia campi inseirmento", "FormProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion
    }
}
