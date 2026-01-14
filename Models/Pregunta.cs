namespace PrototipoCuestionario
{
    public class Pregunta
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public string RespuestaCorrecta { get; set; }
        public string Area { get; set; }
        public string Tema { get; set; }  // NUEVO
        public int Puntuaje { get; set; }
    }
}