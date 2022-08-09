﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgendaAziendale.SRAgendaAziendale {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SRAgendaAziendale.IServiceAgendaAziendale")]
    public interface IServiceAgendaAziendale {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/TestConnessione", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/TestConnessioneResponse")]
        void TestConnessione();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/TestConnessione", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/TestConnessioneResponse")]
        System.Threading.Tasks.Task TestConnessioneAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/Login", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/LoginResponse")]
        bool Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/Login", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetInfoLavoratore", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetInfoLavoratoreResponse")]
        string GetInfoLavoratore(string username, string username_cercato);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetInfoLavoratore", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetInfoLavoratoreResponse")]
        System.Threading.Tasks.Task<string> GetInfoLavoratoreAsync(string username, string username_cercato);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/InserisciLavoratore", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/InserisciLavoratoreResponse")]
        bool InserisciLavoratore(string username, ServerAziendaleDB.Modelli.LavoratoreSRV nuovoLavoratore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/InserisciLavoratore", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/InserisciLavoratoreResponse")]
        System.Threading.Tasks.Task<bool> InserisciLavoratoreAsync(string username, ServerAziendaleDB.Modelli.LavoratoreSRV nuovoLavoratore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/AggiornaLavoratore", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/AggiornaLavoratoreResponse")]
        bool AggiornaLavoratore(string username, [System.ServiceModel.MessageParameterAttribute(Name="aggiornaLavoratore")] ServerAziendaleDB.Modelli.LavoratoreSRV aggiornaLavoratore1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/AggiornaLavoratore", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/AggiornaLavoratoreResponse")]
        System.Threading.Tasks.Task<bool> AggiornaLavoratoreAsync(string username, ServerAziendaleDB.Modelli.LavoratoreSRV aggiornaLavoratore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/AggiornaPassword", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/AggiornaPasswordResponse")]
        bool AggiornaPassword(string username, string username_in, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/AggiornaPassword", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/AggiornaPasswordResponse")]
        System.Threading.Tasks.Task<bool> AggiornaPasswordAsync(string username, string username_in, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/EliminaLavoratore", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/EliminaLavoratoreResponse")]
        bool EliminaLavoratore(string username, string username_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/EliminaLavoratore", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/EliminaLavoratoreResponse")]
        System.Threading.Tasks.Task<bool> EliminaLavoratoreAsync(string username, string username_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoLavoratori", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoLavoratoriResponse")]
        string GetElencoLavoratori(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoLavoratori", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoLavoratoriResponse")]
        System.Threading.Tasks.Task<string> GetElencoLavoratoriAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/CreaEvento", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/CreaEventoResponse")]
        bool CreaEvento(string username, ServerAziendaleDB.Modelli.EventoSRV nuovoEvento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/CreaEvento", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/CreaEventoResponse")]
        System.Threading.Tasks.Task<bool> CreaEventoAsync(string username, ServerAziendaleDB.Modelli.EventoSRV nuovoEvento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/AggiornaEvento", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/AggiornaEventoResponse")]
        bool AggiornaEvento(string username, [System.ServiceModel.MessageParameterAttribute(Name="aggiornaEvento")] ServerAziendaleDB.Modelli.EventoSRV aggiornaEvento1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/AggiornaEvento", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/AggiornaEventoResponse")]
        System.Threading.Tasks.Task<bool> AggiornaEventoAsync(string username, ServerAziendaleDB.Modelli.EventoSRV aggiornaEvento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/EliminaEvento", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/EliminaEventoResponse")]
        bool EliminaEvento(string username, string codice, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/EliminaEvento", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/EliminaEventoResponse")]
        System.Threading.Tasks.Task<bool> EliminaEventoAsync(string username, string codice, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoEventi", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoEventiResponse")]
        string GetElencoEventi(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoEventi", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoEventiResponse")]
        System.Threading.Tasks.Task<string> GetElencoEventiAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoEventiLavoratore", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoEventiLavoratoreResponse")]
        string GetElencoEventiLavoratore(string username, string username_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoEventiLavoratore", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoEventiLavoratoreResponse")]
        System.Threading.Tasks.Task<string> GetElencoEventiLavoratoreAsync(string username, string username_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetStoricoEventi", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetStoricoEventiResponse")]
        string GetStoricoEventi(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetStoricoEventi", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetStoricoEventiResponse")]
        System.Threading.Tasks.Task<string> GetStoricoEventiAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/CreaProgetto", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/CreaProgettoResponse")]
        bool CreaProgetto(string username, string nome, string descrizione, System.DateTime dataInizio, System.DateTime dataFine, string cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/CreaProgetto", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/CreaProgettoResponse")]
        System.Threading.Tasks.Task<bool> CreaProgettoAsync(string username, string nome, string descrizione, System.DateTime dataInizio, System.DateTime dataFine, string cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/AggiornaProgetto", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/AggiornaProgettoResponse")]
        bool AggiornaProgetto(string username, string codice, string id, string nome, string descrizione, System.DateTime dataInizio, System.DateTime dataFine, string cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/AggiornaProgetto", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/AggiornaProgettoResponse")]
        System.Threading.Tasks.Task<bool> AggiornaProgettoAsync(string username, string codice, string id, string nome, string descrizione, System.DateTime dataInizio, System.DateTime dataFine, string cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/EliminaProgetto", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/EliminaProgettoResponse")]
        bool EliminaProgetto(string username, string codice, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/EliminaProgetto", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/EliminaProgettoResponse")]
        System.Threading.Tasks.Task<bool> EliminaProgettoAsync(string username, string codice, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoProgetti", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoProgettiResponse")]
        string GetElencoProgetti(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoProgetti", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoProgettiResponse")]
        System.Threading.Tasks.Task<string> GetElencoProgettiAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoProgettiLavoratore", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoProgettiLavoratoreResponse")]
        string GetElencoProgettiLavoratore(string username, string username_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoProgettiLavoratore", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoProgettiLavoratoreResponse")]
        System.Threading.Tasks.Task<string> GetElencoProgettiLavoratoreAsync(string username, string username_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetStoricoProgetti", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetStoricoProgettiResponse")]
        string GetStoricoProgetti(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetStoricoProgetti", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetStoricoProgettiResponse")]
        System.Threading.Tasks.Task<string> GetStoricoProgettiAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoObiettivi", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoObiettiviResponse")]
        string GetElencoObiettivi(string username, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoObiettivi", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoObiettiviResponse")]
        System.Threading.Tasks.Task<string> GetElencoObiettiviAsync(string username, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/CalcolaAvanzamento", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/CalcolaAvanzamentoResponse")]
        int CalcolaAvanzamento(string username, int[] obiettivi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/CalcolaAvanzamento", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/CalcolaAvanzamentoResponse")]
        System.Threading.Tasks.Task<int> CalcolaAvanzamentoAsync(string username, int[] obiettivi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/AggiungiObiettivo", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/AggiungiObiettivoResponse")]
        bool AggiungiObiettivo(string username, string id, string descrizione, bool completato);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/AggiungiObiettivo", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/AggiungiObiettivoResponse")]
        System.Threading.Tasks.Task<bool> AggiungiObiettivoAsync(string username, string id, string descrizione, bool completato);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/ModificaObiettivo", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/ModificaObiettivoResponse")]
        bool ModificaObiettivo(string username, string id, string descrizione, bool completato);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/ModificaObiettivo", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/ModificaObiettivoResponse")]
        System.Threading.Tasks.Task<bool> ModificaObiettivoAsync(string username, string id, string descrizione, bool completato);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/EliminaObiettivo", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/EliminaObiettivoResponse")]
        bool EliminaObiettivo(string username, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/EliminaObiettivo", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/EliminaObiettivoResponse")]
        System.Threading.Tasks.Task<bool> EliminaObiettivoAsync(string username, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoPartecipantiAttivita", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoPartecipantiAttivitaResponse")]
        string GetElencoPartecipantiAttivita(string username, string codice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoPartecipantiAttivita", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoPartecipantiAttivitaResponse")]
        System.Threading.Tasks.Task<string> GetElencoPartecipantiAttivitaAsync(string username, string codice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoLavoratoriAttivita", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoLavoratoriAttivitaResponse")]
        string GetElencoLavoratoriAttivita(string username, string codice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoLavoratoriAttivita", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoLavoratoriAttivitaResponse")]
        System.Threading.Tasks.Task<string> GetElencoLavoratoriAttivitaAsync(string username, string codice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/AggiungiPartecipanteAttivita", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/AggiungiPartecipanteAttivitaResponse")]
        bool AggiungiPartecipanteAttivita(string username, string username_in, string codice, string ruolo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/AggiungiPartecipanteAttivita", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/AggiungiPartecipanteAttivitaResponse")]
        System.Threading.Tasks.Task<bool> AggiungiPartecipanteAttivitaAsync(string username, string username_in, string codice, string ruolo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/RimuoviPartecipanteAttivita", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/RimuoviPartecipanteAttivitaResponse")]
        bool RimuoviPartecipanteAttivita(string username, string username_in, string codice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/RimuoviPartecipanteAttivita", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/RimuoviPartecipanteAttivitaResponse")]
        System.Threading.Tasks.Task<bool> RimuoviPartecipanteAttivitaAsync(string username, string username_in, string codice);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAgendaAziendaleChannel : AgendaAziendale.SRAgendaAziendale.IServiceAgendaAziendale, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAgendaAziendaleClient : System.ServiceModel.ClientBase<AgendaAziendale.SRAgendaAziendale.IServiceAgendaAziendale>, AgendaAziendale.SRAgendaAziendale.IServiceAgendaAziendale {
        
        public ServiceAgendaAziendaleClient() {
        }
        
        public ServiceAgendaAziendaleClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAgendaAziendaleClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAgendaAziendaleClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAgendaAziendaleClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public string GetInfoLavoratore(string username, string username_cercato) {
            return base.Channel.GetInfoLavoratore(username, username_cercato);
        }
        
        public System.Threading.Tasks.Task<string> GetInfoLavoratoreAsync(string username, string username_cercato) {
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
        
        public string GetElencoLavoratori(string username) {
            return base.Channel.GetElencoLavoratori(username);
        }
        
        public System.Threading.Tasks.Task<string> GetElencoLavoratoriAsync(string username) {
            return base.Channel.GetElencoLavoratoriAsync(username);
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
        
        public string GetElencoEventi(string username) {
            return base.Channel.GetElencoEventi(username);
        }
        
        public System.Threading.Tasks.Task<string> GetElencoEventiAsync(string username) {
            return base.Channel.GetElencoEventiAsync(username);
        }
        
        public string GetElencoEventiLavoratore(string username, string username_in) {
            return base.Channel.GetElencoEventiLavoratore(username, username_in);
        }
        
        public System.Threading.Tasks.Task<string> GetElencoEventiLavoratoreAsync(string username, string username_in) {
            return base.Channel.GetElencoEventiLavoratoreAsync(username, username_in);
        }
        
        public string GetStoricoEventi(string username) {
            return base.Channel.GetStoricoEventi(username);
        }
        
        public System.Threading.Tasks.Task<string> GetStoricoEventiAsync(string username) {
            return base.Channel.GetStoricoEventiAsync(username);
        }
        
        public bool CreaProgetto(string username, string nome, string descrizione, System.DateTime dataInizio, System.DateTime dataFine, string cliente) {
            return base.Channel.CreaProgetto(username, nome, descrizione, dataInizio, dataFine, cliente);
        }
        
        public System.Threading.Tasks.Task<bool> CreaProgettoAsync(string username, string nome, string descrizione, System.DateTime dataInizio, System.DateTime dataFine, string cliente) {
            return base.Channel.CreaProgettoAsync(username, nome, descrizione, dataInizio, dataFine, cliente);
        }
        
        public bool AggiornaProgetto(string username, string codice, string id, string nome, string descrizione, System.DateTime dataInizio, System.DateTime dataFine, string cliente) {
            return base.Channel.AggiornaProgetto(username, codice, id, nome, descrizione, dataInizio, dataFine, cliente);
        }
        
        public System.Threading.Tasks.Task<bool> AggiornaProgettoAsync(string username, string codice, string id, string nome, string descrizione, System.DateTime dataInizio, System.DateTime dataFine, string cliente) {
            return base.Channel.AggiornaProgettoAsync(username, codice, id, nome, descrizione, dataInizio, dataFine, cliente);
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
        
        public int CalcolaAvanzamento(string username, int[] obiettivi) {
            return base.Channel.CalcolaAvanzamento(username, obiettivi);
        }
        
        public System.Threading.Tasks.Task<int> CalcolaAvanzamentoAsync(string username, int[] obiettivi) {
            return base.Channel.CalcolaAvanzamentoAsync(username, obiettivi);
        }
        
        public bool AggiungiObiettivo(string username, string id, string descrizione, bool completato) {
            return base.Channel.AggiungiObiettivo(username, id, descrizione, completato);
        }
        
        public System.Threading.Tasks.Task<bool> AggiungiObiettivoAsync(string username, string id, string descrizione, bool completato) {
            return base.Channel.AggiungiObiettivoAsync(username, id, descrizione, completato);
        }
        
        public bool ModificaObiettivo(string username, string id, string descrizione, bool completato) {
            return base.Channel.ModificaObiettivo(username, id, descrizione, completato);
        }
        
        public System.Threading.Tasks.Task<bool> ModificaObiettivoAsync(string username, string id, string descrizione, bool completato) {
            return base.Channel.ModificaObiettivoAsync(username, id, descrizione, completato);
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
        
        public string GetElencoLavoratoriAttivita(string username, string codice) {
            return base.Channel.GetElencoLavoratoriAttivita(username, codice);
        }
        
        public System.Threading.Tasks.Task<string> GetElencoLavoratoriAttivitaAsync(string username, string codice) {
            return base.Channel.GetElencoLavoratoriAttivitaAsync(username, codice);
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
