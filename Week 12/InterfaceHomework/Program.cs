
List<IRun> runners = new List<IRun>();
runners.Add(new Person());
runners.Add(new Animal());
foreach (var runner in runners)
{
    runner.Run();
}
Console.ReadLine();


public interface IRun {
    void Run();
}
public class Person : IRun
{
    public void Run()
    {
        Console.WriteLine("Person is running");
    }


}

public class Animal : IRun
{
    public void Run()
    {
        Console.WriteLine("Animal is running");
    }
}
