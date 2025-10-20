

using Dapper;
using SampleDataMover;
using System;
using System.Data;
using System.Data.SqlClient;

// Read from csv
string[] lines = await File.ReadAllLinesAsync(@"C:\Users\moxey\source\repos\C#Mastercourse\44_Week\SampleData.txt");

List<string> badData = new(); // store bad data

string connectionString = @"Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = SampleDB; Integrated Security = True; Connect Timeout = 60; Encrypt = False; ";

using (IDbConnection connection = new SqlConnection(connectionString)) 
{
    // Loop over the CSV file and separate out into data columns
    foreach (string line in lines)
    {
        string[] data = line.Split(',');

        // Identify if a record is valid
        if (data.Length != 3)
        {
            badData.Add(line);
            continue; // go to next entry in foreach
        }

        if (string.IsNullOrWhiteSpace(data[0]) ||
            string.IsNullOrWhiteSpace(data[1]) ||
            string.IsNullOrWhiteSpace(data[2]))
        {
            badData.Add(line);
            continue; // go to next entry in foreach
        }

       
        PersonModel p = new();
        p.FirstName = data[0];
        p.LastName = data[1];
        p.State = data[2];


        // Insert good records in SQL
        await connection.ExecuteAsync("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure); // if model matches up exactly you can pass the object in

        
    }
}
// Save bad records to a Errors.txt
File.WriteAllLinesAsync(@"C:\Users\moxey\source\repos\C#Mastercourse\44_Week\Error.txt", badData);


Console.WriteLine("Done!");
Console.ReadLine();