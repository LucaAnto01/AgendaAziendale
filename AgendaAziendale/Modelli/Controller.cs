using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerAziendaleDB.Modelli;

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
            try
            {
                string passwordHash = Lavoratore.PasswordHashing(password);

                if (Sessione.ServerAziendale.Login(username, passwordHash)) ///Effettuo il login
                    return true;

                else
                    return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo EffettuaLogin: errore richiamo web service", "Metodo EffettuaLogin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

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
            try
            {
                string result = Sessione.ServerAziendale.GetInfoLavoratore(username, username_info);

                if (result != "")
                    return Lavoratore.GeneraLavoratore(result);

                return null;
            }
            

            catch
            {
                MessageBox.Show("ERRORE! Metodo GetInfoLavoratore: errore richiamo web service", "Metodo GetInfoLavoratore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return null;
        }

        /// <summary>
        /// Metodo adibito all'inserimento di un lavoratore nel DB
        /// --> richiamo del web service InserisciLavoratore() dopo aver controllato che l'utente non esistesse già mediante il web service Login()
        /// </summary>
        /// <param name="nuovoLavoratore"></param>
        /// <returns></returns>
        public static bool InserisciLavoratore(Lavoratore nuovoLavoratore)
        {
            try
            {
                string passwordHash = Lavoratore.PasswordHashing(nuovoLavoratore.Password);
                if (Sessione.ServerAziendale.GetInfoLavoratore(Sessione.Lavoratore.Username, nuovoLavoratore.Username) == "") ///Così facendo controllo che il Lavoratore non sia già presente all'interno del DB
                {
                    LavoratoreSRV nuovoLavoratoreSrv = new LavoratoreSRV(nuovoLavoratore.Username, passwordHash, nuovoLavoratore.Nome, nuovoLavoratore.Cognome, nuovoLavoratore.Residenza, nuovoLavoratore.DataNascita, Lavoratore.GeneraEmail(nuovoLavoratore.Username, nuovoLavoratore.Cognome), nuovoLavoratore.Categoria);
                    if (Sessione.ServerAziendale.InserisciLavoratore(Sessione.Lavoratore.Username, nuovoLavoratoreSrv)) ///Inserisco il lavoratore nel db
                        return true;
                }
                    
                return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo InserisciLavoratore: errore richiamo web service", "Metodo InserisciLavoratore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }

        /// <summary>
        /// Metodo adibito alla modifica di un lavoratore presente nel DB
        /// --> richiamo del web service AggiornaLavoratore()
        /// </summary>
        /// <param name="aggiornaLavoratore"></param>
        /// <returns></returns>
        public static bool AggiornaLavoratore(Lavoratore aggiornaLavoratore)
        {
            try
            {
                LavoratoreSRV aggiornaLavoratoreSrv = new LavoratoreSRV(aggiornaLavoratore.Username, "", aggiornaLavoratore.Nome, aggiornaLavoratore.Cognome, aggiornaLavoratore.Residenza, aggiornaLavoratore.DataNascita, aggiornaLavoratore.Email, aggiornaLavoratore.Categoria);
                if (Sessione.ServerAziendale.AggiornaLavoratore(Sessione.Lavoratore.Username, aggiornaLavoratoreSrv)) ///Aggiorno il lavoratore nel db
                    return true;

                return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo AggiornaLavoratore: errore richiamo web service", "Metodo AggiornaLavoratore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }

        /// <summary>
        /// Metodo adibito all'aggiornamento della password associata ad un Lavoratore
        /// --> richiamo del web service AggiornaPassword()
        /// </summary>
        /// <param name="username_in"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool AggiornaPassword(string username_in, string password)
        {
            try
            {
                string passwordHash = Lavoratore.PasswordHashing(password);
                if (Sessione.ServerAziendale.AggiornaPassword(Sessione.Lavoratore.Username, username_in, passwordHash))
                    return true;

                return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo AggiornaPassword: errore richiamo web service", "Metodo AggiornaPassword", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

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
            try
            {
                if (Sessione.ServerAziendale.EliminaLavoratore(Sessione.Lavoratore.Username, username_in))
                    return true;

                return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo EliminaLavoratore: errore richiamo web service", "Metodo EliminaLavoratore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }

        /// <summary>
        /// Funzione adibita all'ottenimento dell'elenco di tutti i lavoratori presenti nel DB
        /// </summary>
        /// <returns></returns>
        public static string GetElencoLavoratori()
        {
            try
            {
                string result = Sessione.ServerAziendale.GetElencoLavoratori(Sessione.Lavoratore.Username);

                if (result != "")
                    return result;

                return "";
            }
            

            catch
            {
                MessageBox.Show("ERRORE! Metodo GetElencoLavoratori: errore richiamo web service", "Metodo GetElencoLavoratori", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return "";
        }
        #endregion

        #region Eventi
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
            try
            {
                if (Sessione.ServerAziendale.CreaEvento(Sessione.Lavoratore.Username, nome, descrizione, dataInizio, dataFine, luogo))
                    return true;

                return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo CreaEvento: errore richiamo web service", "Metodo CreaEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }

        /// <summary>
        /// Metodo adibito all'aggiornamento di un Evento nel DB
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="luogo"></param>
        /// <returns></returns>
        public static bool AggiornaEvento(string codice, string id, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, string luogo)
        {
            try
            {
                if (Sessione.ServerAziendale.AggiornaEvento(Sessione.Lavoratore.Username, codice, id, nome, descrizione, dataInizio, dataFine, luogo))
                    return true;

                else
                    return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo AggiornaEvento: errore richiamo web service", "Metodo AggiornaEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }

        /// <summary>
        /// Metodo adibito all'eliminazione di un Evento dal DB
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool EliminaEvento(string codice, string id)
        {
            try
            {
                if (Sessione.ServerAziendale.EliminaEvento(Sessione.Lavoratore.Username, codice, id))
                    return true;

                return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo EliminaEvento: errore richiamo web service", "Metodo EliminaEvento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }

        /// <summary>
        /// Funzione adibita all'ottenimento dell'elenco di tutti gli eventi presenti nel DB con una data maggiore o uguale all'odierna
        /// </summary>
        /// <returns></returns>
        public static string GetElencoEventi()
        {
            try
            {
                string result = Sessione.ServerAziendale.GetElencoEventi(Sessione.Lavoratore.Username);

                if (result != "")
                    return result;

                return "";
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo GetElencoEventi: errore richiamo web service", "Metodo GetElencoEventi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return "";
        }

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti gli eventi presenti nel DB con una data maggiore o uguale all'odierna
        /// a cui partecipa uno specifico lavoratore
        /// </summary>
        /// <param name="username_in"></param>
        /// <returns></returns>
        public static string GetElencoEventiLavoratore(string username_in)
        {
            try
            {
                string result = Sessione.ServerAziendale.GetElencoEventiLavoratore(Sessione.Lavoratore.Username, username_in);

                if (result != "")
                    return result;

                return "";
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo GetElencoEventiLavoratore: errore richiamo web service", "Metodo GetElencoEventiLavoratore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return "";
        }

        /// <summary>
        /// Funzione adibita all'ottenimento dell'elenco di tutti gli eventi presenti nel DB
        /// </summary>
        /// <returns></returns>
        public static string GetStoricoEventi()
        {
            try
            {
                string result = Sessione.ServerAziendale.GetStoricoEventi(Sessione.Lavoratore.Username);

                if (result != "")
                    return result;

                return "";
            }        

            catch
            {
                MessageBox.Show("ERRORE! Metodo GetStoricoEventi: errore richiamo web service", "Metodo GetStoricoEventi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return "";
        }
        #endregion

        #region Progetti
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
            try
            {
                if (Sessione.ServerAziendale.CreaProgetto(Sessione.Lavoratore.Username, nome, descrizione, dataInizio, dataFine, cliente))
                    return true;

                return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo CreaProgetto: errore richiamo web service", "Metodo CreaProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }

        /// <summary>
        /// Metodo adibito all'aggiornamento di un Progetto nel DB
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool AggiornaProgetto(string codice, string id, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, string cliente)
        {
            try
            {
                if (Sessione.ServerAziendale.AggiornaProgetto(Sessione.Lavoratore.Username, codice, id, nome, descrizione, dataInizio, dataFine, cliente))
                    return true;

                return false;
            }         

            catch
            {
                MessageBox.Show("ERRORE! Metodo AggiornaProgetto: errore richiamo web service", "Metodo AggiornaProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }

        /// <summary>
        /// Metodo adibito all'eliminazione di un Progetto dal DB
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool EliminaProgetto(string codice, string id)
        {
            try
            {
                if (Sessione.ServerAziendale.EliminaProgetto(Sessione.Lavoratore.Username, codice, id))
                    return true;

                return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo EliminaProgetto: errore richiamo web service", "Metodo EliminaProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }

        /// <summary>
        /// Funzione adibita all'ottenimento dell'elenco di tutti i progetti presenti nel DB con una data maggiore o uguale all'odierna
        /// </summary>
        /// <returns></returns>
        public static string GetElencoProgetti()
        {
            try
            {
                string result = Sessione.ServerAziendale.GetElencoProgetti(Sessione.Lavoratore.Username);

                if (result != "")
                    return result;

                return "";
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo GetElencoProgetti: errore richiamo web service", "Metodo GetElencoProgetti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return "";
        }

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti i Progetti presenti nel DB  con una data maggiore o uguale all'odierna
        /// a cui partecipa uno specifico lavoratore
        /// </summary>
        /// <param name="username_in"></param>
        /// <returns></returns>
        public static string GetElencoProgettiLavoratore(string username_in)
        {
            try
            {
                string result = Sessione.ServerAziendale.GetElencoProgettiLavoratore(Sessione.Lavoratore.Username, username_in);

                if (result != "")
                    return result;

                return "";
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo GetElencoProgettiLavoratore: errore richiamo web service", "Metodo GetElencoProgettiLavoratore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return "";
        }

        /// <summary>
        /// Funzione adibita all'ottenimento dell'elenco di tutti i progetti presenti nel DB
        /// </summary>
        /// <returns></returns>
        public static string GetStoricoProgetti()
        {
            try
            {
                string result = Sessione.ServerAziendale.GetStoricoProgetti(Sessione.Lavoratore.Username);

                if (result != "")
                    return result;

                return "";
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo GetStoricoProgetti: errore richiamo web service", "Metodo GetStoricoProgetti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return "";
        }

        #region Obiettivi
        /// <summary>
        /// Funzione adibita all'ottenimento dell'elenco di tutti gli obiettivi associati ad un determinato Progetto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetElencoObiettivi(string id)
        {
            try
            {
                string result = Sessione.ServerAziendale.GetElencoObiettivi(Sessione.Lavoratore.Username, id);

                if (result != "")
                    return result;

                return "";
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo GetElencoObiettivi: errore richiamo web service", "Metodo GetElencoObiettivi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return "";
        }

        /// <summary>
        /// Funzione adibita al calcolo dell'avanzamento percentuale di un determinato progetto sulla base del completamento degli Obiettivi
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int CalcolaAvanzamentoProgetto(Progetto progetto)
        {
            try
            {
                int[] obiettivi = new int[progetto.Obiettivi.Count];

                int i = 0;
                foreach (Obiettivo obiettivo in progetto.Obiettivi)
                {
                    obiettivi[i] = obiettivo.Completato ? 1 : 0;
                    i++;
                }

                int result = Sessione.ServerAziendale.CalcolaAvanzamento(Sessione.Lavoratore.Username, obiettivi);

                return result;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo CalcolaAvanzamentoProgetto: errore richiamo web service", "Metodo CalcolaAvanzamentoProgetto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return 0;
        }

        /// <summary>
        /// Funzione adibita all'inserimento di un nuovo Obiettivo ad un determinato Progetto
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descrizione"></param>
        /// <param name="completato"></param>
        /// <returns></returns>
        public static bool AggiungiObiettivo(string id, string descrizione, bool completato)
        {
            try
            {
                if (Sessione.ServerAziendale.AggiungiObiettivo(Sessione.Lavoratore.Username, id, descrizione, completato))
                    return true;

                return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo AggiungiObiettivo: errore richiamo web service", "Metodo AggiungiObiettivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }

        /// <summary>
        /// Funzione adibita alla modifica di un Obiettivo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descrizione"></param>
        /// <param name="completato"></param>
        /// <returns></returns>
        public static bool ModificaObiettivo(string id, string descrizione, bool completato)
        {
            try
            {
                if (Sessione.ServerAziendale.ModificaObiettivo(Sessione.Lavoratore.Username, id, descrizione, completato))
                    return true;

                return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo ModificaObiettivo: errore richiamo web service", "Metodo ModificaObiettivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }

        /// <summary>
        /// Funzione adibita all'eliminazione di un Obiettivo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool EliminaObiettivo(string id)
        {
            try
            {
                if (Sessione.ServerAziendale.EliminaObiettivo(Sessione.Lavoratore.Username, id))
                    return true;

                return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo EliminaObiettivo: errore richiamo web service", "Metodo EliminaObiettivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }
        #endregion
        #endregion

        /// <summary>
        /// Funzione adibita all'inserimento di un nuovo Lavoratore ad un'attività
        /// </summary>
        /// <param name="username_in"></param>
        /// <param name="codice"></param>
        /// <param name="ruolo"></param>
        /// <returns></returns>
        public static bool AggiugniPartecipanteAttivita(string username_in, string codice, string ruolo)
        {
            try
            {
                if (Sessione.ServerAziendale.AggiungiPartecipanteAttivita(Sessione.Lavoratore.Username, username_in, codice, ruolo))
                    return true;

                return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo AggiugniPartecipanteAttivita: errore richiamo web service", "Metodo AggiugniPartecipanteAttivita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }

        /// <summary>
        /// Funzione adibtia all'ottenimento dell'elenco dei partecipanti ad un'attività
        /// </summary>
        /// <param name="codice"></param>
        /// <returns></returns>
        public static string GetElencoPartecipantiAttivita(string codice)
        {
            try
            {
                string result = Sessione.ServerAziendale.GetElencoPartecipantiAttivita(Sessione.Lavoratore.Username, codice);

                if (result != "")
                    return result;

                return "";
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo GetElencoPartecipantiAttivita: errore richiamo web service", "Metodo GetElencoPartecipantiAttivita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return "";
        }

        /// <summary>
        /// Funzione adibita ad ottenere l'elenco dei lavoratori disponibili ad un'attività
        /// --> noon già impiegati in un'altra attività
        /// </summary>
        /// <param name="codice"></param>
        /// <returns></returns>
        public static string GetElencoLavoratoriAttivita(string codice)
        {
            try
            {
                string result = Sessione.ServerAziendale.GetElencoLavoratoriAttivita(Sessione.Lavoratore.Username, codice);

                if (result != "")
                    return result;

                return "";
            }          

            catch
            {
                MessageBox.Show("ERRORE! Metodo GetElencoLavoratoriAttivita: errore richiamo web service", "Metodo GetElencoLavoratoriAttivita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return "";
        }

        /// <summary>
        /// Funzione adibtia all'eliminazione di una partecipazione ad un'attività
        /// </summary>
        /// <param name="username"></param>
        /// <param name="codice"></param>
        /// <returns></returns>
        public static bool EliminaPartecipazioneAttivita(string username, string codice)
        {
            try
            {
                if (Sessione.ServerAziendale.RimuoviPartecipanteAttivita(Sessione.Lavoratore.Username, username, codice))
                    return true;

                return false;
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo EliminaPartecipazioneAttivita: errore richiamo web service", "Metodo EliminaPartecipazioneAttivita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }
    }
}
