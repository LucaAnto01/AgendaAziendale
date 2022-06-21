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
using AgendaAziendale.Forms.UserControls;

namespace AgendaAziendale.Forms
{
    public partial class FormObiettivi : Form
    {
        #region Attributi
        private Form formPadre;
        private UCProgetti ucProgettiPadre;
        private UCObiettivi ucObiettivi;
        private Progetto progettoPadre;
        #endregion

        #region Getters & Setters
        public Form FormPadre { get => formPadre; set => formPadre = value; }
        public UCProgetti UcProgettiPadre { get => ucProgettiPadre; set => ucProgettiPadre = value; }
        public UCObiettivi UcObiettivi { get => ucObiettivi; set => ucObiettivi = value; }
        public Progetto ProgettoPadre { get => progettoPadre; set => progettoPadre = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore FormObiettivi
        /// </summary>
        /// <param name="formPadre"></param>
        /// <param name="ucProgettiPadre"></param>
        /// <param name="progettoPadre"></param>
        public FormObiettivi(Form formPadre, UCProgetti ucProgettiPadre, Progetto progettoPadre)
        {
            InitializeComponent();
            FormPadre = formPadre;
            UcProgettiPadre = ucProgettiPadre;
            ProgettoPadre = progettoPadre;
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormObiettivi_Load(object sender, EventArgs e)
        {
            ///Figli del Form
            panelTop.Parent = this;
            panelCentro.Parent = this;
            ///Figli del pannello top
            btChiudi.Parent = panelTop;
            ///Figli del pannello centrale
            btAggiugniObiettivo.Parent = panelCentro;
            panelContenitore.Parent = panelCentro;

            UcObiettivi = new UCObiettivi(this, ProgettoPadre, UcProgettiPadre);
            panelContenitore.Controls.Add(UcObiettivi);
        }

        /// <summary>
        /// Ascoltatore evento click sul bottone di chiusura 
        /// --> chiusura form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtChiudi_Click(object sender, EventArgs e)
        {
            FormPadre.Show();
            Close();
        }

        /// <summary>
        /// Ascoltatore click button adibito all'aggiunta di un obiettivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAggiugniObiettivo_Click(object sender, EventArgs e)
        {
            FormObiettivo formAggiungiObiettivo = new FormObiettivo(this, UcProgettiPadre, UcObiettivi, ProgettoPadre, null, "aggiungi");
            Hide();
            formAggiungiObiettivo.Show();
        }
        #endregion       
    }
}
