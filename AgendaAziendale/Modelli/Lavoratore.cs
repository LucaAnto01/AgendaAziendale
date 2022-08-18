using ServerAziendaleDB.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaAziendale.Modelli
{
    public class Lavoratore
    {
        #region Attributi
        private string username;
        private string password;
        private string nome;
        private string cognome;
        private string residenza;
        private DateTime dataNascita;
        private string email; //Generata automaticamente in fase di creazione
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
        /// <param name="categoria"></param>
        public Lavoratore(string username, string password, string nome, string cognome, string residenza, DateTime dataNascita, string categoria)
        {
            this.username = username;
            this.password = password;
            this.nome = nome;
            this.cognome = cognome;
            this.residenza = residenza;
            this.dataNascita = dataNascita;
            GeneraEmail(username, cognome);
            this.categoria = categoria;
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

        #region Metodi
        /// <summary>
        /// Metodo per generare la mail personale di ciascun utente
        /// --> si è già sicuri che non ci sia nel db essendo basata sull'username
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cognome"></param>
        /// <returns></returns>
        public static string GeneraEmail(string username, string cognome)
        {
            try
            {
                return username.ToLower() + "." + cognome.ToLower() + "@agendaaziendale.it";
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo GeneraEmail: errore istanziazione", "Metodo GeneraEmail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return "";
        }

        /// <summary>
        /// Metodo adibido all'effetuazione dell'hashing della password
        /// </summary>
        /// <param name="passowrd"></param>
        /// <returns></returns>
        public static string PasswordHashing(string passowrd)
        {
            try
            {
                ///Effettuo l'hashing in SHA256 della password
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(passowrd)); ///Converto la stringa in un array di byte

                                                                                             ///Converto l'array di byte nella stringa hashata 
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2")); ///ToString("x2") --> solo caratteri (lettere minuscole + numeri)
                    }
                    return builder.ToString();
                }
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo PasswordHashing: errore errore hash password", "Metodo PasswordHashing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return "";
        }

        /// <summary>
        /// Metodo per convertire un lavotatoreSRV a Lavoratore
        /// </summary>
        /// <param name="lavoratoreSrv"></param>
        /// <returns></returns>
        public static Lavoratore FromLavoratoreSRVToLavoratore(LavoratoreSRV lavoratoreSrv)
        {
            return new Lavoratore(lavoratoreSrv.Username, lavoratoreSrv.Password, lavoratoreSrv.Nome, lavoratoreSrv.Cognome, lavoratoreSrv.Residenza, lavoratoreSrv.DataNascita, lavoratoreSrv.Categoria);
        }

        /// <summary>
        /// Metodo per convertire una lista di lavotatoreSRV in una lista di Lavoratore
        /// </summary>
        /// <param name="lavoratoreSrv"></param>
        /// <returns></returns>
        public static List<Lavoratore> FromLavoratoreSRVToLavoratore(List<LavoratoreSRV> lavoratoriSrv)
        {
            List<Lavoratore> elencoLavoratori = new List<Lavoratore>();

            foreach(LavoratoreSRV lavoratoreSrv in lavoratoriSrv)
            {
                elencoLavoratori.Add(new Lavoratore(lavoratoreSrv.Username, lavoratoreSrv.Password, lavoratoreSrv.Nome, lavoratoreSrv.Cognome, lavoratoreSrv.Residenza, lavoratoreSrv.DataNascita, lavoratoreSrv.Categoria));
            }

            return elencoLavoratori;
        }

        /// <summary>
        /// Metodo adibito alla creazione di un Lavoratore sulla base di una stringa formattata dato-dato-...
        /// </summary>
        /// <param name="info"></param>
        /// <returns>Lavoratore</returns>
        public static Lavoratore GeneraLavoratore(string info)
        {
            Lavoratore lavoratore = new Lavoratore();

            try
            {
                List<string> informazioni = info.Split('-').ToList();

                lavoratore.Username = informazioni.ElementAt(0);
                lavoratore.Password = informazioni.ElementAt(1);
                lavoratore.Nome = informazioni.ElementAt(2);
                lavoratore.Cognome = informazioni.ElementAt(3);
                lavoratore.Residenza = informazioni.ElementAt(4);
                lavoratore.DataNascita = DateTime.Parse(informazioni.ElementAt(5));
                lavoratore.Email = informazioni.ElementAt(6);
                lavoratore.Categoria = informazioni.ElementAt(7);
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo GeneraLavoratore: errore errore istanziazione", "Metodo GeneraLavoratore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return lavoratore;
        }

        /// <summary>
        /// Metodo adibito alla creazione di una lista di Lavoratore sulla base di una stringa formattata dato-dato-...\n...
        /// </summary>
        /// <param name="elenco"></param>
        /// <returns>List<Lavoratore></returns>
        public static List<Lavoratore> GeneraElencoLavoratori(string elenco)
        {
            List<Lavoratore> elencoLavoratori = new List<Lavoratore>();

            try
            {
                List<string> lavoratori_info = elenco.Split('\n').ToList(); ///Splitto l'elenco al fine di avere per ogni elemento le informazioni di ogni lavoratore

                lavoratori_info.RemoveAt((lavoratori_info.Count - 1)); ///A causa dello split l'ultimo elemento rimane vuoto --> ""

                foreach (string lavoratore_info in lavoratori_info) ///Popolo la lista dei lavoratori
                    elencoLavoratori.Add(GeneraLavoratore(lavoratore_info));
            }
            
            catch
            {
                MessageBox.Show("ERRORE! Metodo GeneraElencoLavoratori: errore errore istanziazione", "Metodo GeneraElencoLavoratori", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return elencoLavoratori;
        }
        #endregion
    }
}
