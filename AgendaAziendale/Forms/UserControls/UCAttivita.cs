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
    public partial class UCAttivita : UserControl
    {
        #region Attributi
        private Attivita attivita;
        #endregion

        #region Getters & Setters
        public Attivita Attivita { get => attivita; set => attivita = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore dell'UCAttivita
        /// </summary>
        /// <param name="attivita"></param>
        public UCAttivita(Attivita attivita)
        {
            InitializeComponent();
            Attivita = attivita;
        }

        #region Ascoltatori eventi
        /// <summary>
        ///  Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> gestione visualizzazione elementi a seconda del tipo di attività
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCAttivita_Load(object sender, EventArgs e)
        {
            ///Figli del form
            panelCentro.Parent = this;
            ///Figli del panelCentro
            lbTitolo.Parent = panelCentro;
            lbClienteLuogo.Parent = panelCentro;    
            lbDataInizioFine.Parent = panelCentro; 
            pbProgetto.Parent = panelCentro;

            //TODO: SETTA I TESTI --> FAI UN METODO
        }

        /// <summary>
        /// Metodo richiamato quando il puntatore del mouse entra nell'area dell'user control
        /// --> rendo più scuro il background per risaltare l'effetto di passaggio visivamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCAttivita_MouseEnter(object sender, EventArgs e)
        {
            panelCentro.BackColor = Color.Gainsboro;
        }

        /// <summary>
        /// Metodo richiamato quando il puntatore del mouse esce nell'area dell'user control
        /// --> riporto il background al suo colore originale per risaltare l'effetto di passaggio visivamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCAttivita_MouseLeave(object sender, EventArgs e)
        {
            panelCentro.BackColor = Color.WhiteSmoke;
        }
        #endregion
    }
}
