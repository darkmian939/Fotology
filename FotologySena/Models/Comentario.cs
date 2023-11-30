using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FotologySena.Models
{
    public class Comentario
    {
        [Key]
        public int IDcomentario { get; set; }

        [Required]
        [StringLength(15)]
        [ForeignKey("Fotografia")]
        public string IDfotografia { get; set; }

        [Required]
        [StringLength(30)]
        [ForeignKey("Cliente")]
        public string IDcliente { get; set; }

        public DateTime? Fecha_comentario { get; set; }

        // Propiedades de navegación para las relaciones con Fotografia y Cliente
        public Fotografia Fotografia { get; set; }

        public Cliente Cliente { get; set; }
    }
}
