using System.ComponentModel.DataAnnotations;

namespace Service_Repo_Crud_Manual.Models
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
