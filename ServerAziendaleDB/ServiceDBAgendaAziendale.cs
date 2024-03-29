﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;
//using MySqlConnector;
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
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

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
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

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
        public LavoratoreSRV GetInfoLavoratore(string username, string username_cercato)
        {
            string query = "SELECT * FROM lavoratore l WHERE l.username = '" + username_cercato + "';";

            try
            {
                string result = InterazioneDB.EseguiQuery_GetInfo(query);

                if (result != "")
                    return LavoratoreSRV.GeneraLavoratore(result);
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query GetInfoLavoratore() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                
                WriteLog(username, "GetInfoLavoratore()"); ///Scrittura log
            }

            return null;
        }

        /// <summary>
        /// Servizio adibito all'inserimento di un Lavoratore nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="nuovoLavoratore"></param>
        /// <returns></returns>
        public bool InserisciLavoratore(string username, LavoratoreSRV nuovoLavoratore)
        {
            string query = "INSERT INTO lavoratore (username, pswd, nome, cognome, residenza, data_nascita, email, categoria) VALUES " +
                           "('" + nuovoLavoratore.Username + "','" + nuovoLavoratore.Password + "','"+ nuovoLavoratore.Nome +"','"+ nuovoLavoratore.Cognome +
                           "','" + nuovoLavoratore.Residenza + "','" + nuovoLavoratore.DataNascita.ToString("yyyy-MM-dd") + "','" + nuovoLavoratore.Email + "','" + nuovoLavoratore.Categoria + "');";

            List<string> queries = new List<string>
            {
                query
            };

            try
            {
                if (InterazioneDB.EseguiQueries(queries))
                    return true;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

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
        /// <param name="aggiornaLavoratore"></param>
        /// <returns></returns>
        public bool AggiornaLavoratore(string username, LavoratoreSRV aggiornaLavoratore)
        {
            string query = "UPDATE lavoratore SET nome = '" + aggiornaLavoratore.Nome + "', cognome = '" +
                            aggiornaLavoratore.Cognome + "', residenza = '" + aggiornaLavoratore.Residenza + "', data_nascita = '" +
                            aggiornaLavoratore.DataNascita.ToString("yyyy-MM-dd") + "', categoria = '" 
                            + aggiornaLavoratore.Categoria + "' WHERE username = '" + aggiornaLavoratore.Username + "';";

            List<string> queries = new List<string>
            {
                query
            };

            try
            {
                if (InterazioneDB.EseguiQueries(queries)) ///Aggiorno il lavoratore
                    return true;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

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
        /// Servizio adibito all'aggiornamento della password di un Lavoratore presente nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool AggiornaPassword(string username, string username_in, string password)
        {
            string query = "UPDATE lavoratore SET pswd = '" + password + "' WHERE username = '" + username_in + "';";

            List<string> queries = new List<string>
            {
                query
            };

            try
            {
                if (InterazioneDB.EseguiQueries(queries)) ///Aggiorno il lavoratore
                    return true;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query AggiornaPassword() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "AggiornaPassword()"); ///Scrittura log
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

            ///Al fine di garantire l'integrità del database si verifica che non siano presenti partecipazioni ad eventi o progetti da parte del lavoratore
            if ((GetElencoEventiLavoratore(username, username_in) != null) || (GetElencoProgettiLavoratore(username, username_in) != null))
                return false;

            List<string> queries = new List<string>
            {
                query
            };

            try
            {
                if (InterazioneDB.EseguiQueries(queries)) ///Elimino il lavoratore
                    return true;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

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
        public List<LavoratoreSRV> GetElencoLavoratori(string username)
        {
            string query = "SELECT * FROM lavoratore";

            try
            {
                string result = InterazioneDB.EseguiQuery_GetInfo(query);

                if (result != "")
                    return LavoratoreSRV.GeneraElencoLavoratori(result);
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query GetElencoLavoratori() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {               
                WriteLog(username, "GetElencoLavoratori()"); ///Scrittura log
            }

            return null;
        }

        /// <summary>
        /// Servizio che restituisce l'elenco dei lavoratori presenti nel DB sotto formato di stringa
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public string GetElencoLavoratoriToString(string username)
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
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query GetElencoLavoratoriToString() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoLavoratori()"); ///Scrittura log
            }

            return "";
        }
        #endregion

        #region Eventi
        /// <summary>
        /// Servizio adibito all'inserimento di un Evento nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="nuovoEvento"></param>
        /// <returns></returns>
        public bool CreaEvento(string username, EventoSRV nuovoEvento)
        {
            string query_attivita = "INSERT INTO attivita(nome, descrizione, data_inizio, data_fine) " +
                                    "VALUES('" + nuovoEvento.Nome + "', '" + nuovoEvento.Descrizione + "', '" + nuovoEvento.DataInizio.ToString("yyyy-MM-dd") +
                                    "', '" + nuovoEvento.DataFine.ToString("yyyy-MM-dd") + "');"; ///Creo una nuova attività
            string query_evento = "INSERT INTO evento(luogo) VALUES ('" + nuovoEvento.Luogo + "');"; ///Creo un nuovo evento

            List<string> queries = new List<string>
            {
                query_attivita,
                query_evento
            };

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
                        List<string> queries_sp = new List<string>
                        {
                            query_spEvento
                        };

                        if (InterazioneDB.EseguiQueries(queries_sp))
                            return true;           
                    }
                }
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

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
        /// Servizio adibito all'aggiornamento di un Evento nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="aggiornaEvento"></param>
        /// <returns></returns>
        public bool AggiornaEvento(string username, EventoSRV aggiornaEvento)
        {
            string query_attivita = "UPDATE attivita SET nome = '" + aggiornaEvento.Nome + "', descrizione = '" + aggiornaEvento.Descrizione + "', data_inizio = '" 
                                    + aggiornaEvento.DataInizio.ToString("yyyy-MM-dd") + "', data_fine = '" + aggiornaEvento.DataFine.ToString("yyyy-MM-dd") +
                                    "' WHERE codice = '" + aggiornaEvento.Codice + "';"; ///Aggiorno l'attività

            string query_evento = "UPDATE evento SET luogo = '" + aggiornaEvento.Luogo + "' WHERE id = '" + aggiornaEvento.Id.ToString() + "';"; ///Aggiorno l'evento

            List<string> queries = new List<string>
            {
                query_attivita,
                query_evento
            };

            try
            {
                if (InterazioneDB.EseguiQueries(queries))
                    return true;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query AggiornaEvento() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "AggiornaEvento()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio adibito all'eliminazione di un Evento nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="codice"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool EliminaEvento(string username, string codice, string id)
        {
            string query_sp_evento = "DELETE FROM specifica_evento WHERE fk_attivita = '" + codice + "' AND fk_evento = '" + id + "';";
            string query_attivita = "DELETE FROM attivita WHERE codice = '" + codice + "';";
            string query_evento = "DELETE FROM evento WHERE id = '" + id + "'";

            List<string> queries = new List<string>
            {
                query_sp_evento,
                query_attivita,
                query_evento
            };

            try
            {
                if (InterazioneDB.EseguiQueries(queries)) ///Elimino l'evento
                    return true;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query EliminaEvento() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "EliminaEvento()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti gli eventi presenti nel DB con una data maggiore o uguale all'odierna
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public List<EventoSRV> GetElencoEventi(string username)
        {
            string query = "SELECT a.codice, a.nome, a.descrizione, a.data_inizio, a.data_fine, e.id, e.luogo " +
                           "FROM attivita a, evento e, specifica_evento se " +
                           "WHERE a.codice = se.fk_attivita AND e.id = se.fk_evento AND a.data_fine >= CURRENT_DATE " +
                           " ORDER BY a.data_inizio ASC;";

            try
            {
                string result = InterazioneDB.EseguiQuery_GetInfo(query);

                if (result != "")
                    return EventoSRV.GeneraElencoEventi(result);
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query GetElencoEventi() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoEventi()"); ///Scrittura log
            }

            return null;
        }

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti gli eventi presenti nel DB con una data maggiore o uguale all'odierna
        /// a cui partecipa uno specifico lavoratore
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <returns></returns>
        public List<EventoSRV> GetElencoEventiLavoratore(string username, string username_in)
        {
            string query = "SELECT a.codice, a.nome, a.descrizione, a.data_inizio, a.data_fine, e.id, e.luogo" +
                           " FROM attivita a, evento e, specifica_evento se, partecipazione pa" +
                           " WHERE a.codice = se.fk_attivita AND a.codice = pa.fk_attivita AND e.id = se.fk_evento" +
                           "       AND pa.fk_lavoratore = '" + username_in + "' AND a.data_fine >= CURRENT_DATE" +
                           " ORDER BY a.data_inizio ASC; ";
            try
            {
                string result = InterazioneDB.EseguiQuery_GetInfo(query);

                if (result != "")
                    return EventoSRV.GeneraElencoEventi(result);
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query GetElencoEventiLavoratore() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoEventiLavoratore()"); ///Scrittura log
            }

            return null;
        }

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti gli eventi presenti nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public List<EventoSRV> GetStoricoEventi(string username)
        {
            string query = "SELECT a.codice, a.nome, a.descrizione, a.data_inizio, a.data_fine, e.id, e.luogo " +
               "FROM attivita a, evento e, specifica_evento se " +
               "WHERE a.codice = se.fk_attivita AND e.id = se.fk_evento;";

            try
            {
                string result = InterazioneDB.EseguiQuery_GetInfo(query);

                if (result != "")
                    return EventoSRV.GeneraElencoEventi(result); ;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query GetStoricoEventi() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetStoricoEventi()"); ///Scrittura log
            }

            return null;
        }
        #endregion

        #region Progetti
        /// <summary>
        /// Servizio adibito all'inserimento di un Progetto nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="nuovoProgetto"></param>
        /// <returns></returns>
        public bool CreaProgetto(string username, ProgettoSRV nuovoProgetto)
        {
            string query_attivita = "INSERT INTO attivita(nome, descrizione, data_inizio, data_fine) " +
                                    "VALUES('" + nuovoProgetto.Nome + "', '" + nuovoProgetto.Descrizione + "', '" +
                                    nuovoProgetto.DataInizio.ToString("yyyy-MM-dd") + "', '" + nuovoProgetto.DataFine.ToString("yyyy-MM-dd") + "');"; ///Creo una nuova attività
            string query_progetto = "INSERT INTO progetto(cliente) VALUES ('" + nuovoProgetto.Cliente + "');"; ///Creo un nuovo progetto

            List<string> queries = new List<string>
            {
                query_attivita,
                query_progetto
            };

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
                        List<string> queries_sp = new List<string>
                        {
                            query_spProgetto
                        };

                        if (InterazioneDB.EseguiQueries(queries_sp))
                            return true;
                    }
                }
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query CreaProgetto() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "CreaProgetto()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio adibito all'aggiornamento di un Progetto nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="aggiornaProgetto"></param>
        /// <returns></returns>
        public bool AggiornaProgetto(string username, ProgettoSRV aggiornaProgetto)
        {
            string query_attivita = "UPDATE attivita SET nome = '" + aggiornaProgetto.Nome + "', descrizione = '" + aggiornaProgetto.Descrizione + 
                                    "', data_inizio = '" + aggiornaProgetto.DataInizio.ToString("yyyy-MM-dd") + "', data_fine = '" +
                                    aggiornaProgetto.DataFine.ToString("yyyy-MM-dd") +
                                    "' WHERE codice = '" + aggiornaProgetto.Codice + "';"; ///Aggiorno l'attività

            string query_progetto = "UPDATE progetto SET cliente = '" + aggiornaProgetto.Cliente + "' WHERE id = '" + aggiornaProgetto.Id.ToString() + "';"; ///Aggiorno il progetto

            List<string> queries = new List<string>
            {
                query_attivita,
                query_progetto
            };

            try
            {
                if (InterazioneDB.EseguiQueries(queries))
                    return true;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query AggiornaProgetto() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "AggiornaProgetto()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio adibito all'eliminazione di un Progetto dal DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="codice"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool EliminaProgetto(string username, string codice, string id)
        {
            string query_sp_progetto = "DELETE FROM specifica_progetto WHERE fk_attivita = '" + codice + "' AND fk_progetto = '" + id + "';";
            string query_attivita = "DELETE FROM attivita WHERE codice = '" + codice + "';";
            string query_progetto = "DELETE FROM progetto WHERE id = '" + id + "'";

            List<string> queries = new List<string>
            {
                query_sp_progetto,
                query_attivita,
                query_progetto
            };

            try
            {
                if (InterazioneDB.EseguiQueries(queries)) ///Elimino l'evento
                    return true;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query EliminaProgetto() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "EliminaProgetto()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti i Progetti presenti nel DB con una data maggiore o uguale all'odierna
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public List<ProgettoSRV> GetElencoProgetti(string username)
        {
            string query = "SELECT a.codice, a.nome, a.descrizione, a.data_inizio, a.data_fine, p.id, p.cliente" +
                           " FROM attivita a, progetto p, specifica_progetto sp" +
                           " WHERE a.codice = sp.fk_attivita AND p.id = sp.fk_progetto AND a.data_fine >= CURRENT_DATE" +
                           " ORDER BY a.data_inizio ASC;";

            try
            {
                string result = InterazioneDB.EseguiQuery_GetInfo(query);

                if (result != "")
                    return ProgettoSRV.GeneraElencoProgetti(result);
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query GetElencoProgetti() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoProgetti()"); ///Scrittura log
            }

            return null;
        }

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti i Progetti presenti nel DB  con una data maggiore o uguale all'odierna
        /// a cui partecipa uno specifico lavoratore
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <returns></returns>
        public List<ProgettoSRV> GetElencoProgettiLavoratore(string username, string username_in)
        {
            string query = "SELECT a.codice, a.nome, a.descrizione, a.data_inizio, a.data_fine, p.id, p.cliente" +
                           " FROM attivita a, progetto p, specifica_progetto sp, partecipazione pa" +
                           " WHERE a.codice = sp.fk_attivita AND a.codice = pa.fk_attivita AND p.id = sp.fk_progetto" +
                           "       AND pa.fk_lavoratore = '" + username_in + "' AND a.data_fine >= CURRENT_DATE" +
                           " ORDER BY a.data_inizio ASC;";

            try
            {
                string result = InterazioneDB.EseguiQuery_GetInfo(query);

                if (result != "")
                    return ProgettoSRV.GeneraElencoProgetti(result);
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query GetElencoProgettiLavoratore() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoProgettiLavoratore()"); ///Scrittura log
            }

            return null;
        }

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti i Progetti presenti nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public List<ProgettoSRV> GetStoricoProgetti(string username)
        {
            string query = "SELECT a.codice, a.nome, a.descrizione, a.data_inizio, a.data_fine, p.id, p.cliente" +
               " FROM attivita a, progetto p, specifica_progetto sp" +
               " WHERE a.codice = sp.fk_attivita AND p.id = sp.fk_progetto;";

            try
            {
                string result = InterazioneDB.EseguiQuery_GetInfo(query);

                if (result != "")
                    return ProgettoSRV.GeneraElencoProgetti(result);
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query GetStoricoProgetti() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetStoricoProgetti()"); ///Scrittura log
            }

            return null;
        }

        #region Obiettivi
        /// <summary>
        /// Servizio adibito all'ottenimento dell'elenco di tutti gli Obiettivi di un determinato Progetto
        /// </summary>
        /// <param name="username"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ObiettivoSRV> GetElencoObiettivi(string username, string id)
        {
            string query = "SELECT * " +
                           " FROM obiettivo " +
                           " WHERE obiettivo.fk_progetto = '" + id + "';";

            try
            {
                string result = InterazioneDB.EseguiQuery_GetInfo(query);

                if (result != "")
                    return ObiettivoSRV.GeneraElencoObiettivi(result);
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query GetElencoObiettivi() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoObiettivi()"); ///Scrittura log
            }

            return null;
        }

        /// <summary>
        /// Servizio adibito all'inserimento di un nuovo Obiettivo ad un determinato Progetto
        /// </summary>
        /// <param name="username"></param>
        /// <param name="nuovoObiettivo"></param>
        /// <returns></returns>
        public bool AggiungiObiettivo(string username, ObiettivoSRV nuovoObiettivo)
        {
            string query = "INSERT INTO obiettivo(fk_progetto, descrizione, completato) " +
                           " VALUES ('" + nuovoObiettivo.Id.ToString() + "','" + nuovoObiettivo.Desccrizione + "','" + (nuovoObiettivo.Completato ? 1.ToString() : 0.ToString()) + "');";

            List<string> queries = new List<string>
            {
                query
            };

            try
            {
                if (InterazioneDB.EseguiQueries(queries))
                    return true;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query AggiungiObiettivo() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "AggiungiObiettivo()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio adibito alla modifica di un determinato obiettivo
        /// </summary>
        /// <param name="username"></param>
        /// <param name="aggiornaObiettivo"></param>
        /// <returns></returns>
        public bool ModificaObiettivo(string username, ObiettivoSRV aggiornaObiettivo)
        {
            string query = "UPDATE obiettivo SET descrizione = '" + aggiornaObiettivo.Desccrizione + "',completato = '" + (aggiornaObiettivo.Completato ? 1.ToString() : 0.ToString()) + "' " +
                           " WHERE obiettivo.id = '" + aggiornaObiettivo.Id.ToString() + "';";

            List<string> queries = new List<string>
            {
                query
            };

            try
            {
                if (InterazioneDB.EseguiQueries(queries))
                    return true;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query ModificaObiettivo() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "ModificaObiettivo()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio adibito all'eliminazione di un determinato obiettivo
        /// </summary>
        /// <param name="username"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool EliminaObiettivo(string username, string id)
        {
            string query = "DELETE FROM obiettivo WHERE obiettivo.id = '" + id + "';";

            List<string> queries = new List<string>
            {
                query
            };

            try
            {
                if (InterazioneDB.EseguiQueries(queries))
                    return true;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query EliminaObiettivo() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "EliminaObiettivo()"); ///Scrittura log
            }

            return false;
        }
        #endregion
        #endregion

        /// <summary>
        /// Servizio adibtio all'ottenimento dell'elenco dei partecipanti (Lavoratori) ad un'attività
        /// </summary>
        /// <param name="username"></param>
        /// <param name="codice"></param>
        /// <returns></returns>
        public string GetElencoPartecipantiAttivita(string username, string codice)
        {
            string query = "SELECT l.username, a.codice, p.ruolo " +
                           "FROM lavoratore l, attivita a, partecipazione p " +
                           "WHERE l.username = p.fk_lavoratore AND a.codice = p.fk_attivita" +
                           "      AND a.codice = '" + codice + "'; ";

            try
            {
                string result = InterazioneDB.EseguiQuery_GetInfo(query);

                if (result != "")
                    return result;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query GetElencoPartecipantiAttivita() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoPartecipantiAttivita()"); ///Scrittura log
            }

            return "";
        }

        /// <summary>
        /// Servizio adibito all'inserimento di un nuovo partecipante (Lavoratore) ad un'attività
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <param name="codice"></param>
        /// <param name="ruolo"></param>
        /// <returns></returns>
        public bool AggiungiPartecipanteAttivita(string username, string username_in, string codice, string ruolo)
        {
            string query = "INSERT INTO partecipazione(fk_lavoratore, fk_attivita, ruolo) VALUES ('" + username_in + "','" + codice + "','" + ruolo + "')";

            List<string> queries = new List<string>
            {
                query
            };

            try
            {
                if (InterazioneDB.EseguiQueries(queries)) ///Elimino l'evento
                    return true;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query AggiungiPartecipanteAttivita() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "AggiungiPartecipanteAttivita()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio adibito all'eliminazione di un partecipante (Lavoratore) da un'attività
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <param name="codice"></param>
        /// <returns></returns>
        public bool RimuoviPartecipanteAttivita(string username, string username_in, string codice)
        {
            string query = "DELETE FROM partecipazione WHERE fk_lavoratore = '" + username_in + "' AND fk_attivita = '" + codice + "';";

            List<string> queries = new List<string>
            {
                query,
            };

            try
            {
                if (InterazioneDB.EseguiQueries(queries)) ///Elimino la partecipazione
                    return true;
            }

            catch (Exception ex)
            {
                if (InterazioneDB.Connessione != null) //Controllo che la connessione sia stata aperta
                    InterazioneDB.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE!!! Esecuzione query RimuoviPartecipanteAttivita() in ServerAziendaleDB: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "RimuoviPartecipanteAttivita()"); ///Scrittura log
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
