using Microsoft.EntityFrameworkCore;
using ProjeApi.Entities.Concrete;
using System.Collections;
using System.Collections.Generic;

namespace ProjeApi.DataAccess.Concrete.Context
{
    public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DenemeDb;TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}
