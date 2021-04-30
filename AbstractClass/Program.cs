using System;
public abstract class Vehicle
{
    public abstract void Display();
}

public class Bus : Vehicle
{
    public override void Display()
    {
        Console.WriteLine("Bus");
    }
}

public class Car : Vehicle
{
    public override void Display()
    {
        Console.WriteLine("Car");
    }
}

public class Motorcycle : Vehicle
{
    public override void Display()
    {
        Console.WriteLine("Motorcycle");
    }
}

public class MyClass
{
    public static void Main()
    {
        Vehicle v;
        v = new Bus();
        v.Display();
        v = new Car();
        v.Display();
        v = new Motorcycle();
        v.Display();
    }
}