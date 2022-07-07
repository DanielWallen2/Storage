using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Storage.Models;

namespace Storage.Data
{
    public class StorageContext : DbContext
    {
        public StorageContext (DbContextOptions<StorageContext> options)
            : base(options)
        {
        }

        public DbSet<Storage.Models.Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Krocket-spel", Category = Category.Lek, Shelf = "R1:H1:V1", Orderdate = DateTime.Now, Count = 12, Price = 230, Description = "Krocket-spel för högst 4 personer." },
                new Product { Id = 2, Name = "Extra Krocket-klubba", Category = Category.Lek, Shelf = "R1:H1:V2", Orderdate = DateTime.Now, Count = 4, Price = 110, Description = "Extra klubba till krocket-spel." },
                new Product { Id = 3, Name = "Extra Krocket-klot", Category = Category.Lek, Shelf = "R1:H1:V3", Orderdate = DateTime.Now, Count = 7, Price = 72, Description = "Extra klot till krocket-spel." },
                new Product { Id = 4, Name = "Tå-plåster", Category = Category.Vård, Shelf = "R1:H2:V1", Orderdate = DateTime.Now, Count = 25, Price = 23, Description = "Plåster för tårna."},
                new Product { Id = 5, Name = "Hjälm", Category = Category.Skydd, Shelf = "R1:H3:V1", Orderdate = DateTime.Now, Count = 19, Price = 249, Description = "Hjälm" }
                );
        }
    }
}
