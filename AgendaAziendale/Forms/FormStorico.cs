using AgendaAziendale.Forms.UserControls;
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
    public partial class FormStorico : Form
    {
        #region Attributi
        private readonly string tipologia;
        private UserControl ucContenitore;
        #endregion

        #region Getters & Setters
        public UserControl UcContenitore { get => ucContenitore; set => ucContenitore = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore FormStorico 
        /// </summary>
        /// <param name="tipologia"></param>
        public FormStorico(string tipologia)
        {
            InitializeComponent();
            this.tipologia = tipologia;
        }

        #region Ascoltatori eventi
        /// <summary>
        ///  Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormStorico_Load(object sender, EventArgs e)
        {
            ///Figli del form
            panelCentro.Parent = this;
            ///Figli del panelCentro
            panelUCcontenitore.Parent = panelCentro;

            if ((tipologia == "Eventi") || (tipologia == "eventi"))
            {
                UcContenitore = new UCStoricoEventi();
            }

            else if ((tipologia == "Progetti") || (tipologia == "progetti"))
            {
                UcContenitore = new UCStoricoProgetti();
            }

            else
            {
                MessageBox.Show("ERRORE! Valore FormStorico:tipologia --> controllare stack chiamate!", "Compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            panelUCcontenitore.Controls.Add(UcContenitore); ///Aggiungo l'UC all'interfaccia
        }
        #endregion
    }
}
