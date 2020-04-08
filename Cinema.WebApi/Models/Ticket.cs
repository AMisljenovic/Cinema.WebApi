using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.WebApi.Models
{
    public class Ticket
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string RepertoryId { get; set; }
        public string UserId { get; set; }
        public int SeatRow { get; set; }
        public int SeatColumn { get; set; }
        public int Price { get; set; }
    }
}
