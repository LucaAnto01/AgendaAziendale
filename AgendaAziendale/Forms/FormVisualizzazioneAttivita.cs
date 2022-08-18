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
    public partial class FormVisualizzazioneAttivita : Form
    {
        #region Attributi
        private Form formPadre;
        private List<Attivita> elencoAttivita;
        private List<UCAttivita> listaUCAttivita;
        #endregion

        #region Gettrs & Setters
        public Form FormPadre { get => formPadre; set => formPadre = value; }
        public List<Attivita> ElencoAttivita { get => elencoAttivita; set => elencoAttivita = value; }
        public List<UCAttivita> ListaUCAttivita { get => listaUCAttivita; set => listaUCAttivita = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore del FormVisualizzazioneAttivita
        /// </summary>
        /// <param name="formPadre"></param>
        public FormVisualizzazioneAttivita(Form formPadre)
        {
            InitializeComponent();
            FormPadre = formPadre;
            ElencoAttivita = new List<Attivita>();
            ListaUCAttivita = new List<UCAttivita>();
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> visualizzazione attività
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVisualizzazioneAttivita_Load(object sender, EventArgs e)
        {
            try
            {
                ///Figli del form
                panelTop.Parent = this;
                panelCentro.Parent = this;
                ///Figli del panelTop
                lbEventi.Parent = panelTop;
                lbProgetti.Parent = panelTop;
                ///Figli del pannelCentro
                flpSinistra.Parent = panelCentro;
                flpDestra.Parent = panelCentro;

                if (Sessione.Lavoratore.Categoria == "Segretario")
                {
                    flpDestra.Visible = false;
                    lbProgetti.Visible = false;
                }

                AggiornaInterfaccia();
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormVisualizzazioneAttivita: errore caricamento interfaccia", "FormVisualizzazioneAttivita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo adibito all'aggiornamento dei dati visualizzati nell'interfaccia
        /// </summary>
        private void AggiornaInterfaccia()
        {
            try
            {
                ///Pulisco le List
                ElencoAttivita.Clear();
                ListaUCAttivita.Clear();

                CaricaEventi();

                if (Sessione.Lavoratore.Categoria != "Segretario")
                    CaricaProgetti();
            }            

            catch
            {
                MessageBox.Show("ERRORE! FormVisualizzazioneAttivita: errore aggiornamento interfaccia", "FormVisualizzazioneAttivita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Metodo che si occupa del caricamento degli UCAttività di tipologia Evento nel flpSinistra al fine di mostrarli all'utente
        /// </summary>
        private void CaricaEventi()
        {
            try
            {
                List<Evento> elencoEventi = Controller.GetElencoEventiLavoratore(Sessione.Lavoratore.Username);
                flpSinistra.Controls.Clear(); ///Mi assicuro che il pannello sia pulito e lo pulisco nel caso ci sia da aggiornare l'interfaccia

                if (elencoEventi != null)
                {
                    List<UCAttivita> listaUCAttivita = new List<UCAttivita>();

                    elencoEventi.ForEach(evento => listaUCAttivita.Add(new UCAttivita(evento))); ///Genero gli UCAttivita associati ad ogni evento

                    foreach (UCAttivita attivita in listaUCAttivita)
                    {
                        //attivita.Click += UCAttivita_Click; ///Aggiungo l'ascoltatore dell'evento del click sull'UC
                        flpSinistra.Controls.Add(attivita); ///Inserisco nel flpSinistra l'UC                   
                    }

                    ElencoAttivita.Concat(elencoEventi); ///Aggiungo l'elenco degli eventi  all'elenco delle attività
                    ListaUCAttivita.Concat(listaUCAttivita); ///Aggiungo l'elenco delle UCAttività alla lista degli UC attività
                }

                else
                    MessageBox.Show("Non partecipi ad alcun evento!", "CaricaEventi FormVisualizzazioneAttivita", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormVisualizzazioneAttivita: errore cariamento eventi", "FormVisualizzazioneAttivita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Metodo che si occupa del caricamento degli UCAttività di tipologia Progetto nel flpDestra al fine di mostrarli all'utente
        /// </summary>
        private void CaricaProgetti()
        {
            try
            {
                List<Progetto> result_elencoProgetti = Controller.GetElencoProgettiLavoratore(Sessione.Lavoratore.Username);
                flpDestra.Controls.Clear(); ///Mi assicuro che il pannello sia pulito e lo pulisco nel caso ci sia da aggiornare l'interfaccia

                if (result_elencoProgetti != null)
                {
                    List<Progetto> elencoProgetti = result_elencoProgetti;
                    List<UCAttivita> listaUCAttivita = new List<UCAttivita>();

                    elencoProgetti.ForEach(progetto => listaUCAttivita.Add(new UCAttivita(progetto))); ///Genero gli UCAttivita associati ad ogni evento

                    foreach (UCAttivita attivita in listaUCAttivita)
                    {
                        //attivita.Click += UCAttivita_Click; ///Aggiungo l'ascoltatore dell'evento del click sull'UC
                        flpDestra.Controls.Add(attivita); ///Inserisco nel flpSinistra l'UC                   
                    }

                    ElencoAttivita.Concat(elencoProgetti); ///Aggiungo l'elenco dei progetto  all'elenco delle attività
                    ListaUCAttivita.Concat(listaUCAttivita); ///Aggiungo l'elenco delle UCAttività alla lista degli UC attività
                }

                else
                    MessageBox.Show("Non partecipi ad alcun progetto!", "CaricaProgetti FormVisualizzazioneAttivita", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            catch
            {
                MessageBox.Show("ERRORE! FormVisualizzazioneAttivita: errore cariamento progetti", "FormVisualizzazioneAttivita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /*/// <summary>
        /// Ascoltatore click sugli UCAttività creati
        /// --> se viene cliccato un progetto permette di segnare gli obbiettivi portati a termine
        /// --> se viene cliccato un evento mostra le informazioni relative ad esso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCAttivita_Click(object sender, EventArgs e)
        {
            UCAttivita ucAttivita = (UCAttivita)sender; ///Ottengo l'elemento cliccato
            MessageBox.Show("Click avvenuto");
            //Se progetto --> form per segnare le cose fatte
            //Se evento --> form per mostrare le info
        }*/
        #endregion
    }
}
