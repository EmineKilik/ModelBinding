using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.Models
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
    }



    public class OgrenciContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenci { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=InternetProgramciligi;Integrated Security=true");
        }
    }
}
