using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            lbClienteLuogoInt.Parent = panelCentro;
            lbClienteLuogo.Parent = panelCentro;  
            lbDataInizioFineInt.Parent = panelCentro;
            lbDataInizioFine.Parent = panelCentro;
            btInfo.Parent = panelCentro;
            pbProgetto.Parent = panelCentro;

            SetTesti();
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

        /// <summary>
        /// Ascoltatore click sul bottone adibito al mostrare le informazioni relative all'attività
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: " + Attivita.Nome + "\nDescrizione: " + Attivita.Descrizione + ".", Attivita.Nome, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo richiamato durante il load dell'user control
        /// --> settaggio testi dell'user control
        /// </summary>
        private void SetTesti()
        {
            lbTitolo.Text = Attivita.Nome;
            
            if(Attivita is Evento)
            {
                Evento evento = (Evento)Attivita;
                lbClienteLuogoInt.Text = "Luogo";
                lbClienteLuogo.Text = evento.Luogo;
                lbDataInizioFineInt.Text = "Inizio - Fine";
                lbDataInizioFine.Text = evento.DataInizio.ToString("dd-MM-yyyy") + " - " + evento.DataFine.ToString("dd-MM-yyyy");
                Size = new Size(325, 100);
            }

            else if(Attivita is Progetto)
            {
                Progetto progetto = (Progetto)Attivita;
                lbClienteLuogoInt.Text = "Cliente";
                lbClienteLuogo.Text = progetto.Cliente;
                lbDataInizioFineInt.Text = "Consegna";
                lbDataInizioFine.Text = progetto.DataFine.ToString("dd-MM-yyyy");
                pbProgetto.Visible = true;

                pbProgetto.Maximum = 100;
                int avanzamento = Controller.CalcolaAvanzamentoProgetto(progetto);
                pbProgetto.Value = avanzamento; ///Calcolo l'avanzamento del progetto e lo mostro mostrando l'avanzamento della progress bar

                ///A seconda della percentuale di avanzamento setto il colore della barra
                if (avanzamento <= 30)
                    ProgressBarColor.SetState(pbProgetto, 2);

                else if ((avanzamento > 30) && (avanzamento <= 85))
                    ProgressBarColor.SetState(pbProgetto, 3);

                else if (avanzamento > 85)
                    ProgressBarColor.SetState(pbProgetto, 1);
            }
        }
        #endregion        
    }

    #region Classe ProgressBarColor
    /// <summary>
    /// Classe di comodo utilizzata per poter modificare il colore della progress bar
    /// --> https://foxlearn.com/windows-forms/change-color-progress-bar-in-csharp-350.html
    /// </summary>
    public static class ProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar p, int state)
        {
            SendMessage(p.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
    #endregion
}
