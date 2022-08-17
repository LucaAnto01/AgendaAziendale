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
    public partial class UCObiettivi : UserControl
    {
        #region Attributi
        private Form formPadre;
        private Progetto progettoPadre;
        private UCProgetti ucProgettiPadre;
        #endregion

        #region Getters & Setters
        public Form FormPadre { get => formPadre; set => formPadre = value; }
        public Progetto ProgettoPadre { get => progettoPadre; set => progettoPadre = value; }
        public UCProgetti UcProgettiPadre { get => ucProgettiPadre; set => ucProgettiPadre = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore dell'user control UCObiettivi
        /// </summary>
        /// <param name="formPadre"></param>
        /// <param name="progettoPadre"></param>
        /// <param name="ucProgettiPadre"></param>
        public UCObiettivi(Form formPadre, Progetto progettoPadre, UCProgetti ucProgettiPadre)
        {
            FormPadre = formPadre;
            ProgettoPadre = progettoPadre;
            UcProgettiPadre = ucProgettiPadre;
            InitializeComponent();
        }

        #region Meotdi ascoltatori
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> caricamento dati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCObiettivi_Load(object sender, EventArgs e)
        {
            try
            {
                ///Figli del Form
                panelCentro.Parent = this;
                ///Figli del panelCentro
                dgvObiettivi.Parent = panelCentro;

                AggiornadgvObiettivi();
            }
            
            catch
            {
                MessageBox.Show("ERRORE! UCObiettivi: errore caricamento interfaccia", "UCObiettivi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore click sulle celle della dgv con possibilità di click (3a, 4a)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvObiettivi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Obiettivo obiettivo = new Obiettivo();
                string idObiettivoSelezionato = dgvObiettivi.Rows[e.RowIndex].Cells[0].Value.ToString();
                obiettivo = ProgettoPadre.Obiettivi.FirstOrDefault(ob => ob.Id.ToString() == idObiettivoSelezionato);

                //Click sulla colonna con i button di modifica dell'obiettivo
                if (e.ColumnIndex == 3)
                {
                    FormObiettivo formObiettivo = new FormObiettivo(FormPadre, UcProgettiPadre, this, ProgettoPadre, obiettivo, "aggiorna");
                    FormPadre.Hide();
                    formObiettivo.Show();
                }

                //Click sulla colonna con i button d'eliminazione dell'obiettivo
                if (e.ColumnIndex == 4)
                {
                    if (MessageBox.Show("Sei sicuro di voler procedere con l'eliminazione del'obiettivo selezionato? Tutte le informazioni ad esso collegato verranno eliminate.",
                        "Eliminazione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (Controller.EliminaObiettivo(idObiettivoSelezionato))
                        {
                            MessageBox.Show("Eliminazione progetto avvenuta con successo!", "UCObiettivi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AggiornadgvObiettivi();
                        }

                        else
                            MessageBox.Show("ERRORE! Impossibile eliminare l'obiettivo dal DB, contattare l'amministrazione.", "UCObiettivi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                    Console.WriteLine("No action");
            }
            
            catch
            {
                MessageBox.Show("ERRORE! UCObiettivi: errore cell click", "UCObiettivi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion

        #region Meotdi
        /// <summary>
        /// Metodo per aggiornare i dati presenti nella dgvObiettivi
        /// </summary>
        public void AggiornadgvObiettivi()
        {
            try
            {
                string result = Controller.GetElencoObiettivi(ProgettoPadre.Id.ToString());

                dgvObiettivi.Rows.Clear();

                if (result != "")
                {
                    ProgettoPadre.Obiettivi = Obiettivo.GeneraElencoObiettivi(result);

                    foreach (Obiettivo obiettivo in ProgettoPadre.Obiettivi)
                        dgvObiettivi.Rows.Add(obiettivo.Id, obiettivo.Desccrizione, (obiettivo.Completato ? 1.ToString() : 0.ToString()));
                }

                else
                    MessageBox.Show("Non sono presenti obiettivi!", "Aggiorna UCObiettivi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            catch
            {
                MessageBox.Show("ERRORE! UCObiettivi: errore aggiornamento dgv obiettivi", "UCObiettivi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion       
    }
}
