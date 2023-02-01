using Microsoft.EntityFrameworkCore;

namespace NotDefteriAPI.Data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext>options):base(options)
        {

        }

        public DbSet<Not> Notlar => Set<Not>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Not>().HasData(
                new Not( ){Id=1,Baslik="Alinacaklar",Icerik="1.Bot\n2.Kod\n3.Pot"},
                new Not( ){Id=2,Baslik="Ozlu Sozler",Icerik="1.Yemek ye\n2.Dua et\n3.Sev"},
                new Not( ){Id=3,Baslik="Gezilecek Yerler",Icerik="1.Ankara\n2.Istanbul\n3.Izmir"}
                );
        }

    }
}
