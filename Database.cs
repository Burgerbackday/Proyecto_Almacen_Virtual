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
                            Puntuaje = reader.GetInt32(4),
                            Tema = reader.IsDBNull(5) ? "" : reader.GetString(5)  // NUEVO
                        });
                    }
                }
            }

            return list;
        }




        // Crear un nuevo jugador
        public int CrearJugador(string noControl, string nombre, string apellidos)
        {
            using (var conn = Open())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO JUGADOR (NoControl, Nombre, Apellidos, PuntuajeTotal) 
                           VALUES (@noControl, @nombre, @apellidos, 0);
                           SELECT last_insert_rowid();";

                cmd.Parameters.AddWithValue("@noControl", noControl);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellidos", apellidos);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Guardar respuesta del jugador
        public void GuardarRespuesta(int jugadorId, int preguntaId, string respuesta, bool esCorrecta)
        {
            using (var conn = Open())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO RESPUESTA_JUGADOR 
                           (RespuestaTexto, Acierto, JugadorId, PreguntaId) 
                           VALUES (@respuesta, @acierto, @jugadorId, @preguntaId)";

                cmd.Parameters.AddWithValue("@respuesta", respuesta);
                cmd.Parameters.AddWithValue("@jugadorId", jugadorId);
                cmd.Parameters.AddWithValue("@preguntaId", preguntaId);
                cmd.Parameters.AddWithValue("@acierto", esCorrecta ? 1 : 0);  // Convierte bool a int

                cmd.ExecuteNonQuery();
            }
        }

        // Actualizar puntaje total del jugador
        public void ActualizarPuntaje(int jugadorId, int puntajeTotal)
        {
            using (var conn = Open())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE JUGADOR SET PuntuajeTotal = @puntaje WHERE Id = @id";

                cmd.Parameters.AddWithValue("@puntaje", puntajeTotal);
                cmd.Parameters.AddWithValue("@id", jugadorId);

                cmd.ExecuteNonQuery();
            }
        }

        // Obtener respuestas de un jugador
        public List<RespuestaJugador> GetRespuestasJugador(int jugadorId)
        {
            var list = new List<RespuestaJugador>();

            using (var conn = Open())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM RESPUESTA_JUGADOR WHERE JugadorId = @jugadorId";
                cmd.Parameters.AddWithValue("@jugadorId", jugadorId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new RespuestaJugador()
                        {
                            Id = reader.GetInt32(0),
                            RespuestaJugadorTexto = reader.GetString(1),
                            JugadorId = reader.GetInt32(2),
                            PreguntaId = reader.GetInt32(3),
                            Acierto = reader.IsDBNull(4) ? false : reader.GetInt32(4) == 1  // Lee como int y convierte a bool
                        });
                    }
                }
            }

            return list;
        }


    }
}
