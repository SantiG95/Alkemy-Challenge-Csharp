namespace Alkemy_Challenge.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string imagen { get; set; }
        public List<Pelicula> peliculasAsociadas { get; set; }
    }
}
