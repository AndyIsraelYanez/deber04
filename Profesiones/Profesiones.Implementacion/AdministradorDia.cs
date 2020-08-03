using Profesiones.Entidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class AdministradorDia : IAdministrador,IEquatable<AdministradorDia>
    {
        private readonly Administrador1 administrador = new Administrador1();
        public int Id { get { return administrador.Id; } set { administrador.Id = value; } }
        public Administrador1 Administrador1 { get; set; }

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

        public bool Equals([AllowNull] AdministradorDia other)
        {
            return this.Id == other.Id;
        }
    }
}