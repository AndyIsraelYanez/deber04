using Profesiones.Interface;
using System;

namespace Profesiones.Consola
{
    class Programs
    {
        static void Main(string[] args)
        {
            if (args == null)
            {
                Console.WriteLine("Bienvenido");
            }

            Organizacion LaOrganizacion = new Organizacion();
            //Un empleado vendedor
            var empleadoVendedorElectrodomestico = LaOrganizacion.ContratarEmpleadoVendedor(new EmpleadoVendedorElectrodomesticos());
            var empleadoVendedorElectrodomesticoAtender = LaOrganizacion.AtenderCliente();
            var empleadoVendedor = LaOrganizacion.ContratarEmpleadoVendedor(new EmpleadoVendedor());
            var empleadoVendedorAtender = LaOrganizacion.AtenderCliente();
            var empleadoVendedorTecnologico = LaOrganizacion.ContratarEmpleadoVendedor(new EmpleadoVendedorTecnologicos());
            var empleadoVendedorTecnologicoAtender = LaOrganizacion.AtenderCliente();
            //El Gerente
            var gerente = LaOrganizacion.BuscarDuenoDeTienda(new Gerente());
            var gerenteConoceAlmacen = LaOrganizacion.ConocerAlmacen();
            var duenoTienda = LaOrganizacion.BuscarDuenoDeTienda(new DuenoTienda());
            var duenoConeAlmacen = LaOrganizacion.ConocerAlmacen();
            // Los Proveedores 
            var proveedorElectrodomestico = LaOrganizacion.PedirProveedor(new ProveedorElectrodomesticos());
            var proveedorElectrodomesticoEntrega = LaOrganizacion.EntregarPedido();
            var proveedorTecnologico = LaOrganizacion.PedirProveedor(new ProveedorTecnologicos());
            var proveedorTecnologicoEntrega = LaOrganizacion.EntregarPedido();

            //Los Administradores del almacen
            var administradorNocturno = LaOrganizacion.ContratarAdministrador(new AdministradorNocturno());
            var administradorNocturnoDesarrolla = LaOrganizacion.DesarrollarActividad();
            var administradorDia = LaOrganizacion.ContratarAdministrador(new AdministradorDia());
            var administradorDiaDesarrolla = LaOrganizacion.DesarrollarActividad();

            //Horarios de trabajo en el dia o la noche 
            var empleadoVendedorNocturno = LaOrganizacion.BuscarEmpleadosNocturno(new EmpleadoVendedorNocturno());
            var empleadoVendedorNocturnoDistribuir = LaOrganizacion.DistribuirTrabajo();
            var empleadoVendedorDia = LaOrganizacion.BuscarEmpleadosNocturno(new EmpleadoVendedorDia());
            var empleadoVendedorDiaDistribuir = LaOrganizacion.DistribuirTrabajo();

            Console.WriteLine($"\tBuscar elementos  para una buena administracion de (Almacenes)");
            Console.WriteLine($"--------------------");
            Console.WriteLine($"- ");
            Console.WriteLine($"--------------------");

            //empleado vendedor
            Console.WriteLine(empleadoVendedorElectrodomestico + " Electrodomésticos");
            Console.WriteLine(empleadoVendedorElectrodomesticoAtender);
            Console.WriteLine($"- ");
            Console.WriteLine($"--------------------");
            Console.WriteLine(empleadoVendedor + " Común");
            Console.WriteLine(empleadoVendedorAtender);
            Console.WriteLine($"- ");
            Console.WriteLine($"--------------------");
            Console.WriteLine(empleadoVendedorTecnologico + " tecnológicos");
            Console.WriteLine(empleadoVendedorTecnologicoAtender);

            //El Gerente
            Console.WriteLine($"- ");
            Console.WriteLine($"--------------------");
            Console.WriteLine(duenoTienda + " Dueño de Almacen");
            Console.WriteLine(duenoConeAlmacen);
            Console.WriteLine($"- ");
            Console.WriteLine($"--------------------");
            Console.WriteLine(gerente + " Gerente");
            Console.WriteLine(gerenteConoceAlmacen);

            //Los Proveedores 
            Console.WriteLine($"- ");
            Console.WriteLine($"--------------------");
            Console.WriteLine(proveedorTecnologico + " Dueño del Almacen");
            Console.WriteLine(proveedorTecnologicoEntrega);
            Console.WriteLine($"- ");
            Console.WriteLine($"--------------------");
            Console.WriteLine(proveedorElectrodomestico + " Dueño del almacen");
            Console.WriteLine(proveedorElectrodomesticoEntrega);

            //Los Administradores del almacen en sus Horarios
            Console.WriteLine($"- ");
            Console.WriteLine($"--------------------");
            Console.WriteLine(administradorNocturno + " en el almacen");
            Console.WriteLine(administradorNocturnoDesarrolla);
            Console.WriteLine($"- ");
            Console.WriteLine($"--------------------");
            Console.WriteLine(administradorDia + " en el almacen");
            Console.WriteLine(administradorDiaDesarrolla);

            //Horarios de trabajo en el dia o la noche  de un empleado vendedor
            Console.WriteLine($"- ");
            Console.WriteLine($"--------------------");
            Console.WriteLine(empleadoVendedorNocturno + " Dia");
            Console.WriteLine(empleadoVendedorNocturnoDistribuir);
            Console.WriteLine($"- ");
            Console.WriteLine($"--------------------");
            Console.WriteLine(empleadoVendedorDia + " Noche");
            Console.WriteLine(empleadoVendedorDiaDistribuir);

            Console.ReadKey();
        }

    }
}
