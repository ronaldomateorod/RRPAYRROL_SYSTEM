using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }

        [Required]
        [StringLength(20)]
        //[Index(IsUnique = true)]
        public string? Codigo { get; set; }

        [Required]
        //[Index(IsUnique = true)]
        public int NumDeCuenta { get; set; }

        [ForeignKey("Usuarios")]
        public int CreadoPor { get; set; }

        [ForeignKey("Usuarios")]
        public int ModificadoPor { get; set; }

        [ForeignKey("Personas")]
        public int IdPersonaFK { get; set; }

        [ForeignKey("Puestos")]
        public int IdPuestoFK { get; set; }

        [ForeignKey("Contratos")]
        public int IdContratoFK { get; set; }

        [ForeignKey("Estados")]
        public int IdEstadoFK { get; set; }

        public virtual Usuario? CreadoPorUsuario { get; set; }

        public virtual Usuario? ModificadoPorUsuario { get; set; }

        public virtual Persona? Persona { get; set; }

        public virtual Puesto? Puesto { get; set; }

        public virtual Contrato? Contrato { get; set; }

        public virtual Estado? Estado { get; set; }
    }
}
