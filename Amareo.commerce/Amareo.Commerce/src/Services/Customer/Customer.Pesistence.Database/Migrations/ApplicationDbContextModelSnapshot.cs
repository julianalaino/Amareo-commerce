﻿// <auto-generated />
using Customer.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Customer.Persistence.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Customer")
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Customer.Domain.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ClientId");

                    b.HasIndex("ClientId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            Name = "Name for clien 1"
                        },
                        new
                        {
                            ClientId = 2,
                            Name = "Name for clien 2"
                        },
                        new
                        {
                            ClientId = 3,
                            Name = "Name for clien 3"
                        },
                        new
                        {
                            ClientId = 4,
                            Name = "Name for clien 4"
                        },
                        new
                        {
                            ClientId = 5,
                            Name = "Name for clien 5"
                        },
                        new
                        {
                            ClientId = 6,
                            Name = "Name for clien 6"
                        },
                        new
                        {
                            ClientId = 7,
                            Name = "Name for clien 7"
                        },
                        new
                        {
                            ClientId = 8,
                            Name = "Name for clien 8"
                        },
                        new
                        {
                            ClientId = 9,
                            Name = "Name for clien 9"
                        },
                        new
                        {
                            ClientId = 10,
                            Name = "Name for clien 10"
                        },
                        new
                        {
                            ClientId = 11,
                            Name = "Name for clien 11"
                        },
                        new
                        {
                            ClientId = 12,
                            Name = "Name for clien 12"
                        },
                        new
                        {
                            ClientId = 13,
                            Name = "Name for clien 13"
                        },
                        new
                        {
                            ClientId = 14,
                            Name = "Name for clien 14"
                        },
                        new
                        {
                            ClientId = 15,
                            Name = "Name for clien 15"
                        },
                        new
                        {
                            ClientId = 16,
                            Name = "Name for clien 16"
                        },
                        new
                        {
                            ClientId = 17,
                            Name = "Name for clien 17"
                        },
                        new
                        {
                            ClientId = 18,
                            Name = "Name for clien 18"
                        },
                        new
                        {
                            ClientId = 19,
                            Name = "Name for clien 19"
                        },
                        new
                        {
                            ClientId = 20,
                            Name = "Name for clien 20"
                        },
                        new
                        {
                            ClientId = 21,
                            Name = "Name for clien 21"
                        },
                        new
                        {
                            ClientId = 22,
                            Name = "Name for clien 22"
                        },
                        new
                        {
                            ClientId = 23,
                            Name = "Name for clien 23"
                        },
                        new
                        {
                            ClientId = 24,
                            Name = "Name for clien 24"
                        },
                        new
                        {
                            ClientId = 25,
                            Name = "Name for clien 25"
                        },
                        new
                        {
                            ClientId = 26,
                            Name = "Name for clien 26"
                        },
                        new
                        {
                            ClientId = 27,
                            Name = "Name for clien 27"
                        },
                        new
                        {
                            ClientId = 28,
                            Name = "Name for clien 28"
                        },
                        new
                        {
                            ClientId = 29,
                            Name = "Name for clien 29"
                        },
                        new
                        {
                            ClientId = 30,
                            Name = "Name for clien 30"
                        },
                        new
                        {
                            ClientId = 31,
                            Name = "Name for clien 31"
                        },
                        new
                        {
                            ClientId = 32,
                            Name = "Name for clien 32"
                        },
                        new
                        {
                            ClientId = 33,
                            Name = "Name for clien 33"
                        },
                        new
                        {
                            ClientId = 34,
                            Name = "Name for clien 34"
                        },
                        new
                        {
                            ClientId = 35,
                            Name = "Name for clien 35"
                        },
                        new
                        {
                            ClientId = 36,
                            Name = "Name for clien 36"
                        },
                        new
                        {
                            ClientId = 37,
                            Name = "Name for clien 37"
                        },
                        new
                        {
                            ClientId = 38,
                            Name = "Name for clien 38"
                        },
                        new
                        {
                            ClientId = 39,
                            Name = "Name for clien 39"
                        },
                        new
                        {
                            ClientId = 40,
                            Name = "Name for clien 40"
                        },
                        new
                        {
                            ClientId = 41,
                            Name = "Name for clien 41"
                        },
                        new
                        {
                            ClientId = 42,
                            Name = "Name for clien 42"
                        },
                        new
                        {
                            ClientId = 43,
                            Name = "Name for clien 43"
                        },
                        new
                        {
                            ClientId = 44,
                            Name = "Name for clien 44"
                        },
                        new
                        {
                            ClientId = 45,
                            Name = "Name for clien 45"
                        },
                        new
                        {
                            ClientId = 46,
                            Name = "Name for clien 46"
                        },
                        new
                        {
                            ClientId = 47,
                            Name = "Name for clien 47"
                        },
                        new
                        {
                            ClientId = 48,
                            Name = "Name for clien 48"
                        },
                        new
                        {
                            ClientId = 49,
                            Name = "Name for clien 49"
                        },
                        new
                        {
                            ClientId = 50,
                            Name = "Name for clien 50"
                        },
                        new
                        {
                            ClientId = 51,
                            Name = "Name for clien 51"
                        },
                        new
                        {
                            ClientId = 52,
                            Name = "Name for clien 52"
                        },
                        new
                        {
                            ClientId = 53,
                            Name = "Name for clien 53"
                        },
                        new
                        {
                            ClientId = 54,
                            Name = "Name for clien 54"
                        },
                        new
                        {
                            ClientId = 55,
                            Name = "Name for clien 55"
                        },
                        new
                        {
                            ClientId = 56,
                            Name = "Name for clien 56"
                        },
                        new
                        {
                            ClientId = 57,
                            Name = "Name for clien 57"
                        },
                        new
                        {
                            ClientId = 58,
                            Name = "Name for clien 58"
                        },
                        new
                        {
                            ClientId = 59,
                            Name = "Name for clien 59"
                        },
                        new
                        {
                            ClientId = 60,
                            Name = "Name for clien 60"
                        },
                        new
                        {
                            ClientId = 61,
                            Name = "Name for clien 61"
                        },
                        new
                        {
                            ClientId = 62,
                            Name = "Name for clien 62"
                        },
                        new
                        {
                            ClientId = 63,
                            Name = "Name for clien 63"
                        },
                        new
                        {
                            ClientId = 64,
                            Name = "Name for clien 64"
                        },
                        new
                        {
                            ClientId = 65,
                            Name = "Name for clien 65"
                        },
                        new
                        {
                            ClientId = 66,
                            Name = "Name for clien 66"
                        },
                        new
                        {
                            ClientId = 67,
                            Name = "Name for clien 67"
                        },
                        new
                        {
                            ClientId = 68,
                            Name = "Name for clien 68"
                        },
                        new
                        {
                            ClientId = 69,
                            Name = "Name for clien 69"
                        },
                        new
                        {
                            ClientId = 70,
                            Name = "Name for clien 70"
                        },
                        new
                        {
                            ClientId = 71,
                            Name = "Name for clien 71"
                        },
                        new
                        {
                            ClientId = 72,
                            Name = "Name for clien 72"
                        },
                        new
                        {
                            ClientId = 73,
                            Name = "Name for clien 73"
                        },
                        new
                        {
                            ClientId = 74,
                            Name = "Name for clien 74"
                        },
                        new
                        {
                            ClientId = 75,
                            Name = "Name for clien 75"
                        },
                        new
                        {
                            ClientId = 76,
                            Name = "Name for clien 76"
                        },
                        new
                        {
                            ClientId = 77,
                            Name = "Name for clien 77"
                        },
                        new
                        {
                            ClientId = 78,
                            Name = "Name for clien 78"
                        },
                        new
                        {
                            ClientId = 79,
                            Name = "Name for clien 79"
                        },
                        new
                        {
                            ClientId = 80,
                            Name = "Name for clien 80"
                        },
                        new
                        {
                            ClientId = 81,
                            Name = "Name for clien 81"
                        },
                        new
                        {
                            ClientId = 82,
                            Name = "Name for clien 82"
                        },
                        new
                        {
                            ClientId = 83,
                            Name = "Name for clien 83"
                        },
                        new
                        {
                            ClientId = 84,
                            Name = "Name for clien 84"
                        },
                        new
                        {
                            ClientId = 85,
                            Name = "Name for clien 85"
                        },
                        new
                        {
                            ClientId = 86,
                            Name = "Name for clien 86"
                        },
                        new
                        {
                            ClientId = 87,
                            Name = "Name for clien 87"
                        },
                        new
                        {
                            ClientId = 88,
                            Name = "Name for clien 88"
                        },
                        new
                        {
                            ClientId = 89,
                            Name = "Name for clien 89"
                        },
                        new
                        {
                            ClientId = 90,
                            Name = "Name for clien 90"
                        },
                        new
                        {
                            ClientId = 91,
                            Name = "Name for clien 91"
                        },
                        new
                        {
                            ClientId = 92,
                            Name = "Name for clien 92"
                        },
                        new
                        {
                            ClientId = 93,
                            Name = "Name for clien 93"
                        },
                        new
                        {
                            ClientId = 94,
                            Name = "Name for clien 94"
                        },
                        new
                        {
                            ClientId = 95,
                            Name = "Name for clien 95"
                        },
                        new
                        {
                            ClientId = 96,
                            Name = "Name for clien 96"
                        },
                        new
                        {
                            ClientId = 97,
                            Name = "Name for clien 97"
                        },
                        new
                        {
                            ClientId = 98,
                            Name = "Name for clien 98"
                        },
                        new
                        {
                            ClientId = 99,
                            Name = "Name for clien 99"
                        },
                        new
                        {
                            ClientId = 100,
                            Name = "Name for clien 100"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}