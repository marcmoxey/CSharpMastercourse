using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;


namespace TextFileUI
{
    class Program
    {
        private static IConfiguration _config;
        private static string textFile;
        private static TextFileDataAccess db = new TextFileDataAccess();

        static void Main(string[] args)
        {
            InitializeConfiguration();
            textFile = _config.GetValue<string>("TextFile");


            ContactModel user1 = new ContactModel();
            user1.FirstName = "Tim";
            user1.LastName = "Corey";
            user1.EmailAddresses.Add("tim@iamtimcorey.com");
            user1.EmailAddresses.Add("me@timothycorey.com");
            user1.PhoneNumbers.Add("555-1212");
            user1.PhoneNumbers.Add("555-1234");

            ContactModel user2 = new ContactModel();
            user2.FirstName = "Charity";
            user2.LastName = "Corey";
            user2.EmailAddresses.Add("nope@aol.com");
            user2.EmailAddresses.Add("me@timothycorey.com");
            user2.PhoneNumbers.Add("555-1212");
            user2.PhoneNumbers.Add("555-9876");


            //CreateContact(user1);
            //CreateContact(user2);
            //GetAllContacts();
            //UpdatecContactFirstName("Timothy");
            //GetAllContacts();

            //Console.WriteLine();

            //RemovePhoneNumberFromContact("555-1212");
            //GetAllContacts();

            RemoveContact();
            GetAllContacts();



            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        private static void RemoveContact()
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts.RemoveAt(0);
            db.WriteAllRecords(contacts, textFile);

        }
        private static void RemovePhoneNumberFromContact(string phoneNumber)
        {

            var contact = db.ReadAllRecords(textFile);
            contact[0].PhoneNumbers.Remove(phoneNumber);
            db.WriteAllRecords(contact, textFile);


        }
        private static void UpdatecContactFirstName(string firstName)
        {
           var contact = db.ReadAllRecords(textFile);
           contact[0].FirstName = firstName;
            db.WriteAllRecords(contact, textFile);

           
        }

        private static void GetAllContacts()
        {
            var contacts = db.ReadAllRecords(textFile);
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.FirstName}, {contact.LastName}");
            }
        }
        private static void CreateContact(ContactModel contact)
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts.Add(contact); 
            db.WriteAllRecords(contacts, textFile);

        }
       

        private static void InitializeConfiguration()
        {

            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json");

            _config = builder.Build();

        }
    }
}


