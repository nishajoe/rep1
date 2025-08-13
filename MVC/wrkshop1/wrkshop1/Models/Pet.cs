using System.ComponentModel.DataAnnotations;

namespace wrkshop1.Models
{
    public class Pet
    {
        
        public Guid Id { get; set; }
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
        //[Required]
        //public string image { get; set; }
    }
}
