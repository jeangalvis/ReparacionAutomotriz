namespace ReparacionAutomotriz.Clases;
class Empleado
{
    private string cc;
    public string CC
    {
        get { return cc; }
        set { cc = value; }
    }

    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    private string telefono;
    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }

    private string especialidad;
    public string Especialidad
    {
        get { return especialidad; }
        set { especialidad = value; }
    }

    public Empleado()
    {

    }

    public Empleado(string cc, string nombre, string telefono, string especialidad)
    {
        this.CC = cc;
        this.Nombre = nombre;
        this.Telefono = telefono;
        this.Especialidad = especialidad;
    }

    public Empleado AgregarEmpleado()
    {
        Empleado empleado = new Empleado();
        Console.Write("Ingrese la cedula del empleado: ");
        empleado.cc = Console.ReadLine();
        Console.Write("Ingrese el nombre del empleado: ");
        empleado.nombre = Console.ReadLine();
        Console.Write("Ingrese el telefono del empleado: ");
        empleado.telefono = Console.ReadLine();
        Console.Write("Ingrese la especialidad del empleado: ");
        empleado.especialidad = Console.ReadLine();
        return empleado;
    }

    public void MostrarEmpleados(List<Empleado> empleadosList)
    {
        Console.Clear();
        Console.WriteLine("CC\tNombre\tTelefono\tEspecialidad");
        foreach (var item in empleadosList)
        {
            Console.WriteLine($"{item.CC}\t{item.Nombre}\t{item.Telefono}\t{item.Especialidad}");
        }
        Console.ReadKey();
    }

    public Empleado BuscarEmpleado(List<Empleado> empleadosList)
    {
        MostrarEmpleados(empleadosList);
        Console.Write("Ingrese la cedula del empleado: ");
        string opcion = Console.ReadLine();
        return empleadosList.Find(n => n.CC.Equals(opcion));
    }
}