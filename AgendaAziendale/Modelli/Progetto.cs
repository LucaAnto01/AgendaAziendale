using ServerAziendaleDB.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaAziendale.Modelli
{
    public class Progetto : Attivita
    {
        #region Attributi
        private int id;
        private string cliente;
        private List<Obiettivo> obiettivi;
        #endregion

        #region Metodi costruttori
        /// <summary>
        /// Metodo costruttore della classe Progetto
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="id"></param>
        /// <param name="cliente"></param>
        /// <param name="obiettivi"></param>
        public Progetto(string codice, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, int id, string cliente, List<Obiettivo> obiettivi) : base(codice, nome, descrizione, dataInizio, dataFine)
        {
            Id = id;
            Cliente = cliente;
            Obiettivi = obiettivi;
        }

        /// <summary>
        /// Metodo costruttore della classe Progetto
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="id"></param>
        /// <param name="cliente"></param>
        public Progetto(string codice, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, int id, string cliente) : base(codice, nome, descrizione, dataInizio, dataFine)
        {
            Id = id;
            Cliente = cliente;

            List<Obiettivo> result_obiettivi = new List<Obiettivo>();
            result_obiettivi = Controller.GetElencoObiettivi(Id.ToString()); ///Aggiungo gli obiettivi al progetto

            if (result_obiettivi != null)
               Obiettivi = result_obiettivi;

            else
                Obiettivi = new List<Obiettivo>();
        }
        
        /// <summary>
        /// Metodo costruttore vuoto della classe Progetto
        /// </summary>
        public Progetto() { }
        #endregion

        #region Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public List<Obiettivo> Obiettivi { get => obiettivi; set => obiettivi = value; }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo per aggiungere un nuovo obiettivo alla lista di obiettivi
        /// </summary>
        /// <param name="obiettivo"></param>
        public void AggiungiObiettivo(Obiettivo obiettivo)
        {
            Obiettivi.Add(obiettivo);
        }

        /// <summary>
        /// Metodo per contrassegnare un obiettivo come completato
        /// </summary>
        /// <param name="obiettivo"></param>
        public void ObiettivoCompletato(Obiettivo obiettivo)
        {
            try
            {
                Obiettivi.FirstOrDefault(i => i.Id == obiettivo.Id).Completato = true;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo ObiettivoCompletato: errore istanziazione", "Metodo ObiettivoCompletato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Metodo per convertire un ProgettoSRV in un Progetto
        /// </summary>
        /// <param name="progettoSrv"></param>
        /// <returns></returns>
        public static Progetto FromProgettoSRVToProgetto(ProgettoSRV progettoSrv)
        {
            return new Progetto(progettoSrv.Codice, progettoSrv.Nome, progettoSrv.Descrizione, progettoSrv.DataInizio, progettoSrv.DataFine, progettoSrv.Id, progettoSrv.Cliente);
        }

        /// <summary>
        /// Metodo per convertire una lista di ProgettoSRV in una lista di Progetto
        /// </summary>
        /// <param name="progettiSrv"></param>
        /// <returns></returns>
        public static List<Progetto> FromProgettoSRVToProgetto(List<ProgettoSRV> progettiSrv)
        {
            List<Progetto> elencoProgetti = new List<Progetto>();

            foreach(ProgettoSRV progettoSrv in progettiSrv)
            {
                elencoProgetti.Add(new Progetto(progettoSrv.Codice, progettoSrv.Nome, progettoSrv.Descrizione, progettoSrv.DataInizio, progettoSrv.DataFine, progettoSrv.Id, progettoSrv.Cliente));
            }

            return elencoProgetti;
        }
        #endregion

    }
}
