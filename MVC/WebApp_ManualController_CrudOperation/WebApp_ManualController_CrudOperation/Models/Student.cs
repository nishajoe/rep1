using System.ComponentModel.DataAnnotations;

namespace WebApp_ManualController_CrudOperation.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

    }
}
