using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            obiettivi = new List<Obiettivo>();
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
            Obiettivi.FirstOrDefault(i => i.Id == obiettivo.Id).Completato = true;
        }

        /// <summary>
        /// Metodo adibito alla creazione di un Progetto sulla base di una stringa formattata dato-dato-...
        /// </summary>
        /// <param name="info"></param>
        /// <returns>Progetto</returns>
        public static Progetto GeneraProgetto(string info)
        {
            Progetto progetto = new Progetto();

            List<string> informazioni = info.Split('-').ToList();

            progetto.Codice = informazioni.ElementAt(0);
            progetto.Nome = informazioni.ElementAt(1);
            progetto.Descrizione = informazioni.ElementAt(2);
            progetto.DataInizio = DateTime.Parse(informazioni.ElementAt(3));
            progetto.DataFine = DateTime.Parse(informazioni.ElementAt(4));
            progetto.Id = int.Parse(informazioni.ElementAt(5));
            progetto.Cliente = informazioni.ElementAt(6);

            return progetto;
        }

        /// <summary>
        /// Metodo adibito alla creazione di una lista di Progetto sulla base di una stringa formattata dato-dato-...\n...
        /// </summary>
        /// <param name="elenco"></param>
        /// <returns></returns>
        public static List<Progetto> GeneraElencoProgetti(string elenco)
        {
            List<Progetto> elencoProgetti = new List<Progetto>();

            List<string> progetti_info = elenco.Split('\n').ToList(); ///Splitto l'elenco al fine di avere per ogni elemento le informazioni di ogni progetto

            progetti_info.RemoveAt((progetti_info.Count - 1)); ///A causa dello split l'ultimo elemento rimane vuoto --> ""

            foreach (string progetto_info in progetti_info) ///Popolo la lista dei progetti
                elencoProgetti.Add(GeneraProgetto(progetto_info));

            return elencoProgetti;
        }
        #endregion

    }
}
