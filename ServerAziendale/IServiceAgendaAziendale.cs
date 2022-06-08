using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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
        bool InserisciLavoratore(string username, string username_in, string password, string nome, string cognome, string residenza, DateTime dataNascita, string email, string categoria);

        /// <summary>
        /// Servizio che restituisce l'elenco dei lavoratori presenti nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [OperationContract]
        string GetElencoLavoratori(string username);

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
        bool CreaEvento(string username, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, string luogo);
        #endregion
    }
}
