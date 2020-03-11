using Microsoft.EntityFrameworkCore;
using MobileShop.Model.Database;
using System;

namespace MobileShop.Model
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> x) : base(x)
        {

        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
       
        public DbSet<Klijenti> Klijenti { get; set; }
        public DbSet<Ocjene> Ocjene { get; set; }
        public DbSet<Artikli> Artikli { get; set; }
        public DbSet<Proizvodjaci> Proizvodjaci { get; set; }
        public DbSet<Modeli> Modeli { get; set; }
        public DbSet<Karakteristike> Karakteristike { get; set; }
        public DbSet<Dobavljaci> Dobavljaci { get; set; }
        public DbSet<Korisnici> Korisnici { get; set; }
        public DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public DbSet<Nabavka> Nabavka { get; set; }
        public DbSet<NabavkaStavke> NabavkaStavke { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<NarudzbaStavke> NarudzbaStavke { get; set; }
        public DbSet<Skladista> Skladista { get; set; }
        public DbSet<Uloge> Uloge { get; set; }
        public DbSet<Zahtjevi> Zahtjevi { get; set; }
        public DbSet<ZahtjeviStavke> ZahtjeviStavke { get; set; }
        public DbSet<Obavijesti> Obavijesti { get; set; }
        public DbSet<PoslanaNarudzba> PoslanaNarudzba { get; set; }



    }
}
