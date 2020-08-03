using System.Collections.Generic;

namespace Profesiones.Entidad
{
    public class Proveedores
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string TipoCarroConduce { get; set; }
        public List<string> ListaDeEntregas { get; set; }

        
    }
}
