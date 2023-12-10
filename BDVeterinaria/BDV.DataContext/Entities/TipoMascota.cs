using System;
using System.Collections.Generic;

namespace BDV.DataContext.Entities;

public partial class TipoMascota
{
    public int Iidtipomascota { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? Bhabilitado { get; set; }

    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();

    public virtual ICollection<Mascota> Mascota { get; set; } = new List<Mascota>();
}
