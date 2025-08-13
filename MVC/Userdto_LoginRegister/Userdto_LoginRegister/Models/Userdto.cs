using System.ComponentModel.DataAnnotations;

namespace Userdto_LoginRegister.Models
{
    public class Userdto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
