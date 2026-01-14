namespace PrototipoCuestionario
{
    public class Jugador
    {
        public int Id { get; set; }
        public string NoControl { get; set; }  // NUEVO
        public string Nombre { get; set; }
        public string Apellidos { get; set; }  // NUEVO
        public int PuntuajeTotal { get; set; }
    }
}