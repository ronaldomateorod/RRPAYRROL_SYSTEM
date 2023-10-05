using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class Provincia
    {
        [Key]
        public int IdProvincia { get; set; }
        public string? NombreProvincia { get; set; }
    }
}
