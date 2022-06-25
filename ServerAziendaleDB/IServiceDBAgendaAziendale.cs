using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServerAziendaleDB
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IServiceDBAgendaAziendale" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IServiceDBAgendaAziendale
    {
        #region Servizi
        /// <summary>
        /// Servizio per testare la connessione client-server
        /// </summary>
        [OperationContract]
        void TestConnessione();

        /// <summary>
        /// Servizio adibito all'effetuazione del login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [OperationContract]
        bool Login(string username, string password);

        #region Lavoratori
        /// <summary>
        /// Servizio adibito all'ottenimento delle informazioni di uno specifico lavoratore
        /// </summary>
        /// <param name="username">Chi richiama il WS</param>
        /// <param name="username_cercato"></param>
        /// <returns></returns>
        [OperationContract]
        string GetInfoLavoratore(string username, string username_cercato);

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
        [OperationContract]
        bool InserisciLavoratore(string username, string username_in, string password, string nome, string cognome, string residenza, string dataNascita, string email, string categoria);

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
        [OperationContract]
        bool AggiornaLavoratore(string username, string username_in, string nome, string cognome, string residenza, string dataNascita, string categoria);

        /// <summary>
        /// Servizio adibito all'eiminazione di un Lavoratore presente nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <returns></returns>
        [OperationContract]
        bool EliminaLavoratore(string username, string username_in);

        /// <summary>
        /// Servizio che restituisce l'elenco dei lavoratori presenti nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [OperationContract]
        string GetElencoLavoratori(string username);
        #endregion

        #region Eventi
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
        [OperationContract]
        bool CreaEvento(string username, string nome, string descrizione, string dataInizio, string dataFine, string luogo);

        /// <summary>
        /// Servizio adibito all'aggiornamento di un Evento nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="codice"></param>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="luogo"></param>
        /// <returns></returns>
        [OperationContract]
        bool AggiornaEvento(string username, string codice, string id, string nome, string descrizione, string dataInizio, string dataFine, string luogo);

        /// <summary>
        /// Servizio adibito all'eliminazione di un Evento nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="codice"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        bool EliminaEvento(string username, string codice, string id);

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti gli eventi presenti nel DB con una data maggiore o uguale all'odierna
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [OperationContract]
        string GetElencoEventi(string username);

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti gli eventi presenti nel DB con una data maggiore o uguale all'odierna
        /// a cui partecipa uno specifico lavoratore
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <returns></returns>
        [OperationContract]
        string GetElencoEventiLavoratore(string username, string username_in);

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti gli eventi presenti nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [OperationContract]
        string GetStoricoEventi(string username);
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
        [OperationContract]
        bool CreaProgetto(string username, string nome, string descrizione, string dataInizio, string dataFine, string cliente);

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
        [OperationContract]
        bool AggiornaProgetto(string username, string codice, string id, string nome, string descrizione, string dataInizio, string dataFine, string cliente);

        /// <summary>
        /// Servizio adibito all'eliminazione di un Progetto dal DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="codice"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        bool EliminaProgetto(string username, string codice, string id);

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti i Progetti presenti nel DB con una data maggiore o uguale all'odierna
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [OperationContract]
        string GetElencoProgetti(string username);

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti i Progetti presenti nel DB  con una data maggiore o uguale all'odierna
        /// a cui partecipa uno specifico lavoratore
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <returns></returns>
        [OperationContract]
        string GetElencoProgettiLavoratore(string username, string username_in);

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti i Progetti presenti nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [OperationContract]
        string GetStoricoProgetti(string username);

        #region Obiettivi
        /// <summary>
        /// Servizio adibito all'ottenimento dell'elenco di tutti gli Obiettivi di un determinato Progetto
        /// </summary>
        /// <param name="username"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        string GetElencoObiettivi(string username, string id);

        /// <summary>
        /// Servizio adibito all'inserimento di un nuovo Obiettivo ad un determinato Progetto
        /// </summary>
        /// <param name="username"></param>
        /// <param name="id"></param>
        /// <param name="descrizione"></param>
        /// <param name="completato"></param>
        /// <returns></returns>
        [OperationContract]
        bool AggiungiObiettivo(string username, string id, string descrizione, bool completato);

        /// <summary>
        /// Servizio adibito alla modifica di un determinato obiettivo
        /// </summary>
        /// <param name="username"></param>
        /// <param name="id"></param>
        /// <param name="descrizione"></param>
        /// <param name="completato"></param>
        /// <returns></returns>
        [OperationContract]
        bool ModificaObiettivo(string username, string id, string descrizione, bool completato);

        /// <summary>
        /// Servizio adibito all'eliminazione di un determinato obiettivo
        /// </summary>
        /// <param name="username"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        bool EliminaObiettivo(string username, string id);
        #endregion
        #endregion

        /// <summary>
        /// Servizio adibtio all'ottenimento dell'elenco dei partecipanti (Lavoratori) ad un'attività
        /// </summary>
        /// <param name="username"></param>
        /// <param name="codice"></param>
        /// <returns></returns>
        [OperationContract]
        string GetElencoPartecipantiAttivita(string username, string codice);

        /// <summary>
        /// Servizio adibito all'inserimento di un nuovo partecipante (Lavoratore) ad un'attività
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <param name="codice"></param>
        /// <param name="ruolo"></param>
        /// <returns></returns>
        [OperationContract]
        bool AggiungiPartecipanteAttivita(string username, string username_in, string codice, string ruolo);

        /// <summary>
        /// Servizio adibito all'eliminazione di un partecipante (Lavoratore) da un'attività
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <param name="codice"></param>
        /// <returns></returns>
        [OperationContract]
        bool RimuoviPartecipanteAttivita(string username, string username_in, string codice);
        #endregion
    }
}
