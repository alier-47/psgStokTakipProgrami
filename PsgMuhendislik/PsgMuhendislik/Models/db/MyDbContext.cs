using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsgMuhendislik.Models.db
{
    class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=pisagorMuhendislikST2; integrated security=true");
        }

        public DbSet<CalisanCizelgesi> CalisanCizelgesi { get; set; }
        public DbSet<CalisanEDevlet> CalisanEDevlet { get; set; }
        public DbSet<Calisanlar> Calisanlar{ get; set; }
        public DbSet<CalisanlarDetay> CalisanlarDetay { get; set; }
        public DbSet<Firmalar> Firmalar { get; set; }
        public DbSet<FirmalarDetay> FirmalarDetay { get; set; }
        public DbSet<GelenOdemeler> GelenOdemeler { get; set; }
        public DbSet<Harcamalar> Harcamalar { get; set; }
        public DbSet<İdris> İdris { get; set; }
        public DbSet<Kullanıcılar> Kullanıcılar { get; set; }
        public DbSet<Musteriler> Musteriler { get; set; }
        public DbSet<MusterilerDetay> MusterilerDetay { get; set; }
    }
}
