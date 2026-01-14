namespace PrototipoCuestionario
{
    class Program
    {
        static void Main()
        {
            Database db = new Database("database.db");

            // Solicitar datos del jugador
            Console.WriteLine("=== Cuestionario de Almacén Virtual ===");
            Console.Write("Número de control: ");
            string noControl = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellidos: ");
            string apellidos = Console.ReadLine();

            // Crear jugador en la base de datos
            int jugadorId = db.CrearJugador(noControl, nombre, apellidos);
            Console.WriteLine($"\n¡Bienvenido, {nombre} {apellidos}!\n");

            var preguntas = db.GetPreguntas();
            QuizService servicio = new QuizService(preguntas);

            int score = 0;
            Pregunta p;

            while ((p = servicio.SiguientePregunta()) != null)
            {
                Console.WriteLine($"\nPregunta ({p.Area} - {p.Tema}): {p.Texto}");
                Console.WriteLine("Tu respuesta: ");
                var r = Console.ReadLine();

                // Permitir salir
                if (r?.ToLower() == "salir" || r?.ToLower() == "exit")
                {
                    Console.WriteLine("\n=== CUESTIONARIO INTERRUMPIDO ===");
                    Console.WriteLine($"Score parcial: {score}");

                    // Guardar puntaje parcial
                    db.ActualizarPuntaje(jugadorId, score);
                    return;
                }

                if (servicio.Verificar(p, r, out int puntos))
                {
                    score += puntos;
                    Console.WriteLine("Correcto! +" + puntos);

                    // Guardar respuesta correcta
                    db.GuardarRespuesta(jugadorId, p.Id, r, true);
                }
                else
                {
                    Console.WriteLine("Incorrecto.");

                    // Guardar respuesta incorrecta
                    db.GuardarRespuesta(jugadorId, p.Id, r, false);
                }

                Console.WriteLine("Score actual: " + score);
            }

            // Actualizar puntaje final del jugador
            db.ActualizarPuntaje(jugadorId, score);

            Console.WriteLine("\n=== CUESTIONARIO FINALIZADO ===");
            Console.WriteLine($"Score final: {score}");
            Console.WriteLine($"Jugador: {nombre} {apellidos} ({noControl})");
        }
    }
}