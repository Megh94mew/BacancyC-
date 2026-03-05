using System.Component.DataAnnotations;

namespace TMS.DTOs
{
    public class CreateUserDto
    {
        [Required]
        public string FIrstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public int RoleId { get; set; }
    } 
}