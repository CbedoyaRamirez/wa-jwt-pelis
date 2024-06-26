using Microsoft.EntityFrameworkCore;
using wa_pelis.Contexto;
using wa_pelis.Interfaces;
using wa_pelis.Models.BD;

namespace wa_pelis.Servicio
{
    public class PelisService : IPelis
    {

        private readonly ApplicationDbContext _context;

        public PelisService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblPelicula>> consultarPeliculas()
        {
            return  await _context.TBL_Peliculas.ToListAsync();
        }
    }
}
