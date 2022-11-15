using Customer.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Customer.Persistence.Database.Configuration
{
    public  class ClientConfiguration
    {
        public ClientConfiguration(EntityTypeBuilder<Client> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.ClientId);
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(100);

            var clients = new List<Client>();
            var random = new Random();

            for(int i=1; i<= 100; i++)
            {
                clients.Add(new Client
                {
                    ClientId = i,
                    Name = $"Name for clien {i}"
                });
            }

            entityBuilder.HasData(clients);
        }
    }
}
