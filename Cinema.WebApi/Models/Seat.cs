using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.WebApi.Models
{
    public class Seat
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string HallId { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public bool Reserved { get; set; }
    }
}