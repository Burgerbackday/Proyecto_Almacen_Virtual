namespace PrototipoCuestionario
{
    public class RespuestaJugador
    {
        public int Id { get; set; }
        public string RespuestaJugadorTexto { get; set; }

        public int JugadorId { get; set; }
        public int PreguntaId { get; set; }
    }
}
