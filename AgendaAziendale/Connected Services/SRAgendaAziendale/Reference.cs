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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoLavoratori", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoLavoratoriResponse")]
        string GetElencoLavoratori(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAgendaAziendale/GetElencoLavoratori", ReplyAction="http://tempuri.org/IServiceAgendaAziendale/GetElencoLavoratoriResponse")]
        System.Threading.Tasks.Task<string> GetElencoLavoratoriAsync(string username);
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
        
        public string GetElencoLavoratori(string username) {
            return base.Channel.GetElencoLavoratori(username);
        }
        
        public System.Threading.Tasks.Task<string> GetElencoLavoratoriAsync(string username) {
            return base.Channel.GetElencoLavoratoriAsync(username);
        }
    }
}
