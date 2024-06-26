
using System.ComponentModel.DataAnnotations;

namespace wa_pelis.Entitys
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        public string NombreGenero { get; set; }


    }
}
