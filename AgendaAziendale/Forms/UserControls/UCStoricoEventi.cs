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
    public partial class UCStoricoEventi : UserControl
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
        /// Metodo costruttore dell'user control UCStoricoEventi
        /// </summary>
        /// <param name="formPadre"></param>
        public UCStoricoEventi(Form formPadre)
        {
            InitializeComponent();
            FormPadre = formPadre;
        }

        #region Metodi ascoltatori
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> caricamento dati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCStoricoEventi_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelCentro.Parent = this;
            ///Figli del panelCentro
            dgvStoricoEventi.Parent = panelCentro;

            AggiornadgvStoricoEventi();
        }

        /// <summary>
        /// Ascoltatore click sul bottone per effettuare l'eliminazione di un evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvStoricoEventi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Evento evento = new Evento();
            string codiceEventoSelezionato = dgvStoricoEventi.Rows[e.RowIndex].Cells[0].Value.ToString();
            int idEventoSelezionato = int.Parse(dgvStoricoEventi.Rows[e.RowIndex].Cells[5].Value.ToString());
            evento = ElencoEventi.FirstOrDefault(ev => ev.Codice == codiceEventoSelezionato && ev.Id == idEventoSelezionato);

            //Click sulla colonna con i button d'eliminazione
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Sei sicuro di voler procedere con l'eliminazione dell'evento selezionato? Tutte le informazioni ad esso collegato verranno eliminate.",
                    "Eliminazione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (Controller.EliminaEvento(codiceEventoSelezionato, idEventoSelezionato.ToString()))
                    {
                        MessageBox.Show("Eliminazione evento avvenuta con successo!", "UCStoricoEventi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AggiornadgvStoricoEventi();
                    }

                    else
                        MessageBox.Show("ERRORE! Impossibile eliminare l'evento dal DB, contattare l'amministrazione.", "UCStoricoEventi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else
                Console.WriteLine("No action");
        }
        #endregion


        #region Metodi
        /// <summary>
        /// Metodo per aggiornare i dati presenti nella dgvStoricoEventi
        /// </summary>
        public void AggiornadgvStoricoEventi()
        {
            string result = Controller.GetStoricoEventi();

            dgvStoricoEventi.Rows.Clear();

            if (result != "")
            {
                ElencoEventi = Evento.GeneraElencoEventi(result);

                foreach (Evento evento in ElencoEventi)
                    dgvStoricoEventi.Rows.Add(evento.Codice, evento.Nome, evento.Descrizione, evento.DataInizio.ToShortDateString(), evento.DataFine.ToShortDateString(),
                                       evento.Id, evento.Luogo);
            }

            else
                MessageBox.Show("Non sono presenti eventi!", "Aggiorna UCStoricoEventi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
