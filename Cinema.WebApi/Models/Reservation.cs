using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.WebApi.Models
{
    public class Reservation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public string RepertoryId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        [Range(0,4)]
        public int SeatRow { get; set; }
        [Required]
        [Range(0, 4)]
        public int SeatColumn { get; set; }
        [Required]
        public string Date { get; set; }
    }
}
