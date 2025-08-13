using System.ComponentModel.DataAnnotations;

namespace WebApp_AutoController_CrudOperation.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Age { get; set; }

        [Required]
        public string Course { get; set; }
    }
}
