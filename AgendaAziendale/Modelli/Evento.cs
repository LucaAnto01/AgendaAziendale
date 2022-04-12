using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAziendale.Modelli
{
    internal class Evento : Attivita
    {
        #region Attributi
        private int id;
        private string luogo;


        #endregion

        #region Metodi e costruttori
        /// <summary>
        /// Metodo costruttore della classe Evento
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="referente"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="id"></param>
        /// <param name="luogo"></param>
        public Evento(string codice, Lavoratore referente, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, int id, string luogo) : base(codice, referente, nome, descrizione, dataInizio, dataFine)
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
    }
}
