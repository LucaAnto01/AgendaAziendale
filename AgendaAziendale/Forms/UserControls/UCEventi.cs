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
    public partial class UCEventi : UserControl
    {
        #region Attributi
        private Form formPadre;
        private List<Evento> elencoEventi;
        private bool filtra;
        #endregion

        #region Getters & Setters
        public Form FormPadre { get => formPadre; set => formPadre = value; }
        public List<Evento> ElencoEventi { get => elencoEventi; set => elencoEventi = value; }
        public bool Filtra { get => filtra; set => filtra = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore dell'user control UCEventi
        /// </summary>
        /// <param name="formPadre"></param>
        /// <param name="filtra"></param>
        public UCEventi(Form formPadre, bool filtra)
        {
            InitializeComponent();
            FormPadre = formPadre;
            Filtra = filtra;
        }

        #region Meotdi ascoltatori
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> caricamento dati
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
        /// Ascoltatore click sulle celle della dgv con possibilità di click (7a, 8a, 9a)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvEventi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Evento evento = new Evento();
            string codiceEventoSelezionato = dgvEventi.Rows[e.RowIndex].Cells[0].Value.ToString();
            int idEventoSelezionato = int.Parse(dgvEventi.Rows[e.RowIndex].Cells[5].Value.ToString());
            evento = ElencoEventi.FirstOrDefault(ev => ev.Codice == codiceEventoSelezionato && ev.Id == idEventoSelezionato);

            //Click sulla colonna con i button di gestione della partecipazione
            if (e.ColumnIndex == 7)
            {              
                FormPartecipanti formPartecipanti = new FormPartecipanti(FormPadre, this, evento, "evento"); //TODO: invece che null genera l'evento e passalo come parametro
                formPadre.Hide();
                formPartecipanti.Show();
            }

            //Click sulla colonna con i button di modifica
            if (e.ColumnIndex == 8)
            {
                FormEvento formModificaEvento = new FormEvento(formPadre, this, evento, "aggiorna");
                formPadre.Hide();
                formModificaEvento.Show();
            }           

            //Click sulla colonna con i button d'eliminazione
            if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("Sei sicuro di voler procedere con l'eliminazione dell'evento selezionato? Tutte le informazioni ad esso collegato verranno eliminate.",
                    "Eliminazione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (Controller.EliminaEvento(codiceEventoSelezionato, idEventoSelezionato.ToString()))
                    {
                        MessageBox.Show("Eliminazione evento avvenuta con successo!", "UCEventi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AggiornadgvEventi();
                    }

                    else
                        MessageBox.Show("ERRORE! Impossibile eliminare l'evento dal DB, contattare l'amministrazione.", "UCEventi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else
                Console.WriteLine("No action");
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo per aggiornare i dati presenti nella dgvEventi
        /// </summary>
        public void AggiornadgvEventi()
        {
            string result = "";

            if (Filtra)
                result = Controller.GetElencoEventiLavoratore(Sessione.Lavoratore.Username);

            else
                result = Controller.GetElencoEventi();

            dgvEventi.Rows.Clear();

            if (result != "")
            {
                ElencoEventi = Evento.GeneraElencoEventi(result);

                foreach (Evento evento in ElencoEventi)
                    dgvEventi.Rows.Add(evento.Codice, evento.Nome, evento.Descrizione, evento.DataInizio.ToShortDateString(), evento.DataFine.ToShortDateString(),
                                       evento.Id, evento.Luogo);
            }

            else
                MessageBox.Show("Non sono presenti eventi!", "Aggiorna UCLavoratori", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
