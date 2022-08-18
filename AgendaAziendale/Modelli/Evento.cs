using ServerAziendaleDB.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaAziendale.Modelli
{
    public class Evento : Attivita
    {
        #region Attributi
        private int id;
        private string luogo;
        #endregion

        #region Metodi costruttori
        /// <summary>
        /// Metodo costruttore della classe Evento
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="id"></param>
        /// <param name="luogo"></param>
        public Evento(string codice, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, int id, string luogo) : base(codice, nome, descrizione, dataInizio, dataFine)
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

        #region Metodi
        /// <summary>
        /// Metodo per verificare che un evento sia ancora in corso o se è già terminato
        /// --> true: terminato
        /// --> false: ancora in corso
        /// </summary>
        /// <returns>bool</returns>
        public bool IsTerminato()
        {
            try
            {
                if (DataFine < DateTime.Now)
                    return true;

                return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo IsTerminato: errore calcolo", "Metodo IsTerminato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }

        /// <summary>
        /// Metodo che restituisce la durata dell'evento in termini di giorni
        /// </summary>
        /// <returns></returns>
        public int Durata()
        {
            try
            {
                return (int)(DataFine - DataInizio).TotalDays;
            }

            catch
            {
                MessageBox.Show("ERRORE! Metodo Durata: errore calcolo", "Metodo Durata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return 0;
        }

        /// <summary>
        /// Metodo per convertire un EventoSRV in un Evento
        /// </summary>
        /// <param name="eventoSrv"></param>
        /// <returns></returns>
        public static Evento FromEventoSRVToEvento(EventoSRV eventoSrv)
        {
            return new Evento(eventoSrv.Codice, eventoSrv.Nome, eventoSrv.Descrizione, eventoSrv.DataInizio, eventoSrv.DataFine, eventoSrv.Id, eventoSrv.Luogo);
        }

        /// <summary>
        /// Metodo per convertire una lista di EventoSRV in una lista di Evento
        /// </summary>
        /// <param name="eventiSrv"></param>
        /// <returns></returns>
        public static List<Evento> FromEventoSRVToEvento(List<EventoSRV> eventiSrv)
        {
            List<Evento> elencoEventi = new List<Evento>();

            foreach(EventoSRV eventoSrv in eventiSrv)
            {
                elencoEventi.Add(new Evento(eventoSrv.Codice, eventoSrv.Nome, eventoSrv.Descrizione, eventoSrv.DataInizio, eventoSrv.DataFine, eventoSrv.Id, eventoSrv.Luogo));
            }

            return elencoEventi;
        }
        #endregion
    }
}
