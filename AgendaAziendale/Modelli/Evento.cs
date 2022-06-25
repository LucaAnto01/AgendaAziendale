using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAziendale.Modelli
{
    public class Evento : Attivita
    {
        #region Attributi
        private int id;
        private string luogo;
        #endregion

        #region Metodi costruttori
        /// <summary>
        /// Metodo costruttore della classe Evento
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="id"></param>
        /// <param name="luogo"></param>
        public Evento(string codice, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, int id, string luogo) : base(codice, nome, descrizione, dataInizio, dataFine)
        {
            Id = id;
            Luogo = luogo;
        }

        /// <summary>
        /// Metodo costruttore vuoto della classe Evento
        /// </summary>
        public Evento() { }
        #endregion

        #region Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Luogo { get => luogo; set => luogo = value; }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo per verificare che un evento sia ancora in corso o se è già terminato
        /// --> true: terminato
        /// --> false: ancora in corso
        /// </summary>
        /// <returns>bool</returns>
        public bool IsTerminato()
        {
            if(DataFine < DateTime.Now)
                return true;

            return false;
        }

        /// <summary>
        /// Metodo che restituisce la durata dell'evento in termini di giorni
        /// </summary>
        /// <returns></returns>
        public int Durata()
        {
            return  (int)(DataFine - DataInizio).TotalDays;
        }

        /// <summary>
        /// Metodo adibito alla creazione di un Evento sulla base di una stringa formattata dato-dato-...
        /// </summary>
        /// <param name="info"></param>
        /// <returns>Evento</returns>
        public static Evento GeneraEvento(string info)
        {
            Evento evento = new Evento();

            List<string> informazioni = info.Split('-').ToList();

            evento.Codice = informazioni.ElementAt(0);
            evento.Nome = informazioni.ElementAt(1);
            evento.Descrizione = informazioni.ElementAt(2);
            evento.DataInizio = DateTime.Parse(informazioni.ElementAt(3));
            evento.DataFine = DateTime.Parse(informazioni.ElementAt(4));
            evento.Id = int.Parse(informazioni.ElementAt(5));
            evento.Luogo = informazioni.ElementAt(6);

            return evento;
        }

        /// <summary>
        /// Metodo adibito alla creazione di una lista di Evento sulla base di una stringa formattata dato-dato-...\n...
        /// </summary>
        /// <param name="elenco"></param>
        /// <returns></returns>
        public static List<Evento> GeneraElencoEventi(string elenco)
        {
            List<Evento> elencoEventi = new List<Evento>();

            List<string> eventi_info = elenco.Split('\n').ToList(); ///Splitto l'elenco al fine di avere per ogni elemento le informazioni di ogni evento

            eventi_info.RemoveAt((eventi_info.Count - 1)); ///A causa dello split l'ultimo elemento rimane vuoto --> ""

            foreach (string evento_info in eventi_info) ///Popolo la lista degli eventi
                elencoEventi.Add(GeneraEvento(evento_info));

            return elencoEventi;
        }
        #endregion
    }
}
