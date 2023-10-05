using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }

        [Required]
        //[Unique]
        public string? rol { get; set; }
    }
}
