namespace ReparacionAutomotriz.View;
class MainMenu{
    public MainMenu() { }

    public int menu(){
    Console.Clear();
    Console.WriteLine("1. Registrar Clientes");
    Console.WriteLine("2. Registrar Vechiculos");
    Console.WriteLine("3. Registrar Empleados");
    Console.WriteLine("4. Orden de Servicio");
    Console.WriteLine("5. Facturacion");
    Console.WriteLine("6. salir");
    Console.Write("Seleccione una opcion: ");
    return int.Parse(Console.ReadLine());
    }
}