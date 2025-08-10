using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using DataAccessLibrary;
using DataAccessLibrary.Models;

namespace MongoDBUI
{
    internal class Program
    {
        private static MongoDBDataAccess db;
        private static readonly string tableName = "Contacts";
        static void Main(string[] args)
        {
            db = new MongoDBDataAccess("MongoContactsDB", GetConnectionString());

            ContactModel user = new ContactModel
            {
                FirstName = "Kenneth",
                LastName = "Moxey"
            };
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "nope@aol.com"});
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "mam52801@gmail.com" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1212" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-9876" });

            //CreateContact(user);
            //GetAllContacts();
            //GetContactById("fb292302-f95e-4f8f-877a-5220c6713314");

            //UpdateContactFirstName("Marc-Anthony", "ba0e9dd1-2c40-4775-ad15-eaaf7aded960");
            // GetAllContacts();

            //RemovePhoneNumberFromUser("555-1212", "ba0e9dd1-2c40-4775-ad15-eaaf7aded960");

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
        public static void RemovePhoneNumberFromUser(string phoneNumber, string id)
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid);
            contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber != phoneNumber).ToList();

            db.UpsertRecord(tableName, contact.Id, contact);
        }
        private static void UpdateContactFirstName(string firstName, string id)
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid); 
            contact.FirstName = firstName;

            db.UpsertRecord(tableName, contact.Id, contact);

        }
        private static void GetContactById(string id)
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid);

            Console.WriteLine($"{contact.Id}: {contact.FirstName}, {contact.LastName}");
        }
        private static void GetAllContacts()
        {
            var contacts = db.LoadRecords<ContactModel>(tableName);
            foreach(var contact in contacts)
            {
                Console.WriteLine($"{contact.Id}: {contact.FirstName}, {contact.LastName}");
            }
        }
        private static void CreateContact(ContactModel contact)
        {
            db.UpsertRecord(tableName, contact.Id, contact);
        }
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();

            output = config.GetConnectionString(connectionStringName);

            return output;
        }
    }
}
