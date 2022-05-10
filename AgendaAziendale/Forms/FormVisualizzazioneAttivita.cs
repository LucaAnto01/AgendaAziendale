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
        private Lavoratore lavoratore;
        #endregion

        #region Getters & Setters
        public Lavoratore Lavoratore { get => lavoratore; set => lavoratore = value; }
        #endregion

        /// <summary>
        /// Metodo costruttore del FormVisualizzazioneAttivita
        /// </summary>
        /// <param name="lavoratore"></param>
        public FormVisualizzazioneAttivita(Lavoratore lavoratore)
        {
            InitializeComponent();
            Lavoratore = lavoratore;
        }

        #region Ascoltatori eventi
        /// <summary>
        /// Metodo richiamato al caricamento dell'interfaccia
        ///  --> settaggio gerarchie interfaccia
        ///  --> visualizzo le attività
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVisualizzazioneAttivita_Load(object sender, EventArgs e)
        {
            flpCentro.Parent = this;
            CaricaAttivita();
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo che si occupa del caricamento degli UCAttività nel form al fine di mostrarli all'utente
        /// </summary>
        private void CaricaAttivita()
        {
            flpCentro.Controls.Clear(); ///Mi assicuro che il pannello sia pulito e lo pulisco nel caso ci sia da aggiornare l'interfaccia

            List<UCAttivita> listaUCAttivita = new List<UCAttivita>();

            //TODO: OTTIENI UNA LISTA DI ATTIVITA' INERROGANDO IL DB e differenzia in base al tipo di account loggato
            //FAI PRIMA UN CICLO PER GLI EVENTI E POI UNO PER I PROGETTI --> FAI DUE LISTE (fai due metodi che peschino tutti gli eventi
            //e tutti i progetti) ED UNISCILE IN UNA UNICA
            //ORDINALI PER DATA D'INIZIO
            //AGGIUNGILI A listaUCAttivita
            //AGGIUNGI L'ELEMENTO CORRENTE A flpCentro.Controls.Add(elemtno i-esimo)
            //AGGIUNGI L'ASCOLTATORE DELL'EVENTO: eli-esimo.Click += EventHandler(UCAttivita_Click);
        }

        /// <summary>
        /// Ascoltatore click sugli UCAttività creati
        /// --> se viene cliccato un progetto permette di segnare gli obbiettivi portati a termine
        /// --> se viene cliccato un evento mostra le informazioni relative ad esso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCAttivita_Click(object sender, EventArgs e)
        {
            UCAttivita ucAttivita = (UCAttivita)sender; ///Ottengo l'elemento cliccato

            //Se progetto --> form per segnare le cose fatte
            //Se evento --> form per mostrare le info
        }
        #endregion
    }
}
