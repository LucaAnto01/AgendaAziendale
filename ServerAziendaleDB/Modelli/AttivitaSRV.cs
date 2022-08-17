using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerAziendaleDB.Modelli
{
    /// <summary>
    /// Classe Attività server
    /// </summary>
    public abstract class AttivitaSRV
    {
        #region Attributi
        private string codice;
        private string nome;
        private string descrizione;
        private DateTime dataInizio;
        private DateTime dataFine;
        #endregion

        #region Metodi costruttori
        /// <summary>
        /// Metodo costruttore della classe AttivitaSRV
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        public AttivitaSRV(string codice, string nome, string descrizione, DateTime dataInizio, DateTime dataFine)
        {
            Codice = codice;
            Nome = nome;
            Descrizione = descrizione;
            DataInizio = dataInizio;
            DataFine = dataFine;
        }

        /// <summary>
        /// Metodo costruttore vuoto della classe AttivitaSRV
        /// </summary>
        public AttivitaSRV() { }
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
