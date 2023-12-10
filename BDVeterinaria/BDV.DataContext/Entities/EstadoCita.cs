using System;
using System.Collections.Generic;

namespace BDV.DataContext.Entities;

public partial class EstadoCita
{
    public int Iidestado { get; set; }

    public string? Vnombre { get; set; }

    public string? Vdescripcion { get; set; }

    public int? Bhabilitado { get; set; }

    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();
}
