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
    public partial class UCStoricoEventi : UserControl
    {
        public UCStoricoEventi()
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
        private void UCStoricoEventi_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelCentro.Parent = this;
            ///Figli del panelCentro
            dgvStoricoEventi.Parent = panelCentro;
        }

        /// <summary>
        /// Ascoltatore click sul bottone per ottenere le informazioni inerenti all'evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvStoricoEventi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO: fai form info
        }
        #endregion


        #region Metodi
        /// <summary>
        /// Metodo per aggiornare i dati presenti nella dgvStoricoEventi
        /// </summary>
        public void AggiornadgvStoricoEventi()
        {
            //TODO: fai e richiama il metodo per popolare la dgv --> va fatto lato server-db --> guarda la foto in condivisa
        }
        #endregion
    }
}
