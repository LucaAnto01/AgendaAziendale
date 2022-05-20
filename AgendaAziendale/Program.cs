using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaAziendale.Forms;
using AgendaAziendale.Modelli;

namespace AgendaAziendale
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Sessione.ServerAziendale = new SRAgendaAziendale.ServiceAgendaAziendaleClient(); //Istanziazione client per comunicazione con ServerAziendale
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
