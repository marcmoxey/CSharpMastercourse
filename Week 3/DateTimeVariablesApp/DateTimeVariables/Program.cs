
using System.Globalization;

DateTime today = DateTime.UtcNow; // Date Time, when the program was run - base on where you computer is 
//DateTime birthday = DateTime.Parse("5/28/2001"); // valid date for US base format
//DateTime birthday = DateTime.ParseExact("28/5/2001", "d/M/yyyy", CultureInfo.InvariantCulture); // Date, Format, culture - specify on format doesn't matter where in the word in the word

//Console.WriteLine(birthday);
//Console.WriteLine(today);
//Console.WriteLine(today.ToString("t")); // '.ToString("")' - can format
Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz"));