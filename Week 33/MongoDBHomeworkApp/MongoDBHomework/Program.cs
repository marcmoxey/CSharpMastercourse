using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace MongoDBHomework
{
    internal class Program
    {
        private static MongoDBDataAccess db;
        private static readonly string tableName = "People";
        static void Main(string[] args)
        {
            db = new MongoDBDataAccess("MongoPeopleDB", GetConnectionString());


            PersonModel person = new PersonModel
            {
                FirstName = "Sue",
                LastName = "Storm"
            };

            person.Addresses.Add(new AddressModel
            {
                StreetAddress = "146 Mango St",
                City = "Raspberry",
                State = "OC",
                ZipCode = "12124"
            });

            person.Addresses.Add(new AddressModel
            {
                StreetAddress = "786 Pineapple Blvd",
                City = "Strawberry",
                State = "OC",
                ZipCode = "67890"
            });

            person.Employers.Add(new EmployerModel
            {
                Employer = "Nvidia"
            });

            person.Employers.Add(new EmployerModel
            {
                Employer = "AMD"
            });


            //CreatePerson(person);
            //GetAllPeople();
            // GetContactById("62008caf-2cff-4336-95de-5f8be1d9fe7c");
            //UpdatePersonFirstName("Marc-Anthony", "62008caf-2cff-4336-95de-5f8be1d9fe7c");
            //RemoveEmployerFromPerson("Intel", "62008caf-2cff-4336-95de-5f8be1d9fe7c");
            //RemovePerson("62008caf-2cff-4336-95de-5f8be1d9fe7c");

            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        private static void RemovePerson(string id)
        {
            Guid guid = new Guid(id);
            db.DeleteRecord<PersonModel>(tableName, guid);
        }
        private static void RemoveEmployerFromPerson(string employer, string id)
        {
            Guid guid = new Guid(id);
            var person = db.LoadRecordById<PersonModel>(tableName, guid);
            person.Employers = person.Employers.Where(x => x.Employer != employer).ToList();

            db.UpsertRecord(tableName, person.Id, person);
        }
        private static void UpdatePersonFirstName(string firstName, string id)
        {
            Guid guid = new Guid(id);
            var person = db.LoadRecordById<PersonModel>(tableName, guid);
            person.FirstName = firstName;

            db.UpsertRecord(tableName, person.Id, person);
        }
        private static void GetContactById(string id)
        {
            Guid guid = new Guid(id);
            var person = db.LoadRecordById<PersonModel>(tableName, guid);
            Console.WriteLine($"{person.Id}: {person.FirstName}, {person.LastName}");
        }
        private static void GetAllPeople()
        {
            var people = db.LoadRecords<PersonModel>(tableName);
            foreach(var person in people)
            {
                Console.WriteLine($"{person.Id}: {person.FirstName}, {person.LastName}");
            }
        }
        private static void CreatePerson(PersonModel person)
        {
            db.UpsertRecord(tableName, person.Id, person);
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
