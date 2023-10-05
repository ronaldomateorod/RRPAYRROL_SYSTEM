using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class Contrato
    {
        [Key]
        public int IdContrato { get; set; }
        public DateTime FechaContratacion { get; set; }
        public DateTime FechaRenovacion { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? Documento { get; set; }
        public int Tipo { get; set; }
    }
}
