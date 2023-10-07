using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class Nacionalidad
    {
        [Key]
        public int IdNacionalidad { get; set; }

        [Required]
        [StringLength(60)]
        public string? Nombre { get; set; }
    }
}
