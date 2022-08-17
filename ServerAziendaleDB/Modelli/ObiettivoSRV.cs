using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerAziendaleDB.Modelli
{
    /// <summary>
    /// Classe Obiettivo server
    /// </summary>
    public class ObiettivoSRV
    {
        #region Attributi
        private int id;
        private string desccrizione;
        private bool completato;
        #endregion

        #region Metodi costruttori
        /// <summary>
        /// Metodo costruttore della classe ObiettivoSRV
        /// </summary>
        /// <param name="id"></param>
        /// <param name="desccrizione"></param>
        /// <param name="completato"></param>
        public ObiettivoSRV(int id, string desccrizione, bool completato)
        {
            this.id = id;
            this.desccrizione = desccrizione;
            this.completato = completato;
        }

        /// <summary>
        /// Metodo costruttore vuoto della classe ObiettivoSRV
        /// </summary>
        public ObiettivoSRV() { }
        #endregion

        #region Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Desccrizione { get => desccrizione; set => desccrizione = value; }
        public bool Completato { get => completato; set => completato = value; }
        #endregion
    }
}
