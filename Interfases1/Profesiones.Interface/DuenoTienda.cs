namespace Profesiones.Interface
{
    public class DuenoTienda : IDuenoDeTienda
    {
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
