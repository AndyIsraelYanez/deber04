using Profesiones.Entidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class ProveedorTecnologicos : IProveedores, IEquatable<ProveedorTecnologicos>
    {
        private readonly Proveedores proveedor = new Proveedores();
        public int Id { get { return proveedor.Id; } set { proveedor.Id = value; } }
        public Proveedores Proveedores { get; set; }

        public Proveedores Carro = new Proveedores()
        {
            TipoCarroConduce = "Camioneta Niza "
        };
        public bool Equals([AllowNull] ProveedorTecnologicos other)
        {
            return this.Id == other.Id;
        }
        public string EntregarProductos()
        {
            return "Me encargo de entregar los productos de Electrodomesticos";
        }
        public string RegistarProductos()
        {
            return "Me encargo de registrar los productos tecnológicos";
        }

        public string CobrarDinero()
        {
            return "Me encargo de Cobrar el dinero  de los artículos  ";
        }

        public string Movilizacion()
        {
            return $"Realizo las entregas en una {Carro.TipoCarroConduce}";
        }
    }

}