﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;

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

                Console.WriteLine("Servizio aperto. Premere un tasto per inetrrompere...");
                Console.ReadLine();

                svcHost.Close();
                Console.WriteLine("Servizio chiuso.");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Errore: " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
