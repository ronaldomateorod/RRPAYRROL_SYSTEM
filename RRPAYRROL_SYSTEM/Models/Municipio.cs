using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class Municipio
    {
        [Key]
        public int IdMunicipio { get; set; }
        public string? Nombre { get; set; }
    }
}
