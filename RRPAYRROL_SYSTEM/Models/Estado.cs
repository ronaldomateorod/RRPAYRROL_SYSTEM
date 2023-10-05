using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }

        [Required]
        [StringLength(30)]
        public string? estado { get; set; }
    }
}

