namespace Alkemy_Challenge.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string imagen { get; set; }
        public string nombre { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int calificacion { get; set; }
        public List<Personaje> personajesAsociados;
    }
}
