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
            try
            {
                Sessione.ServerAziendale = new SRAgendaAziendale.ServiceAgendaAziendaleClient(); //Istanziazione client per comunicazione con ServerAziendale
                //TODO: RIMUOVI COMMENTOOO Sessione.ServerAziendale.TestConnessione(); //Test connessione al server al fine di verificarne il funzionamento

                ///Avvio software
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormLogin());
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRORE! ServerAziendale: " + ex.Message, "ServerAziendale da funzione Main", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
