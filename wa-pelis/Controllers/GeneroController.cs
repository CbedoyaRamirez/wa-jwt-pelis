using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using wa_pelis.Contexto;
using wa_pelis.Models.BD;

namespace wa_pelis.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeneroController : ControllerBase
    {
        private readonly ApplicationDbContext _igenero;

        public GeneroController(ApplicationDbContext igenero)
        {
            _igenero = igenero;
        }

        [HttpGet("consultarGeneros")]
        public async Task<IEnumerable<TblGenero>> consultarGenero()
        {
            return  _igenero.TBL_Genero.ToList();
        } 
        
    }
}
