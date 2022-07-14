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
    public partial class UCLavoratori : UserControl
    {
        #region Attributi
        private Form formPadre;
        private List<Lavoratore> elencoLavoratori;
        #endregion

        #region Getters & Setters
        public Form FormPadre { get => formPadre; set => formPadre = value; }
        public List<Lavoratore> ElencoLavoratori { get => elencoLavoratori; set => elencoLavoratori = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore dell'user control UCLavoratori
        /// </summary>
        /// <param name="formPadre"></param>
        public UCLavoratori(Form formPadre)
        {
            FormPadre = formPadre;
            InitializeComponent();
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> caricamento dati
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

                FormLavoratore formModificaLavoratore = new FormLavoratore(FormPadre, this, lavoratore, "aggiorna");
                formPadre.Hide();
                formModificaLavoratore.Show();               
            }

            //Click sulla colonna con i button d'eliminazione
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("Sei sicuro di voler procedere con l'eliminazione del lavoratore selezionato? Tutte le informazioni ad esso collegato verranno eliminate.",
                    "Eliminazione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes) ///Se l'utente seleziona yes nella message box
                {
                    string username = dgvLavoratori.Rows[e.RowIndex].Cells[0].Value.ToString(); ///Username dell'utente da eliminare selezionato

                    if(username != Sessione.Lavoratore.Username)
                    {
                        if (Controller.EliminaLavoratore(username))
                        {
                            MessageBox.Show("Eliminazione lavoratore " + username + " avvenuta con successo!", "UCLavoratori", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AggiornadgvLavoratori();
                        }

                        else
                            MessageBox.Show("Impossibile eliminare l'utente dal DB. Controllare che non sia associato ad alcuna attività", "UCLavoratori", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                        MessageBox.Show("Non puoi eliminare il tuo account mentre sei loggato!", "UCLavoratori", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else
                Console.WriteLine("No action");
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo per aggiornare i dati presenti nella dgvLavoratori
        /// </summary>
        public void AggiornadgvLavoratori()
        {
            string result = Controller.GetElencoLavoratori();

            dgvLavoratori.Rows.Clear();

            if (result != "")
            {
                ElencoLavoratori = Lavoratore.GeneraElencoLavoratori(result);              

                foreach(Lavoratore lavoratore in ElencoLavoratori)
                    dgvLavoratori.Rows.Add(lavoratore.Username, lavoratore.Nome, lavoratore.Cognome, lavoratore.Residenza, 
                                           lavoratore.DataNascita.ToShortDateString(), lavoratore.Email, lavoratore.Categoria);              
            }

            else
                MessageBox.Show("Non sono presenti lavoratori!", "Aggiorna UCLavoratori", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        #endregion
    }
}
