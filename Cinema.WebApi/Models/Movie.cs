using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.WebApi.Models
{
    public class Movie
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        [StringLength(4)]
        public string Year { get; set; }
        [Required]
        [StringLength(30)]
        public string Title { get; set; }
        [Required]
        [StringLength(10)]
        public string Rated { get; set; }
        [Required]
        [StringLength(10)]
        public string Released { get; set; }
        [Required]
        [StringLength(10)]
        public string Runtime { get; set; }
        [Required]
        [StringLength(20)]
        public string Genre { get; set; }
        [Required]
        [StringLength(600)]
        public string Director { get; set; }
        [Required]
        [StringLength(600)]
        public string Actors { get; set; }
        [Required]
        [StringLength(600)]
        public string Plot { get; set; }
        [Required]
        [StringLength(600)]
        public string Poster { get; set; }
        [Required]
        public bool Playing { get; set; }
    }
}
