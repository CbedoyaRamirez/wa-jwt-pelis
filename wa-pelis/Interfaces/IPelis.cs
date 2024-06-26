using wa_pelis.Models.BD;

namespace wa_pelis.Interfaces
{
    public interface IPelis
    {
        Task<IEnumerable<TblPelicula>> consultarPeliculas();

    }
}
