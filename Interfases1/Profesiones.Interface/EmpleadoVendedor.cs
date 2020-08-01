namespace Profesiones.Interface
{
    public class EmpleadoVendedor : IEmpleadoVenderor
    {
        public string Saludar()
        {
            return "Se saluda primero ya que es algo fundamental ";
        }
        public string Atender()
        {
            return "Estoy antendiendo ";
        }

        public string Informar()
        {
            return "Estoy dando características del objeto ";
        }
        public string Cobrar()
        {
            return "me encuentro cobrando ";
        }
        public string Agradecer()
        {
            return "Es importante agradecer a las personas por su compra";
        }

        public string AnotarLoVendido()
            {
                return "y escribiendo lo vendido ";
            }
        }

    }

