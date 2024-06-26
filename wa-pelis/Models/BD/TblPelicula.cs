using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace wa_pelis.Models.BD;

public class TblPelicula
{
    [Key]
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? Genero { get; set; }
}
