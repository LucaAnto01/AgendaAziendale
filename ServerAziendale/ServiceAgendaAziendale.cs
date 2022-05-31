using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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
            //TODO: richiama funzione DB per login

            WriteLog(username, "Login()"); ///Scrittura log
    
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
            string cartella = "LogServerAziendale";
            string file = @"LogServerAziendale\log_srv_aziendale.txt";

            if (!Directory.Exists(cartella)) ///Controllo che esista la cartella di log
                Directory.CreateDirectory(cartella); ///Creo la cartella di log


            if (!File.Exists(file)) ///Controllo che esista il file di log
                File.Create(file); ///Creo il file di log
        }
        #endregion
    }
}
