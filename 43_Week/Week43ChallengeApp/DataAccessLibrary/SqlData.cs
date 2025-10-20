using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace DataAccessLibrary
{
   public class SqlData
    {
        private readonly ISqlDataAccess _db;
        private static IConfiguration _config;
        private static string csvFile;
        private static CSVFileDataAccess fileAccess = new();
        private const string connectionStringName = "SqlDB";

        public SqlData(ISqlDataAccess db)
        {
            _db = db;
            InitializeConfiguration();
            csvFile = _config.GetValue<string>("CSVFile");
        }

    
        public void Insert()
        {
            List<PersonModel> people = fileAccess.ReadAllRecords(csvFile);
            string sql = "insert into dbo.People (FirsTName, LastName, State) values (@FirstName, @LastName, @State)";

            foreach (var p in people)
            {
                _db.SaveData(sql, new { FirstName = p.FirstName, LastName = p.LastName, State = p.State }, connectionStringName);
            }

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
