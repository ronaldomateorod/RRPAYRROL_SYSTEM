using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class Asistencia
    {
        [Key]
        public int IdAsistencia { get; set; }

        [Required]
        public DateTime FechaEntrada { get; set; }

        [Required]
        public DateTime FechaSalida { get; set; }

        [ForeignKey("Proyecto")]
        public int IdProyecto { get; set; }
        public Proyecto? Proyecto { get; set; }

        [ForeignKey("Empleado")]
        public int IdEmpleado { get; set; }
        public Empleado? Empleado { get; set; }

        [ForeignKey("Estado")]
        public int IdEstado { get; set; }
        public Estado? Estado { get; set; }
    }
}
