using EFHomework.DataAccess;
using EFHomework.Models;
using Microsoft.EntityFrameworkCore;

namespace EFHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CreatePerson();
            //CreatePerson2();
            //ReadAll();
            //ReadById(3);
            //UpdateFirstName(3, "Marc-Anthony");
            //ReadById(3);
            //RemoveEmployer(3, "Apple");
            RemovePerson(3);
            ReadAll();

            Console.WriteLine("Done!");
            Console.ReadLine();

        }

        private static void RemovePerson(int id)
        {
            using (var db = new PersonContext())
            {
                var user = db.Peoples
                    .Include(p => p.Addresses)
                    .Include(p => p.Employers)
                    .Where(p => p.Id == id).First();

               db.Peoples.Remove(user);
                db.SaveChanges();
            }
        }
        private static void RemoveEmployer(int id, string employerName)
        {
            using (var db = new PersonContext())
            {
                var user = db.Peoples
                    .Include(p => p.Employers)
                    .Where(p => p.Id == id).First();

                user.Employers.RemoveAll(p => p.EmployerName == employerName);
                db.SaveChanges();
            }
        }
        private static void UpdateFirstName(int id, string firstName)
        {
            using (var db = new PersonContext())
            {
                var user = db.Peoples.Where(p => p.Id == id).First();
                user.FirstName = firstName;
                db.SaveChanges();
            }
        }
        private static void CreatePerson()
        {
            var p = new Person
            {
               
                FirstName = "Marc",
                LastName = "Moxey"
            };

            p.Addresses.Add(new Address {  StreetAddress = "123 Lane", City = "Orange County", State = "CA", ZipCode = "14578" });
            p.Addresses.Add(new Address {  StreetAddress = "619 Blvd", City = "Bay Area", State = "CA", ZipCode = "06342" });

            p.Employers.Add(new Employer {  EmployerName = "AMD" });
            p.Employers.Add(new Employer { EmployerName = "Apple" });


            using (var db = new PersonContext()) // connection to Db
            {
                db.Peoples.Add(p); // Add to tables
                db.SaveChanges(); // Save changes write to sql
            }

        }

        private static void CreatePerson2()
        {
            var p = new Person

            {   
                FirstName = "John",
                LastName = "Doe"
            };

            p.Addresses.Add(new Address { StreetAddress = "457 Ave", City = "Strawberry Fields", State = "MN", ZipCode = "46562" });
            p.Addresses.Add(new Address { StreetAddress = "619 Blvd", City = "Bay Area", State = "CA", ZipCode = "06342" });

            p.Employers.Add(new Employer {  EmployerName = "GM" });
            p.Employers.Add(new Employer {  EmployerName = "Apple" });

            using (var db = new PersonContext()) // connection to Db
            {
                db.Peoples.Add(p); // Add to tables
                db.SaveChanges(); // Save changes write to sql
            }
        }

        private static void ReadAll()
        {
            using (var db = new PersonContext())
            {
                var records = db.Peoples.ToList();

                foreach(var p in records)
                {
                    Console.WriteLine($"{p.FirstName} {p.LastName}");
                }
            }
        }

        private static void ReadById(int id)
        {
            using (var db = new PersonContext())
            {
                var user = db.Peoples.Where(p =>  p.Id == id).First();

               
                Console.WriteLine($"{user.FirstName} {user.LastName}");
                
            }
        }
    }
}
