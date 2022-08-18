using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerAziendaleDB.Modelli
{
    /// <summary>
    /// Classe Lavoratore server
    /// </summary>
    public class LavoratoreSRV
    {
        #region Attributi
        private string username;
        private string password;
        private string nome;
        private string cognome;
        private string residenza;
        private DateTime dataNascita;
        private string email;
        private string categoria;
        #endregion

        #region Metodi costruttori
        /// <summary>
        /// Metodo costruttore della classe LavoratoreSRV
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="residenza"></param>
        /// <param name="dataNascita"></param>
        /// <param name="email"></param>
        /// <param name="categoria"></param>
        public LavoratoreSRV(string username, string password, string nome, string cognome, string residenza, DateTime dataNascita, string email, string categoria)
        {
            Username = username;
            Password = password;
            Nome = nome;
            Cognome= cognome;
            Residenza = residenza;
            DataNascita = dataNascita;
            Email = email;
            Categoria = categoria;
        }

        /// <summary>
        /// Metodo costruttore vuoto della classe LavoratoreSRV
        /// </summary>
        public LavoratoreSRV() { }
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
        /// Metodo adibito alla creazione di un Lavoratore sulla base di una stringa formattata dato-dato-...
        /// </summary>
        /// <param name="info"></param>
        /// <returns>LavoratoreSRV</returns>
        public static LavoratoreSRV GeneraLavoratore(string info)
        {
            LavoratoreSRV lavoratore = new LavoratoreSRV();

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
        /// <returns>List<LavoratoreSRV></returns>
        public static List<LavoratoreSRV> GeneraElencoLavoratori(string elenco)
        {
            List<LavoratoreSRV> elencoLavoratori = new List<LavoratoreSRV>();

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
