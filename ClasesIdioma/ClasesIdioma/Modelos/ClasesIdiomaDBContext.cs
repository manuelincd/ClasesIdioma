using Microsoft.EntityFrameworkCore;

namespace ClasesIdioma.Modelos
{
    public class ClasesIdiomaDBContext : DbContext
    {
        public ClasesIdiomaDBContext(DbContextOptions<ClasesIdiomaDBContext> options) : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Maestro> Maestros { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Maestro>()
                .HasOne(m => m.Idioma)
                .WithMany(i => i.Maestros)
                .HasForeignKey(m => m.IdiomaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Clase>()
                .HasOne(c => c.Idioma)
                .WithMany(i => i.Clases)
                .HasForeignKey(c => c.IdiomaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Clase>()
                .HasOne(c => c.Maestro)
                .WithMany(m => m.Clases)
                .HasForeignKey(c => c.MaestroId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
