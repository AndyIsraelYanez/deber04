using Profesiones.Interface;
using Profesiones.Entidad;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class EmpleadoVendedorElectrodomesticos : IEmpleadoVenderor, IEquatable<EmpleadoVendedorElectrodomesticos>
    {
        private readonly EmpleadoVendedor empleadoVendedor = new EmpleadoVendedor();
        public int Id { get { return empleadoVendedor.Id; } set { empleadoVendedor.Id = value; } }
        public EmpleadoVendedor EmpleadoVendedor { get; set; }
        public bool Equals([AllowNull] EmpleadoVendedorElectrodomesticos other)
        {
            return this.Id == other.Id;
        }
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
