using System;
using System.Collections.Generic;

abstract class Empleado
{
    public string Nombre { get; set; } = "";
    public abstract void Trabajar();
}

interface ICobrador
{
    void Cobrar();
}

class Aaron : Empleado
{
    public override void Trabajar()
    {
        Console.WriteLine("AARON ESCRIBE CODIGO COMO LOCO.");
    }
}

class GerenteAcosta : Empleado, ICobrador
{
    public override void Trabajar()
    {
        Console.WriteLine("EL LOCO TE OBSERVA.");
    }

    public void Cobrar()
    {
        Console.WriteLine("EL LOCO COBRA MUCHO JAJA.");
    }
}

class Orihuel : Empleado
{
    public override void Trabajar()
    {
        Console.WriteLine("EL NEGRO ORI TRABAJA TRABAJA COMO ESCLAVO.");
    }
}

class Program
{
    static void Main()
    {
        List<Empleado> empleados = new List<Empleado>();
        empleados.Add(new Aaron { Nombre = "Aaron" });
        empleados.Add(new GerenteAcosta { Nombre = "Gerente Acosta" });
        empleados.Add(new Orihuel { Nombre = "Orihuel" });

        foreach (Empleado empleado in empleados)
        {
            empleado.Trabajar();

            if (empleado is ICobrador cobrador)
            {
                cobrador.Cobrar();
            }

        }

    }
}