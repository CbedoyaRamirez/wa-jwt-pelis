using System.ComponentModel.DataAnnotations;

namespace wa_pelis.Models.BD
{
    public class TblGenero
    {
        [Key]
        public int Id { get; set; }

        public string? NombreGenero { get; set; }

    }
}
