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
    public partial class UCLavoratori : UserControl
    {
        #region Attributi
        private readonly Form formPadre;
        private List<Lavoratore> elencoLavoratori;
        #endregion

        #region Getters & Setters
        public List<Lavoratore> ElencoLavoratori { get => elencoLavoratori; set => elencoLavoratori = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore dell'user control UCLavoratori
        /// </summary>
        /// <param name="formPadre"></param>
        public UCLavoratori(Form formPadre)
        {
            this.formPadre = formPadre;
            InitializeComponent();
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCLavoratori_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelCentro.Parent = this;
            //Figli del panelCentro
            dgvLavoratori.Parent = panelCentro;

            AggiornadgvLavoratori();
        }

        /// <summary>
        /// Ascoltatore click sulle celle della dgv con possibilità di click (7a e 8a)
        /// 7a --> effettua modifica del lavoratore
        /// 8a --> effettua eliminazione del lavoratore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvLavoratori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Click sulla colonna con i button di modifica
            if (e.ColumnIndex == 7)
            {
                Lavoratore lavoratore = new Lavoratore();

                string usernameSelezionato = dgvLavoratori.Rows[e.RowIndex].Cells[0].Value.ToString(); ///Username del lavoratore selezionato
                ///Seleziono il lavoratore corrispettivo da quelli presenti nella lista
                lavoratore = ElencoLavoratori.FirstOrDefault(l => l.Username == usernameSelezionato); 

                FormLavoratore formModificaLavoratore = new FormLavoratore(formPadre, this, lavoratore, "aggiorna"); //TODO: metti poi il lavoratore selezionando la riga
                formModificaLavoratore.ShowDialog();
            }

            //Click sulla colonna con i button d'eliminazione
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("Sei sicuro di voler procedere con l'eliminazione del lavoratore selezionato? Tutte le informazioni ad esso collegato verranno eliminate.",
                    "Eliminazione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes) ///Se l'utente seleziona yes nella message box
                {
                    string username = dgvLavoratori.Rows[e.RowIndex].Cells[0].Value.ToString(); ///Username dell'utente da eliminare selezionato

                    if(Controller.EliminaLavoratore(username))
                    {
                        MessageBox.Show("Eliminazione lavoratore " + username + " avvenuta con successo!", "UCLavoratori", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AggiornadgvLavoratori();
                    }

                    else
                        MessageBox.Show("ERRORE! Impossibile eliminare l'utente dal DB, contattare l'amministrazione.", "UCLavoratori", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo per aggiornare i dati presenti nella dgvLavoratori
        /// </summary>
        public void AggiornadgvLavoratori()
        {
            //TODO: fai e richiama il metodo per popolare la dgv --> va fatto lato server-db --> guarda la foto in condivisa
            string result = Controller.GetElencoLavoratori();

            if(result != "")
            {
                ElencoLavoratori = Lavoratore.GeneraElencoLavoratori(result);

                dgvLavoratori.Rows.Clear();

                foreach(Lavoratore lavoratore in ElencoLavoratori)
                    dgvLavoratori.Rows.Add(lavoratore.Username, lavoratore.Nome, lavoratore.Cognome, lavoratore.Residenza, 
                                           lavoratore.DataNascita.ToShortDateString(), lavoratore.Email, lavoratore.Categoria);              
            }

            else
                MessageBox.Show("ERRORE! Impossibile ottenere i dati dal DB, contattare l'amministrazione.", "Aggiorna UCLavoratori", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        #endregion
    }
}
