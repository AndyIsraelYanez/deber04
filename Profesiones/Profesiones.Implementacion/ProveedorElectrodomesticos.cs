using Profesiones.Entidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class ProveedorElectrodomesticos : IProveedores, IEquatable<ProveedorElectrodomesticos>
    {
        private readonly Proveedores proveedor = new Proveedores();
        public int Id { get { return proveedor.Id; } set { proveedor.Id = value; } }
        public Proveedores Proveedores { get; set; }

        public Proveedores Carro = new Proveedores()
        {
            TipoCarroConduce = "Camion Fiat"
        };
        public bool Equals([AllowNull] ProveedorElectrodomesticos other)
        {
            return this.Id == other.Id;
        }
        public string EntregarProductos()
        {
            return "Me encargo de entregar los productos de Electrodomesticos";
        }

        public string RegistarProductos()
        {
            return "además me  encargo de registrar los productos de Electrodomesticos";
        }

        public string CobrarDinero()
        {
            return "Me encargo de cobrar el dinero de los  productos de Electrodomesticos";
        }

        public string Movilizacion()
        {
            return $"Realizo las entregas en un {Carro.TipoCarroConduce}.";
        }

       
    }
}