

Console.Write("Enter comma-separated list of first name(no spaces): ");
string firstNames = Console.ReadLine();

List<string> names = firstNames.Split(',').ToList();
for(int i = 0;  i < names.Count; i++)
{
    Console.WriteLine($"Hello {names[i]}");
}




