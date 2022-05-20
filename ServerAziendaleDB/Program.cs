using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServerAziendaleDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                ServiceHost svcHost = new ServiceHost(typeof(ServiceDBAgendaAziendale)); //Istanzio il servizio di tipo ServiceDBAgendaAziendale
                svcHost.Open(); //Apro il servizio

                Console.WriteLine("Servizio ServerDB aperto. Premere un tasto per interrompere...");
                Console.ReadLine();

                svcHost.Close();
                Console.WriteLine("Servizio chiuso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRORE! In ServerDBAziendale:" + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
