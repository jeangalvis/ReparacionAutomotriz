namespace ReparacionAutomotriz.Clases;
class Cliente
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

    private string apellido;
    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }


    private string telefono;
    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }

    private string email;
    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    private string fecha;
    public string Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }

    private List<Vehiculo> vehiculos = new List<Vehiculo>();
    public List<Vehiculo> Vehiculos
    {
        get { return this.vehiculos; }
        set { this.vehiculos = value; }
    }

    public Cliente()
    {

    }

    public Cliente(string cc, string nombre, string apellido, string telefono, string email, string fecha)
    {
        this.CC = cc;
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Telefono = telefono;
        this.Email = email;
        this.Fecha = fecha;
    }

    public Cliente AgregarCliente()
    {
        Cliente cliente = new Cliente();
        Console.Write("Ingrese la cedula del cliente: ");
        cliente.cc = Console.ReadLine();
        Console.Write("Ingrese el nombre del cliente: ");
        cliente.nombre = Console.ReadLine();
        Console.Write("Ingrese el apellido del cliente: ");
        cliente.apellido = Console.ReadLine();
        Console.Write("Ingrese el telefono del cliente: ");
        cliente.telefono = Console.ReadLine();
        Console.Write("Ingrese el email del cliente: ");
        cliente.email = Console.ReadLine();
        cliente.fecha = DateTime.Now.ToString();
        return cliente;
    }

    public void MostrarClientes(List<Cliente> cliente)
    {
        Console.Clear();
        Console.WriteLine("CC\tNombre\tApellido\tTelefono\tEmail\tFecha");
        foreach (var item in cliente)
        {
            Console.WriteLine($"{item.CC}\t{item.Nombre}\t{item.Apellido}\t{item.Telefono}\t{item.Email}\t{item.Fecha}");
        }
        Console.ReadKey();
    }

    public Cliente BuscarClientes(List<Cliente> cliente)
    {
        MostrarClientes(cliente);
        Console.Write("ingrese la CC del cliente: ");
        string opcion = Console.ReadLine();
        return cliente.Find(n => n.CC.Equals(opcion));
    }
}