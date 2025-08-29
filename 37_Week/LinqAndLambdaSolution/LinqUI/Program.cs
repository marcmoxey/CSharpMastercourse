using LinqUI.Models;

namespace LinqUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LambdaTests();
            LinqTests();
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        private static void LambdaTests()
        {
            var data = SampleData.GetContactData();

            //var results = data.Where(x => x.Addresses.Count() > 1); 

            //foreach(var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName}, {item.LastName}");
            //}

            //var results = data.Select(x => x.FirstName);
            //foreach(var item in results)
            //{
            //    Console.WriteLine(item);
            //}

            //var results = data.Take(2);

            //foreach(var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName}, {item.LastName}");
            //}

            //var results = data.Skip(2).Take(2);
            //foreach(var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName}, {item.LastName}");
            //}

            //var results = data.OrderByDescending(x => x.LastName);
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName}, {item.LastName}");
            //}
        }

        private static void LinqTests()
        {
            var contacts = SampleData.GetContactData();
            var addresses = SampleData.GetAddressData();

            //var results = (from c in contacts 
            //               join a in addresses
            //               on c.Id equals a.ContactId
            //               select new {c.FirstName, c.LastName, a.City, a.State}); // new aynomous object

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName}, {item.LastName} from {item.City}, {item.State}");
            ////}

            //var results = (from c in contacts
            //               select new { c.FirstName, c.LastName, Addresses = addresses.Where(x => x.ContactId == c.Id) });

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName}, {item.LastName} - {item.Addresses.Count()}");
            //}

            //}

            var results = (from c in contacts
                           select new { c.FirstName, c.LastName, Addresses = addresses.Where(a => c.Addresses.Contains(a.Id)) });

            foreach (var item in results)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName} - {item.Addresses.Count()}");
            }

        }


    }
}
