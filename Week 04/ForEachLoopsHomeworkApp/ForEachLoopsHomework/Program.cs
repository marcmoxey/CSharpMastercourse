

using System.Xml.Linq;

List<string> firstNames = new();
string userInput;

do
{
    Console.Write("Enter a first name(or type 'exit' when done): ");
    userInput = Console.ReadLine();
    firstNames.Add(userInput);

    //if(userInput.ToLower() == "exit")
    //{
    //    foreach (string name in firstNames)
    //    {
    //        Console.WriteLine($"Hello {name}");
    //    }
    //}

} while (userInput.ToLower() != "exit");
foreach (string name in firstNames)
{
    Console.WriteLine($"Hello {name}");
}