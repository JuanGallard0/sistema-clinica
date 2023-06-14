using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SistemaClinica.Models
{
    public partial class ClinicaContext : DbContext
    {
        public ClinicaContext()
            : base("name=ClinicaDB")
        {
        }

        public virtual DbSet<Cita> Citas { get; set; }
        public virtual DbSet<Consulta> Consultas { get; set; }
        public virtual DbSet<Medico> Medicos { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cita>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta>()
                .Property(e => e.Diagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<Consulta>()
                .Property(e => e.Tratamiento)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Direccion)
                .IsUnicode(false);
        }
    }
}
