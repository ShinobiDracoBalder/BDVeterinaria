using System;
using System.Collections.Generic;

namespace BDV.DataContext.Entities;

public partial class HistorialCita
{
    public int Iidhistorialcita { get; set; }

    public int? Iidcita { get; set; }

    public int? Iidestado { get; set; }

    public int? Iidusuario { get; set; }

    public DateTime? Dfecha { get; set; }

    public string? Vobservacion { get; set; }
}
