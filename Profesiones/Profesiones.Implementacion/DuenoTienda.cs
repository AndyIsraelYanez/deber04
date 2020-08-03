using Profesiones.Entidad;
using Profesiones.Interface;
using Profesiones.Negocio;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class DuenoTienda : IDuenoDeTienda, IEquatable<DuenoTienda>

    {
        private readonly DuenoPrincipal dueñoPrincipal = new DuenoPrincipal();
        public int Id { get { return dueñoPrincipal.Id; } set { dueñoPrincipal.Id = value; } }
        public DuenoPrincipal DuenoPrincipal { get; set; }
        public Almacen Almacen { get; set; }

        public Almacen Fabrica = new Almacen()
        {
            Nombre = "GRANDES EN VENTAS"
        };
        public Almacen Fabrica2 = new Almacen()
        {
            Nombre = "XD FA"
        };
        public Almacen Fabrica3 = new Almacen()
        {
            Nombre = "GANGA MASTER"
        };

        public bool Equals([AllowNull] DuenoTienda other)
        {
            return this.Id == other.Id;
        }

        public string SupervisarEmpleados()
        {
            return $"Controlo que todo este en orden  de mi almacen {Fabrica2}";
        }

        public string ObservarCalidadRopa()
        {
            return $"Veririfico la calidad de la ropa  de la fabrica {Fabrica2.Nombre}";
        }

        public string RealizarPedidos()
        {
            return $"Realizo de los pedidos a la fabrica {Fabrica3.Nombre}";
        }

        public string CambiarPedidos()
        {
            return $"Me encargo  de  realizar cualquier cambio  de producto a la Fabrica  {Fabrica2.Nombre}";
        }

        public string PagarDinero()
        {
            return $"Me encargo  de pagar  los salarios   a todos  los trabajadores del almacen  {Fabrica3.Nombre}";
        }
    }
}