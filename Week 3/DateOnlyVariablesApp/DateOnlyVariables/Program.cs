
DateTime today = DateTime.Now;
DateOnly birthday = DateOnly.Parse("5/28/2001"); // no time 
Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));

Console.WriteLine($"Today full format: {today}");
Console.WriteLine($"Today just date: {today.Date}");
Console.WriteLine($"Birthday full format: {birthday}");
Console.ReadLine();
