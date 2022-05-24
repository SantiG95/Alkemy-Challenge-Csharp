namespace Alkemy_Challenge.Models
{
    public class Personaje
    {
        public int Id { get; set; }
        public string imagen { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public float peso { get; set; }
        public string historia { get; set; }
        public List<Pelicula> peliculasAsociadas { get; set; }
    }
}
