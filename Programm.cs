using System;
using System.Collections.Generic;

abstract class Empleado
{
    public string Nombre { get; set; } = "";
    public string dni {get; set;}="";
    public abstract void Trabajar();

    public abstract void hablar();
}

interface ICobrador
{
    void Cobrar();
}

class Aaron : Empleado
{
    public override void hablar()
    {
        
        Console.WriteLine("Y TAMBIEN SOOY MUY GORDO.");
    }
    public override void Trabajar()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("AARON ESCRIBE CODIGO COMO LOCO.");
    }
}

class GerenteAcosta : Empleado, ICobrador
{

    public override void hablar()
    {
        
        Console.WriteLine("OJO CONMIGO.");
    }
    public override void Trabajar()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("EL LOCO TE OBSERVA.");
    }

    public void Cobrar()
    {
        Console.WriteLine("EL LOCO COBRA MUCHO JAJA.");
    }
}

class Orihuel : Empleado
{

    public override void hablar()
    {
        Console.WriteLine("Y PREGUNTA SI MACIEL VENDE CONTENIDO?.");
    }
    public override void Trabajar()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("EL NEGRO ORI TRABAJA TRABAJA COMO ESCLAVO.");
    }
}

class Program
{
    static void Main()
    {
        List<Empleado> empleados = new List<Empleado>();
        empleados.Add(new Aaron { Nombre = "Aaron",dni="43565777" });
        empleados.Add(new GerenteAcosta { Nombre = "Gerente Acosta",dni="43915901"});
        empleados.Add(new Orihuel { Nombre = "Orihuel", dni="44567765"});

        foreach (Empleado empleado in empleados)
        {
            empleado.Trabajar();
            empleado.hablar();

            if (empleado is ICobrador cobrador)
            {
                cobrador.Cobrar();
            }

        }

    }
}