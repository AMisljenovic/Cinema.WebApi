using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.WebApi.Models
{
    public class Repertory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public string MovieId { get; set; }
        [Required]
        public string HallId { get; set; }
        [Required]
        [StringLength(20)]
        public string PlayTime { get; set; }
        [Required]
        [Range(1, 7)]
        public int Day { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        [StringLength(10)]
        public int Price { get; set; }
    }
}
