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
        #region Attributi
        private static string username;
        private static string password;
        #endregion

        #region Getters & Setters
        public static string Username { get => username; set => username = value; }
        public static string Password { get => password; set => password = value; }
        #endregion
    }
}
