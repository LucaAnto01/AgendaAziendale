using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAziendale.Modelli
{
    /// <summary>
    /// Classe statica adibita all'utilizzo di una simil-sessione
    /// I dati vengono settati una volta effettuata la fase di login
    /// </summary>
    public static class Sessione
    {
        public static string username;
        public static string password;
    }
}
