class Vehiculo
{
    public virtual void Arrancar()
    {
        Console.WriteLine("El vehículo arranca.");
    }
}
interface IVolar
{
    void Volar();
}
class Auto : Vehiculo
{
    public override void Arrancar()
    {
        Console.WriteLine("El auto arranca normal.");
    }
}

class Moto : Vehiculo
{
    public override void Arrancar()
    {
        Console.WriteLine("La moto arranca con un rugido.");
    }
}

class Avion : Vehiculo, IVolar
{
    public override void Arrancar()
    {
        Console.WriteLine("El avión arranca con potencia.");
    }

    public void Volar()
    {
        Console.WriteLine("El avión está volando.");
    }
}

class Program
{
    static void Main()
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        vehiculos.Add(new Auto());
        vehiculos.Add(new Moto());
        vehiculos.Add(new Avion());


        foreach (var vehiculo in vehiculos)
        {
            vehiculo.Arrancar();
            if (vehiculo is IVolar volador)
            {
                volador.Volar();
            }
        }

    }
}