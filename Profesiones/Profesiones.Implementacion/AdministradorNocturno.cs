using Profesiones.Entidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class AdministradorNocturno : IAdministrador, IEquatable<AdministradorNocturno>
    {
        //Composición
        private readonly DuenoPrincipal duenoTienda = new DuenoPrincipal();
        public int Id { get { return duenoTienda.Id; } set { duenoTienda.Id = value; } }
        public DuenoPrincipal DuenoTienda1 { get; set; }

        public bool Equals([AllowNull] AdministradorNocturno other)
        {
            return this.Id == other.Id;
        }
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