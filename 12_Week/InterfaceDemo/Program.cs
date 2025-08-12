// Interface is a contract that a class must follow.
// Classes implementing an interface must provide implementations for all of its members.

List<IComputerController> controllers = new List<IComputerController>();
Keyboard keyboard = new Keyboard();
GameController gameController = new GameController();
BatteryPowerGameController battery = new BatteryPowerGameController();
BatteryPowerKeyboard batteryKeyboard = new BatteryPowerKeyboard();

controllers.Add(keyboard);
controllers.Add(gameController);
controllers.Add(battery);

foreach (IComputerController controller in controllers)
{
    if(controller is GameController gc) {

    }

    if(controller is IBatteryPowered powered){
        // controller has access to IcomputerController and 
        //powered.BatteryLevel = 100;
    }
}

foreach (IComputerController controller in controllers)
{
    controller.Connect();
    controller.CurrentKeyPressed();

}

List<IBatteryPowered> powereds = new List<IBatteryPowered>();
powereds.Add(battery);
powereds.Add(batteryKeyboard);

using(GameController gc = new GameController())
{
    // auto call gc.dispose 
}

Console.ReadLine();


public interface IComputerController : IDisposable
{
    // Things a class that will implement me do 
    // everything in an interface is public

    void Connect(); // method 
    void CurrentKeyPressed(); // method
}

public class Keyboard : IComputerController
{
    public void Connect() 
    {

    }

    public void CurrentKeyPressed() 
    {

    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public string ConnectionType { get; set; }
}


public interface IBatteryPowered 
{
   int BatteryLevel { get; set; }

}
public class BatteryPowerKeyboard : Keyboard, IBatteryPowered
{
    public int BatteryLevel { get; set; }
}


public class GameController : IComputerController, IDisposable
{
    public void Connect()
    {
        throw new NotImplementedException();
    }

    public void CurrentKeyPressed()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        // do whatever you need to do to clean up
        throw new NotImplementedException();
    }

    public int BatteryLevel { get; set; }
}





public class BatteryPowerGameController : GameController, IBatteryPowered 
{
    public int BatteryLevel { get; set; }

}
