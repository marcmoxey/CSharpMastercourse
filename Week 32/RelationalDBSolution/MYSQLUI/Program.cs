using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;


MySqlCrud sql = new MySqlCrud(GetConnectionString());

//ReadAllContacts(sql);

//ReadContact(sql, 2);

//CreateNewContact(sql);

//UpdateContact(sql);
//ReadAllContacts(sql);

//RemovePhoneNumberFromContact(sql,2, 1);

Console.WriteLine("Done! MySQL");

Console.ReadLine();


static void RemovePhoneNumberFromContact(MySqlCrud sql, int contactId, int phoneNumberId)
{
    sql.RemovePhoneNumberFromContact(contactId, phoneNumberId);
}

static void UpdateContact(MySqlCrud sql)
{
    BasicContactModel contact = new BasicContactModel
    {
        Id = 1,
        FirstName = "Marc-Anthony",
        LastName = "Moxey"
    };
    sql.UpdateContactName(contact);
}

static void CreateNewContact(MySqlCrud sql)
{
    FullContactModel user = new FullContactModel
    {
        BasicInfo = new BasicContactModel
        {
            FirstName = "Charity",
            LastName = "Corey"
        }
    };
    user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "nope@aol.com" });
    user.EmailAddresses.Add(new EmailAddressModel { id = 2, EmailAddress = "me@timothycorey.com" });

    user.PhoneNumbers.Add(new PhoneNumberModel { Id = 1, PhoneNumber = "555-1212" });
    user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-9876" });

    sql.CreateContact(user);
}

static void ReadAllContacts(MySqlCrud sql)
{
    var rows = sql.GetAllContacts();
    foreach (var row in rows)
    {
        Console.WriteLine($"{row.Id} {row.FirstName} {row.LastName}");
    }
}

static void ReadContact(MySqlCrud sql, int ContactId)
{
    var contact = sql.GetFullContactById(ContactId);


    Console.WriteLine($"{contact.BasicInfo.Id}: {contact.BasicInfo.FirstName} {contact.BasicInfo.LastName}");

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
