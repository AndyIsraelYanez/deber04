namespace Profesiones.Interface
{
    public class AdministradorDia : IAdministrador
    {

        public string RealizarCalculoVentas()
        {
            return "Realizo el calculo de ventas que se realizan  en la jornada vespertina";
        }

        public string AsignarTareas()
        {
            return "Asigno tareas que son necesarias a  los  empleados vendedores en el dia";
        }

        public string ComunicarProductosAcaban()
        {
            return "Comunico al gerente los articulos que son necesarios y que se agotaron ";
        }

        public string PlanearEstrategiasVentas()
        {
            return "Observo  y reviso estrategias de marketing";
        }
    }
}
