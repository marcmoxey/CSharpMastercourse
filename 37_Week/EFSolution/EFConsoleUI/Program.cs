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
            // ReadAll();
            //ReadById(1);
            //CreateCharity();
            //UpdateFirstName(1, "Timothy");
            //ReadAll();
            //RemovePhoneNumber(1, "555-1212");
            RemoveUser(1);
            ReadAll();
           
            Console.WriteLine("Done!");
            Console.ReadLine();

        }

        private static void RemoveUser(int id)
        {
            using(var db = new ContactContext())
            {
                var users = db.Contacts
                    .Include(e => e.EmailAddreses)
                    .Include(p => p.PhoneNumbers)
                    .Where(c => c.Id == id).First(); 
                db.Contacts.Remove(users);
                db.SaveChanges();
            }
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

        private static void RemovePhoneNumber(int id, string phoneNumber)
        {
            using(var db = new ContactContext())
            {
                var user = db.Contacts
                            .Include(p => p.PhoneNumbers)
                            .Where(c => c.Id == id).First();

                user.PhoneNumbers.RemoveAll(p => p.PhoneNumber == phoneNumber);
                db.SaveChanges();
            }
        }
        private static void UpdateFirstName(int id, string firstName)
        {
            using(var db = new ContactContext())
            {
                var user = db.Contacts.Where(c => c.Id == id).First();

                user.FirstName = firstName;
                db.SaveChanges();
            }
        }
        private static void CreateCharity()
        {
            var c = new Contact
            {
                FirstName = "Charity",
                LastName = "Corey"
            };
            c.EmailAddreses.Add(new Email { EmailAddress = "nope@aol.com" });
            c.EmailAddreses.Add(new Email { EmailAddress = "me@timothycorey.com" });

            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-1212" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-9876" });

            using (var db = new ContactContext()) // connection to Db
            {
                db.Contacts.Add(c); // Add to tables
                db.SaveChanges(); // Save changes write to sql
            }
        }

        private static void ReadAll()
        {
            using (var db = new ContactContext())
            {
                var records = db.Contacts
                    //.Include(e => e.EmailAddreses)
                    // .Include(p => p.PhoneNumbers)
                    .ToList(); /// read all the records 

                foreach (var c in records)
                {
                    Console.WriteLine($"{c.FirstName}, {c.LastName}");
                }

            }
        }

        private static void ReadById(int id)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts.Where(c => c.Id == id).First();

                Console.WriteLine($"{user.FirstName}, {user.LastName}");
            }
        }
    }
}

// PM - Add-Migration CreateDatabase
// PM - Update-Database