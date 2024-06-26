using wa_pelis.Models.BD;

namespace wa_pelis.Interfaces
{
    public interface IGenero
    {
        Task<IEnumerable<TblGenero>> ConsultarGeneros();
    }
}
