using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        /// Metodo costruttore della classe ProgettoSRV
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="id"></param>
        /// <param name="cliente"></param>
        public ProgettoSRV(string codice, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, int id, string cliente) : base(codice, nome, descrizione, dataInizio, dataFine)
        {
            Id = id;
            Cliente = cliente;
            Obiettivi = new List<ObiettivoSRV>();
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

        #region Metodi
        /// <summary>
        /// Metodo adibito alla creazione di un ProgettoSRV sulla base di una stringa formattata dato-dato-...
        /// </summary>
        /// <param name="info"></param>
        /// <returns>Progetto</returns>
        public static ProgettoSRV GeneraProgetto(string info)
        {
            try
            {
                List<string> informazioni = info.Split('-').ToList();

                string codice = informazioni.ElementAt(0);
                string nome = informazioni.ElementAt(1);
                string descrizione = informazioni.ElementAt(2);
                DateTime dataInizio = DateTime.Parse(informazioni.ElementAt(3));
                DateTime dataFine = DateTime.Parse(informazioni.ElementAt(4));
                int id = int.Parse(informazioni.ElementAt(5));
                string cliente = informazioni.ElementAt(6);

                ProgettoSRV progetto = new ProgettoSRV(codice, nome, descrizione, dataInizio, dataFine, id, cliente);
                return progetto;
            }

            catch
            {
                MessageBox.Show("ERRORE! Metodo GeneraProgetto: errore istanziazione", "Metodo GeneraProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return null;
        }

        /// <summary>
        /// Metodo adibito alla creazione di una lista di Progetto sulla base di una stringa formattata dato-dato-...\n...
        /// </summary>
        /// <param name="elenco"></param>
        /// <returns></returns>
        public static List<ProgettoSRV> GeneraElencoProgetti(string elenco)
        {
            List<ProgettoSRV> elencoProgetti = new List<ProgettoSRV>();

            try
            {
                List<string> progetti_info = elenco.Split('\n').ToList(); ///Splitto l'elenco al fine di avere per ogni elemento le informazioni di ogni progetto

                progetti_info.RemoveAt((progetti_info.Count - 1)); ///A causa dello split l'ultimo elemento rimane vuoto --> ""

                foreach (string progetto_info in progetti_info) ///Popolo la lista dei progetti
                    elencoProgetti.Add(GeneraProgetto(progetto_info));
            }

            catch
            {
                MessageBox.Show("ERRORE! Metodo GeneraElencoProgetti: errore istanziazione", "Metodo GeneraElencoProgetti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return elencoProgetti;
        }
        #endregion
    }
}
