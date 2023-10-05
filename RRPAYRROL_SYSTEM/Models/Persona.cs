using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRPAYRROL_SYSTEM.Models
{
    [Table("Personas")]
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPersona { get; set; }

        [Required]
        [StringLength(60)]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(60)]
        public string? Apellido { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(13)]
        //[Index(IsUnique = true)]
        public string? Cedula { get; set; }

        [Required]
        public string? Direccion { get; set; }

        [StringLength(12)]
        public string? Celular { get; set; }

        [StringLength(12)]
        public string? Telefono { get; set; }

        [StringLength(100)]
        public string? Email { get; set; }

        [Required]
        public char Sexo { get; set; }

        public DateTime FechaCreacion { get; set; }

        [ForeignKey("Nacionalidad")]
        public int IdNacionalidadFK { get; set; }

        [ForeignKey("Municipio")]
        public int IdMunicipioFK { get; set; }

        [ForeignKey("Provincia")]
        public int IdProvinciaFK { get; set; }

        [ForeignKey("Usuario")]
        public int CreadoPor { get; set; }

        [ForeignKey("Usuario")]
        public int ModificadoPor { get; set; }

        // Relaciones con otras tablas
        public virtual Nacionalidad? Nacionalidad { get; set; }
        public virtual Municipio? Municipio { get; set; }
        public virtual Provincia? Provincia { get; set; }
        public virtual Usuario? CreadoPorUsuario { get; set; }
        public virtual Usuario? ModificadoPorUsuario { get; set; }
    }
}
