using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ServerAziendaleDB.Modelli
{
    public static class InterazioneDB
    {
        #region Attributi
        private static readonly string connectionString = ConfigurationManager.AppSettings["connectionString"];
        private static MySqlConnection connessione = null;
        #endregion

        #region Getters & Setters
        public static string ConnectionString => connectionString;
        public static MySqlConnection Connessione { get => connessione; set => connessione = value; }
        #endregion

        #region Metodi
        /// <summary>
        /// Metodo adibito all'esecuzione di una query che prevede la lettura di valori dal db
        /// --> può restituire null
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static bool EseguiQuery_Lettura(string query)
        {
            try
            {
                using (MySqlCommand cmd = Connessione.CreateCommand())
                {
                    cmd.CommandText = query;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        int cont = 0;

                        while (reader.Read())
                            cont++;

                        if (cont != 0)
                            return true;

                        else
                            return false;
                    }
                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Metodo EseguiQuery_Lettura in InterazioneDB: " + ex.ToString());
                Console.ReadLine();
            }

            return false;
        }

        /// <summary>
        /// Metodo adibito all'esecuzione di una query che preveda l'ottenimento di dati
        /// --> dati formattati
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static string EseguiQuery_GetInfo(string query)
        {
            try
            {
                if (EseguiQuery_Lettura(query)) ///Controllo che la query abbia un qualche riscontro per evitare di farne a vuoto
                {
                    using (MySqlCommand cmd = Connessione.CreateCommand())
                    {
                        cmd.CommandText = query;
                        string result = "";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for(int i = 0; i < reader.FieldCount; i++)
                                    result += reader[i].ToString() + "-";

                                result += "\n";
                            }

                            return result;
                        }
                    }
                }

                else
                    return "";
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Metodo EseguiQuery_GetInfo in InterazioneDB: " + ex.ToString());
                Console.ReadLine();
            }

            return "";
        }

        /// <summary>
        /// Metodo adibito all'esecuzione di query adibite all'inserimento di dati nel DB
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static bool EseguiQueryInserimento(string query)
        {
            List<string> queries = new List<string>();
            queries.Add(query);

            if (EseguiTransazione(queries))
                return true;

            return false;
        }

        /// <summary>
        /// Metodo adibito all'esecuzione di una transazione
        /// </summary>
        /// <param name="queries"></param>
        /// <returns></returns>
        private static bool EseguiTransazione(List<string> queries)
        {
            MySqlTransaction transaction = null;

            try
            {
                transaction = Connessione.BeginTransaction();

                List<MySqlCommand> commands = new List<MySqlCommand>();

                foreach (string query in queries)
                {
                    MySqlCommand cmd = Connessione.CreateCommand();
                    cmd.CommandText = query;
                    commands.Add(cmd);
                }

                foreach (MySqlCommand cmd in commands)
                    cmd.ExecuteNonQuery();

                transaction.Commit();

                return true;
            }

            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("ERRORE!!! Metodo EseguiTransazione in InterazioneDB: " + ex.ToString());
                Console.ReadLine();
            }

            return false;
        }
        #endregion
    }
}
