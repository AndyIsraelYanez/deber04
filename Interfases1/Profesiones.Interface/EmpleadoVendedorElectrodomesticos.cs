namespace Profesiones.Interface
{
    public class EmpleadoVendedorElectrodomesticos : IEmpleadoVenderor
    {
        public string Saludar()
        {
            return "Se saluda primero   ya que das a conocer que tienes valores";
        }
        public string Atender()
        {
            return "Estoy antendiendo en la seccion de electrodomésticos ";
        }

        public string Informar()
        {
            return "Estoy dando características del objeto electrodomésticos ";
        }
        public string Cobrar()
        {
            return "Estoy  cobrando al cliente en efectivo o crédito para comprar su electrodoméstico";
        }
        public string Agradecer()
        {
            return "Agradecido por su compra del electrodoméstico";
        }

        public string AnotarLoVendido()
            {
                return "y escribiendo el electrodoméstico que se vendió ";
            }
        }
}
