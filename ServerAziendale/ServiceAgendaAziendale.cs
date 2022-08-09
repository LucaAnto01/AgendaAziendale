using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServerAziendale.Modelli;
using ServerAziendaleDB.Modelli;

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

        #region Lavoratori
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
        /// <param name="nuovoLavoratore"></param>
        /// <returns></returns>
        public bool InserisciLavoratore(string username, LavoratoreSRV nuovoLavoratore)
        {
            try
            {
                if (Sessione.ServerAziendaleDB.InserisciLavoratore(username, nuovoLavoratore))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione InserisciLavoratore() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "InserisciLavoratore()"); ///Scrittura log
            }

            return false;
        }

        /// <summary>
        /// Servizio adibito all'aggiornamento di un Lavoratore nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="aggiornaLavoratore"></param>
        /// <returns></returns>
        public bool AggiornaLavoratore(string username, LavoratoreSRV aggiornaLavoratore)
        {
            try
            {
                if (Sessione.ServerAziendaleDB.AggiornaLavoratore(username, aggiornaLavoratore))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione AggiornaLavoratore() in ServerAziendale: " + ex.ToString());
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
            try
            {
                if (Sessione.ServerAziendaleDB.AggiornaPassword(username, username_in, password))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione AggiornaPassword() in ServerAziendale: " + ex.ToString());
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
            try
            {
                if (Sessione.ServerAziendaleDB.EliminaLavoratore(username, username_in))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione EliminaLavoratore() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "EliminaLavoratore()"); ///Scrittura log
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
            try
            {
                string result = Sessione.ServerAziendaleDB.GetElencoLavoratori(username);

                if (result != "")
                    return result;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione GetElencoLavoratori() in ServerAziendale: " + ex.ToString());
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
            try
            {
                if (Sessione.ServerAziendaleDB.CreaEvento(username, nuovoEvento))
                    return true;
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
        /// Servizio adibito all'aggiornamento di un Evento nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="aggiornaEvento"></param>
        /// <returns></returns>
        public bool AggiornaEvento(string username, EventoSRV aggiornaEvento)
        {
            try
            {
                if (Sessione.ServerAziendaleDB.AggiornaEvento(username, aggiornaEvento))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione AggiornaEvento() in ServerAziendale: " + ex.ToString());
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
            try
            {
                if (Sessione.ServerAziendaleDB.EliminaEvento(username, codice, id))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione EliminaEvento() in ServerAziendale: " + ex.ToString());
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
        public string GetElencoEventi(string username)
        {
            try
            {
                string result = Sessione.ServerAziendaleDB.GetElencoEventi(username);

                if (result != "")
                    return result;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione GetElencoEventi() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoEventi()"); ///Scrittura log
            }

            return "";
        }

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti gli eventi presenti nel DB con una data maggiore o uguale all'odierna
        /// a cui partecipa uno specifico lavoratore
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <returns></returns>
        public string GetElencoEventiLavoratore(string username, string username_in)
        {
            try
            {
                string result = Sessione.ServerAziendaleDB.GetElencoEventiLavoratore(username, username_in);

                if (result != "")
                    return result;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione GetElencoEventiLavoratore() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoEventiLavoratore()"); ///Scrittura log
            }

            return "";
        }

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti gli eventi presenti nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public string GetStoricoEventi(string username)
        {
            try
            {
                string result = Sessione.ServerAziendaleDB.GetStoricoEventi(username);

                if (result != "")
                    return result;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione GetStoricoEventi() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetStoricoEventi()"); ///Scrittura log
            }

            return "";
        }
        #endregion

        #region Progetti
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

        /// <summary>
        /// Servizio adibito all'aggiornamento di un Progetto nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="codice"></param>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool AggiornaProgetto(string username, string codice, string id, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, string cliente)
        {
            try
            {
                if (Sessione.ServerAziendaleDB.AggiornaProgetto(username, codice, id, nome, descrizione, dataInizio.ToString("yyyy-MM-dd"), dataFine.ToString("yyyy-MM-dd"), cliente))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione AggiornaProgetto() in ServerAziendale: " + ex.ToString());
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
            try
            {
                if (Sessione.ServerAziendaleDB.EliminaProgetto(username, codice, id))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione EliminaProgetto() in ServerAziendale: " + ex.ToString());
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
        public string GetElencoProgetti(string username)
        {
            try
            {
                string result = Sessione.ServerAziendaleDB.GetElencoProgetti(username);

                if (result != "")
                    return result;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione GetElencoProgetti() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoProgetti()"); ///Scrittura log
            }

            return "";
        }

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti i Progetti presenti nel DB  con una data maggiore o uguale all'odierna
        /// a cui partecipa uno specifico lavoratore
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <returns></returns>
        public string GetElencoProgettiLavoratore(string username, string username_in)
        {
            try
            {
                string result = Sessione.ServerAziendaleDB.GetElencoProgettiLavoratore(username, username_in);

                if (result != "")
                    return result;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione GetElencoProgettiLavoratore() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoProgettiLavoratore()"); ///Scrittura log
            }

            return "";
        }

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti i Progetti presenti nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public string GetStoricoProgetti(string username)
        {
            try
            {
                string result = Sessione.ServerAziendaleDB.GetStoricoProgetti(username);

                if (result != "")
                    return result;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione GetStoricoProgetti() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetStoricoProgetti()"); ///Scrittura log
            }

            return "";
        }

        #region Obiettivi
        /// <summary>
        /// Servizio adibito all'ottenimento dell'elenco di tutti gli Obiettivi di un determinato Progetto
        /// </summary>
        /// <param name="username"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetElencoObiettivi(string username, string id)
        {
            try
            {
                string result = Sessione.ServerAziendaleDB.GetElencoObiettivi(username, id);

                if (result != "")
                    return result;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione GetElencoObiettivi() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoObiettivi()"); ///Scrittura log
            }

            return "";
        }

        /// <summary>
        /// Servizio adibito al calcolo dell'avanzamento percentuale di un determinato progetto sulla base del completamento degli Obiettivi
        /// </summary>
        /// <param name="username"></param>
        /// <param name="obiettivi"></param>
        /// <returns></returns>
        public int CalcolaAvanzamento(string username, int[] obiettivi)
        {
            int result = 0;
            int completati = 0;

            try
            {
                foreach (int obiettivo in obiettivi)
                    if (obiettivo == 1) //1 --> completato
                        completati++;

                if(obiettivi.Length != 0) ///Al fine di evitare divisioni per zero
                    result = ((100 * completati) / obiettivi.Length);
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione CalcolaAvanzamento() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "CalcolaAvanzamento()"); ///Scrittura log
            }

            return result;
        }

        /// <summary>
        /// Servizio adibito all'inserimento di un nuovo Obiettivo ad un determinato Progetto
        /// </summary>
        /// <param name="username"></param>
        /// <param name="id"></param>
        /// <param name="descrizione"></param>
        /// <param name="completato"></param>
        /// <returns></returns>
        public bool AggiungiObiettivo(string username, string id, string descrizione, bool completato)
        {
            try
            {
                if (Sessione.ServerAziendaleDB.AggiungiObiettivo(username, id, descrizione, completato))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione AggiungiObiettivo() in ServerAziendale: " + ex.ToString());
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
        /// <param name="id"></param>
        /// <param name="descrizione"></param>
        /// <param name="completato"></param>
        /// <returns></returns>
        public bool ModificaObiettivo(string username, string id, string descrizione, bool completato)
        {
            try
            {
                if (Sessione.ServerAziendaleDB.ModificaObiettivo(username, id, descrizione, completato))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione ModificaObiettivo() in ServerAziendale: " + ex.ToString());
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
            try
            {
                if (Sessione.ServerAziendaleDB.EliminaObiettivo(username, id))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione EliminaObiettivo() in ServerAziendale: " + ex.ToString());
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
        /// Servizio adibtio all'ottenimento dell'elenco dei partecipanti (Lavoratori) ad un'attvivita
        /// </summary>
        /// <param name="username"></param>
        /// <param name="codice"></param>
        /// <returns></returns>
        public string GetElencoPartecipantiAttivita(string username, string codice)
        {
            try
            {
                string result = Sessione.ServerAziendaleDB.GetElencoPartecipantiAttivita(username, codice);

                if (result != "")
                    return result;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione GetElencoPartecipantiEvento() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoPartecipantiEvento()"); ///Scrittura log
            }

            return "";
        }

        /// <summary>
        /// Servizio adibito all'ottenimento dei Lavoratori disponibili per un'attività
        /// --> non restituisce i lavoratori già impiegati nella stessa
        /// </summary>
        /// <param name="username"></param>
        /// <param name="codice"></param>
        /// <returns></returns>
        public string GetElencoLavoratoriAttivita(string username, string codice)
        {
            string result = "";
            try
            {
                string result_partecipanti = Sessione.ServerAziendaleDB.GetElencoPartecipantiAttivita(username, codice);
                string result_lavoratori = Sessione.ServerAziendaleDB.GetElencoLavoratori(username);

                if ((result_partecipanti != "") && (result_lavoratori != ""))
                {
                    List<string> listaPartecipanti = result_partecipanti.Split('\n').ToList();
                    listaPartecipanti.RemoveAt((listaPartecipanti.Count - 1));

                    List<string> listaLavoratori = result_lavoratori.Split('\n').ToList();
                    listaLavoratori.RemoveAt((listaLavoratori.Count - 1));

                    foreach (string lavoratore in listaLavoratori)
                    {
                        int cont = 0;
                        List<string> info_lavoratore = lavoratore.Split('-').ToList();

                        foreach (string partecipante in listaPartecipanti)
                        {
                            List<string> info_partecipante = partecipante.Split('-').ToList();

                            if (info_lavoratore.ElementAt(0).Equals(info_partecipante.ElementAt(0)))
                                cont++;
                        }

                        if (cont == 0)
                            result += lavoratore + "\n";
                    }
                }

                else if ((result == "")  && (result_lavoratori != "")) ///Tutti i lavoratori liberi
                    return result_lavoratori;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione GetElencoLavoratoriAattivita() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "GetElencoLavoratoriAattivita()"); ///Scrittura log
            }

            return result;
        }

        /// <summary>
        /// Servizio adibito all'inserimento di un nuovo partecipante (Lavoratore) ad un'attivita
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <param name="codice"></param>
        /// <param name="ruolo"></param>
        /// <returns></returns>
        public bool AggiungiPartecipanteAttivita(string username, string username_in, string codice, string ruolo)
        {
            try
            {
                if (Sessione.ServerAziendaleDB.AggiungiPartecipanteAttivita(username, username_in, codice, ruolo))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione AggiungiPartecipanteEvento() in ServerAziendale: " + ex.ToString());
                Console.ReadLine();
            }

            finally
            {
                WriteLog(username, "AggiungiPartecipanteEvento()"); ///Scrittura log
            }

            return false;
        }          

        /// <summary>
        /// Servizio adibito all'eliminazione di un partecipante (Lavoratore) da un'attività
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <param name="codice"></param>
        /// <returns></returns>>
        public bool RimuoviPartecipanteAttivita(string username, string username_in, string codice)
        {
            try
            {
                if (Sessione.ServerAziendaleDB.RimuoviPartecipanteAttivita(username, username_in, codice))
                    return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Richiamo funzione RimuoviPartecipanteAttivita() in ServerAziendale: " + ex.ToString());
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
