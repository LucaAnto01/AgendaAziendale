using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaAziendale.Forms.UserControls;
using AgendaAziendale.Modelli;

namespace AgendaAziendale.Forms
{
    public partial class FormGestione : Form
    {
        #region Attributi
        private Form formPadre;
        private readonly string tipologia;
        private UserControl ucContenitore;
        private bool filtra;
        #endregion

        #region Gettrs & Setters
        public UserControl UcContenitore { get => ucContenitore; set => ucContenitore = value; }
        public Form FormPadre { get => formPadre; set => formPadre = value; }
        public bool Filtra { get => filtra; set => filtra = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore del FormGestione
        /// </summary>
        /// <param name="formPadre"></param>
        /// <param name="tipologia"></param>
        /// <param name="filtra"></param>
        public FormGestione(Form formPadre, string tipologia, bool filtra)
        {
            InitializeComponent();
            FormPadre = formPadre;
            this.tipologia = tipologia;
            Filtra = filtra;
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> settaggio testi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGestione_Load(object sender, EventArgs e)
        {
            try
            {
                ///Figli del form
                panelCentro.Parent = this;
                ///Figli del panelCentro
                btAggiungi.Parent = panelCentro;
                panelUCcontenitore.Parent = panelCentro;

                if (Filtra)
                    btAggiungi.Visible = false;

                if ((tipologia == "Lavoratore") || (tipologia == "lavoratore"))
                {
                    btAggiungi.Text = "Aggiungi lavoratore";
                    UcContenitore = new UCLavoratori(FormPadre);
                }

                else if ((tipologia == "Evento") || (tipologia == "evento"))
                {
                    btAggiungi.Text = "Aggiungi evento";
                    UcContenitore = new UCEventi(FormPadre, Filtra);
                }

                else if ((tipologia == "Progetto") || (tipologia == "progetto"))
                {
                    btAggiungi.Text = "Aggiungi progetto";
                    UcContenitore = new UCProgetti(FormPadre, Filtra);
                }

                else
                {
                    MessageBox.Show("ERRORE! Valore FormGestione:tipologia --> controllare stack chiamate!", "Compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

                panelUCcontenitore.Controls.Add(UcContenitore); ///Aggiungo l'UC all'interfaccia
            }

            catch
            {
                MessageBox.Show("ERRORE! FormGestione: errore caricamento interfaccia", "FormGestione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void BtAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tipologia == "Lavoratore") || (tipologia == "lavoratore"))
                {
                    FormLavoratore formAggiungi = new FormLavoratore(FormPadre, (UCLavoratori)UcContenitore, "aggiungi");
                    FormPadre.Hide();
                    formAggiungi.ShowDialog();
                }

                else if ((tipologia == "Evento") || (tipologia == "evento"))
                {
                    FormEvento formAggiungi = new FormEvento(FormPadre, (UCEventi)UcContenitore, "aggiungi");
                    FormPadre.Hide();
                    formAggiungi.ShowDialog();
                }

                else if ((tipologia == "Progetto") || (tipologia == "progetto"))
                {
                    FormProgetto formAggiungi = new FormProgetto(FormPadre, (UCProgetti)UcContenitore, "aggiungi");
                    FormPadre.Hide();
                    formAggiungi.ShowDialog();
                }

                else
                {
                    MessageBox.Show("ERRORE! Valore FormGestione:tipologia --> controllare stack chiamate!", "Compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormGestione: errore click bottone aggiunta", "FormGestione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion
    }
}
