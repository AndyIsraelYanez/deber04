using System.Collections.Generic;

namespace Profesiones.Entidad
{
    public class Administrador1
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Estado { get; set; }
        public string Direccion { get; set; }
        public List<string> ListaDeTareas { get; set; }
    }
}
