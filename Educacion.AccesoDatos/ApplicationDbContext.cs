using Microsoft.EntityFrameworkCore;
using Educacion.Negocio;
using Microsoft.Extensions.Configuration;
using System;


namespace Educacion.AccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var Configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appconfig.json")
                .Build();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<EstudianteAsignatura>()
                .ToTable("EstudaintePorAsignatura")
                .HasKey(ea => new { ea.AsignaturaId, ea.EstudianteId });
            modelBuilder.Entity<Estudiante>()
                .HasKey(e => new { e.EstudianteId });
        }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<EstudianteAsignatura> EstudiantesAsignaturas { get; set; }

    }
    //Se aplica el proceso de migraciones
}
