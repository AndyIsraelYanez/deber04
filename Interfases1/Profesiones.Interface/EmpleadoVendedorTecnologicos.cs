namespace Profesiones.Interface
{
    public class EmpleadoVendedorTecnologicos : IEmpleadoVenderor
    {
        public string Saludar()
        {
            return "Se saluda primero  ya que es algo fundamental y de muy buena educación";
        }
        public string Atender()
        {
            return "Estoy antendiendo en la seccion de equiposTecnologicos ";
        }

        public string Informar()
        {
            return "Estoy dando características del objeto Tecnologicos ";
        }
        public string Cobrar()
        {
            return "Estoy  cobrando al cliente en efectivo o crédito por la compra que realizo de su equipo Tecnológico";
        }
        public string Agradecer()
        {
            return " y Agradecer  por su compra del equipo Tecnológico";
         }

        public string AnotarLoVendido()
            {
                return "Estoy escribiendo el electrodoméstico que se vendió ";
            }
        }
    }