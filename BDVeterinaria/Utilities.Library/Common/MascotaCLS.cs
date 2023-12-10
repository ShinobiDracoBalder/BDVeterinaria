namespace Utilities.Library.Common
{
    public class MascotaCLS
    {
        //Propiedades listar

        public int iidmascota { get; set; } = 0;

        public string nombremascota { get; set; } = "";
        public string nombretipomascota { get; set; } = "";
        public string nombresexo { get; set; } = "";
        public string nombrefoto { get; set; } = "";
        public byte[] foto { get; set; } = new byte[0];

        //Insertar , Recuperar o Editar
        public int iidtipomascota { get; set; } = 0;
        public DateTime fechanacimiento { get; set; }
        public string ancho { get; set; } = "";
        public string alto { get; set; } = "";
        public int iidsexo { get; set; } = 0;
        public int iidusuariopropietario { get; set; } = 0;
        public string vobservacion { get; set; } = "";

    }
}
