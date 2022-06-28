using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaAziendale.SRAgendaAziendale;

namespace AgendaAziendale.Modelli
{
    /// <summary>
    /// Classe statica adibita all'utilizzo di una simil-sessione
    /// I dati vengono settati una volta effettuata la fase di login
    /// </summary>
    public static class Sessione
    {
        #region Attributi
        private static Lavoratore lavoratore;
        private static readonly string salt = "unipr";
        private static readonly string regex = "^[a-zA-Z0-9_.,:;?! ]+$";
        private static ServiceAgendaAziendaleClient serverAziendale;
        #endregion

        #region Getters & Setters
        public static Lavoratore Lavoratore { get => lavoratore; set => lavoratore = value; }
        public static string Regex => regex;
        public static string Salt { get => salt; }
        public static ServiceAgendaAziendaleClient ServerAziendale { get => serverAziendale; set => serverAziendale = value; }

        #endregion
    }
}
