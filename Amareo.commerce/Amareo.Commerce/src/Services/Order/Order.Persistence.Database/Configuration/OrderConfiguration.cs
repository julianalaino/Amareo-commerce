using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Persistence.Database.Configuration
{
    public class OrderConfiguration
    {
        public OrderConfiguration(EntityTypeBuilder<Domain.Order> entityBuilder)
        {
            entityBuilder.HasKey(x => x.OrderId);
        }
    }
}
