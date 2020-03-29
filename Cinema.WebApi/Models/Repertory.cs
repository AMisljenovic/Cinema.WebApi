using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.WebApi.Models
{
    public class Repertory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string MoveId { get; set; }
        public DateTime Time{ get; set; }
        public int AvailableTickets { get; set; }
        public int SoldTickets { get; set; }

    }
}
