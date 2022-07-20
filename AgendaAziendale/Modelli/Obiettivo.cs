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

        #region Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Desccrizione { get => desccrizione; set => desccrizione = value; }
        public bool Completato { get => completato; set => completato = value; }
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

        #region Metodi
        /// <summary>
        /// Metodo adibito alla creazione di un Obiettivo sulla base di una stringa formattata dato-dato-...
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static Obiettivo GeneraProgetto(string info)
        {
            Obiettivo obiettivo = new Obiettivo();

            try
            {
                List<string> informazioni = info.Split('-').ToList();

                obiettivo.Id = int.Parse(informazioni.ElementAt(0));
                //All'indice 1 ho l'fk del progetto di riferimento
                obiettivo.Desccrizione = informazioni.ElementAt(2);
                obiettivo.Completato = bool.Parse(informazioni.ElementAt(3));
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo GeneraProgetto: errore errore istanziazione", "Metodo GeneraProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return obiettivo;
        }

        /// <summary>
        /// Metodo adibito alla creazione di una lista di Obiettivo sulla base di una stringa formattata dato-dato-...\n...
        /// </summary>
        /// <param name="elenco"></param>
        /// <returns></returns>
        public static List<Obiettivo> GeneraElencoObiettivi(string elenco)
        {
            List<Obiettivo> elencoObiettivi = new List<Obiettivo>();

            try
            {
                List<string> obiettivi_info = elenco.Split('\n').ToList(); ///Splitto l'elenco al fine di avere per ogni elemento le informazioni di ogni obiettivo

                obiettivi_info.RemoveAt((obiettivi_info.Count - 1)); ///A causa dello split l'ultimo elemento rimane vuoto --> ""

                foreach (string obiettivo_info in obiettivi_info) ///Popolo la lista degli obiettivi
                    elencoObiettivi.Add(GeneraProgetto(obiettivo_info));
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo GeneraElencoObiettivi: errore errore istanziazione", "Metodo GeneraElencoObiettivi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return elencoObiettivi;
        }
        #endregion
    }
}
