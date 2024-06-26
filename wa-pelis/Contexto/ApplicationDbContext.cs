using Microsoft.EntityFrameworkCore;
using wa_pelis.Models.BD;

namespace wa_pelis.Contexto
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TblPelicula> TBL_Peliculas { get; set; }
        public DbSet<TblGenero> TBL_Genero { get; set; }

    }
}
