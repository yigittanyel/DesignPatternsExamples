AsusLaptop asus = new AsusLaptop();
DellLaptop dell=new DellLaptop();

dell.OpenLid();
Console.WriteLine("------------------------------");
asus.CloseLid();

Console.ReadLine();

public class Computer
{
    public void Start()
    {
        Console.WriteLine($"{GetType().Name} is starting.");
    }

    public void ShutDown()
    {
        Console.WriteLine($"{GetType().Name} is shutting down.");
    }
}

public class Laptop : Computer
{
    public void OpenLid()
    {
        Console.WriteLine($"{GetType().Name}'s lid is opening");
    }

    public void CloseLid()
    {
        Console.WriteLine($"{GetType().Name}'s lid is closing");
    }
}

public class LaptopDecorator : Laptop
{
    public virtual void OpenLid()
    {
        base.OpenLid();
    }

    public virtual void CloseLid()
    {
        base.CloseLid();
    }
}

public class DellLaptop : LaptopDecorator
{
    public override void OpenLid()
    {
        Console.WriteLine("Dell laptop is opening");
        base.OpenLid();
    }
}

public class AsusLaptop : LaptopDecorator
{
    public override void CloseLid()
    {
        base.CloseLid();
        Console.WriteLine("Good bye :)");
    }
}