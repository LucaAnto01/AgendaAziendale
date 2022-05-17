﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAziendale.Modelli
{
    public class Evento : Attivita
    {
        #region Attributi
        private int id;
        private string luogo;
        #endregion

        #region Metodi e costruttori
        /// <summary>
        /// Metodo costruttore della classe Evento
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="nome"></param>
        /// <param name="descrizione"></param>
        /// <param name="dataInizio"></param>
        /// <param name="dataFine"></param>
        /// <param name="id"></param>
        /// <param name="luogo"></param>
        public Evento(string codice, string nome, string descrizione, DateTime dataInizio, DateTime dataFine, int id, string luogo) : base(codice, nome, descrizione, dataInizio, dataFine)
        {
            Id = id;
            Luogo = luogo;
        }

        /// <summary>
        /// Metodo costruttore vuoto della classe Evento
        /// </summary>
        public Evento() { }

        /// <summary>
        /// Metodo per verificare che un evento sia ancora in corso o se è già terminato
        /// --> true: terminato
        /// --> false: ancora in corso
        /// </summary>
        /// <returns>bool</returns>
        public bool IsTerminato()
        {
            if(DataFine < DateTime.Now)
                return true;

            return false;
        }

        /// <summary>
        /// Metodo che restituisce la durata dell'evento in termini di giorni
        /// </summary>
        /// <returns></returns>
        public int Durata()
        {
            return  (int)(DataFine - DataInizio).TotalDays;
        }
        #endregion

        #region Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Luogo { get => luogo; set => luogo = value; }
        #endregion
    }
}
