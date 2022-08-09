using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerAziendaleDB.Modelli
{
    /// <summary>
    /// Classe Progetto server
    /// </summary>
    public class ProgettoSRV : AttivitaSRV
    {
        #region Attributi
        private int id;
        private string cliente;
        private List<ObiettivoSRV> obiettivi;
        #endregion

        #region Metodi costruttori
        /// <summary>
        /// Metodo costruttore della classe ProgettoSRV
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="id"></param>
        /// <param name="cliente"></param>
        /// <param name="obiettivi"></param>
        public ProgettoSRV(string codice, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, int id, string cliente, List<ObiettivoSRV> obiettivi) : base(codice, nome, descrizione, dataInizio, dataFine)
        {
            Id = id;
            Cliente = cliente;
            Obiettivi = obiettivi;
        }

        /// <summary>
        /// Metodo costruttore vuoto della classe ProgettoSRV
        /// </summary>
        public ProgettoSRV() { }
        #endregion

        #region Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public List<ObiettivoSRV> Obiettivi { get => obiettivi; set => obiettivi = value; }
        #endregion
    }
}
