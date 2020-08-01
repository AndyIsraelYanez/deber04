namespace Profesiones.Interface
{
    public class EmpleadoVendedorDia : IHorarioVendedor
    {
        public string ContactarClientes()
        {
            return "Vendo  a clientes en el horario vepertino  ";
        }

        public string RealizarPubliciadad()
        {
            return "Busco tecnícas de publicidad en la jornada vespertina";
        }

        public string CobrarDinero()
        {
            return "Recibo  el dinero de los clientes en el día";
        }

        public string DarCambio()
        {
            return "Devuelo el cambio de los clientes en  la jornaja Vespertina ";
        }
    }

}
