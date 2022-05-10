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
    public partial class UCLavoratori : UserControl
    {
        /// <summary>
        /// Metodo costruttore dell'user control UCLavoratori
        /// </summary>
        public UCLavoratori()
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
            if (e.ColumnIndex == 0)
            {
                FormLavoratore formModificaLavoratore = new FormLavoratore(this, null, "aggiorna"); //TODO: metti poi l'evento selezionando la riga
                formModificaLavoratore.Show();
            }

            //Click sulla colonna con i button d'eliminazione
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Sei sicuro di voler procedere con l'eliminazione del lavoratore selezionato? Tutte le informazioni ad esso collegato verranno eliminate.",
                    "Eliminazione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes) ///Se l'utente seleziona yes nella message box
                {
                    //string username = dgvLavoratori.Rows[e.RowIndex].Cells[0].ToString(); ///Username della riga selezionata
                    //TODO: elimina il lavoratore dal DB sulla base del suo username
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
        }
        #endregion
    }
}
