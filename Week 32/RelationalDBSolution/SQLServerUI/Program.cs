
using DataAccessLibrary;
using Microsoft.Extensions.Configuration;


//Console.WriteLine(GetConnectionString());

SqlCrud sql = new SqlCrud(GetConnectionString());
//ReadAllContacts(sql);
ReadContact(sql, 1);
Console.ReadLine();

static void ReadAllContacts(SqlCrud sql)
{
    var rows = sql.GetAllContacts();
    foreach(var row in rows)
    {
        Console.WriteLine($"{row.Id} {row.FirstName} {row.LastName}");
    }
}

static void ReadContact(SqlCrud sql, int ContactId)
{
    var contact = sql.GetFullContactById(ContactId);
    
  
    Console.WriteLine($"{contact.BasicInfo.Id} {contact.BasicInfo.FirstName} {contact.BasicInfo.LastName}");

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