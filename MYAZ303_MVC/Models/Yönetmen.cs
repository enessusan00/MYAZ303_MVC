namespace myaz303.Models
{
    public class Yonetmen
    {
        public int YonetmenId { get; set; }
        public int FilmId { get; set; }

        public YonetmenDetail YonetmenDetail { get; set; }
        public ICollection<Film> Filmer { get; set; }
    }
}
