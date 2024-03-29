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

namespace AgendaAziendale.Forms.UserControls
{
    public partial class UCProgetti : UserControl
    {
        #region Attributi
        private Form formPadre;
        private List<Progetto> elencoProgetti;
        private bool filtra; 
        #endregion

        #region Getters & Setters
        public Form FormPadre { get => formPadre; set => formPadre = value; }
        public List<Progetto> ElencoProgetti { get => elencoProgetti; set => elencoProgetti = value; }
        public bool Filtra { get => filtra; set => filtra = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore dell'user control UCProgetti
        /// </summary>
        /// <param name="formPadre"></param>
        /// <param name="filtra"></param>
        public UCProgetti(Form formPadre, bool filtra)
        {
            InitializeComponent();
            FormPadre = formPadre;
            Filtra = filtra; ///Se è settato a true, mostra solo i progetti del lavoratore loggato
        }

        #region Meotdi ascoltatori
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> caricamento dati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCProgetti_Load(object sender, EventArgs e)
        {
            try
            {
                ///Figli del Form
                panelCentro.Parent = this;
                ///Figli del panelCentro
                dgvProgetti.Parent = panelCentro;

                if (Sessione.Lavoratore.Categoria == "Sviluppatore")
                {
                    dgvProgetti.Columns["gestione_lavoratori"].Visible = false;
                    dgvProgetti.Columns["modifica"].Visible = false;
                    dgvProgetti.Columns["elimina"].Visible = false;
                }


                AggiornadgvProgetti();
            }
            
            catch
            {
                MessageBox.Show("ERRORE! UCProgetti: errore caricamento interfaccia", "UCProgetti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore click sulle celle della dgv con possibilità di click (7a, 8a, 9a, 10a)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvProgetti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Progetto progetto = new Progetto();
                string codiceProgettoSelezionato = dgvProgetti.Rows[e.RowIndex].Cells[0].Value.ToString();
                int idProgettoSelezionato = int.Parse(dgvProgetti.Rows[e.RowIndex].Cells[5].Value.ToString());
                progetto = ElencoProgetti.FirstOrDefault(ev => ev.Codice == codiceProgettoSelezionato && ev.Id == idProgettoSelezionato);

                //Click sulla colonna con i button di visualizzazione e gestione degli obiettivi
                if (e.ColumnIndex == 7)
                {
                    FormObiettivi formObiettivi = new FormObiettivi(FormPadre, this, progetto);
                    formPadre.Hide();
                    formObiettivi.Show();
                }

                //Click sulla colonna con i button di gestione della partecipazione
                if (e.ColumnIndex == 8)
                {
                    FormPartecipanti formPartecipanti = new FormPartecipanti(FormPadre, this, progetto, "progetto");
                    formPadre.Hide();
                    formPartecipanti.Show();
                }

                //Click sulla colonna con i button di modifica
                if (e.ColumnIndex == 9)
                {
                    FormProgetto formModificaProgetto = new FormProgetto(FormPadre, this, progetto, "aggiorna");
                    formPadre.Hide();
                    formModificaProgetto.Show();
                }

                //Click sulla colonna con i button d'eliminazione
                if (e.ColumnIndex == 10)
                {
                    if (MessageBox.Show("Sei sicuro di voler procedere con l'eliminazione del progetto selezionato? Tutte le informazioni ad esso collegato verranno eliminate.",
                        "Eliminazione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (Controller.EliminaProgetto(codiceProgettoSelezionato, idProgettoSelezionato.ToString()))
                        {
                            MessageBox.Show("Eliminazione progetto avvenuta con successo!", "UCProgetti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AggiornadgvProgetti();
                        }

                        else
                            MessageBox.Show("ERRORE! Impossibile eliminare il progetto dal DB, contattare l'amministrazione.", "UCProgetti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                    Console.WriteLine("No action");
            }
            
            catch
            {
                MessageBox.Show("ERRORE! UCProgetti: errore cell click", "UCProgetti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        #endregion       

        #region Metodi
        /// <summary>
        /// Metodo per aggiornare i dati presenti nella dgvProgetti
        /// </summary>
        public void AggiornadgvProgetti()
        {
            try
            {
                List<Progetto> result_progetti = new List<Progetto>();

                if (Filtra)
                    result_progetti = Controller.GetElencoProgettiLavoratore(Sessione.Lavoratore.Username);

                else
                    result_progetti = Controller.GetElencoProgetti();

                dgvProgetti.Rows.Clear();

                if (result_progetti != null)
                {
                    ElencoProgetti = result_progetti;

                    foreach (Progetto progetto in ElencoProgetti)
                    {

                        int indice_riga = dgvProgetti.Rows.Add(progetto.Codice, progetto.Nome, progetto.Descrizione, progetto.DataInizio.ToShortDateString(), progetto.DataFine.ToShortDateString(),
                                           progetto.Id, progetto.Cliente);

                        /*string result_obiettivi = Controller.GetElencoObiettivi(progetto.Id.ToString()); ///Aggiungo gli obiettivi al progetto
                        if (result_obiettivi != "")
                        { 
                            progetto.Obiettivi = Obiettivo.GeneraElencoObiettivi(result_obiettivi);

                            dgvProgetti.Rows[indice_riga].Cells[7].Value = Controller.CalcolaAvanzamentoProgetto(progetto).ToString() + "%"; ///Calcolo l'avanzamento del progetto
                        }*/

                        if (Controller.GetElencoObiettivi(progetto.Id.ToString()) != null)
                            dgvProgetti.Rows[indice_riga].Cells[7].Value = Controller.CalcolaAvanzamentoProgetto(progetto).ToString() + "%"; ///Calcolo l'avanzamento del progetto

                        else
                            dgvProgetti.Rows[indice_riga].Cells[7].Value = "/";
                    }
                }

                else
                    MessageBox.Show("Non sono presenti progetti!", "Aggiorna UCProgeti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            catch
            {
                MessageBox.Show("ERRORE! UCProgetti: errore aggiornamento dgv progetti", "UCProgetti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion
    }
}
