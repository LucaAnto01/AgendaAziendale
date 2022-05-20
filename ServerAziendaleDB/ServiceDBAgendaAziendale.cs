using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServerAziendaleDB
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "ServiceDBAgendaAziendale" nel codice e nel file di configurazione contemporaneamente.
    public class ServiceDBAgendaAziendale : IServiceDBAgendaAziendale
    {
        public void DoWork()
        {
            Console.WriteLine("Funzeca il servizio DB");
        }
    }
}
