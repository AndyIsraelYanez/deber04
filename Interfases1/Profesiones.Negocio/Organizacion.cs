using Profesiones.Interface;

namespace Profesiones.Negocio
{
    public class Organizacion
    {
        public IEmpleadoVenderor EmpleadoVendedor { get; set; }
        public IDuenoDeTienda DuenoDeTienda { get; set; }
        public IProveedores Proveedores { get; set; }
        public IAdministrador Administrador { get; set; }
        public IHorarioVendedor HorarioVendedor { get; set; }

        //Aqui se  encuentra empleado vendedor
        public string ContratarEmpleadoVendedor(IEmpleadoVenderor empleadoVendedor)
        {
            EmpleadoVendedor = empleadoVendedor;
            return "Se contratato segun  la hoja de vida a un Empleado Vendedor ";
        }
        public string AtenderCliente()
        {
            return $"Para atender a un cliente {EmpleadoVendedor.Saludar()}, {EmpleadoVendedor.Atender()}" +
                $", {EmpleadoVendedor.Cobrar()}, {EmpleadoVendedor.Informar()}, {EmpleadoVendedor.Agradecer()}," +
                $"  {EmpleadoVendedor.AnotarLoVendido()} ya que eso es muy principal";
        }
        //Dueño  del almacen
        public string BuscarDuenoDeTienda(IDuenoDeTienda duenoDeTienda)
        {
            DuenoDeTienda = duenoDeTienda;
            return " Se busco al dueño de la tienda para que nos explique la función que el realiza";
        }
        public string ConocerAlmacen()
        {
            return $"Se verifica que los recursos que faltan se los agreguen y {DuenoDeTienda.ObservarCalidadRopa()}" +
                $",y cada fin de semana realizo {DuenoDeTienda.RealizarPedidos()}, y también {DuenoDeTienda.CambiarPedidos()},principalmente mi rol el {DuenoDeTienda.PagarDinero()}";


        }

        //Aqui se encuentras los proovedores de los equipos tecnologicos y electrodomesticos 
        public string PedirProveedor(IProveedores proveedor)
        {
            Proveedores = proveedor;
            return "El proveedor realiza la entrega ";
        }


        public string EntregarPedido()
        {
            return $"Yo como proveedor  {Proveedores.EntregarProductos()}, {Proveedores.RegistarProductos()}" +
                $", {Proveedores.CobrarDinero()},y {Proveedores.Movilizacion()}";
        }

        //Administrador aquella que ocupa una categoria mas abajo del gerente
        public string ContratarAdministrador(IAdministrador administrador)
        {
            Administrador = administrador;
            return "Las funciones que tiene el  administrador ";
        }

        public string DesarrollarActividad()
        {
            return $"Practicamente {Administrador.RealizarCalculoVentas()}, y {Administrador.AsignarTareas()}" +
                $", de la misma manera {Administrador.ComunicarProductosAcaban()},y también {Administrador.PlanearEstrategiasVentas()}";
        }

        //Horarios de los empleados que venden
        public string BuscarEmpleadosNocturno(IHorarioVendedor horarioVendedor)
        {
            HorarioVendedor = horarioVendedor;
            return "Actividades que realizan los empleados vendedores en la ";
        }
        public string DistribuirTrabajo()
        {
            return $"Mi caracteristica principal es que  {HorarioVendedor.ContactarClientes()}, y tambien {HorarioVendedor.RealizarPubliciadad()}" +

                $", {HorarioVendedor.CobrarDinero()},y {HorarioVendedor.DarCambio()}";
        }
        //Contratar Empleados  en especifico
       /* public string ContratarEmpleadoVendedor()
        {
            EmpleadoVendedor = new EmpleadoVendedor();
            return "Se buscó un empleado para que se integre al almacen ";
        }
        //Contratar Contratar EmpleadoVendedorElectrodomesticos
        public string ContratarEmpleadoVendedorElectrodomesticos()
        {
            EmpleadoVendedor = new EmpleadoVendedorElectrodomesticos();
            return "Se buscó un Empleado que sepa  acerca  de los electrodomésticos  y los pueda vender";
        }
        //Contratar Empleado Vendedor Tecnologicos
        public string EmpleadoVendedorTecnologicos()
        {
            EmpleadoVendedor = new EmpleadoVendedorTecnologicos();
            return "Se buscó un Empleado que sepa  acerca  de los productos tecnológicos  y los pueda vender";
        }*/

    }
}