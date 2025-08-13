
// string[5] firstNames = new string[5];
List<string> firstName = new List<string>();
firstName.Add("Marc");
firstName.Add("Nio");
firstName.Add("Jon");
firstName.Add("Tim");
firstName.Add("Sue");
firstName.Add("Bob");
firstName.Add("Jane");
firstName.Add("Frank");

Console.WriteLine(firstName[3]);
Console.WriteLine(firstName[firstName.Count - 1]);

List<int> ages = new List<int>();
ages.Add(1);
ages.Add(2);
ages.Add(3);

// List<T> - generic - choose the types that passed in

string data = "Corey,Smith,Jones";
List<string> lastNames = data.Split(',').ToList();
lastNames.Add("Franklin");