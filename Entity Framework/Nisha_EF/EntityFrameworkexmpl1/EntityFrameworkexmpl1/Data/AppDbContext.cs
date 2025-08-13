using EntityFrameworkexmpl1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkexmpl1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product>Products { get; set; } //map to Products table
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H9IDN1A;Initial Catalog=tempdb;Integrated Security=True;Trust Server Certificate=True");
        }

        
    }
}
