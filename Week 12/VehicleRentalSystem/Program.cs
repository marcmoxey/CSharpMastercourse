namespace VehicleRentalSystem;

class Program
{
    static void Main(string[] args)
    {

        List<IRentable> vehicles = new List<IRentable>();
        vehicles.Add(new Car());
        vehicles.Add(new Bike());
        vehicles.Add(new Scooter());

        foreach (var vehicle in vehicles)
        {
            vehicle.Rent();
            vehicle.Return();
        }
        Console.ReadLine(); 
    }

    public interface IRentable {
        void Rent();
        void Return();
    }

    public class Car : IRentable {
        public void Rent() {
            Console.WriteLine("Car rented.");
        }

        public void Return() {
            Console.WriteLine("Car returned.");
        }
    }
    public class Bike : IRentable {
        public void Rent() {
            Console.WriteLine("Bike rented.");
        }

        public void Return() {
            Console.WriteLine("Bike returned.");
        }
    }

    public class Scooter : IRentable {
        public void Rent() {
            Console.WriteLine("Scooter rented.");
        }

        public void Return() {
            Console.WriteLine("Scooter returned.");
        }
    }   
}
