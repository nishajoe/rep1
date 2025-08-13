using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Service_Repo_Product.Models
{
    public class Product
    {
        [Key]
        public int Id{ get; set; }

        [Required]
        public string PdtName { get; set; }

        [Required]
        public string Desc { get; set; }

        [Required]
        public string Price { get; set; }


    }
}
