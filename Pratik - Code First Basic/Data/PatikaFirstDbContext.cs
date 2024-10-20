using Microsoft.EntityFrameworkCore;
using Pratik___Code_First_Basic.Data.Entities;

namespace Pratik___Code_First_Basic.Data
{
    public class PatikaFirstDbContext : DbContext
    {

        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Library;Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>(
                entity =>
                {
                    entity.ToTable("Movies"); //tablo adı
                    entity.HasKey(x => x.Id);// Id'yi birincil anahtar olarak ayarlıyoruz
                    entity.Property(x => x.Title).IsRequired().HasMaxLength(25); // title alanı zorunlu ve max 25 karakter
                    entity.Property(x => x.Genre).IsRequired().HasMaxLength(25); // genre alanı zorunlu ve max 25 karakter

                });

            modelBuilder.Entity<Game>(
                entity =>
                {
                    entity.ToTable("Games"); //tablo adı
                    entity.HasKey(x => x.Id); //Birincil anahtar
                    entity.Property(x => x.Name).IsRequired().HasMaxLength(25); // Zorunlu alan ve max 25 karakter
                    entity.Property(x => x.Platform).IsRequired().HasMaxLength(25); // Zorunlu alan ve max 25 karakter
                    entity.Property(x => x.Rating).IsRequired().HasColumnType("decimal(3, 1)"); //3 bamaklı değer alır 1 tanesi virgül sonrası.
                });
        }
    }
}
