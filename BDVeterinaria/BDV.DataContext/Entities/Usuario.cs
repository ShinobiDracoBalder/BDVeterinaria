using System;
using System.Collections.Generic;

namespace BDV.DataContext.Entities;

public partial class Usuario
{
    public int Iidusuario { get; set; }

    public string? Nombreusuario { get; set; }

    public string? Contra { get; set; }

    public byte[]? Passwordhash { get; set; }

    public byte[]? Passwordsalt { get; set; }

    public int? Iidpersona { get; set; }

    public int? Bhabilitado { get; set; }

    public int? Iidtipousuario { get; set; }

    public virtual ICollection<Cita> CitumIiddoctorasignacitausuarioNavigations { get; set; } = new List<Cita>();

    public virtual ICollection<Cita> CitumIidusuarioNavigations { get; set; } = new List<Cita>();

    public virtual Persona? IidpersonaNavigation { get; set; }

    public virtual TipoUsuario? IidtipousuarioNavigation { get; set; }

    public virtual ICollection<Mascota> Mascota { get; set; } = new List<Mascota>();

    public virtual ICollection<UsuarioMascota> UsuarioMascota { get; set; } = new List<UsuarioMascota>();
}
