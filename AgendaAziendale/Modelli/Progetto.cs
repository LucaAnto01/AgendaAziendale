﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAziendale.Modelli
{
    public class Progetto : Attivita
    {
        #region Attributi
        private int id;
        private string cliente;
        private List<Obiettivo> obiettivi;
        #endregion

        #region Metodi e costruttori
        /// <summary>
        /// Metodo costruttore della classe Progetto
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="referente"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="id"></param>
        /// <param name="cliente"></param>
        /// <param name="obiettivi"></param>
        public Progetto(string codice, Lavoratore referente, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, int id, string cliente, List<Obiettivo> obiettivi) : base(codice, referente, nome, descrizione, dataInizio, dataFine)
        {
            Id = id;
            Cliente = cliente;
            Obiettivi = obiettivi;
        }
        /// <summary>
        /// Metodo costruttore della classe Progetto
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="referente"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="id"></param>
        /// <param name="cliente"></param>
        public Progetto(string codice, Lavoratore referente, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, int id, string cliente) : base(codice, referente, nome, descrizione, dataInizio, dataFine)
        {
            Id = id;
            Cliente = cliente;
            obiettivi = new List<Obiettivo>();
        }

        /// <summary>
        /// Metodo costruttore vuoto della classe Progetto
        /// </summary>
        public Progetto() { }

        /// <summary>
        /// Metodo per aggiungere un nuovo obiettivo alla lista di obiettivi
        /// </summary>
        /// <param name="obiettivo"></param>
        public void AggiungiObiettivo(Obiettivo obiettivo)
        {
            obiettivi.Add(obiettivo);
        }
        #endregion

        #region Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public List<Obiettivo> Obiettivi { get => obiettivi; set => obiettivi = value; }
        #endregion
    }
}
