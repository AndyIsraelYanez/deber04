using Profesiones.Interface;
using Profesiones.Entidad;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class EmpleadoVendedorCualquiera : IEmpleadoVenderor, IEquatable<EmpleadoVendedorCualquiera>
    {
        private readonly EmpleadoVendedor empleadoVendedor = new EmpleadoVendedor();
        public int Id { get { return empleadoVendedor.Id; } set { empleadoVendedor.Id = value; } }
        public EmpleadoVendedor EmpleadoVendedor { get; set; }
        public bool Equals([AllowNull] EmpleadoVendedorCualquiera other)
        {
            return this.Id == other.Id;
        }
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