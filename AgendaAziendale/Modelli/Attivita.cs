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
        private string nome;
        private string descrizione;
        private DateTime dataInizio;
        private DateTime dataFine;
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo costruttore della classe Attivita
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        public Attivita(string codice, string nome, string descrizione, DateTime dataInizio, DateTime dataFine)
        {
            Codice = codice;
            Nome = nome;
            Descrizione = descrizione;
            DataInizio = dataInizio;
            DataFine = dataFine;
        }

        /// <summary>
        /// Metodo costruttore vuoto della classe Attivita
        /// </summary>
        public Attivita() { }
        #endregion

        #region Getters & Setters
        public string Codice { get => codice; set => codice = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public DateTime DataInizio { get => dataInizio; set => dataInizio = value; }
        public DateTime DataFine { get => dataFine; set => dataFine = value; }
        #endregion
    }
}
