using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class DetalleNomina
    {
        [Key]
        public int IdDetalleNomina { get; set; }
        public string? Empleado { get; set; }
        public string? Cargo { get; set; }
        public decimal SueldoBruto { get; set; }
        public decimal ISR { get; set; }
        public decimal AFP { get; set; }
        public decimal SFS { get; set; }
        public decimal SueldoNeto { get; set; }
        public decimal Beneficios { get; set; }
        public decimal DeduccionesInternas { get; set; }
        public int IdNomina { get; set; }
    }
}
