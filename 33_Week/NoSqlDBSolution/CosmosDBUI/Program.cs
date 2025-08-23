using DataAccessLibrary;
using DataAccessLibrary.Models;

namespace CosmosDBUI
{
    internal class Program
    {
        private static CosmosDBDataAccess db;
        static void Main(string[] args)
        {
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
        private static void GetAllContacts()
        {
          
        }
        private static void CreateContact(ContactModel contact)
        {
        
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
