using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace CosmosDBUI
{
    internal class Program
    {
        private static CosmosDBDataAccess db;
        static async Task Main(string[] args)
        {
            var c = GetCosmosInfo();
            db = new CosmosDBDataAccess(c.endpointurl,c.primarykey,c.databasename, c.containername);


            ContactModel user = new ContactModel
            {
                FirstName = "Megan",
                LastName = "Moxey"
            };
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "nope@aol.com" });
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "mmoxey2019@stanner.org" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1212" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1234" });

            ContactModel user2 = new ContactModel
            {
                FirstName = "Marc",
                LastName = "Moxey"
            };
            user2.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "marc.moxey@my.liu.edu" });
            user2.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "mmoxey2019@stanner.org" });
            user2.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1212" });
            user2.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-9876" });


            //await CreateContact(user);
            //await CreateContact(user2);
            //await GetAllContacts();


            // "2538a9f2-9dfc-4513-8d56-41b242194837"
            //await GetContactById("2538a9f2-9dfc-4513-8d56-41b242194837");

            //await UpdateContactFirstName("Marc-Anthony", "2538a9f2-9dfc-4513-8d56-41b242194837");
            //await GetContactById("2538a9f2-9dfc-4513-8d56-41b242194837");

            //await RemovePhoneNumberFromUser("555-1212", "2538a9f2-9dfc-4513-8d56-41b242194837");

            await RemoveUser("2538a9f2-9dfc-4513-8d56-41b242194837", "Moxey");


            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        public static async Task RemoveUser(string id, string lastName)
        {
            await db.DeleteRecordAsync<ContactModel>(id, lastName);
        }

        public static async Task RemovePhoneNumberFromUser(string phoneNumber, string id)
        {
            var contact = await db.LoadRecordByIdAsync<ContactModel>(id);
            contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber != phoneNumber).ToList();
            await db.UpsertRecordAsync(contact);

        }


        private static async Task UpdateContactFirstName(string firstName, string id)
        {
            var contact = await db.LoadRecordByIdAsync<ContactModel>(id);
            contact.FirstName = firstName;
            await db.UpsertRecordAsync(contact);

        }


        private static async Task GetContactById(string id)
        {
            var contact = await db.LoadRecordByIdAsync<ContactModel>(id);
            Console.WriteLine($"{contact.Id}: {contact.FirstName}, {contact.LastName}");
        }

        private static async Task GetAllContacts()
        {
            var contacts = await db.LoadRecordsAsync<ContactModel>();
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Id}: {contact.FirstName}, {contact.LastName}");
            }
        }

        private static async Task CreateContact(ContactModel contact)
        {
            await db.UpsertRecordAsync(contact);

        }


        private static (string endpointurl, string primarykey, string databasename, string containername) GetCosmosInfo()
        {
            (string endpointurl, string primarykey, string databasename, string containername) output;

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();
            output.endpointurl = config.GetValue<string>("CosmosDB:EndpointUrl");
            output.primarykey = config.GetValue<string>("CosmosDB:PrimaryKey");
            output.databasename = config.GetValue<string>("CosmosDB:DatabaseName");
            output.containername = config.GetValue<string>("CosmosDB:ContainerName");

            return output;
        }
    }
}
