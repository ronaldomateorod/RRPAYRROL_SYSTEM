using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    [Table("Puestos")]
    public class Puesto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPuesto { get; set; }

        [Required]
        [StringLength(70)]
        public string? Nombre { get; set; }

        [StringLength(150)]
        public string?   Descripcion { get; set; }
    }
}
