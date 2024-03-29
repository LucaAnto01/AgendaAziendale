﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServerAziendaleDB.Modelli;

namespace ServerAziendale
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IServiceAgendaAziendale" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IServiceAgendaAziendale
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
        LavoratoreSRV GetInfoLavoratore(string username, string username_cercato);

        /// <summary>
        /// Servizio adibito all'inserimento di un Lavoratore nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="nuovoLavoratore"></param>
        /// <returns></returns>
        [OperationContract]
        bool InserisciLavoratore(string username, LavoratoreSRV nuovoLavoratore);

        /// <summary>
        /// Servizio adibito all'aggiornamento di un Lavoratore nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="aggiornaLavoratore"></param>
        /// <returns></returns>
        [OperationContract]
        bool AggiornaLavoratore(string username, LavoratoreSRV aggiornaLavoratore);

        /// <summary>
        /// Servizio adibito all'aggiornamento della password di un Lavoratore presente nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [OperationContract]
        bool AggiornaPassword(string username, string username_in, string password);

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
        List<LavoratoreSRV> GetElencoLavoratori(string username);
        #endregion

        #region Eventi
        /// <summary>
        /// Servizio adibito all'inserimento di un Evento nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="nuovoEvento"></param>
        /// <returns></returns>
        [OperationContract]
        bool CreaEvento(string username, EventoSRV nuovoEvento);

        /// <summary>
        /// Servizio adibito all'aggiornamento di un Evento nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="aggiornaEvento"></param>
        /// <returns></returns>
        [OperationContract]
        bool AggiornaEvento(string username, EventoSRV aggiornaEvento);

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
        List<EventoSRV> GetElencoEventi(string username);

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti gli eventi presenti nel DB con una data maggiore o uguale all'odierna
        /// a cui partecipa uno specifico lavoratore
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <returns></returns>
        [OperationContract]
        List<EventoSRV> GetElencoEventiLavoratore(string username, string username_in);

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti gli eventi presenti nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [OperationContract]
        List<EventoSRV> GetStoricoEventi(string username);
        #endregion

        #region Progetti
        /// <summary>
        /// Servizio adibito all'inserimento di un Progetto nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="nuovoProgetto"></param>
        /// <returns></returns>
        [OperationContract]
        bool CreaProgetto(string username, ProgettoSRV nuovoProgetto);

        /// <summary>
        /// Servizio adibito all'aggiornamento di un Progetto nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="aggiornaProgetto"></param>
        /// <returns></returns>
        [OperationContract]
        bool AggiornaProgetto(string username, ProgettoSRV aggiornaProgetto);

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
        List<ProgettoSRV> GetElencoProgetti(string username);

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti i Progetti presenti nel DB  con una data maggiore o uguale all'odierna
        /// a cui partecipa uno specifico lavoratore
        /// </summary>
        /// <param name="username"></param>
        /// <param name="username_in"></param>
        /// <returns></returns>
        [OperationContract]
        List<ProgettoSRV> GetElencoProgettiLavoratore(string username, string username_in);

        /// <summary>
        /// Servizio adibito all'ottenimento dell'Elenco di tutti i Progetti presenti nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [OperationContract]
        List<ProgettoSRV> GetStoricoProgetti(string username);

        #region Obiettivi
        /// <summary>
        /// Servizio adibito all'ottenimento dell'elenco di tutti gli Obiettivi di un determinato Progetto
        /// </summary>
        /// <param name="username"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        List<ObiettivoSRV> GetElencoObiettivi(string username, string id);

        /// <summary>
        /// Servizio adibito al calcolo dell'avanzamento percentuale di un determinato progetto sulla base del completamento degli Obiettivi
        /// </summary>
        /// <param name="username"></param>
        /// <param name="obiettivi"></param>
        /// <returns></returns>
        [OperationContract]
        int CalcolaAvanzamento(string username, int[] obiettivi);

        /// <summary>
        /// Servizio adibito all'inserimento di un nuovo Obiettivo ad un determinato Progetto
        /// </summary>
        /// <param name="username"></param>
        /// <param name="nuovoObiettivo"></param>
        /// <returns></returns>
        [OperationContract]
        bool AggiungiObiettivo(string username, ObiettivoSRV nuovoObiettivo);

        /// <summary>
        /// Servizio adibito alla modifica di un determinato obiettivo
        /// </summary>
        /// <param name="username"></param>
        /// <param name="aggiornaObiettivo"></param>
        /// <returns></returns>
        [OperationContract]
        bool ModificaObiettivo(string username, ObiettivoSRV aggiornaObiettivo);

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
        /// Servizio adibtio all'ottenimento dell'elenco dei partecipanti (Lavoratori) ad un'attivita
        /// </summary>
        /// <param name="username"></param>
        /// <param name="codice"></param>
        /// <returns></returns>
        [OperationContract]
        string GetElencoPartecipantiAttivita(string username, string codice);

        /// <summary>
        /// Servizio adibito all'ottenimento dei Lavoratori disponibili per un'attività
        /// --> non restituisce i lavoratori già impiegati nella stessa
        /// </summary>
        /// <param name="username"></param>
        /// <param name="codice"></param>
        /// <returns></returns>
        [OperationContract]
        string GetElencoLavoratoriAttivita(string username, string codice);

        /// <summary>
        /// Servizio adibito all'inserimento di un nuovo partecipante (Lavoratore) ad un'attivita
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
