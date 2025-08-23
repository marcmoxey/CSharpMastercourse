using DataAccessLibrary;
using Microsoft.Extensions.Configuration;

namespace CosmosDBHomework
{
    internal class Program
    {
        private static CosmosDBDataAccess db;
        static void Main(string[] args)
        {
            var c = GetCosmosInfo();
            db = new CosmosDBDataAccess(c.endpointurl, c.primarykey, c.databasename, c.containername);












            Console.WriteLine("Done!");
            Console.ReadLine();
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
