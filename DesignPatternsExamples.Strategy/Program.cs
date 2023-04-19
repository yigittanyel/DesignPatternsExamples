
SpecialProduction specialProduction = new SpecialProduction();
MassProduction massProduction = new MassProduction();

Producer producer1 = new Producer(specialProduction);
Producer producer2 = new Producer(massProduction);

Console.ReadLine();

class Car
{
    public Car(string productionType)
    {
        Console.WriteLine($"Car produced as {productionType}.");
    }

    public string Brand { get; set; }
    public string Model { get; set; }
}

abstract class Strategy
{
    public abstract Car Produce();
}

class MassProduction : Strategy
{
    public override Car Produce()
    {
        return new Car("mass");
    }
}

class SpecialProduction : Strategy
{
    public override Car Produce()
    {
        return new Car("special");
    }
}

class Producer
{
    public Producer(Strategy strategy)
    {
        strategy.Produce();
    }
}