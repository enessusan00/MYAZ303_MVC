using Microsoft.Extensions.Hosting;
using System.ComponentModel;

namespace myaz303.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public int Sure { get; set; }
        public ICollection<Film> Filmler { get; set; }
    }
}
