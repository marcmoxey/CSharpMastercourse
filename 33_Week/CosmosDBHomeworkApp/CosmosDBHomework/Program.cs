using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace CosmosDBHomework
{
    internal class Program
    {
        private static  CosmosDBDataAccess db;
        static async Task Main(string[] args)
        {
            var c = GetCosmosInfo();
            db = new CosmosDBDataAccess(c.endpointurl, c.primarykey, c.databasename, c.containername);


            PersonModel person1 = new PersonModel
            {
                FirstName = "Sue",
                LastName = "Storm"
            };

            person1.Addresses.Add(new AddressModel
            {
                StreetAddress = "146 Mango St",
                City = "Raspberry",
                State = "OC",
                ZipCode = "12124"
            });

            person1.Addresses.Add(new AddressModel
            {
                StreetAddress = "786 Pineapple Blvd",
                City = "Strawberry",
                State = "OC",
                ZipCode = "67890"
            });

            person1.Employers.Add(new EmployerModel
            {
                Employer = "Nvidia"
            });

            person1.Employers.Add(new EmployerModel
            {
                Employer = "AMD"
            });


            PersonModel person2 = new PersonModel
            {
                FirstName = "John",
                LastName = "Doe"
            };

            person2.Addresses.Add(new AddressModel
            {
                StreetAddress = "146 Mango St",
                City = "Raspberry",
                State = "OC",
                ZipCode = "12124"
            });

            person2.Addresses.Add(new AddressModel
            {
                StreetAddress = "786 Orange Ave",
                City = "Apple",
                State = "OC",
                ZipCode = "45632"
            });

            person2.Employers.Add(new EmployerModel
            {
                Employer = "Nvidia"
            });

            person2.Employers.Add(new EmployerModel
            {
                Employer = "Intel"
            });

            await CreatePerson(person1);
            await CreatePerson(person2);





            Console.WriteLine("Done!");
            Console.ReadLine();
        }


        private static async Task RemovePerson(string id)
        {
         
        }
        private static async Task RemoveEmployerFromPerson(string employer, string id)
        {
          
        }
        private static async Task UpdatePersonFirstName(string firstName, string id)
        {
            
        }
        private static async Task GetContactById(string id)
        {
            
        }
        private static async Task GetAllPeople()
        {
            
        }
        private static async Task CreatePerson(PersonModel person)
        {
            await db.UpsertRecordAsync(person);
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
