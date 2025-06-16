namespace InheritanceMiniProjectHomework;

class Program
{
        static void Main(string[] args)
        {
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            BeachBall beachBall = new BeachBall { ProductName = "Beach Ball", QuantityInStock = 10 };
            Towels towels = new Towels { ProductName = "Towels", QuantityInStock = 20 };
            Umbrella umbrella = new Umbrella { ProductName = "Umbrella", QuantityInStock = 5 };
            rentables.Add(umbrella);
            purchasables.Add(beachBall);
            purchasables.Add(towels);

            Console.WriteLine("Welcome to the Beach Rental Store!");
            System.Console.WriteLine("Do you want to rent or purchase an item? (Enter 'rent' or 'purchase')"); 
            string itemToRent = Console.ReadLine();
            if(itemToRent.ToLower() == "rent") 
            {
                Console.WriteLine("We have the following items available for rent:");

                foreach (var item in rentables)
                {
                    Console.WriteLine($"{item.ProductName} - {item.QuantityInStock} available");
                    System.Console.WriteLine("Do you want to rent this item? (yes/no)");
                    string wantToRent = Console.ReadLine();
                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                        System.Console.WriteLine($"You have rented {item.ProductName}. Please return it when you are done.");
                    }
                    System.Console.WriteLine("Do you want to return this item? (yes/no)");
                    string wantToReturn = Console.ReadLine();
                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.Return();
                        System.Console.WriteLine($"You have returned {item.ProductName}. Thank you!");
                    }
                }

            } else if(itemToRent.ToLower() == "purchase") 
            {
                Console.WriteLine("We have the following items available for purchase:");

                foreach (var item in purchasables)
                {
                    Console.WriteLine($"{item.ProductName} - {item.QuantityInStock} available");
                    System.Console.WriteLine("Do you want to purchase this item? (yes/no)");
                    string wantToPurchase = Console.ReadLine();
                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                        System.Console.WriteLine($"You have purchased {item.ProductName}. Thank you!");
                    }
                }
            } else 
            {
                Console.WriteLine("Invalid input. Please enter 'rent' or 'purchase'.");
            }


    System.Console.WriteLine("Done");
            Console.ReadLine(); 
        }

        public interface IInventoryItem
        {
            string ProductName { get; }

            int QuantityInStock { get; }

        }

        public interface IRentable : IInventoryItem
        {
            void Rent();
            void Return();
        }

        public interface IPurchasable : IInventoryItem
        {
            void Purchase();
        }
        public class InventoryItem : IInventoryItem
        {
            public string ProductName { get; set; }
            public int QuantityInStock { get; set; }
        }

        public class BeachBall : InventoryItem, IPurchasable 
        {
            public void Purchase()
            {
                QuantityInStock -= 1;
                Console.WriteLine($"Purchasing {ProductName}");
            }
        }


        public class Towels: InventoryItem,  IPurchasable
        {
            public void Purchase()
            {
                QuantityInStock -= 1;
                Console.WriteLine($"Purchasing {ProductName}");
            }
        }
        

        public class Umbrella: InventoryItem, IRentable
        {
            public void Rent()
            {
                QuantityInStock -= 1;
                Console.WriteLine($"Renting {ProductName}");
            }

            public void Return()
            {
                QuantityInStock += 1;
                Console.WriteLine($"Returning {ProductName}");
            }
        }
       
  }  
