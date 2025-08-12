using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

MySqlCrud sql = new MySqlCrud(GetConnectionString());


GetAllPeople(sql);
//GetPerson(sql, 1);
//CreatePerson(sql);
//GetPerson(sql, 16);
//UpdatePerson(sql);
//GetPerson(sql, 16);
//DeletePerson(sql, 16);

//GetAllAddresses(sql);
//GetAddress(sql, 1); 
//CreateAddress(sql);
//UpdateAddress(sql); 
//RemoveAddress(sql,11);

//GetAllEmployers(sql);
//GetEmployer(sql,1);
//CreateEmployer(sql);
//UpdateEmployer(sql);
//RemoveEmployer(sql, 6);

Console.WriteLine("Done!");
Console.ReadLine();




static void RemoveEmployer(MySqlCrud sql, int id)
{
    sql.DeleteEmployer(id);
}
static void UpdateEmployer(MySqlCrud sql)
{
    EmployerModel employer = new EmployerModel
    {
        Id = 6,
        Employer = "Advanced Micro Devices"
    };

    sql.UpdateEmployer(employer);
}
static void CreateEmployer(MySqlCrud sql)
{
    FullEmployerModel employer = new FullEmployerModel
    {
        BasicInfo = new EmployerModel
        {
            Employer = "Advanced Micro Devices"
        }
    };

    employer.Addresses.Add(new AddressModel
    {
        StreetAddress = "1340 Airport Commerce Drive",
        City = "Austin",
        State = "TX",
        ZipCode = "78741"
    });

    employer.Addresses.Add(new AddressModel
    {
        StreetAddress = "1024 Iron Point Road",
        City = "Folsom",
        State = "CA",
        ZipCode = "95630"
    });

    sql.CreateEmployer(employer);
}
static void GetEmployer(MySqlCrud sql, int id)
{
    var employer = sql.GetEmployerById(id);
    Console.WriteLine($"{employer.Id}: {employer.Employer}");
}
static void GetAllEmployers(MySqlCrud sql)
{
    var rows = sql.GetAllEmployers();
    foreach (var row in rows)
    {
        Console.WriteLine($"{row.Id}: {row.Employer}");
    }
}


static void RemoveAddress(MySqlCrud sql, int id)
{
    sql.DeleteAddress(id);
}
static void UpdateAddress(MySqlCrud sql)
{
    AddressModel address = new AddressModel
    {
        Id = 11,
        StreetAddress = "200-08 Linden Blvd",
        City = "Saint Albans",
        State = "NY",
        ZipCode = "11412"
    };
    sql.UpdateAddress(address);
}
static void CreateAddress(MySqlCrud sql)
{
    AddressModel address = new AddressModel
    {
        StreetAddress = "200-12 Linden Blvd",
        City = "Saint Albans",
        State = "NY",
        ZipCode = "11412"
    };

    sql.CreateAddress(address);
}
static void GetAllAddresses(MySqlCrud sql)
{
    var rows = sql.GetAllAddresses();
    foreach (var row in rows)
    {
        Console.WriteLine($"{row.StreetAddress} {row.City}, {row.State} {row.ZipCode}");
    }
}
static void GetAddress(MySqlCrud sql, int id)
{
    var Address = sql.GetAnAddressById(id);

    Console.WriteLine($"{Address.Id}: {Address.StreetAddress} {Address.City}, {Address.State} {Address.ZipCode}");
}


static void DeletePerson(MySqlCrud sql, int personId)
{
    sql.DeletePerson(personId);
}
static void UpdatePerson(MySqlCrud sql)
{
    PersonModel person = new PersonModel
    {
        Id = 16,
        FirstName = "Marc-Anthony",
        LastName = "Moxey"
    };
    sql.UpdatePerson(person);
}
static void CreatePerson(MySqlCrud sql)
{
    FullPersonModel person = new FullPersonModel
    {
        BasicInfo = new PersonModel
        {
            FirstName = "Marc",
            LastName = "Moxey"
        }
    };

    person.Addresses.Add(new AddressModel
    {
        StreetAddress = "200-12 Linden Blvd",
        City = "Saint Albans",
        State = "NY",
        ZipCode = "11412"
    });


    person.Addresses.Add(new AddressModel
    {
        StreetAddress = "200-08 Linden Blvd",
        City = "Saint Albans",
        State = "NY",
        ZipCode = "11412"
    });

    sql.CreatePerson(person);
}
static void GetPerson(MySqlCrud sql, int id)
{
    var Person = sql.GetPersonById(id);

    Console.WriteLine($"{Person.Id}: {Person.FirstName}, {Person.LastName}");
}
static void GetAllPeople(MySqlCrud sql)
{
    var rows = sql.GetAllPeople();
    foreach (var row in rows)
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