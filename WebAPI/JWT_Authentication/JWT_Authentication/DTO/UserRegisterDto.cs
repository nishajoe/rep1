using System.ComponentModel.DataAnnotations;

namespace JWT_Authentication.DTO
{
    public class UserRegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
