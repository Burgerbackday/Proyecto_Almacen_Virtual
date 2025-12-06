using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Data;

namespace PrototipoCuestionario
{
    public class Database
    {
        private readonly string _connectionString;

        public Database(string path)
        {
            _connectionString = "Data Source=" + path;
        }

        private SqliteConnection Open()
        {
            var conn = new SqliteConnection(_connectionString);
            conn.Open();
            return conn;
        }

        public List<Pregunta> GetPreguntas()
        {
            var list = new List<Pregunta>();

            using (var conn = Open())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM PREGUNTA";

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Pregunta()
                        {
                            Id = reader.GetInt32(0),
                            Texto = reader.GetString(1),
                            RespuestaCorrecta = reader.GetString(2),
                            Area = reader.GetString(3),
                            Puntuaje = reader.GetInt32(4)
                        });
                    }
                }
            }

            return list;
        }
    }
}
