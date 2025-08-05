using DataAccessLibrary;
using Microsoft.Extensions.Configuration;

SqlCrud sql = new SqlCrud(GetConnectionString());

//GetAllPeople(sql);
//GetPersonById(sql, 1);

Console.WriteLine("Done!");
Console.ReadLine();


static void GetPersonById(SqlCrud sql, int id)
{
    var Person = sql.GetPersonById(id);

    Console.WriteLine($"{Person.Id}: {Person.FirstName}, {Person.LastName}");
}
static void GetAllPeople(SqlCrud sql)
{
    var rows = sql.GetAllPeople();
    foreach(var row in rows)
    {
        Console.WriteLine($"{row.Id}.{row.FirstName}, {row.LastName}");
    }
}


static string GetConnectionString(string connectionStringName = "Default")
{
    string output = "";

    var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json");

    var config = builder.Build();

    output = config.GetConnectionString(connectionStringName);

    return output;
}