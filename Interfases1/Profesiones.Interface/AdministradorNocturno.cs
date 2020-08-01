namespace Profesiones.Interface
{
    public class AdministradorNocturno : IAdministrador
    {
        public string RealizarCalculoVentas()
        {
            return "Realizo el calculo de ventas que se realizan  en la noche";
        }

        public string AsignarTareas()
        {
            return "Asigno tareas que son necesarias a  los  empleados vendedores";
        }

        public string ComunicarProductosAcaban()
        {
            return "Comunico al gerente los articulos que son necesarios  comprar";
        }

        public string PlanearEstrategiasVentas()
        {
            return "Observo  y reviso estrategias de marketing";
        }
    }

}

