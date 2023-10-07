using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace RRPAYRROL_SYSTEM.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        // Aquí se declaran las propiedades DbSet para cada una de las tablas de la base de datos

        public DbSet<Estado> Estados { get; set; }
        public DbSet<Nacionalidad> Nacionalidades { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Puesto> Puestos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioRol> UsuarioRoles { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Ausencia> Ausencias { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<EmpleadoProyecto> EmpleadoProyectos { get; set; }
        public DbSet<ActividadAsignada> ActividadesAsignadas { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Nomina> Nominas { get; set; }
        public DbSet<DetalleNomina> DetallesNominas { get; set; }
        public DbSet<Concepto> Conceptos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
    }
}
