using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;
using ServerAziendaleDB.Modelli;

namespace ServerAziendaleDB
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "ServiceDBAgendaAziendale" nel codice e nel file di configurazione contemporaneamente.
    public class ServiceDBAgendaAziendale : IServiceDBAgendaAziendale
    {
        #region Servizi
        /// <summary>
        /// Servizio per testare la connessione client-server
        /// </summary>
        public void TestConnessione()
        {
            CheckLogDirFile(); ///Controllo della cartella per il log ed il respettivo file

            ///Apro la connessione con il database
            try
            {
                InterazioneDB.Connessione = new MySqlConnection(InterazioneDB.ConnectionString); //Mi collego al database
                InterazioneDB.Connessione.Open(); //Apro la connessione 
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Apertura connessione DB in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Servizio adibito all'effetuazione del login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>bool</returns>
        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM lavoratore l WHERE l.username = '" +  username + "' AND l.pswd = '"+ password + "';"; ///Query adibita al login

            try
            {

                if (InterazioneDB.EseguiQuery_Lettura(query))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Esecuzione query Login() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "Login()"); ///Scrittura log
            }           

            return false;
        }

        #region Lavoratori
        /// <summary>
        /// Servizio adibito all'ottenimento delle informazioni di uno specifico lavoratore
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_cercato"></param>
        /// <returns></returns>
        public string GetInfoLavoratore(string username, string username_cercato)
        {
            string query = "SELECT * FROM lavoratore l WHERE l.username = '" + username_cercato + "';";

            try
            {
                string result = InterazioneDB.EseguiQuery_GetInfo(query);

                if (result != "")
                    return result;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Esecuzione query GetInfoLavoratore() in ServerAziendaleDB: " + ex.ToString());
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
        /// <param name="password"></param>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="residenza"></param>
        /// <param name="dataNascita"></param>
        /// <param name="email"></param>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public bool InserisciLavoratore(string username, string username_in, string password, string nome, string cognome, string residenza, string dataNascita, string email, string categoria)
        {
            string query = "INSERT INTO lavoratore (username, pswd, nome, cognome, residenza, data_nascita, email, categoria) VALUES " +
                           "('" + username_in + "','" + password + "','"+ nome +"','"+ cognome + "','" + residenza + "','" + 
                            dataNascita + "','" + email + "','" + categoria + "');";

            List<string> queries = new List<string>();
            queries.Add(query);

            try
            {
                if (InterazioneDB.EseguiQueries(queries))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Esecuzione query AggiungiLavoratore() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "AggiungiLavoratore()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio adibito all'aggiornamento di un Lavoratore presente nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="residenza"></param>
        /// <param name="dataNascita"></param>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public bool AggiornaLavoratore(string username, string username_in, string nome, string cognome, string residenza, string dataNascita, string categoria)
        {
            string query = "UPDATE lavoratore SET nome = '" + nome + "', cognome = '" +
                                cognome + "', residenza = '" + residenza + "', data_nascita = '" + dataNascita + "', categoria = '" 
                                + categoria + "' WHERE username = '" + username_in + "';";

            List<string> queries = new List<string>();
            queries.Add(query);

            try
            {
                if (InterazioneDB.EseguiQueries(queries)) ///Aggiorno il lavoratore
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Esecuzione query AggiornaLavoratore() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "AggiornaLavoratore()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio adibito all'eiminazione di un Lavoratore presente nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <returns></returns>
        public bool EliminaLavoratore(string username, string username_in)
        {
            string query = "DELETE FROM lavoratore WHERE username = '" + username_in + "';";

            List<string> queries = new List<string>();
            queries.Add(query);

            try
            {
                if (InterazioneDB.EseguiQueries(queries)) ///Elimino il lavoratore
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Esecuzione query EliminaLavoratore() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "EliminaLavoratore()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio che restituisce l'elenco dei lavoratori (e relative informazioni) presenti nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <returns>string</returns>
        public string GetElencoLavoratori(string username)
        {
            string query = "SELECT * FROM lavoratore";

            try
            {
                string result = InterazioneDB.EseguiQuery_GetInfo(query);

                if (result != "")
                    return result;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Esecuzione query GetElencoLavoratori() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoLavoratori()"); ///Scrittura log
            }

            return "";
        }
        #endregion

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
        public bool CreaEvento(string username, string nome, string descrizione, string dataInizio, string dataFine, string luogo)
        {
            string query_attivita = "INSERT INTO attivita(nome, descrizione, data_inizio, data_fine) " +
                                    "VALUES('" + nome + "', '" + descrizione + "', '" + dataInizio + "', '" + dataFine + "');"; ///Creo una nuova attività
            string query_evento = "INSERT INTO evento(luogo) VALUES ('" + luogo + "');"; ///Creo un nuovo evento

            List<string> queries = new List<string>();
            queries.Add(query_attivita);
            queries.Add(query_evento);

            try
            {
                if (InterazioneDB.EseguiQueries(queries))
                {
                    string query_codAttivita = "SELECT MAX(attivita.codice) as codice FROM attivita"; ///Ricavo l'ultima attività inserita nel DB
                    string query_codEvento = "SELECT MAX(evento.id) as codice FROM evento"; ///Ricavo l'ultimo evento inserito nel DB

                    string[] codUltimaAttivita = InterazioneDB.EseguiQuery_GetInfo(query_codAttivita).Split('-');
                    string[] codUltimoEvento = InterazioneDB.EseguiQuery_GetInfo(query_codEvento).Split('-');

                    if ((codUltimaAttivita[0] != "") && (codUltimoEvento[0] != ""))
                    {
                        string query_spEvento = "INSERT INTO specifica_evento(fk_attivita, fk_evento) VALUES ('" + codUltimaAttivita[0] + "','" + codUltimoEvento[0] + "');";
                        List<string> queries_sp = new List<string>();
                        queries_sp.Add(query_spEvento);

                        if (InterazioneDB.EseguiQueries(queries_sp))
                            return true;           
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Esecuzione query CreaEvento() in ServerAziendaleDB: " + ex.ToString());
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
        public bool CreaProgetto(string username, string nome, string descrizione, string dataInizio, string dataFine, string cliente)
        {
            string query_attivita = "INSERT INTO attivita(nome, descrizione, data_inizio, data_fine) " +
                                    "VALUES('" + nome + "', '" + descrizione + "', '" + dataInizio + "', '" + dataFine + "');"; ///Creo una nuova attività
            string query_progetto = "INSERT INTO progetto(cliente) VALUES ('" + cliente + "');"; ///Creo un nuovo progetto

            List<string> queries = new List<string>();
            queries.Add(query_attivita);
            queries.Add(query_progetto);

            try
            {
                if (InterazioneDB.EseguiQueries(queries))
                {
                    string query_codAttivita = "SELECT MAX(attivita.codice) as codice FROM attivita;"; ///Ricavo l'ultima attività inserita nel DB
                    string query_codProgetto = "SELECT MAX(progetto.id) as codice FROM progetto;"; ///Ricavo l'ultimo progetto inserito nel DB

                    string[] codUltimaAttivita = InterazioneDB.EseguiQuery_GetInfo(query_codAttivita).Split('-');
                    string[] codUltimoProgetto = InterazioneDB.EseguiQuery_GetInfo(query_codProgetto).Split('-');

                    if ((codUltimaAttivita[0] != "") && (codUltimoProgetto[0] != ""))
                    {
                        string query_spProgetto = "INSERT INTO specifica_progetto(fk_attivita, fk_progetto) " +
                                                  "VALUES ('" + codUltimaAttivita[0] + "','" + codUltimoProgetto[0] + "');";
                        List<string> queries_sp = new List<string>();
                        queries_sp.Add(query_spProgetto);

                        if (InterazioneDB.EseguiQueries(queries_sp))
                            return true;
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Esecuzione query CreaProgetto() in ServerAziendaleDB: " + ex.ToString());
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
            string file = @"LogServerAziendaleDB\log_srv_aziendale_db.txt";
            string logFormat = DateTime.Now.ToString() + ": " + username + " --> " + servizio + "\n";

            try
            {
                File.AppendAllText(file, logFormat);
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Scrittura log in ServerAziendaleDB: " + ex.ToString());
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
                string cartella = "LogServerAziendaleDB";
                string file = @"LogServerAziendaleDB\log_srv_aziendale_db.txt";

                if (!Directory.Exists(cartella)) ///Controllo che esista la cartella di log
                    Directory.CreateDirectory(cartella); ///Creo la cartella di log


                if (!File.Exists(file)) ///Controllo che esista il file di log
                    File.Create(file); ///Creo il file di log
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Creazione file e/o directory per log di ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }
        }
        #endregion
    }
}
