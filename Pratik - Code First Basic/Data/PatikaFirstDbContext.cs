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
        }


        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>(
                entity =>
                {
                    entity.HasKey(x => x.Id);// Id'yi birincil anahtar olarak ayarlıyoruz
                    entity.Property(x => x.Id)
                          .ValueGeneratedOnAdd(); //otomatik artma

                    entity.Property(x => x.Title)
                          .IsRequired(); // title alanı zorunlu

                    entity.Property(x => x.Genre)
                          .IsRequired(); // genre alanı zorunlu

                });

            modelBuilder.Entity<Game>(
                entity =>
                {
                    entity.Property(x => x.Rating)
                          .HasPrecision(3, 1); //1-10 arasında rating değeri aldırır.
                });
        }
    }
}
