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
        /// <summary>
        /// Metodo costruttore dell'user control UCEventi
        /// </summary>
        public UCEventi()
        {
            InitializeComponent();
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
            if (e.ColumnIndex == 0)
            {
                FormEvento formModificaEvento = new FormEvento(this, null, "aggiorna"); //TODO: invece che null genera l'evento e passalo come parametro
                formModificaEvento.Show();
            }

            //Click sulla colonna con i button d'eliminazione
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Sei sicuro di voler procedere con l'eliminazione dell'evento selezionato? Tutte le informazioni ad esso collegato verranno eliminate.",
                    "Eliminazione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //string username = dgvEventi.Rows[e.RowIndex].Cells[0].ToString(); ///Codice della riga selezionata
                    //TODO: elimina il lavoratore dal DB sulla base del suo username
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
            //TODO: fai e richiama il metodo per popolare la dgv --> va fatto lato server-db --> guarda la foto in condivisa
        }
        #endregion
    }
}
