﻿// <auto-generated />
using CountryCrud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CountryCrud.Migrations
{
    [DbContext(typeof(CountryDbContext))]
    partial class CountryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CountryCrud.Models.FullInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCapital")
                        .HasColumnType("bit");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Infos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Washington",
                            Country = "Usa",
                            IsCapital = true,
                            Population = 10000000
                        },
                        new
                        {
                            Id = 2,
                            City = "New York",
                            Country = "Usa",
                            IsCapital = false,
                            Population = 20000000
                        },
                        new
                        {
                            Id = 3,
                            City = "Berlin",
                            Country = "Germany",
                            IsCapital = true,
                            Population = 7000000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
