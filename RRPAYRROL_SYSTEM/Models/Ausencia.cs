using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class Ausencia
    {
        [Key]
        public int IdAusencia { get; set; }
        public DateTime FechaAusencia { get; set; }
        public bool Pagado { get; set; }
        public string? Motivo { get; set; }
        public int IdEmpleadoFK { get; set; }
    }
}
