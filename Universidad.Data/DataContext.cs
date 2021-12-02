using Microsoft.EntityFrameworkCore;
using System;
using Universidad.Core.Models;

namespace Universidad.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Core.Models.Universidad> Universidads { get; set; }
        public DbSet<Pensum> Pensums { get; set; }
        public DbSet<PensumDetalle> PensumDetalle { get; set; }
        public DbSet<Seccion> Seccions { get; set; }
        public DbSet<Carreras> Carreras { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Cursa> Cursas { get; set; }
        public DbSet<Profesor> Profesors { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}