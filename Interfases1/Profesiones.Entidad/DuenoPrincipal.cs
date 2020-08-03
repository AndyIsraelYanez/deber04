using System.Collections.Generic;

namespace Profesiones.Entidad
{
    public class DuenoPrincipal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Estado { get; set; }
        public List<string> ListaDePagos { get; set; }
    }
}
