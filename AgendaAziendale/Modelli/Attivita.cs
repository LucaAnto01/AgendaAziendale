using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAziendale.Modelli
{
    public abstract class Attivita
    {
        #region Attributi
        private string codice;
        private Lavoratore referente;
        private List<Lavoratore> partecipanti;
        private string nome;
        private string descrizione;
        private DateTime dataInizio;
        private DateTime dataFine;
        #endregion

        #region Metodi e costruttori
        /// <summary>
        /// Metodo costruttore della classe Attivita
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="referente"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        public Attivita(string codice, Lavoratore referente, string nome, string descrizione, DateTime dataInizio, DateTime dataFine)
        {
            Codice = codice;
            Referente = referente;
            Partecipanti = new List<Lavoratore>();
            Nome = nome;
            Descrizione = descrizione;
            DataInizio = dataInizio;
            DataFine = dataFine;
        }

        /// <summary>
        /// Metodo costruttore della classe Attivita
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="referente"></param>
        /// <param name="partecipanti"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        public Attivita(string codice, Lavoratore referente, List<Lavoratore> partecipanti, string nome, string descrizione, DateTime dataInizio, DateTime dataFine)
        {
            Codice = codice;
            Referente = referente;
            Partecipanti = partecipanti;
            Nome = nome;
            Descrizione = descrizione;
            DataInizio = dataInizio;
            DataFine = dataFine;
        }

        /// <summary>
        /// Metodo costruttore vuoto della classe Attivita
        /// </summary>
        public Attivita() { }

        /// <summary>
        /// Metodo per aggiungere un nuovo partecipante all'attività
        /// true --> partecipante aggiunto
        /// false --> errore, partecipante non aggiunto
        /// </summary>
        /// <param name="partecipante"></param>
        /// <returns>bool</returns>
        public bool AggiugniPartecipante(Lavoratore partecipante)
        {
            if(!Partecipanti.Contains(partecipante))
            {
                Partecipanti.Add(partecipante);
                return true;
            }
                
            return false;
        }

        /// <summary>
        /// Metodo per rimuovere un partecipante dall'attività
        /// true --> partecipante rimosso
        /// false --> errore, partecipante non rimosso
        /// </summary>
        /// <param name="partecipante"></param>
        /// <returns></returns>
        public bool RimuoviPartecipante(Lavoratore partecipante)
        {
            if (Partecipanti.Contains(partecipante))
            {
                Partecipanti.Remove(partecipante);
                return true;
            }

            return false;
        }
        #endregion

        #region Getters & Setters
        public string Codice { get => codice; set => codice = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public DateTime DataInizio { get => dataInizio; set => dataInizio = value; }
        public DateTime DataFine { get => dataFine; set => dataFine = value; }
        internal Lavoratore Referente { get => referente; set => referente = value; }
        public List<Lavoratore> Partecipanti { get => partecipanti; set => partecipanti = value; }
        #endregion
    }
}
