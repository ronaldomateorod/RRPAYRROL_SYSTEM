using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class Nomina
    {
        [Key]
        public int IdNomina { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        [Required]
        public DateTime FechaCorte { get; set; }

        [ForeignKey("Usuarios")]
        public int CreadoPor { get; set; }

        [ForeignKey("Usuarios")]
        public int ModificadoPor { get; set; }

        [ForeignKey("Estados")]
        public int IdEstado { get; set; }

        [ForeignKey("Proyectos")]
        public int IdProyecto { get; set; }

        // Propiedades de navegación
        public virtual Usuario? CreadoPorUsuario { get; set; }
        public virtual Usuario? ModificadoPorUsuario { get; set; }
        public virtual Estado? Estado { get; set; }
        public virtual Proyecto? Proyecto { get; set; }
    }
}
