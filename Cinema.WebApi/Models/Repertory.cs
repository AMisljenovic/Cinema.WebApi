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
        public string HallId { get; set; }
        public string PlayTime { get; set; }
        public int Day { get; set; }
        public int Price { get; set; }
    }
}
