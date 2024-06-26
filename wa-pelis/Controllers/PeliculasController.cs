using LinqToDB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using wa_pelis.Contexto;
using wa_pelis.Entitys;
using wa_pelis.Interfaces;
using wa_pelis.Models.BD;

namespace wa_pelis.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class PeliculasController : ControllerBase
    {

        private readonly ApplicationDbContext _ipelis;

        public PeliculasController(ApplicationDbContext ipelis)
        {
            _ipelis = ipelis;
        }


        [HttpGet("consultarPeliculas")]
        public async Task<IEnumerable<TblPelicula>> ConsultarPeliculas()
        {
            return await _ipelis.TBL_Peliculas.ToArrayAsync();
        }
            /*
        public async List<TblPelicula> ConsultarPeliculas()
        {
            List<TblPelicula> listaPeliculas = new List<TblPelicula>();
            using (var db = new Models.BD.DbPelisContext())
            {
                listaPeliculas = (from d in db.TblPeliculas
                       select new TblPelicula
                       {
                           Id = d.Id,
                           Nombre = d.Nombre,
                           Genero = d.Genero
                       }).ToList();
            }
            return listaPeliculas;

        }
            */
    }
}
