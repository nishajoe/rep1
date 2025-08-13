using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkexmpl1.Models
{
    public class Product
    {
        [Key]   //to set primary key, we use key annotation
        public int Id { get; set; } //primary key

        [Required]
        public string Name { get; set; } //product name

        public decimal Price { get; set; } //product price
    }
}
