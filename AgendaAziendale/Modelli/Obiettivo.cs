using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAziendale.Modelli
{
    public  class Obiettivo
    {
        #region Attributi
        private int id;
        private string desccrizione;
        private bool completato;
        #endregion

        #region Metodi e costruttori
        /// <summary>
        /// Metodo costruttore della classe Obiettivo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="desccrizione"></param>
        /// <param name="completato"></param>
        public Obiettivo(int id, string desccrizione, bool completato)
        {
            this.id = id;
            this.desccrizione = desccrizione;
            this.completato = completato;
        }

        /// <summary>
        /// Metodo costruttore vuoto della classe Obiettivo
        /// </summary>
        public Obiettivo() { }
        #endregion

        #region Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Desccrizione { get => desccrizione; set => desccrizione = value; }
        public bool Completato { get => completato; set => completato = value; }
        #endregion
    }
}
