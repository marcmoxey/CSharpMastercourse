using Microsoft.Extensions.Configuration;
using DataAccessLibrary;

// 1️⃣ Build configuration (loads appsettings.json)
var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

// 2️ Create the SQL data access object (inject configuration)
ISqlDataAccess db = new SqlDataAccess(config);

// 3️ Create your SqlData class (injects db dependency)
SqlData sqlData = new SqlData(db);

// 4️ Call Insert() to read from CSV and insert into DB
sqlData.Insert();




Console.WriteLine("Done!");
Console.ReadLine();