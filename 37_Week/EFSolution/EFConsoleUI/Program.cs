using EFConsoleUI.DataAccess;
using EFConsoleUI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // CreateTim();
            ReadAll();
            Console.WriteLine("Done!");
            Console.ReadLine();

        }

        private static void CreateTim()
        {
            var c = new Contact
            {
                FirstName = "Tim",
                LastName = "Corey"
            };
            c.EmailAddreses.Add(new Email { EmailAddress = "tim@iamtimcorey.com" });
            c.EmailAddreses.Add(new Email { EmailAddress = "me@timothycorey.com" });

            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-1212" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-1234" });

            using (var db = new ContactContext()) // connection to Db
            {
                db.Contacts.Add(c); // Add to tables
                db.SaveChanges(); // Save changes write to sql
            }
        }

        private static void ReadAll()
        {
            using(var db = new ContactContext())
            {
                var records = db.Contacts
                    .Include(e => e.EmailAddreses)
                     .Include(p => p.PhoneNumbers)
                    .ToList(); /// read all the records 

                foreach (var c in records) 
                {
                    Console.WriteLine($"{c.FirstName}, {c.LastName}");
                }

            }
        }
    }
}

// PM - Add-Migration CreateDatabase
// PM - Update-Database