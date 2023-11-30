using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FotologySena.Models
{
    public class Categoria
    {
        [Key]
        [StringLength(20)]
        public string IDcategoria { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [ForeignKey("Portafolio")]
        [StringLength(15)]
        public string IDportafolio { get; set; }

        // Propiedad de navegación para la relación con Portafolio
        public Portafolio Portafolio { get; set; }
    }
}