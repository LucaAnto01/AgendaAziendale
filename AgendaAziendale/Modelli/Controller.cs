using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAziendale.Modelli
{
    /// <summary>
    /// Classe adibita all'interazione del client e del server --> richiama i metodi esposti lato server
    /// </summary>
    public static class Controller
    {
        /// <summary>
        /// Metodo adibito all'esecuzione dell'azione di login
        /// --> richiamo del web service Login()
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool EffettuaLogin(string username, string password)
        {
            string passwordHash = Lavoratore.PasswordHashing(password);

            if (Sessione.ServerAziendale.Login(username, passwordHash)) ///Effettuo il login
                    return true;

            else
                return false;
        }

        #region Lavoratori
        /// <summary>
        /// Metodo adibito all'ottenimento di un lavoratore dal DB
        /// --> richiamo del web service GetInfoLavoratore()
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_info"></param>
        /// <returns></returns>
        public static Lavoratore GetInfoLavoratore(string username, string username_info)
        {
            string result = Sessione.ServerAziendale.GetInfoLavoratore(username, username_info);

            if (result != "")
                return Lavoratore.GeneraLavoratore(result);

            return null;
        }

        /// <summary>
        /// Metodo adibito all'inserimento di un lavoratore nel DB
        /// --> richiamo del web service InserisciLavoratore() dopo aver controllato che l'utente non esistesse già mediante il web service Login()
        /// </summary>
        /// <param name="username_in"></param>
        /// <param name="password"></param>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="residenza"></param>
        /// <param name="dataNascita"></param>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public static bool InserisciLavoratore(string username_in, string password, string nome, string cognome, string residenza, string dataNascita, string categoria)
        {
            string passwordHash = Lavoratore.PasswordHashing(password);
            if(Sessione.ServerAziendale.GetInfoLavoratore(Sessione.Lavoratore.Username, username_in) == "") ///Così facendo controllo che il Lavoratore non sia già presente all'interno del DB
                if (Sessione.ServerAziendale.InserisciLavoratore(Sessione.Lavoratore.Username, username_in, passwordHash, nome, cognome, residenza, DateTime.Parse(dataNascita), Lavoratore.GeneraEmail(username_in, cognome), categoria)) ///Inserisco il lavoratore nel db
                    return true;
            
            return false;
        }

        /// <summary>
        /// Metodo adibito alla modifica di un lavoratore presente nel DB
        /// --> richiamo del web service AggiornaLavoratore()
        /// </summary>
        /// <param name="username_in"></param>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="residenza"></param>
        /// <param name="dataNascita"></param>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public static bool AggiornaLavoratore(string username_in, string nome, string cognome, string residenza, string dataNascita, string categoria)
        {
            if (Sessione.ServerAziendale.AggiornaLavoratore(Sessione.Lavoratore.Username, username_in, nome, cognome, residenza, DateTime.Parse(dataNascita), categoria)) ///Aggiorno il lavoratore nel db
                return true;

            return false;
        }

        /// <summary>
        /// Metodo adibito all'eliminazione di un utente dal DB
        /// --> richiamo del web service EliminaLavoratore()
        /// </summary>
        /// <param name="username_in"></param>
        /// <returns></returns>
        public static bool EliminaLavoratore(string username_in)
        {
            if (Sessione.ServerAziendale.EliminaLavoratore(Sessione.Lavoratore.Username, username_in))
                return true;

            return false;
        }

        /// <summary>
        /// Funzione adibita all'ottenimento dell'elenco di tutti i lavoratori presenti nel DB
        /// </summary>
        /// <returns></returns>
        public static string GetElencoLavoratori()
        {
            string result = Sessione.ServerAziendale.GetElencoLavoratori(Sessione.Lavoratore.Username);

            if (result != "")
                return result;

            return "";
        }
        #endregion

        /// <summary>
        /// Metodo adibito all'inserimento di un evento nel DB
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="id"></param>
        /// <param name="luogo"></param>
        /// <returns></returns>
        public static bool CreaEvento(string nome, string descrizione, DateTime dataInizio, DateTime dataFine, string luogo)
        {
            if (Sessione.ServerAziendale.CreaEvento(Sessione.Lavoratore.Username, nome, descrizione, dataInizio, dataFine, luogo))
                return true;

            return false;
        }

        /// <summary>
        /// Metodo adibito all'inserimento di un progetto nel DB
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool CreaProgetto(string nome, string descrizione, DateTime dataInizio, DateTime dataFine, string cliente)
        {
            if(Sessione.ServerAziendale.CreaProgetto(Sessione.Lavoratore.Username, nome, descrizione, dataInizio, dataFine, cliente))
                return true;

            return false;
        }
    }
}
