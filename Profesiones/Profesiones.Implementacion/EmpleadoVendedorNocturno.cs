using Profesiones.Entidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class EmpleadoVendedorNocturno : IHorarioVendedor, IEquatable<EmpleadoVendedorNocturno>
    {
        private readonly HorarioVendedor1 horarioVendedor = new HorarioVendedor1();
        public int Id { get { return horarioVendedor.Id; } set { horarioVendedor.Id = value; } }
        public HorarioVendedor1 HorarioVendedor1 { get; set; }
        public bool Equals([AllowNull] EmpleadoVendedorNocturno other)
        {
            return this.Id == other.Id;
        }
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