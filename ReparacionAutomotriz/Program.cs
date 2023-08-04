using ReparacionAutomotriz.View;
using ReparacionAutomotriz.Clases;
internal class Program{
private static void Main(string[] args){
    int opcion =0;
    List<Cliente> clientes = new List<Cliente>();
        MainMenu menu = new MainMenu();

        do
        {
            opcion= menu.menu();
            switch  (opcion){
                case 1:
                    RegistrarUsuario(clientes);
                    break;
                case 2:
                    RegistrarVehiculo(clientes);
                    break;
                default:
                    break;
            }
        } while (opcion!=6);
    }

static void RegistrarUsuario(List<Cliente> clientes){
    Cliente c = new Cliente();
    Cliente opcionCliente;

    opcionCliente = c.AgregarCliente();
    clientes.Add(opcionCliente);
    c.MostrarClientes(clientes);
}
static void RegistrarVehiculo(List<Cliente> clientes){
    Cliente c = new Cliente();
    Vehiculo v = new Vehiculo();
    Cliente opcionCliente;
    Vehiculo opcionVehiculo;


    opcionCliente = c.BuscarClientes(clientes);
    Console.WriteLine(opcionCliente.Nombre);
    Console.ReadKey();
    //v.mostrarVehiculoCliente(opcionCliente);
    //opcionCliente.Vehiculo = opcionVehiculo;
}

}


