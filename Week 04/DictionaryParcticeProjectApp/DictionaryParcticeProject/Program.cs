

Dictionary<int, string> lastNames = new Dictionary<int, string>();
lastNames.Add(23, "Lebron");
lastNames[11] = "Irving";
lastNames[30] = "Curry";
lastNames.Add(35, "Durant");

Console.WriteLine($"My favorite basketball player is {lastNames[23]}");
