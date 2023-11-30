using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FotologySena.Models
{
    public class Fotografia
    {
        [Key]
        [StringLength(15)]
        public string IDfotografia { get; set; }

        [Required]
        [StringLength(50)]
        public string Titulo { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [StringLength(15)]
        public string IDcategoria { get; set; }

        [ForeignKey("Fotografo")]
        public int IDfotografo { get; set; }

        [Required]
        public int IDcalificacion { get; set; }

        // Propiedades de navegación para las relaciones con Fotografo y Categoria
        public Fotografo Fotografo { get; set; }

        public Categoria Categoria { get; set; }
    }
}