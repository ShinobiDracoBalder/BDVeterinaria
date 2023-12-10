using BDV.DataContext.DataContext;
using BDV.DataContext.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using Utilities.Library.Common;

namespace BDV.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        private readonly BdveterinariaContext _bdveterinariaContext;

        public CitaController(BdveterinariaContext bdveterinariaContext)
        {
            _bdveterinariaContext = bdveterinariaContext;
        }
        [HttpGet("{idusuario}")]

        public List<CitaCLS> listarCitas(int idusuario)
        {
            List<CitaCLS> lista = new List<CitaCLS>();
            try
            {
                using (BdveterinariaContext bd = new BdveterinariaContext())
                {
                    lista = (from cita in bd.Cita
                             join mascota in bd.Mascota
                             on cita.Iidmascota equals mascota.Iidmascota
                             join tipomascota in bd.TipoMascota
                             on mascota.Iidtipomascota equals tipomascota.Iidtipomascota
                             join usuario in bd.Usuarios
                             on cita.Iidusuario equals usuario.Iidusuario
                             join persona in bd.Personas
                             on usuario.Iidpersona equals persona.Iidpersona
                             join estadocita in bd.EstadoCita
                             on cita.Iidestadocita equals estadocita.Iidestado
                             where cita.Bhabilitado == 1 && cita.Iidusuario == idusuario
                             select new CitaCLS
                             {
                                 iidcita = cita.Iidcita,
                                 descripcionenfermedad = cita.Vdescripcion,
                                 nombremascota = mascota.Nombre,
                                 fotomascota = mascota.Archivo,
                                 fechaenfermedadcadena = cita.Dfechaenfermo == null ? "" :
                                cita.Dfechaenfermo.Value.ToShortDateString(),
                                 nombretipomascota = tipomascota.Nombre,
                                 nombreusuariomascota = persona.Nombre + " " + persona.Appaterno + " " + persona.Apmaterno,
                                 nombreestadocita = estadocita.Vnombre

                             }).ToList();
                    return lista;

                }

            }
            catch (Exception)
            {
                return lista;
            }

        }


        [HttpPost]
        public int guardarCita([FromBody] CitaCLS oCitaCLS)
        {
            int rpta = 0;
            try
            {
                int iidcita = oCitaCLS.iidcita;
                using (TransactionScope transaccion = new TransactionScope())
                {
                    using (BdveterinariaContext bd = new BdveterinariaContext())
                    {
                        if (iidcita == 0)
                        {
                            Cita oCitum = new Cita();
                            oCitum.Iidusuario = oCitaCLS.iidusuario;
                            oCitum.Iidtipomascota = oCitaCLS.iidtipomascota;
                            oCitum.Iidmascota = oCitaCLS.iidmascota;
                            oCitum.Vdescripcion = oCitaCLS.descripcionenfermedad;
                            oCitum.Dfechaenfermo = oCitaCLS.fechaenfermedad;
                            oCitum.Iidsede = oCitaCLS.iidsede;
                            oCitum.Iidestadocita = oCitaCLS.iidestadocita;
                            oCitum.Dfechainicio = DateTime.Now;
                            oCitum.Bhabilitado = 1;
                            bd.Cita.Add(oCitum);
                            bd.SaveChanges();
                            oCitaCLS.iidcita = oCitum.Iidcita;
                            int reg = insertarHistorialCita(oCitaCLS, "Se registro la cita");
                            if (reg == 0) return 0;
                            transaccion.Complete();
                            rpta = 1;


                        }
                        else
                        {
                            Cita oCitum = bd.Cita.Where(p => p.Iidcita == iidcita).First();
                            oCitum.Iidtipomascota = oCitaCLS.iidtipomascota;
                            oCitum.Iidmascota = oCitaCLS.iidmascota;
                            oCitum.Vdescripcion = oCitaCLS.descripcionenfermedad;
                            oCitum.Dfechaenfermo = oCitaCLS.fechaenfermedad;
                            oCitum.Iidsede = oCitaCLS.iidsede;
                            bd.SaveChanges();
                            transaccion.Complete();
                            rpta = 1;
                        }


                    }
                }



            }
            catch (Exception)
            {
                rpta = 0;
            }
            return rpta;

        }


        private int insertarHistorialCita(CitaCLS oCitaCLS, string observacion)
        {
            int rpta = 0;
            try
            {
                HistorialCita oHistorialCitum = new HistorialCita();
                oHistorialCitum.Iidcita = oCitaCLS.iidcita;
                oHistorialCitum.Iidestado = oCitaCLS.iidestadocita;
                oHistorialCitum.Iidusuario = oCitaCLS.iidusuario;
                oHistorialCitum.Dfecha = DateTime.Now;
                oHistorialCitum.Vobservacion = observacion;
                _bdveterinariaContext.HistorialCita.Add(oHistorialCitum);
                _bdveterinariaContext.SaveChanges();
                rpta = 1;

            }
            catch (Exception)
            {
                rpta = 0;
            }
            return rpta;

        }

    }
}
