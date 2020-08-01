namespace Profesiones.Interface
{
    public class EmpleadoVendedorNocturno : IHorarioVendedor
    {
        public string ContactarClientes()
        {
            return "Vendo  a clientes en la noche  ";
        }

        public string RealizarPubliciadad()
        {
            return "Busco tecnícas de publicidad en la noche";
        }

        public string CobrarDinero()
        {
            return "Recibo  el dinero de los clientes en la noche";
        }

        public string DarCambio()
        {
            return "Devuelo el cambio de los clientes en la noche ";
        }
    }


}

