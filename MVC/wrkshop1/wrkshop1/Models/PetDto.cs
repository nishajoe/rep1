using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wrkshop1.Models
{
    public class PetDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int Age { get; set; }
        //[NotMapped]
        //public IFormFile image { get; set; }
    }
}
