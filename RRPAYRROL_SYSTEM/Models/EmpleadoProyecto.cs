using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class EmpleadoProyecto
    {
        [Key]
        public int IdEmpleadoProyecto { get; set; }
        public bool EsEncargado { get; set; }
        public int IdEmpleado { get; set; }
        public int IdProyecto { get; set; }
    }
}
