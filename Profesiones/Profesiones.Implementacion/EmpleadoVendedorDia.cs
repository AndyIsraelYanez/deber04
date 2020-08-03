using Profesiones.Entidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class EmpleadoVendedorDia : IHorarioVendedor, IEquatable<EmpleadoVendedorDia>
    {
        private readonly HorarioVendedor1 horarioVendedor = new HorarioVendedor1();
        public int Id { get { return horarioVendedor.Id; } set { horarioVendedor.Id = value; } }
        public HorarioVendedor1 HorarioVendedor1 { get; set; }
        public bool Equals([AllowNull] EmpleadoVendedorDia other)
        {
            return this.Id == other.Id;
        }
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