using AppLaercio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLaercio.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Viagem> Viagens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-P6H4HNQ;Initial Catalog=AppLaercio;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Viagem>(table =>
            {
                table.ToTable("Viagens");
                table.HasKey(prop => prop.Id);

                table.Property(prop => prop.Viajante).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.Destino).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.TemGuia).HasColumnType("bit").IsRequired();
            });
        }
    }
}