using System;
using System.Collections.Generic;

namespace BDV.DataContext.Entities;

public partial class Sede
{
    public int Iidsede { get; set; }

    public string? Vnombre { get; set; }

    public string? Vdireccion { get; set; }

    public int? Bhabilitado { get; set; }

    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();
}
