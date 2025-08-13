using System.ComponentModel.DataAnnotations;

namespace Session_Userdto_LoginRegister.Models
{
    public class UserDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
