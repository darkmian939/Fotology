using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FotologySena.Models
{
    public class Portafolio
    {
        [Key]
        [StringLength(15)]
        public string IDportafolio { get; set; }

        [ForeignKey("Fotografo")]
        public int IDfotografo { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre_portafolio { get; set; }

        // Propiedad de navegación para la relación con Fotografo
        public Fotografo Fotografo { get; set; }
    }
}
