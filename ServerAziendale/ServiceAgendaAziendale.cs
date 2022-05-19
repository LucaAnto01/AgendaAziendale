using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServerAziendale
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "ServiceAgendaAziendale" nel codice e nel file di configurazione contemporaneamente.
    public class ServiceAgendaAziendale : IServiceAgendaAziendale
    {
        /// <summary>
        /// Funzione che restituisce l'elenco dei lavoratori presenti nel DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetElencoLavoratori(string username, string password)
        {
            return "";
        }
    }
}
