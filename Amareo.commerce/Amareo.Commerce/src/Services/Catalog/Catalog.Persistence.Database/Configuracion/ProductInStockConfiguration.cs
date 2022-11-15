using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Database.Configuracion
{
    public class ProductInStockConfiguration
    {
        public ProductInStockConfiguration(EntityTypeBuilder<ProductInStock> entityBuilder) {

            entityBuilder.HasKey(x => x.ProductInStockId);

            var productsInStock = new List<ProductInStock>();
            var random = new Random();
            for (var i = 1; i <= 100; i++)
            {
                productsInStock.Add(new ProductInStock
                {
                    ProductInStockId = i,
                    ProductId = i,
                    Stock = random.Next(0, 100),

                });
            }
            entityBuilder.HasData(productsInStock);
            
        }
    }
}
