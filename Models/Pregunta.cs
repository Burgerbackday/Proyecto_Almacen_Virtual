namespace PrototipoCuestionario
{
    public class Pregunta
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public string RespuestaCorrecta { get; set; }
        public string Area { get; set; }
        public int Puntuaje { get; set; }
    }
}