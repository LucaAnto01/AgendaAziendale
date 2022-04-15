using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaAziendale.Forms
{
    public partial class FormEliminazione : Form
    {
        #region Attributi
        private string tipologia;
        #endregion

        #region Getters & Setters
        public string Tipologia { get => tipologia; set => tipologia = value; }
        #endregion

        public FormEliminazione(string tipologia)
        {
            InitializeComponent();
            Tipologia = tipologia;
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> settaggio valore lbEventoProgetto
        ///  --> caricamento personalizzato della combobox sulla base della tipologia di attività o per i lavoratori
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEliminazioneAttivita_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelTop.Parent = this;
            panelCentro.Parent = this;
            ///Figli del pannello top
            btChiudi.Parent = panelTop;
            ///Figli del pannello centrale
            lbCampoEliminazione.Parent = panelCentro;
            cbCampoEliminazione.Parent = panelCentro;
            btElimina.Parent = panelCentro;
            
            if (Tipologia.Equals("evento") || Tipologia.Equals("Evento"))
                lbCampoEliminazione.Text = "Evento";

            else if (Tipologia.Equals("progetto") || Tipologia.Equals("Progetto"))
                lbCampoEliminazione.Text = "Progetto";

            else if (Tipologia.Equals("lavoratore") || Tipologia.Equals("Lavoratore"))
                lbCampoEliminazione.Text = "Lavoratore";

            else
            {
                MessageBox.Show("ERRORE valore FormEliminazioneAttivita:tipologia --> controllare stack chiamate!");
                Application.Exit();
            }
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di chiusura 
        /// --> chiusura form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Ascoltatore click sul button per effettuare l'eliminazione
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtElimina_Click(object sender, EventArgs e)
        {
            //TODO: fai cose
        }
        #endregion

    }
}
