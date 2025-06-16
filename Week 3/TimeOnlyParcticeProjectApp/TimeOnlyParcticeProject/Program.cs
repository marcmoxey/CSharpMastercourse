
TimeOnly opensAt = TimeOnly.Parse("11:00 AM");
Console.WriteLine(opensAt.ToString("hh:mm:ss tt"));

TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(rightNow.ToString("hh:mm:ss tt"));