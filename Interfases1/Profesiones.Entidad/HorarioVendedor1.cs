using System;
using System.Collections.Generic;
using System.Text;

namespace Profesiones.Entidad
{
    public class HorarioVendedor1
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Estado { get; set; }
        public List<string> ListaDeTareasSegunHorario { get; set; }
    }
}
