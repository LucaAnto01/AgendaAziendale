using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAziendale.Modelli
{
    public abstract class Lavoratore
    {
        #region Attributi
        private string username;
        private string password;
        private string nome;
        private string cognome;
        private string residenza;
        private DateTime dataNascita;
        private string email; //Generata automaticamente
        private string categoria;
        #endregion

        #region Metodi costruttori
        /// <summary>
        /// Metodo costruttore della classe Lavoratore
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="residenza"></param>
        /// <param name="dataNascita"></param>
        /// <param name="email"></param>
        /// <param name="categoria"></param>
        public Lavoratore(string username, string password, string nome, string cognome, string residenza, DateTime dataNascita, string email, string categoria)
        {
            Username = username;
            Password = password;
            Nome = nome;
            Cognome = cognome;
            Residenza = residenza;
            DataNascita = dataNascita;
            Email = email;
            Categoria = categoria;
        }

        /// <summary>
        /// Metodo costruttore vuoto della classe Lavoratore
        /// </summary>
        public Lavoratore() { }
        #endregion

        #region Getters & Setters
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Residenza { get => residenza; set => residenza = value; }
        public DateTime DataNascita { get => dataNascita; set => dataNascita = value; }
        public string Email { get => email; set => email = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        #endregion
    }
}
