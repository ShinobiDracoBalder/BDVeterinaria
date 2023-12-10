using System;
using System.Collections.Generic;

namespace BDV.DataContext.Entities;

public partial class Mascota
{
    public int Iidmascota { get; set; }

    public int? Iidusuariopropietario { get; set; }

    public string? Nombre { get; set; }

    public int? Iidtipomascota { get; set; }

    public DateTime Fechanacimiento { get; set; }

    public string? Ancho { get; set; }

    public string? Altura { get; set; }

    public int? Iidsexo { get; set; }

    public string? Vobservacion { get; set; }

    public int? Bhabilitado { get; set; }

    public string? Vnombrearchivo { get; set; }

    public byte[]? Archivo { get; set; }

    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();

    public virtual Sexo? IidsexoNavigation { get; set; }

    public virtual TipoMascota? IidtipomascotaNavigation { get; set; }

    public virtual Usuario? IidusuariopropietarioNavigation { get; set; }

    public virtual ICollection<UsuarioMascota> UsuarioMascota { get; set; } = new List<UsuarioMascota>();
}
