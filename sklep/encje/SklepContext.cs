using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sklep.encje
{
    public class SklepContext : DbContext
    {
        private string polaczenie =
"Server=(localdb)\\mssqllocaldb;database=Sklep;Trusted_Connection=True;";
        public DbSet<klient> klienci { get; set; }
        public DbSet<produkt> produkty { get; set; }
        public DbSet<zamowienie> zamowienia { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<produkt>()
                .HasOne(produkt => produkt.zamowienie)
                .WithOne(zamowienie => zamowienie.produkt)
                .HasForeignKey<zamowienie>(zamowienie => zamowienie.ProduktFK);

            modelBuilder.Entity<klient>()
                .HasMany(klient => klient.zamowienia)
                .WithOne(zamowienie => zamowienie.Klient)
                .HasForeignKey(zamowienie => zamowienie.KlientFK);

            modelBuilder.Entity<zamowienie>()
                .HasOne(zamowienie => zamowienie.Klient)
                .WithMany(klient => klient.zamowienia);
                
                            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            optionsBuilder.UseSqlServer(polaczenie);
        }
    }
}
