﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
    }
}
