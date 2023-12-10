using System;
using System.Collections.Generic;

namespace BDV.DataContext.Entities;

public partial class Sexo
{
    public int Iidsexo { get; set; }

    public string? Nombre { get; set; }

    public int? Bhabilitado { get; set; }

    public virtual ICollection<Mascota> Mascota { get; set; } = new List<Mascota>();

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
