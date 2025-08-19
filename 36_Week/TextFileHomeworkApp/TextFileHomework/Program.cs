
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace TextFileHomework
{
    public class Program
    {
        private static IConfiguration _config;
        private static string csvFile;
        private static CSVFileDataAccess db = new CSVFileDataAccess();

        static void Main(string[] args)
        {
            InitializeConfiguration();
            csvFile = _config.GetValue<string>("CSVFile");



            PersonModel person1 = new PersonModel
            {
                FirstName = "Marc",
                LastName = "Moxey",
               
               
             };

            PersonModel person2 = new PersonModel
            {
                FirstName = "Sue",
                LastName = "Storm",
              
              
            };


            PersonModel person3 = new PersonModel
            {
                FirstName = "John",
                LastName = "Doe",
             

            };

            CreatePerson(person1);
            CreatePerson(person2);
            CreatePerson(person3);
            GetAllPeople();






            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        private static void GetAllPeople()
        {
            var people = db.ReadAllRecords(csvFile);
            foreach(var person in people)
            {
                Console.WriteLine($"{person.FirstName}, {person.LastName}");
            }
        }
        private static void CreatePerson(PersonModel person)
        {
            var people = db.ReadAllRecords(csvFile);
            people.Add(person);
            db.WrtieAllRecords(people, csvFile);
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
