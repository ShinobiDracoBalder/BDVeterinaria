using System;
using System.Collections.Generic;

namespace BDV.DataContext.Entities;

public partial class UsuarioMascota
{
    public int Iidpersonamascota { get; set; }

    public int? Iidusuario { get; set; }

    public int? Iidmascota { get; set; }

    public int? Bhabilitado { get; set; }

    public virtual Mascota? IidmascotaNavigation { get; set; }

    public virtual Usuario? IidusuarioNavigation { get; set; }
}
