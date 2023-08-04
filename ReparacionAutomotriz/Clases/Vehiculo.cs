namespace ReparacionAutomotriz.Clases;
class Vehiculo
{
    private string placa;
    public string Placa
    {
        get { return placa; }
        set { placa = value; }
    }

    private string modelo;
    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }
    
    private string marca;
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }
    
    private string color;
    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    
    private int km;
    public int Km
    {
        get { return km; }
        set { km = value; }
    }
    
    public Vehiculo()
    {
        
    }

    public Vehiculo(string placa, string modelo, string marca, string color, int km)
    {
        this.Placa = placa;
        this.Modelo = modelo;
        this.Marca = marca;
        this.Color = color;
        this.Km = km;
    }

    public Vehiculo Agregar(){
        Vehiculo vehiculo = new Vehiculo();
        Console.Write("Ingrese la placa del vehiculo: ");
        vehiculo.placa = Console.ReadLine();
        Console.Write("Ingrese el modelo del vehiculo: ");
        vehiculo.modelo = Console.ReadLine();
        Console.Write("Ingrese la marca del vehiculo: ");
        vehiculo.marca = Console.ReadLine();
        Console.Write("Ingrese el color del vehiculo: ");
        vehiculo.color = Console.ReadLine();
        Console.Write("Ingrese el kilometraje del vehiculo: ");
        vehiculo.km = int.Parse(Console.ReadLine());
        return vehiculo;
    }

    public void mostrarVehiculoCliente(Cliente cliente){
        foreach (var item in cliente.Vehiculos){
            Console.WriteLine(item);
        }
    }
}