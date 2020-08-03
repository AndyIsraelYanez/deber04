using Profesiones.Interface;
using Profesiones.Entidad;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class EmpleadoVendedorTecnologicos : IEmpleadoVenderor, IEquatable<EmpleadoVendedorTecnologicos>
    {
        private readonly EmpleadoVendedor empleadoVendedor = new EmpleadoVendedor();
        public int Id { get { return empleadoVendedor.Id; } set { empleadoVendedor.Id = value; } }
        public EmpleadoVendedor EmpleadoVendedor { get; set; }
        public bool Equals([AllowNull] EmpleadoVendedorTecnologicos other)
        {
            return this.Id == other.Id;
        }
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