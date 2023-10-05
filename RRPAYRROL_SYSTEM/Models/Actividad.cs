using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class Actividad
    {
        [Key]
        public int IdActividad { get; set; }

        [StringLength(250)]
        public string? Descripcion { get; set; }

        public decimal TarifaMinima { get; set; }

        public bool PagadaPorHora { get; set; }
    }
}
