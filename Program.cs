namespace PrototipoCuestionario
{
    class Program
    {
        static void Main()
        {
            Database db = new Database("database.db");
            var preguntas = db.GetPreguntas();

            QuizService servicio = new QuizService(preguntas);

            int score = 0;
            Pregunta p;

            while ((p = servicio.SiguientePregunta()) != null)
            {
                Console.WriteLine("Pregunta: " + p.Texto);
                Console.WriteLine("Tu respuesta (o escribe 'salir' para terminar): ");
                var r = Console.ReadLine();

                if (r?.ToLower() == "salir" || r?.ToLower() == "exit")
                {
                    Console.WriteLine("Saliendo del cuestionario...");
                    break;
                }

                if (servicio.Verificar(p, r, out int puntos))
                {
                    score += puntos;
                    Console.WriteLine("Correcto! +" + puntos);
                }
                else
                {
                    Console.WriteLine("Incorrecto.");
                }

                Console.WriteLine("Score actual: " + score);
            }

            Console.WriteLine("Score final: " + score);
        }
    }
}