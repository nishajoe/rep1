using CFA_Activity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFA_Activity.Data
{
    public class AppDB_PdtContext :DbContext
    {
        public DbSet<Pdt> ProductsTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H9IDN1A;Initial Catalog=sampledb;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
