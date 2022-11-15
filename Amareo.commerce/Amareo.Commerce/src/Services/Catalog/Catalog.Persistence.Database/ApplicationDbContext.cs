using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Catalog.Domain;
using Catalog.Persistence.Database.Configuracion;

namespace Catalog.Persistence.Database
{
    public class ApplicationDbContext : DbContext
    {
        //Se requiere inicializar la cadena de conexión
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInStock> Stock { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Database Schema
            builder.HasDefaultSchema("Catalog");

            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new ProductConfiguration(modelBuilder.Entity<Product>());
            new ProductInStockConfiguration(modelBuilder.Entity<ProductInStock>());
        }

    }
}
