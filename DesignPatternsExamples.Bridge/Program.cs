//Aşağıdaki kod, Bridge Design Pattern’ı uygulayan bir örnek göstermektedir. İki farklı komut sınıfı (TurnOnCommand ve TurnOffCommand) bir arayüzle (ICommand) birleştiriliyor ve bu arayüz bir sınıf (Switch) tarafından kullanılıyor. Bu örnekte “ICommand” arayüzü “Bridge” rolünü oynamaktadır.


ILight light = new Light();
ICommand turnOnCommand = new TurnOnCommand(light);
ICommand turnOffCommand = new TurnOffCommand(light);
Switch s=new Switch(turnOnCommand, turnOffCommand);

s.FlipUp();
s.FlipDown();


public interface ICommand{
    void Execute();
}

public interface ILight
{
    void TurnOn();
    void TurnOff();
}

public class TurnOnCommand : ICommand
{
    private ILight _light;

    public TurnOnCommand(ILight light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }
}

public class TurnOffCommand : ICommand
{
    private ILight _light;
    public TurnOffCommand(ILight light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOff();
    }
}

public class Light : ILight
{
    public void TurnOff()
    {
        Console.WriteLine("Light turned off.");
    }

    public void TurnOn()
    {
        Console.WriteLine("Light turned on.");
    }
}

public class Switch
{
    private ICommand _onCommand;
    private ICommand _offCommand;

    public Switch(ICommand onCommand, ICommand offCommand)
    {
        _offCommand = offCommand;
        _onCommand = onCommand; 
    }

    public void FlipUp()
    {
        _onCommand.Execute();
    }

    public void FlipDown()
    {
        _offCommand.Execute();
    }
}