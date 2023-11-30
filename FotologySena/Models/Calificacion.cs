using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FotologySena.Models
{
    public class Calificacion
    {
        [Key]
        public int IDcalificacion { get; set; }

        [Required]
        public int Calificacion { get; set; }

        [ForeignKey("Fotografia")]
        [StringLength(15)]
        public string IDfotografia { get; set; }

        // Propiedad de navegación para la relación con Fotografia
        public Fotografia Fotografia { get; set; }
    }
}
