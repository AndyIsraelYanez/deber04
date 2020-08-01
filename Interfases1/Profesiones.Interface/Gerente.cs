namespace Profesiones.Interface
{
    public class Gerente : IDuenoDeTienda
    {
        public Almacen Almacen { get; set; }

        public Almacen Almacen1 = new Almacen()
        {
            Nombre = "ADIDAS MASTER"
        };
        public Almacen Almacen2 = new Almacen()
        {
            Nombre = "ALMACEN XD"
        };
        public Almacen Almacen3 = new Almacen()
        {
            Nombre = "ALMACEN PATODOS"
        };



        public string SupervisarEmpleados()
        {
            return $"Informar y verifcar  que no falte  en mi almacen {Almacen2}";
        }

        public string ObservarCalidadRopa()
        {
            return $"Informar si la calidad de ropa  es buena o mala en el  {Almacen3.Nombre}";
        }

        public string RealizarPedidos()
        {
            return $" Puedo  realizar pedidos  para mi {Almacen3.Nombre}";
        }

        public string CambiarPedidos()
        {
            return $"Puedo solicitar cambios de pedídos para mi  {Almacen3.Nombre}";
        }

        public string PagarDinero()
        {
            return $"Puedo depósitar   a los trabajadores  de la empresa {Almacen1.Nombre}";
        }

    }

}
