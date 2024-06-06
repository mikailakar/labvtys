using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            //options ile bağlantı dizesi alınmış olacak
        }
        public DbSet<Fakulte> tFakulte { get; set; } //Tablo
        public DbSet<Bolum> tBolum { get; set; } //Tablo
        public DbSet<Ogrenci> tOgrenci { get; set; } //Tablo
        public DbSet<OgrenciDers> tOgrenciDers { get; set; } //Tablo
    }
}
