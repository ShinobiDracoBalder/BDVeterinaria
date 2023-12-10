namespace BDV.DataContext.Entities;

public partial class Cita
{
    public int Iidcita { get; set; }

    public int Iidusuario { get; set; }

    public int Iidtipomascota { get; set; }

    public int Iidmascota { get; set; }

    public string Vdescripcion { get; set; }

    public string Vmedidastomadas { get; set; }

    public DateTime? Dfechaenfermo { get; set; }

    public DateTime Dfechainicio { get; set; }

    public decimal Precioatencion { get; set; }

    public decimal Totalpagar { get; set; }

    public int Iidsede { get; set; }

    public int Iiddoctorasignacitausuario { get; set; }

    public int Bhabilitado { get; set; }

    public int Iidestadocita { get; set; }

    public DateTime? Dfechacita { get; set; }

    public virtual ICollection<CitaMedicamento> CitaMedicamentos { get; set; } = new List<CitaMedicamento>();

    public virtual Usuario IiddoctorasignacitausuarioNavigation { get; set; }

    public virtual EstadoCita IidestadocitaNavigation { get; set; }

    public virtual Mascota IidmascotaNavigation { get; set; }

    public virtual Sede IidsedeNavigation { get; set; }

    public virtual TipoMascota IidtipomascotaNavigation { get; set; }

    public virtual Usuario IidusuarioNavigation { get; set; }
}
