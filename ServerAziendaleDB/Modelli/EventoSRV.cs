using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerAziendaleDB.Modelli
{
    /// <summary>
    /// Classe Evento server
    /// </summary>
    public class EventoSRV : AttivitaSRV
    {
        #region Attributi
        private int id;
        private string luogo;
        #endregion

        #region Metodi costruttori
        /// <summary>
        /// Metodo costruttore della classe EventoSRV
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="id"></param>
        /// <param name="luogo"></param>
        public EventoSRV(string codice, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, int id, string luogo) : base(codice, nome, descrizione, dataInizio, dataFine)
        {
            Id = id;
            Luogo = luogo;
        }

        /// <summary>
        /// Metodo costruttore vuoto della classe EventoSRV
        /// </summary>
        public EventoSRV() { }
        #endregion

        #region Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Luogo { get => luogo; set => luogo = value; }
        #endregion
    }
}
