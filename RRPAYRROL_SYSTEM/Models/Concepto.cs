using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class Concepto
    {
        [Key]
        public int IdConcepto { get; set; }
        public string? NombreConcepto { get; set; }
        public bool Tipo { get; set; }
        public decimal? Monto { get; set; }
        public float? Porcentaje { get; set; }
        public int IdDetalleNominaFK { get; set; }

        // Relación con la tabla DetalleNomina
        public DetalleNomina? DetalleNomina { get; set; }
    }
}
