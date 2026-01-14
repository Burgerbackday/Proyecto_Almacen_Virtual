namespace PrototipoCuestionario
{
    public class RespuestaJugador
    {
        public int Id { get; set; }
        public string RespuestaJugadorTexto { get; set; }
        public bool Acierto { get; set; }  // NUEVO: 1 = correcto, 0 = incorrecto
        public int JugadorId { get; set; }
        public int PreguntaId { get; set; }
    }
}
