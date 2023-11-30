using System.ComponentModel.DataAnnotations;

namespace FotologySena.Models
{
    public class Administradores
    {

        [Key]
        public long IDadministrador { get; set; }

        [Required]
        [StringLength(50)]
        public required string Email { get; set; }

        [Required]
        [StringLength(20)]
        public required string Contrasena { get; set; }
    }
}
