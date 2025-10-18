using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week43ChallengeLibrary.DataAccess
{
    public class SQLCrud
    {
        private static IConfiguration _config;
        private readonly string _connectionString;
        private  string textFile;
        private SQLDataAccess _db = new SQLDataAccess();
        private TextFileDataAccess _tf = new TextFileDataAccess();

        public SQLCrud(string connectionString)
        {
            _connectionString = connectionString;
            InitializeConfiguration();
            textFile = _config.GetValue<string>("TextFile");
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
