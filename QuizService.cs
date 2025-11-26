using System;
using PrototipoCuestionario;

namespace PrototipoCuestionario
{
    public class QuizService
    {
        private List<Pregunta> _preguntas;
        private int _index = 0;

        public QuizService(List<Pregunta> preguntas)
        {
            _preguntas = preguntas;
            Shuffle(_preguntas);
        }

        public Pregunta SiguientePregunta()
        {
            if (_index >= _preguntas.Count)
                return null;

            return _preguntas[_index++];
        }

        public bool Verificar(Pregunta p, string respuesta, out int puntosGanados)
        {
            if (respuesta == p.RespuestaCorrecta)
            {
                puntosGanados = p.Puntuaje;
                return true;
            }

            puntosGanados = 0;
            return false;
        }

        private void Shuffle<T>(IList<T> list)
        {
            var rng = new System.Random();
            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);

                T temp = list[k];
                list[k] = list[n];
                list[n] = temp;
            }
        }
    }
}