using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class ActividadAsignada
    {
        [Key]
        public int IdActividadAsignada { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        [ForeignKey("Actividad")]
        public int IdActividad { get; set; }
        public Actividad? Actividad { get; set; }

        [ForeignKey("Estado")]
        public int IdEstado { get; set; }
        public Estado? Estado { get; set; }

        [ForeignKey("EmpleadoProyecto")]
        public int IdEmpleadoProyectoFK { get; set; }
        public EmpleadoProyecto? EmpleadoProyecto { get; set; }
    }
}
