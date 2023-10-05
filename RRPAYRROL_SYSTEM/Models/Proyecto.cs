using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class Proyecto
    {
        [Key]
        public int IdProyecto { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Cliente { get; set; }

        [MaxLength(100)]
        public string? Localizacion { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public DateTime FechaEntrega { get; set; }

        [MaxLength(500)]
        public string? Descripcion { get; set; }

        [ForeignKey("Estado")]
        public int IdEstado { get; set; }
        public Estado? Estado { get; set; }

        [ForeignKey("Persona")]
        public int IdPersonaFK { get; set; }
        public Persona? Persona { get; set; }
    }
}
