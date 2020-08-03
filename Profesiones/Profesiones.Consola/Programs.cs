using Profesiones.Negocio;
using Profesiones.Implementacion;
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

            Random generador = new Random();


            //Un empleado vendedor electrodomesticos
            var empleadoElectrodomestico = new EmpleadoVendedorElectrodomesticos { Id = generador.Next() };
            var empleadoVendedorElectrodomestico = LaOrganizacion.ContratarEmpleadoVendedor(empleadoElectrodomestico);
            var empleadoElectrodomesticoAtender = LaOrganizacion.AtenderCliente();
            //empleadoVendedor
            var empleadoVendedor = LaOrganizacion.ContratarEmpleadoVendedor(new EmpleadoVendedorCualquiera());
            var empleadoVendedorAtender = LaOrganizacion.AtenderCliente();
            //empleadoVendedor de Tecnologia
            var empleadoVendedorTecnologico = LaOrganizacion.ContratarEmpleadoVendedor(new EmpleadoVendedorTecnologicos());
            var empleadoVendedorTecnologicoAtender = LaOrganizacion.AtenderCliente();

            //El Gerente 
            var gerente = LaOrganizacion.BuscarDuenoDeTienda(new Gerente());
            var gerenteConoceAlmacen = LaOrganizacion.ConocerAlmacen();
            //Dueño de la tienda es importante conoceer que la ñ esta reemplazado por la N en las clases
            var duenoTienda = LaOrganizacion.BuscarDuenoDeTienda(new DuenoTienda());
            var duenoConeAlmacen = LaOrganizacion.ConocerAlmacen();

            // Los Proveedores  de elctrodomésticos
            var proveedorElectrodomestico = LaOrganizacion.PedirProveedor(new ProveedorElectrodomesticos());
            var proveedorElectrodomesticoEntrega = LaOrganizacion.EntregarPedido();
            // Los proveedores de equipos tecnológicos
            var proveedorTecnologico = LaOrganizacion.PedirProveedor(new ProveedorTecnologicos());
            var proveedorTecnologicoEntrega = LaOrganizacion.EntregarPedido();

            //Los Administradores que trabajan en la jornada nocturna
            var administradorNocturno = LaOrganizacion.ContratarAdministrador(new AdministradorNocturno());
            var administradorNocturnoDesarrolla = LaOrganizacion.DesarrollarActividad();
            //Los administradores que trabajan en la jornada del dia
            var administradorDia = LaOrganizacion.ContratarAdministrador(new AdministradorDia());
            var administradorDiaDesarrolla = LaOrganizacion.DesarrollarActividad();

            //Horarios de trabajo de un empleado vendedor en la noche 
            var empleadoVendedorNocturno = LaOrganizacion.BuscarEmpleadosNocturno(new EmpleadoVendedorNocturno());
            var empleadoVendedorNocturnoDistribuir = LaOrganizacion.DistribuirTrabajo();
            //Horarios de trabajo de un empleado vendedor en el dia 
            var empleadoVendedorDia = LaOrganizacion.BuscarEmpleadosNocturno(new EmpleadoVendedorDia());
            var empleadoVendedorDiaDistribuir = LaOrganizacion.DistribuirTrabajo();


            //titulo que se mostrara en la consola
            Console.WriteLine($"--------------------");
            Console.WriteLine($"- ");
            Console.WriteLine($"--------------------");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"\t Informacion de los roles que cumplen  los integrantes de un  (Almacen)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"--------------------");
            Console.WriteLine($"- ");
            Console.WriteLine($"--------------------");

            //empleado vendedor
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Especificación de ventas");
            Console.WriteLine($"{empleadoElectrodomestico.Id} {empleadoVendedorElectrodomestico} electrodomestico");
            Console.WriteLine(empleadoElectrodomesticoAtender);

            Console.WriteLine($"- ");
            Console.WriteLine($"-");
            Console.WriteLine(empleadoVendedor + " Común");
            Console.WriteLine(empleadoVendedorAtender);
            Console.WriteLine($"- ");
            Console.WriteLine($"-");
            Console.WriteLine(empleadoVendedorTecnologico + " tecnológicos");
            Console.WriteLine(empleadoVendedorTecnologicoAtender);

            //El Gerente
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Personas con mayor autoridad en el almacen");
            Console.WriteLine($"-");
            Console.WriteLine(duenoTienda + " Dueño de Almacen");
            Console.WriteLine(duenoConeAlmacen);
            Console.WriteLine($"- ");
            Console.WriteLine($"-");
            Console.WriteLine(gerente + " Gerente");
            Console.WriteLine(gerenteConoceAlmacen);

            //Los Proveedores 
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Los Proveedores   quienes abastecen de productos al almacen");
            Console.WriteLine($"-");
            Console.WriteLine(proveedorTecnologico + " Dueño del Almacen");
            Console.WriteLine(proveedorTecnologicoEntrega);
            Console.WriteLine($"- ");
            Console.WriteLine($"-");
            Console.WriteLine(proveedorElectrodomestico + " Dueño del almacen");
            Console.WriteLine(proveedorElectrodomesticoEntrega);

            //Los Administradores del almacen en sus Horarios
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Los Administradores del almacen en sus Horarios");
            Console.WriteLine($"-");
            Console.WriteLine(administradorNocturno + " en el almacen");
            Console.WriteLine(administradorNocturnoDesarrolla);
            Console.WriteLine($"- ");
            Console.WriteLine($"-");
            Console.WriteLine(administradorDia + " en el almacen");
            Console.WriteLine(administradorDiaDesarrolla);

            //Horarios de trabajo en el dia o la noche  de un empleado vendedor
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Horarios de trabajo en el dia o la noche  de un empleado vendedor");
            Console.WriteLine($"-");
            Console.WriteLine(empleadoVendedorNocturno + " Dia");
            Console.WriteLine(empleadoVendedorNocturnoDistribuir);
            Console.WriteLine($"- ");
            Console.WriteLine($"-");
            Console.WriteLine(empleadoVendedorDia + " Noche");
            Console.WriteLine(empleadoVendedorDiaDistribuir);
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ReadKey();
        }

    }
}