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
using AgendaAziendale.Modelli;
using AgendaAziendale.Forms.UserControls;

namespace AgendaAziendale.Forms
{
    public partial class FormEvento : Form
    {
        #region Attributi
        private readonly Form formPadre;
        private readonly UCEventi ucPadre;
        private readonly Evento evento;
        private readonly string azione;
        #endregion

        #region Metodi costruttori
        /// <summary>
        /// Metodo costruttore del FormEvento
        /// </summary>
        /// <param name="formPadre"></param>
        /// <param name="ucPadre"></param>
        /// <param name="evento"></param>
        /// <param name="azione"></param>
        public FormEvento(Form formPadre, UCEventi ucPadre, Evento evento, string azione)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            this.ucPadre = ucPadre;
            this.evento = evento;
            this.azione = azione;
        }

        /// <summary>
        /// Metodo costruttore del FormEvento
        /// </summary>
        /// <param name="formPadre"></param>
        /// <param name="ucPadre"></param>
        /// <param name="azione"></param>
        public FormEvento(Form formPadre, UCEventi ucPadre,string azione)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            this.ucPadre = ucPadre;
            this.evento = null;
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
        private void FormEvento_Load(object sender, EventArgs e)
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
                lbLuogo.Parent = panelCentro;
                tbNome.Parent = panelCentro;
                tbDescrizione.Parent = panelCentro;
                tbDataInizio.Parent = panelCentro;
                tbDataFine.Parent = panelCentro;
                tbLuogo.Parent = panelCentro;
                mcDataInizio.Parent = panelCentro;
                mcDataFine.Parent = panelCentro;
                lbErrore.Parent = panelCentro;
                lbErroreData.Parent = panelCentro;
                btAggiungiAggiorna.Parent = panelCentro;

                ///Setto un minimo valido per il settaggio delle date di un nuovo Evento
                mcDataInizio.MinDate = DateTime.Now;
                mcDataFine.MinDate = DateTime.Now;

                if (evento != null) ///Se ho un evento da modificare
                {
                    tbNome.Text = evento.Nome;
                    tbDescrizione.Text = evento.Descrizione;
                    tbDataInizio.Text = evento.DataInizio.ToShortDateString();
                    tbDataFine.Text = evento.DataFine.ToShortDateString();
                    tbLuogo.Text = evento.Luogo;
                }

                if ((azione == "Aggiungi") || (azione == "aggiungi"))
                    btAggiungiAggiorna.Text = "Aggiungi";

                else if ((azione == "Aggiorna") || (azione == "aggiorna"))
                    btAggiungiAggiorna.Text = "Aggiorna";

                else
                {
                    MessageBox.Show("ERRORE! Valore FormEvento:tipologia --> controllare stack chiamate!", "Compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
           
            catch
            {
                MessageBox.Show("ERRORE! FormEvento: caricamento form", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ERRORE! FormEvento: impossibile chiudere il form", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ERRORE! FormEvento: impossibile minimizzare il form", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ERRORE! FormEvento: errore correzzione caratteri speciali", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        ///  Ascoltatore click sulla text box relativa all'inserimento della data d'inizio dell'evento
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
                MessageBox.Show("ERRORE! FormEvento: errore visualizzazione calendario per input data inizio", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore selezione data calendario data d'inizio dell'evento
        /// --> chiusura calendario, settaggio della data e visualizzazione nella text box
        /// --> riabilitazione possibilità di input text box relativa all'inserimento della data d'inizio dell'evento
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
                MessageBox.Show("ERRORE! FormEvento: errore chiusura calendario per input data inizio", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore click sulla text box relativa all'inserimento della data di fine dell'evento
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
                MessageBox.Show("ERRORE! FormEvento: errore visualizzazione calendario per input data fine", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore selezione data calendario data di fine dell'evento
        /// --> chiusura calendario, settaggio della data e visualizzazione nella text box
        /// --> riabilitazione possibilità di input text box relativa all'inserimento della data di fine dell'evento
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
                MessageBox.Show("ERRORE! FormEvento: errore chiusura calendario per input data inizio", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ERRORE! FormEvento: errore pulizia campo input", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore click sul bottone adibito alla creazione o all'aggiornamento di un evento
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
                        if (Controller.CreaEvento(tbNome.Text, tbDescrizione.Text, DateTime.Parse(tbDataInizio.Text), DateTime.Parse(tbDataFine.Text), tbLuogo.Text))
                        {
                            MessageBox.Show("Inserimento evento " + tbNome.Text + " avvenuto con successo!", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PulisciCampiInserimento();
                        }

                        else
                            MessageBox.Show("Errore in fase d'inserimento.", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                    if ((azione == "Aggiorna") || (azione == "aggiorna"))
                    {
                        if (Controller.AggiornaEvento(evento.Codice, evento.Id.ToString(), tbNome.Text, tbDescrizione.Text, DateTime.Parse(tbDataInizio.Text), DateTime.Parse(tbDataFine.Text), tbLuogo.Text))
                        {
                            MessageBox.Show("Aggiornamento evento " + tbNome.Text + " avvenuto con successo!", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            formPadre.Show();
                            Close();
                        }

                        else
                            MessageBox.Show("Errore in fase di aggiornamento.", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (ucPadre != null)
                        ucPadre.AggiornadgvEventi();
                }

                else
                    lbErrore.Visible = true;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormEvento: errore click aggiornamento/inserimento dati", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (tbLuogo.Text == "")
                {
                    tbLuogo.BackColor = Color.Red;
                    check = false;
                }
            }

            catch
            {
                MessageBox.Show("ERRORE! FormEvento: errore check campi intput", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                tbLuogo.Text = "";
                lbErrore.Visible = false;
                lbErroreData.Visible = false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormEvento: errore pulizia campi inseirmento", "FormEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion       
    }
}
