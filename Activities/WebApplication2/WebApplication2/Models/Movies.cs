using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; } 
        public string Mname { get; set; }
        public string Director { get; set; }
        public int Ticketprice { get; set; }
    }
}
