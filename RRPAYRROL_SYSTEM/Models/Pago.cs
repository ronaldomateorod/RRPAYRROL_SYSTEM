using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    [Table("Pagos")]
    public class Pago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPago { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public decimal Monto { get; set; }

        [Required]
        [MaxLength(80)]
        public string? Empleado { get; set; }

        [Required]
        [MaxLength(80)]
        public string? Emisor { get; set; }

        [Required]
        [MaxLength(50)]
        public string? TipoPago { get; set; }

        [Required]
        public decimal Comision { get; set; }

        [ForeignKey("Empleado")]
        public int IdEmpleadoFK { get; set; }

        [ForeignKey("Nomina")]
        public int IdNominaFK { get; set; }

        [ForeignKey("Estado")]
        public int IdEstadoFK { get; set; }

        [ForeignKey("Usuario")]
        public int CreadoPor { get; set; }

        [ForeignKey("Usuario")]
        public int ModificadoPor { get; set; }

        // Relaciones con otras tablas
        public Empleado? empleado { get; set; }
        public Nomina? Nomina { get; set; }
        public Estado? Estado { get; set; }
        public Usuario? CreadoPorUsuario { get; set; }
        public Usuario? ModificadoPorUsuario { get; set; }
    }
}