using OopLibrary.Models;

List<IShiftWorker> workers = new List<IShiftWorker>();

PersonModel p = new()
{
    FirstName = "Marc",
    LastName = "Moxey"
};
workers.Add(p);
p = new()
{
    FirstName = "Tim",
    LastName = "Corey"
};
workers.Add(p);
p = new()
{
    FirstName = "Sue",
    LastName = "Storm"
};
workers.Add(p);
p = new()
{
    FirstName = "Jane",
    LastName = "Smith"
};
workers.Add(p);

VehicleModel v = new()
{
    Year = "2023",
    Make = "Toyota",
    Model = "Gr86"
};
workers.Add(v);
v = new()
{
    Year = "2025",
    Make = "Toyota",
    Model = "GrSupra"
};
workers.Add(v);
v = new()
{
    Year = "2022",
    Make = "Toyta",
    Model = "Tundra"

};
workers.Add(v);

foreach (var worker in workers)
{
    Console.WriteLine(worker.EndOfShift());
}

Console.ReadLine();