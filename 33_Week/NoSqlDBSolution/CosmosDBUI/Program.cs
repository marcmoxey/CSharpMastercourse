using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

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


            await CreateContact(user);
            await CreateContact(user2);
            await GetAllContacts();



            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        public static void RemoveUser(string id)
        {
         
        }
        public static void RemovePhoneNumberFromUser(string phoneNumber, string id)
        {
        
        }
        private static void UpdateContactFirstName(string firstName, string id)
        {
         

        }
        private static void GetContactById(string id)
        {
         
        }
        private static async Task GetAllContacts()
        {
            var contacts = await db.LoadRecordsASync<ContactModel>();
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
