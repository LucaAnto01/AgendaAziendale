using ServerAziendaleDB.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaAziendale.Modelli
{
    public  class Obiettivo
    {
        #region Attributi
        private int id;
        private string desccrizione;
        private bool completato;
        #endregion

        #region Metodi costruttori
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

        #region Metodi
        /// <summary>
        /// Metodo per convertire un ObiettivoSRV in un Obiettivo
        /// </summary>
        /// <param name="obiettivoSrv"></param>
        /// <returns></returns>
        public static Obiettivo FromObiettivoSRVToObiettivo(ObiettivoSRV obiettivoSrv)
        {
            return new Obiettivo(obiettivoSrv.Id, obiettivoSrv.Desccrizione, obiettivoSrv.Completato);
        }

        /// <summary>
        /// Metodo per convertire una lista di ObiettivoSRV in una lista di Obiettivo
        /// </summary>
        /// <param name="obiettiviSrv"></param>
        /// <returns></returns>
        public static List<Obiettivo> FromObiettivoSRVToObiettivo(List<ObiettivoSRV> obiettiviSrv)
        {
            List<Obiettivo> elencoObiettivi = new List<Obiettivo>();

            foreach(ObiettivoSRV obiettivoSrv in obiettiviSrv)
            {
                elencoObiettivi.Add(new Obiettivo(obiettivoSrv.Id, obiettivoSrv.Desccrizione, obiettivoSrv.Completato));
            }

            return elencoObiettivi;
        }
        #endregion
    }
}
