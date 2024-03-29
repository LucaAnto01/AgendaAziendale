﻿using System;
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
            try
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
                btProgettiEventi.Parent = panelSinistra;
                btLogout.Parent = panelSinistra;

                SettaggioInterfaccia();
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormAgenda: caricamento form", "FormAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ERRORE! FormAgenda: impossibile chiudere il form", "FormAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ERRORE! FormAgenda: impossibile ridurre il form", "FormAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone per visualizzare evnti o progetti
        /// --> a seconda della tipologia di account loggato verranno visualizzati eventi (in tutti i casi) e progetti (PM, sviluppatore)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtVisualizzaAgenda_Click(object sender, EventArgs e)
        {
            try
            {
                CaricaForm(new FormVisualizzazioneAttivita(this));
            }

            catch
            {
                MessageBox.Show("ERRORE! FormAgenda: impossibile aprire form visualizzazioneAttivita", "FormAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone per operare su eventi o progetti, per segnarne la fine o gli step
        ///  --> a seconda della tipologia di account loggato si opera su eventi (segretario) e progetti (PM, sviluppatore)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtProgettiEventi_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Sessione.Lavoratore.Categoria == "Project Manager") || (Sessione.Lavoratore.Categoria == "Sviluppatore"))
                    CaricaForm(new FormGestione(this, "Progetto", true));
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormAgenda: impossibile aprire form progetti", "FormAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore vento click sul bottone per creare e gestire eventi o progetti
        /// --> visibile SOLO se account loggato è segretario o PM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtGestione_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sessione.Lavoratore.Categoria == "Project Manager")
                    CaricaForm(new FormGestione(this, "Progetto", false));

                else if (Sessione.Lavoratore.Categoria == "Segretario")
                    CaricaForm(new FormGestione(this, "Evento", false));
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormAgenda: impossibile aprire form progetti o eventi", "FormAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone per visualizzare lo storico di eventi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtVisualizzaStoricoEvento_Click(object sender, EventArgs e)
        {
            try
            {
                CaricaForm(new FormStorico(this, "eventi"));
            }

            catch
            {
                MessageBox.Show("ERRORE! FormAgenda: impossibile aprire form storico eventi", "FormAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ERRORE! FormAgenda: impossibile aprire form storico progetti", "FormAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ERRORE! FormAgenda: impossibile effettuare il logout", "FormAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ERRORE! FormAgenda: impossibile effettuare il caricamento del form", "FormAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Metodo adibito al settaggio dei testi e visualizzazione dei button a seconda della tipologia di account loggato
        /// </summary>
        private void SettaggioInterfaccia()
        {
            try
            {
                if (Sessione.Lavoratore.Categoria == "Project Manager")
                {
                    btGestione.Visible = true;
                    btStoricoProgetti.Visible = true;
                    btVisualizzaStoricoEvento.Visible = false;
                    btGestione.Text = "Gestione progetti";
                    btGestione.Image = Properties.Resources.Progetti; ///Settaggio dell'icona
                    btProgettiEventi.Text = "Progetti";
                    btProgettiEventi.Image = Properties.Resources.Progetti;
                }

                else if (Sessione.Lavoratore.Categoria == "Segretario")
                {
                    btGestione.Visible = true;
                    btGestione.Location = new Point(33, 205);
                    btProgettiEventi.Visible = false;
                    btVisualizzaStoricoEvento.Visible = true;
                    btStoricoProgetti.Visible = false;
                    btGestione.Text = "Gestione eventi";
                    btGestione.Image = Properties.Resources.Eventi;
                    btProgettiEventi.Text = "Eventi";
                    btProgettiEventi.Image = Properties.Resources.Eventi;
                }

                else if (Sessione.Lavoratore.Categoria == "Sviluppatore")
                {
                    btProgettiEventi.Text = "Progetti";
                    btProgettiEventi.Image = Properties.Resources.Progetti;
                }
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormAgenda: impossibile settare il testo del'interfaccia", "FormAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion
    }
}
