namespace Profesiones.Interface
{
    public class ProveedorElectrodomesticos : IProveedores
    {
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
            return "Realizo las entregas en una camioneta";
        }
    }




}

