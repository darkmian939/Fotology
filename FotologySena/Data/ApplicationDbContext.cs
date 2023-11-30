using FotologySena.Models;
using Microsoft.EntityFrameworkCore;

namespace FotologySena.Data
{
    public class ApplicationDbContext : DbContext
    {
        
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {

            }

            public DbSet<Administrador> Administradores { get; set; }
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Fotografo> Fotografos { get; set; }
            public DbSet<Portafolio> Portafolios { get; set; }
            public DbSet<Fotografia> Fotografias { get; set; }
            public DbSet<Categoria> Categorias { get; set; }
            public DbSet<Calificacion> Calificacion { get; set; }
            public DbSet<Comentario> Comentarios { get; set; }

    }

}

