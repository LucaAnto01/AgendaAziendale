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

namespace AgendaAziendale.Forms.UserControls
{
    public partial class UCStoricoProgetti : UserControl
    {
        #region Attributi
        private Form formPadre;
        private List<Progetto> elencoProgetti;
        #endregion

        #region Getters & Setters
        public Form FormPadre { get => formPadre; set => formPadre = value; }
        public List<Progetto> ElencoProgetti { get => elencoProgetti; set => elencoProgetti = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore dell'user control UCStoricoProgetti
        /// </summary>
        /// <param name="formPadre"></param>
        public UCStoricoProgetti(Form formPadre)
        {
            InitializeComponent();
            FormPadre = formPadre;
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> caricamento dati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCStoricoProgetti_Load(object sender, EventArgs e)
        {
            try
            {
                ///Figli del Form
                panelCentro.Parent = this;
                ///Figli del panelCentro
                dgvStoricoProgetti.Parent = panelCentro;

                AggiornadgvStoricoProgetti();
            }
            
            catch
            {
                MessageBox.Show("ERRORE! UCStoricoProgetti: errore caricamento interfaccia", "UCStoricoProgetti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore click sul bottone per effettuare l'eliminazione di un progetto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvProgetti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Progetto progetto = new Progetto();
                string codiceProgettoSelezionato = dgvStoricoProgetti.Rows[e.RowIndex].Cells[0].Value.ToString();
                int idProgettoSelezionato = int.Parse(dgvStoricoProgetti.Rows[e.RowIndex].Cells[5].Value.ToString());
                progetto = ElencoProgetti.FirstOrDefault(ev => ev.Codice == codiceProgettoSelezionato && ev.Id == idProgettoSelezionato);

                //Click sulla colonna con i button d'eliminazione
                if (e.ColumnIndex == 8)
                {
                    if (MessageBox.Show("Sei sicuro di voler procedere con l'eliminazione del progetto selezionato? Tutte le informazioni ad esso collegato verranno eliminate.",
                        "Eliminazione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (Controller.EliminaProgetto(codiceProgettoSelezionato, idProgettoSelezionato.ToString()))
                        {
                            MessageBox.Show("Eliminazione progetto avvenuta con successo!", "UCStoricoProgetti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AggiornadgvStoricoProgetti();
                        }

                        else
                            MessageBox.Show("ERRORE! Impossibile eliminare il progetto dal DB, contattare l'amministrazione.", "UCStoricoProgetti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                    Console.WriteLine("No action");
            }
            
            catch
            {
                MessageBox.Show("ERRORE! UCStoricoProgetti: errore cell click", "UCStoricoProgetti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo per aggiornare i dati presenti nella dgvStoricoProgetti
        /// </summary>
        public void AggiornadgvStoricoProgetti()
        {
            try
            {
                List<Progetto> result_progetti = Controller.GetElencoProgetti();

                dgvStoricoProgetti.Rows.Clear();

                if (result_progetti != null)
                {
                    ElencoProgetti = result_progetti;

                    foreach (Progetto progetto in ElencoProgetti)
                    {

                        int indice_riga = dgvStoricoProgetti.Rows.Add(progetto.Codice, progetto.Nome, progetto.Descrizione, progetto.DataInizio.ToShortDateString(), progetto.DataFine.ToShortDateString(),
                                           progetto.Id, progetto.Cliente);

                        /*string result_obiettivi = Controller.GetElencoObiettivi(progetto.Id.ToString()); ///Aggiungo gli obiettivi al progetto
                        if (result_obiettivi != "")
                        {
                            progetto.Obiettivi = Obiettivo.GeneraElencoObiettivi(result_obiettivi);

                            dgvStoricoProgetti.Rows[indice_riga].Cells[7].Value = Controller.CalcolaAvanzamentoProgetto(progetto).ToString() + "%"; ///Calcolo l'avanzamento del progetto
                        }*/

                        if (Controller.GetElencoObiettivi(progetto.Id.ToString()) != null)
                            dgvStoricoProgetti.Rows[indice_riga].Cells[7].Value = Controller.CalcolaAvanzamentoProgetto(progetto).ToString() + "%"; ///Calcolo l'avanzamento del progetto

                        else
                            dgvStoricoProgetti.Rows[indice_riga].Cells[7].Value = "/";
                    }
                }

                else
                    MessageBox.Show("Non sono presenti progetti!", "Aggiorna UCStoricoProgetti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            catch
            {
                MessageBox.Show("ERRORE! UCStoricoProgetti: errore aggiornamento dgv storico progetti", "UCStoricoProgetti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion
    }
}
