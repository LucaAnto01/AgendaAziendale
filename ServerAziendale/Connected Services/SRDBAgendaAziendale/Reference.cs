﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerAziendale.SRDBAgendaAziendale {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SRDBAgendaAziendale.IServiceDBAgendaAziendale")]
    public interface IServiceDBAgendaAziendale {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/TestConnessione", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/TestConnessioneResponse")]
        void TestConnessione();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/TestConnessione", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/TestConnessioneResponse")]
        System.Threading.Tasks.Task TestConnessioneAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/Login", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/LoginResponse")]
        bool Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/Login", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetInfoLavoratore", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetInfoLavoratoreResponse")]
        ServerAziendaleDB.Modelli.LavoratoreSRV GetInfoLavoratore(string username, string username_cercato);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetInfoLavoratore", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetInfoLavoratoreResponse")]
        System.Threading.Tasks.Task<ServerAziendaleDB.Modelli.LavoratoreSRV> GetInfoLavoratoreAsync(string username, string username_cercato);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/InserisciLavoratore", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/InserisciLavoratoreResponse")]
        bool InserisciLavoratore(string username, ServerAziendaleDB.Modelli.LavoratoreSRV nuovoLavoratore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/InserisciLavoratore", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/InserisciLavoratoreResponse")]
        System.Threading.Tasks.Task<bool> InserisciLavoratoreAsync(string username, ServerAziendaleDB.Modelli.LavoratoreSRV nuovoLavoratore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaLavoratore", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaLavoratoreResponse")]
        bool AggiornaLavoratore(string username, [System.ServiceModel.MessageParameterAttribute(Name="aggiornaLavoratore")] ServerAziendaleDB.Modelli.LavoratoreSRV aggiornaLavoratore1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaLavoratore", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaLavoratoreResponse")]
        System.Threading.Tasks.Task<bool> AggiornaLavoratoreAsync(string username, ServerAziendaleDB.Modelli.LavoratoreSRV aggiornaLavoratore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaPassword", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaPasswordResponse")]
        bool AggiornaPassword(string username, string username_in, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaPassword", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaPasswordResponse")]
        System.Threading.Tasks.Task<bool> AggiornaPasswordAsync(string username, string username_in, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/EliminaLavoratore", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/EliminaLavoratoreResponse")]
        bool EliminaLavoratore(string username, string username_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/EliminaLavoratore", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/EliminaLavoratoreResponse")]
        System.Threading.Tasks.Task<bool> EliminaLavoratoreAsync(string username, string username_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoLavoratori", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoLavoratoriResponse")]
        ServerAziendaleDB.Modelli.LavoratoreSRV[] GetElencoLavoratori(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoLavoratori", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoLavoratoriResponse")]
        System.Threading.Tasks.Task<ServerAziendaleDB.Modelli.LavoratoreSRV[]> GetElencoLavoratoriAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoLavoratoriToString", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoLavoratoriToStringResponse")]
        string GetElencoLavoratoriToString(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoLavoratoriToString", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoLavoratoriToStringResponse")]
        System.Threading.Tasks.Task<string> GetElencoLavoratoriToStringAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/CreaEvento", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/CreaEventoResponse")]
        bool CreaEvento(string username, ServerAziendaleDB.Modelli.EventoSRV nuovoEvento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/CreaEvento", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/CreaEventoResponse")]
        System.Threading.Tasks.Task<bool> CreaEventoAsync(string username, ServerAziendaleDB.Modelli.EventoSRV nuovoEvento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaEvento", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaEventoResponse")]
        bool AggiornaEvento(string username, [System.ServiceModel.MessageParameterAttribute(Name="aggiornaEvento")] ServerAziendaleDB.Modelli.EventoSRV aggiornaEvento1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaEvento", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaEventoResponse")]
        System.Threading.Tasks.Task<bool> AggiornaEventoAsync(string username, ServerAziendaleDB.Modelli.EventoSRV aggiornaEvento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/EliminaEvento", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/EliminaEventoResponse")]
        bool EliminaEvento(string username, string codice, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/EliminaEvento", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/EliminaEventoResponse")]
        System.Threading.Tasks.Task<bool> EliminaEventoAsync(string username, string codice, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoEventi", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoEventiResponse")]
        ServerAziendaleDB.Modelli.EventoSRV[] GetElencoEventi(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoEventi", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoEventiResponse")]
        System.Threading.Tasks.Task<ServerAziendaleDB.Modelli.EventoSRV[]> GetElencoEventiAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoEventiLavoratore", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoEventiLavoratoreResponse")]
        ServerAziendaleDB.Modelli.EventoSRV[] GetElencoEventiLavoratore(string username, string username_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoEventiLavoratore", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoEventiLavoratoreResponse")]
        System.Threading.Tasks.Task<ServerAziendaleDB.Modelli.EventoSRV[]> GetElencoEventiLavoratoreAsync(string username, string username_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetStoricoEventi", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetStoricoEventiResponse")]
        ServerAziendaleDB.Modelli.EventoSRV[] GetStoricoEventi(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetStoricoEventi", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetStoricoEventiResponse")]
        System.Threading.Tasks.Task<ServerAziendaleDB.Modelli.EventoSRV[]> GetStoricoEventiAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/CreaProgetto", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/CreaProgettoResponse")]
        bool CreaProgetto(string username, ServerAziendaleDB.Modelli.ProgettoSRV nuovoProgetto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/CreaProgetto", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/CreaProgettoResponse")]
        System.Threading.Tasks.Task<bool> CreaProgettoAsync(string username, ServerAziendaleDB.Modelli.ProgettoSRV nuovoProgetto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaProgetto", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaProgettoResponse")]
        bool AggiornaProgetto(string username, [System.ServiceModel.MessageParameterAttribute(Name="aggiornaProgetto")] ServerAziendaleDB.Modelli.ProgettoSRV aggiornaProgetto1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaProgetto", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/AggiornaProgettoResponse")]
        System.Threading.Tasks.Task<bool> AggiornaProgettoAsync(string username, ServerAziendaleDB.Modelli.ProgettoSRV aggiornaProgetto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/EliminaProgetto", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/EliminaProgettoResponse")]
        bool EliminaProgetto(string username, string codice, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/EliminaProgetto", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/EliminaProgettoResponse")]
        System.Threading.Tasks.Task<bool> EliminaProgettoAsync(string username, string codice, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoProgetti", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoProgettiResponse")]
        string GetElencoProgetti(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoProgetti", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoProgettiResponse")]
        System.Threading.Tasks.Task<string> GetElencoProgettiAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoProgettiLavoratore", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoProgettiLavoratoreResponse")]
        string GetElencoProgettiLavoratore(string username, string username_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoProgettiLavoratore", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoProgettiLavoratoreResponse")]
        System.Threading.Tasks.Task<string> GetElencoProgettiLavoratoreAsync(string username, string username_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetStoricoProgetti", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetStoricoProgettiResponse")]
        string GetStoricoProgetti(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetStoricoProgetti", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetStoricoProgettiResponse")]
        System.Threading.Tasks.Task<string> GetStoricoProgettiAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoObiettivi", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoObiettiviResponse")]
        string GetElencoObiettivi(string username, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoObiettivi", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoObiettiviResponse")]
        System.Threading.Tasks.Task<string> GetElencoObiettiviAsync(string username, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/AggiungiObiettivo", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/AggiungiObiettivoResponse")]
        bool AggiungiObiettivo(string username, ServerAziendaleDB.Modelli.ObiettivoSRV nuovoObiettivo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/AggiungiObiettivo", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/AggiungiObiettivoResponse")]
        System.Threading.Tasks.Task<bool> AggiungiObiettivoAsync(string username, ServerAziendaleDB.Modelli.ObiettivoSRV nuovoObiettivo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/ModificaObiettivo", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/ModificaObiettivoResponse")]
        bool ModificaObiettivo(string username, ServerAziendaleDB.Modelli.ObiettivoSRV aggiornaObiettivo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/ModificaObiettivo", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/ModificaObiettivoResponse")]
        System.Threading.Tasks.Task<bool> ModificaObiettivoAsync(string username, ServerAziendaleDB.Modelli.ObiettivoSRV aggiornaObiettivo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/EliminaObiettivo", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/EliminaObiettivoResponse")]
        bool EliminaObiettivo(string username, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/EliminaObiettivo", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/EliminaObiettivoResponse")]
        System.Threading.Tasks.Task<bool> EliminaObiettivoAsync(string username, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoPartecipantiAttivita", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoPartecipantiAttivitaRespons" +
            "e")]
        string GetElencoPartecipantiAttivita(string username, string codice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoPartecipantiAttivita", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/GetElencoPartecipantiAttivitaRespons" +
            "e")]
        System.Threading.Tasks.Task<string> GetElencoPartecipantiAttivitaAsync(string username, string codice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/AggiungiPartecipanteAttivita", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/AggiungiPartecipanteAttivitaResponse" +
            "")]
        bool AggiungiPartecipanteAttivita(string username, string username_in, string codice, string ruolo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/AggiungiPartecipanteAttivita", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/AggiungiPartecipanteAttivitaResponse" +
            "")]
        System.Threading.Tasks.Task<bool> AggiungiPartecipanteAttivitaAsync(string username, string username_in, string codice, string ruolo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/RimuoviPartecipanteAttivita", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/RimuoviPartecipanteAttivitaResponse")]
        bool RimuoviPartecipanteAttivita(string username, string username_in, string codice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDBAgendaAziendale/RimuoviPartecipanteAttivita", ReplyAction="http://tempuri.org/IServiceDBAgendaAziendale/RimuoviPartecipanteAttivitaResponse")]
        System.Threading.Tasks.Task<bool> RimuoviPartecipanteAttivitaAsync(string username, string username_in, string codice);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceDBAgendaAziendaleChannel : ServerAziendale.SRDBAgendaAziendale.IServiceDBAgendaAziendale, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceDBAgendaAziendaleClient : System.ServiceModel.ClientBase<ServerAziendale.SRDBAgendaAziendale.IServiceDBAgendaAziendale>, ServerAziendale.SRDBAgendaAziendale.IServiceDBAgendaAziendale {
        
        public ServiceDBAgendaAziendaleClient() {
        }
        
        public ServiceDBAgendaAziendaleClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceDBAgendaAziendaleClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDBAgendaAziendaleClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDBAgendaAziendaleClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void TestConnessione() {
            base.Channel.TestConnessione();
        }
        
        public System.Threading.Tasks.Task TestConnessioneAsync() {
            return base.Channel.TestConnessioneAsync();
        }
        
        public bool Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public ServerAziendaleDB.Modelli.LavoratoreSRV GetInfoLavoratore(string username, string username_cercato) {
            return base.Channel.GetInfoLavoratore(username, username_cercato);
        }
        
        public System.Threading.Tasks.Task<ServerAziendaleDB.Modelli.LavoratoreSRV> GetInfoLavoratoreAsync(string username, string username_cercato) {
            return base.Channel.GetInfoLavoratoreAsync(username, username_cercato);
        }
        
        public bool InserisciLavoratore(string username, ServerAziendaleDB.Modelli.LavoratoreSRV nuovoLavoratore) {
            return base.Channel.InserisciLavoratore(username, nuovoLavoratore);
        }
        
        public System.Threading.Tasks.Task<bool> InserisciLavoratoreAsync(string username, ServerAziendaleDB.Modelli.LavoratoreSRV nuovoLavoratore) {
            return base.Channel.InserisciLavoratoreAsync(username, nuovoLavoratore);
        }
        
        public bool AggiornaLavoratore(string username, ServerAziendaleDB.Modelli.LavoratoreSRV aggiornaLavoratore1) {
            return base.Channel.AggiornaLavoratore(username, aggiornaLavoratore1);
        }
        
        public System.Threading.Tasks.Task<bool> AggiornaLavoratoreAsync(string username, ServerAziendaleDB.Modelli.LavoratoreSRV aggiornaLavoratore) {
            return base.Channel.AggiornaLavoratoreAsync(username, aggiornaLavoratore);
        }
        
        public bool AggiornaPassword(string username, string username_in, string password) {
            return base.Channel.AggiornaPassword(username, username_in, password);
        }
        
        public System.Threading.Tasks.Task<bool> AggiornaPasswordAsync(string username, string username_in, string password) {
            return base.Channel.AggiornaPasswordAsync(username, username_in, password);
        }
        
        public bool EliminaLavoratore(string username, string username_in) {
            return base.Channel.EliminaLavoratore(username, username_in);
        }
        
        public System.Threading.Tasks.Task<bool> EliminaLavoratoreAsync(string username, string username_in) {
            return base.Channel.EliminaLavoratoreAsync(username, username_in);
        }
        
        public ServerAziendaleDB.Modelli.LavoratoreSRV[] GetElencoLavoratori(string username) {
            return base.Channel.GetElencoLavoratori(username);
        }
        
        public System.Threading.Tasks.Task<ServerAziendaleDB.Modelli.LavoratoreSRV[]> GetElencoLavoratoriAsync(string username) {
            return base.Channel.GetElencoLavoratoriAsync(username);
        }
        
        public string GetElencoLavoratoriToString(string username) {
            return base.Channel.GetElencoLavoratoriToString(username);
        }
        
        public System.Threading.Tasks.Task<string> GetElencoLavoratoriToStringAsync(string username) {
            return base.Channel.GetElencoLavoratoriToStringAsync(username);
        }
        
        public bool CreaEvento(string username, ServerAziendaleDB.Modelli.EventoSRV nuovoEvento) {
            return base.Channel.CreaEvento(username, nuovoEvento);
        }
        
        public System.Threading.Tasks.Task<bool> CreaEventoAsync(string username, ServerAziendaleDB.Modelli.EventoSRV nuovoEvento) {
            return base.Channel.CreaEventoAsync(username, nuovoEvento);
        }
        
        public bool AggiornaEvento(string username, ServerAziendaleDB.Modelli.EventoSRV aggiornaEvento1) {
            return base.Channel.AggiornaEvento(username, aggiornaEvento1);
        }
        
        public System.Threading.Tasks.Task<bool> AggiornaEventoAsync(string username, ServerAziendaleDB.Modelli.EventoSRV aggiornaEvento) {
            return base.Channel.AggiornaEventoAsync(username, aggiornaEvento);
        }
        
        public bool EliminaEvento(string username, string codice, string id) {
            return base.Channel.EliminaEvento(username, codice, id);
        }
        
        public System.Threading.Tasks.Task<bool> EliminaEventoAsync(string username, string codice, string id) {
            return base.Channel.EliminaEventoAsync(username, codice, id);
        }
        
        public ServerAziendaleDB.Modelli.EventoSRV[] GetElencoEventi(string username) {
            return base.Channel.GetElencoEventi(username);
        }
        
        public System.Threading.Tasks.Task<ServerAziendaleDB.Modelli.EventoSRV[]> GetElencoEventiAsync(string username) {
            return base.Channel.GetElencoEventiAsync(username);
        }
        
        public ServerAziendaleDB.Modelli.EventoSRV[] GetElencoEventiLavoratore(string username, string username_in) {
            return base.Channel.GetElencoEventiLavoratore(username, username_in);
        }
        
        public System.Threading.Tasks.Task<ServerAziendaleDB.Modelli.EventoSRV[]> GetElencoEventiLavoratoreAsync(string username, string username_in) {
            return base.Channel.GetElencoEventiLavoratoreAsync(username, username_in);
        }
        
        public ServerAziendaleDB.Modelli.EventoSRV[] GetStoricoEventi(string username) {
            return base.Channel.GetStoricoEventi(username);
        }
        
        public System.Threading.Tasks.Task<ServerAziendaleDB.Modelli.EventoSRV[]> GetStoricoEventiAsync(string username) {
            return base.Channel.GetStoricoEventiAsync(username);
        }
        
        public bool CreaProgetto(string username, ServerAziendaleDB.Modelli.ProgettoSRV nuovoProgetto) {
            return base.Channel.CreaProgetto(username, nuovoProgetto);
        }
        
        public System.Threading.Tasks.Task<bool> CreaProgettoAsync(string username, ServerAziendaleDB.Modelli.ProgettoSRV nuovoProgetto) {
            return base.Channel.CreaProgettoAsync(username, nuovoProgetto);
        }
        
        public bool AggiornaProgetto(string username, ServerAziendaleDB.Modelli.ProgettoSRV aggiornaProgetto1) {
            return base.Channel.AggiornaProgetto(username, aggiornaProgetto1);
        }
        
        public System.Threading.Tasks.Task<bool> AggiornaProgettoAsync(string username, ServerAziendaleDB.Modelli.ProgettoSRV aggiornaProgetto) {
            return base.Channel.AggiornaProgettoAsync(username, aggiornaProgetto);
        }
        
        public bool EliminaProgetto(string username, string codice, string id) {
            return base.Channel.EliminaProgetto(username, codice, id);
        }
        
        public System.Threading.Tasks.Task<bool> EliminaProgettoAsync(string username, string codice, string id) {
            return base.Channel.EliminaProgettoAsync(username, codice, id);
        }
        
        public string GetElencoProgetti(string username) {
            return base.Channel.GetElencoProgetti(username);
        }
        
        public System.Threading.Tasks.Task<string> GetElencoProgettiAsync(string username) {
            return base.Channel.GetElencoProgettiAsync(username);
        }
        
        public string GetElencoProgettiLavoratore(string username, string username_in) {
            return base.Channel.GetElencoProgettiLavoratore(username, username_in);
        }
        
        public System.Threading.Tasks.Task<string> GetElencoProgettiLavoratoreAsync(string username, string username_in) {
            return base.Channel.GetElencoProgettiLavoratoreAsync(username, username_in);
        }
        
        public string GetStoricoProgetti(string username) {
            return base.Channel.GetStoricoProgetti(username);
        }
        
        public System.Threading.Tasks.Task<string> GetStoricoProgettiAsync(string username) {
            return base.Channel.GetStoricoProgettiAsync(username);
        }
        
        public string GetElencoObiettivi(string username, string id) {
            return base.Channel.GetElencoObiettivi(username, id);
        }
        
        public System.Threading.Tasks.Task<string> GetElencoObiettiviAsync(string username, string id) {
            return base.Channel.GetElencoObiettiviAsync(username, id);
        }
        
        public bool AggiungiObiettivo(string username, ServerAziendaleDB.Modelli.ObiettivoSRV nuovoObiettivo) {
            return base.Channel.AggiungiObiettivo(username, nuovoObiettivo);
        }
        
        public System.Threading.Tasks.Task<bool> AggiungiObiettivoAsync(string username, ServerAziendaleDB.Modelli.ObiettivoSRV nuovoObiettivo) {
            return base.Channel.AggiungiObiettivoAsync(username, nuovoObiettivo);
        }
        
        public bool ModificaObiettivo(string username, ServerAziendaleDB.Modelli.ObiettivoSRV aggiornaObiettivo) {
            return base.Channel.ModificaObiettivo(username, aggiornaObiettivo);
        }
        
        public System.Threading.Tasks.Task<bool> ModificaObiettivoAsync(string username, ServerAziendaleDB.Modelli.ObiettivoSRV aggiornaObiettivo) {
            return base.Channel.ModificaObiettivoAsync(username, aggiornaObiettivo);
        }
        
        public bool EliminaObiettivo(string username, string id) {
            return base.Channel.EliminaObiettivo(username, id);
        }
        
        public System.Threading.Tasks.Task<bool> EliminaObiettivoAsync(string username, string id) {
            return base.Channel.EliminaObiettivoAsync(username, id);
        }
        
        public string GetElencoPartecipantiAttivita(string username, string codice) {
            return base.Channel.GetElencoPartecipantiAttivita(username, codice);
        }
        
        public System.Threading.Tasks.Task<string> GetElencoPartecipantiAttivitaAsync(string username, string codice) {
            return base.Channel.GetElencoPartecipantiAttivitaAsync(username, codice);
        }
        
        public bool AggiungiPartecipanteAttivita(string username, string username_in, string codice, string ruolo) {
            return base.Channel.AggiungiPartecipanteAttivita(username, username_in, codice, ruolo);
        }
        
        public System.Threading.Tasks.Task<bool> AggiungiPartecipanteAttivitaAsync(string username, string username_in, string codice, string ruolo) {
            return base.Channel.AggiungiPartecipanteAttivitaAsync(username, username_in, codice, ruolo);
        }
        
        public bool RimuoviPartecipanteAttivita(string username, string username_in, string codice) {
            return base.Channel.RimuoviPartecipanteAttivita(username, username_in, codice);
        }
        
        public System.Threading.Tasks.Task<bool> RimuoviPartecipanteAttivitaAsync(string username, string username_in, string codice) {
            return base.Channel.RimuoviPartecipanteAttivitaAsync(username, username_in, codice);
        }
    }
}
