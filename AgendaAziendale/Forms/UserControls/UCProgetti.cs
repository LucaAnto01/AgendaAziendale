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
    public partial class UCProgetti : UserControl
    {
        #region Attributi
        private Form formPadre;
        #endregion

        #region Getters & Setters
        public Form FormPadre { get => formPadre; set => formPadre = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore dell'user control UCProgetti
        /// </summary>
        /// <param name="formPadre"></param>
        public UCProgetti(Form formPadre)
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
        private void UCProgetti_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelCentro.Parent = this;
            ///Figli del panelCentro
            dgvProgetti.Parent = panelCentro;
        }

        #endregion

        private void DgvProgetti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Click sulla colonna con i button di modifica
            if (e.ColumnIndex == 0)
            {
                FormProgetto formModificaProgetto = new FormProgetto(this, null, "aggiorna"); //TODO: invece che null genera il progetto e passalo come parametro
                formModificaProgetto.ShowDialog();
            }

            if (e.ColumnIndex == 1)
            {
                FormPartecipanti formPartecipanti = new FormPartecipanti(FormPadre, this, null, "progetto"); //TODO: invece che null genera il progetto e passalo come parametro
                formPartecipanti.ShowDialog();
            }

            //Click sulla colonna con i button d'eliminazione
            if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Sei sicuro di voler procedere con l'eliminazione dell'evento selezionato? Tutte le informazioni ad esso collegato verranno eliminate.",
                    "Eliminazione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //string username = dgvProgetti.Rows[e.RowIndex].Cells[0].ToString(); ///Codice della riga selezionata
                    //TODO: elimina il lavoratore dal DB sulla base del suo username
                }
            }
        }

        #region Metodi
        /// <summary>
        /// Metodo per aggiornare i dati presenti nella dgvProgetti
        /// </summary>
        public void AggiornadgvProgetti()
        {
            //TODO: fai e richiama il metodo per popolare la dgv --> va fatto lato server-db --> guarda la foto in condivisa
        }
        #endregion
    }
}
