using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServerAziendale.Modelli;

namespace ServerAziendale
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "ServiceAgendaAziendale" nel codice e nel file di configurazione contemporaneamente.
    public class ServiceAgendaAziendale : IServiceAgendaAziendale
    {
        #region Servizi
        /// <summary>
        /// Servizio per testare la connessione client-server
        /// </summary>
        public void TestConnessione()
        {
            CheckLogDirFile(); ///Controllo della cartella per il log ed il respettivo file
        }

        /// <summary>
        /// Servizio adibito all'effetuazione del login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>bool</returns>
        public bool Login(string username, string password)
        {
            try
            {
                if (Sessione.ServerAziendaleDB.Login(username, password))
                    return true;

                else
                    return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione Login() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "Login()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio adibito all'ottenimento delle informazioni di uno specifico lavoratore
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_cercato"></param>
        /// <returns></returns>
        public string GetInfoLavoratore(string username, string username_cercato)
        {
            try
            {
                string result = Sessione.ServerAziendaleDB.GetInfoLavoratore(username, username_cercato);

                if (result != "")
                    return result;

                else
                    return "";
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione GetInfoLavoratore() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetInfoLavoratore()"); ///Scrittura log
            }

            return "";
        }

        /// <summary>
        /// Servizio adibito all'inserimento di un Lavoratore nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <param name="password"></param>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="residenza"></param>
        /// <param name="dataNascita"></param>
        /// <param name="email"></param>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public bool InserisciLavoratore(string username, string username_in, string password, string nome, string cognome, string residenza, DateTime dataNascita, string email, string categoria)
        {
            try
            {
                if (Sessione.ServerAziendaleDB.InserisciLavoratore(username, username_in, password, nome, cognome, residenza, dataNascita.ToString("yyyy-MM-dd"), email, categoria))
                    return true;

                else
                    return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione AggiungiLavoratore() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "AggiungiLavoratore()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio che restituisce l'elenco dei lavoratori presenti nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <returns>string</returns>
        public string GetElencoLavoratori(string username)
        {
            Console.WriteLine("Funzeca");

            WriteLog(username, "GetElencoLavoratori()"); ///Scrittura log

            return "";
        }

        /// <summary>
        /// Servizio adibito all'inserimento di un Evento nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="luogo"></param>
        /// <returns>bool</returns>
        public bool CreaEvento(string username, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, string luogo)
        {
            try
            {
                if (Sessione.ServerAziendaleDB.CreaEvento(username, nome, descrizione, dataInizio.ToString("yyyy-MM-dd"), dataFine.ToString("yyyy-MM-dd"), luogo))
                    return true;

                else
                    return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione CreaEvento() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "CreaEvento()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio adibito all'inserimento di un Progetto nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool CreaProgetto(string username, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, string cliente)
        {
            try
            {
                if (Sessione.ServerAziendaleDB.CreaProgetto(username, nome, descrizione, dataInizio.ToString("yyyy-MM-dd"), dataFine.ToString("yyyy-MM-dd"), cliente))
                    return true;

                else
                    return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione CreaProgetto() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "CreaProgetto()"); ///Scrittura log
            }

            return false;
        }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo adibito alla scrittura del log
        /// </summary>
        /// <param name="username"></param>
        /// <param name="servizio"></param>
        private void WriteLog(string username, string servizio)
        {
            string file = @"LogServerAziendale\log_srv_aziendale.txt";
            string logFormat = DateTime.Now.ToString() + ": " + username + " --> " + servizio + "\n";

            try
            {
                File.AppendAllText(file, logFormat);
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Scrittura log in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Metodo per controllare che la cartella e file di log esistano, altrimenti le creo
        /// </summary>
        private void CheckLogDirFile()
        {
            try
            {
                string cartella = "LogServerAziendale";
                string file = @"LogServerAziendale\log_srv_aziendale.txt";

                if (!Directory.Exists(cartella)) ///Controllo che esista la cartella di log
                    Directory.CreateDirectory(cartella); ///Creo la cartella di log


                if (!File.Exists(file)) ///Controllo che esista il file di log
                    File.Create(file); ///Creo il file di log
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Creazione file e/o directory per log di ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }
        }
        #endregion
    }
}
