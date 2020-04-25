using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.WebApi.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        [MinLength(2), MaxLength(40)]
        public string Name { get; set; }
        [Required]
        [MinLength(2), MaxLength(40)]
        public string Surname { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [MinLength(4), MaxLength(30)]
        public string Username { get; set; }
        [Required]
        [MinLength(4), MaxLength(30)]
        public string Password { get; set; }
        public string Role { get; set; }
    }

    public enum DbStatusCode
    {
        Executed,
        PasswordDoesntMatch,
        EmailInUse,
    }
}
