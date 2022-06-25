using ServerAziendaleDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerAziendale.SRDBAgendaAziendale;

namespace ServerAziendale.Modelli
{
    public static class Sessione
    {
        #region Attributi
        private static ServiceDBAgendaAziendaleClient serverAziendaleDB;
        #endregion

        #region Getters & Setters
        public static ServiceDBAgendaAziendaleClient ServerAziendaleDB { get => serverAziendaleDB; set => serverAziendaleDB = value; }
        #endregion

    }
}
