using System.ComponentModel.DataAnnotations.Schema;

namespace myaz303.Models
{
    public class YonetmenDetail
    {
        public int YonetmenDetailId { get; set; }

        public int YonetmenId { get; set; }
        public Yonetmen Yonetmen { get; set; }
        public double YonetmenAciklama { get; set; }
     
    }
}
