﻿using AgendaAziendale.Modelli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaAziendale.Forms.UserControls
{
    public partial class UCEventi : UserControl
    {
        #region Attributi
        private Form formPadre;
        private List<Evento> elencoEventi;
        #endregion

        #region Getters & Setters
        public Form FormPadre { get => formPadre; set => formPadre = value; }
        public List<Evento> ElencoEventi { get => elencoEventi; set => elencoEventi = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore dell'user control UCEventi
        /// </summary>
        /// <param name="formPadre"></param>
        public UCEventi(Form formPadre)
        {
            InitializeComponent();
            FormPadre = formPadre;
        }

        #region Meotdi ascoltatori
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCEventi_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelCentro.Parent = this;
            ///Figli del panelCentro
            dgvEventi.Parent = panelCentro;

            AggiornadgvEventi();
        }

        /// <summary>
        /// Ascoltatore click sulle celle della dgv con possibilità di click (7a e 8a)
        /// 7a --> effettua modifica del lavoratore
        /// 8a --> effettua eliminazione del lavoratore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvEventi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Click sulla colonna con i button di modifica
            if (e.ColumnIndex == 7)
            {
                Evento evento = new Evento();
                string codiceEventoSelezionato = dgvEventi.Rows[e.RowIndex].Cells[0].Value.ToString();
                int idEventoSelezionato = int.Parse(dgvEventi.Rows[e.RowIndex].Cells[5].Value.ToString());
                evento = ElencoEventi.FirstOrDefault(ev => ev.Codice == codiceEventoSelezionato && ev.Id == idEventoSelezionato);

                FormEvento formModificaEvento = new FormEvento(formPadre, this, evento, "aggiorna");
                formPadre.Hide();
                formModificaEvento.Show();
            }

            if (e.ColumnIndex == 8)
            {
                Evento evento = new Evento();
                string codiceEventoSelezionato = dgvEventi.Rows[e.RowIndex].Cells[0].Value.ToString();
                int idEventoSelezionato = int.Parse(dgvEventi.Rows[e.RowIndex].Cells[5].Value.ToString());
                evento = ElencoEventi.FirstOrDefault(ev => ev.Codice == codiceEventoSelezionato && ev.Id == idEventoSelezionato);

                FormPartecipanti formPartecipanti = new FormPartecipanti(FormPadre, this, evento, "evento"); //TODO: invece che null genera l'evento e passalo come parametro
                formPadre.Hide();
                formPartecipanti.Show();
            }

            //Click sulla colonna con i button d'eliminazione
            if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("Sei sicuro di voler procedere con l'eliminazione dell'evento selezionato? Tutte le informazioni ad esso collegato verranno eliminate.",
                    "Eliminazione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string codice = dgvEventi.Rows[e.RowIndex].Cells[0].Value.ToString(); ///Codice della riga selezionata
                    string id = dgvEventi.Rows[e.RowIndex].Cells[5].Value.ToString(); ///ID della riga selezionata

                    if (Controller.EliminaEvento(codice, id))
                    {
                        MessageBox.Show("Eliminazione evento avvenuta con successo!", "UCEventi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AggiornadgvEventi();
                    }

                    else
                        MessageBox.Show("ERRORE! Impossibile eliminare l'evento dal DB, contattare l'amministrazione.", "UCEventi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo per aggiornare i dati presenti nella dgvEventi
        /// </summary>
        public void AggiornadgvEventi()
        {
            string result = Controller.GetElencoEventi();

            dgvEventi.Rows.Clear();

            if (result != "")
            {
                ElencoEventi = Evento.GeneraElencoEventi(result);

                foreach (Evento evento in ElencoEventi)
                    dgvEventi.Rows.Add(evento.Codice, evento.Nome, evento.Descrizione, evento.DataInizio.ToShortDateString(), evento.DataFine.ToShortDateString(),
                                       evento.Id, evento.Luogo);
            }

            else
                MessageBox.Show("ERRORE! Impossibile ottenere i dati dal DB, contattare l'amministrazione.", "Aggiorna UCLavoratori", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}
