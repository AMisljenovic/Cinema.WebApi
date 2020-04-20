using System.ComponentModel.DataAnnotations;

namespace Cinema.WebApi.Models.Request
{
    public class PostUserRequestModel
    {
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        [Required]
        [StringLength(40)]
        public string Surname { get; set; }
        [StringLength(20)]
        public string Email { get; set; }
        [Required]
        [StringLength(12)]
        public string Username { get; set; }
        [Required]
        [StringLength(12)]
        public string Password { get; set; }
        [StringLength(12)]
        public string NewPassword { get; set; }
    }
}
