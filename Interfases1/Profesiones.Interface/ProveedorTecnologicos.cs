namespace Profesiones.Interface
{
    public class ProveedorTecnologicos : IProveedores
    {
        public string EntregarProductos()
        {
            return "Me encargo de entregar los pedidos tecnológicos";
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
            return "Realizo las entregas en un Camión";
        }
    }

}

