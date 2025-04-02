

List<IDevice> devices = new List<IDevice>
{
    new SmartLight(),
    new SmartThermostat(),
    new SmartCamera()
}; 

foreach (var device in devices)
{
    device.TurnOn();
    device.GetStatus();
    device.TurnOff();
}

Console.ReadLine();

public interface IDevice
 {
    void TurnOn();
    void TurnOff();
    void GetStatus();
}

public class SmartLight : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Smart Light is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Smart Light is turned off.");
    }

    public void GetStatus()
    {
        Console.WriteLine("Smart Light is in good condition.");
    }
}

public class SmartThermostat : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Smart Thermostat is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Smart Thermostat is turned off.");
    }

    public void GetStatus()
    {
        Console.WriteLine("Smart Thermostat is in good condition.");
    }
}

public class SmartCamera : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Smart Camera is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Smart Camera is turned off.");
    }

    public void GetStatus()
    {
        Console.WriteLine("Smart Camera is in good condition.");
    }

}