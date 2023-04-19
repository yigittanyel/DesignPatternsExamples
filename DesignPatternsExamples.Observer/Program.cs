

Student s = new Student();
s.AddObserver(new FatherObserver());
s.AddObserver(new MotherObserver());

s.Name = "Yigit";
s.ClassName = "12A";
s.IsTruancy = true;

Console.ReadKey(true);



public abstract class Observer
{
    public abstract void Update();
}

public class FatherObserver : Observer
{
    public override void Update()
    {
        Console.WriteLine("The student's truancy was reported to the father.");
    }
}

public class MotherObserver : Observer
{
    public override void Update()
    {
        Console.WriteLine("The student's truancy was reported to the mother.");
    }
}

public class Student
{
    public string Name { get; set; }
    public string ClassName { get; set; }

    bool isTruancy;

    public bool IsTruancy
    {
        get { return isTruancy; }
        set
        {
            if (value)
            {
                Notify();
                isTruancy = true;
            }
            else
                isTruancy = value;
        }
    }

    List<Observer> observers = new List<Observer>();

    public void AddObserver(Observer observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(Observer observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        observers.ForEach(observer => observer.Update());
    }
}
