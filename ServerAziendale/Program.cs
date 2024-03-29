﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;
using ServerAziendale.Modelli;

namespace ServerAziendale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost svcHost = new ServiceHost(typeof(ServiceAgendaAziendale)); //Istanzio il servizio di tipo ServiceAgendaAziendale
                svcHost.Open(); //Apro il servizio

                Console.WriteLine("Servizio ServerAziendale aperto. Premere un tasto per interrompere...");

                Sessione.ServerAziendaleDB = new SRDBAgendaAziendale.ServiceDBAgendaAziendaleClient(); //Istanziazione client per i servizi esposti dal ServerAziendaleDB
                Sessione.ServerAziendaleDB.TestConnessione(); //Test connessione al server DB al fine di verificarne il funzionamento                                                                                  

                Console.WriteLine("Istanzazione client ServerAziendaleDB e test connessione a ServerAziendaleDB effettuata");
                Console.ReadLine();

                svcHost.Close();
                Console.WriteLine("Servizio chiuso.");
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE! In ServerAziendale:" + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
