using System.ComponentModel.DataAnnotations;

namespace FotologySena.Models
{
    public class Clientecs
    {
        [Key]
        [StringLength(30)]
        public int IDcliente { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre_cliente { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public required string Contrasena { get; set; }

        [Required]
        public string Telefono { get; set; }
    }
}
