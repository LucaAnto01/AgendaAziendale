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
    public partial class UCStoricoProgetti : UserControl
    {
        public UCStoricoProgetti()
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
        private void UCStoricoProgetti_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelCentro.Parent = this;
            ///Figli del panelCentro
            dgvStoricoProgetti.Parent = panelCentro;
        }

        /// <summary>
        /// Ascoltatore click sul bottone per ottenere le informazioni inerenti all'evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvProgetti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO: fai form info
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo per aggiornare i dati presenti nella dgvStoricoProgetti
        /// </summary>
        public void AggiornadgvStoricoProgetti()
        {
            //TODO: fai e richiama il metodo per popolare la dgv --> va fatto lato server-db --> guarda la foto in condivisa
        }
        #endregion
    }
}
