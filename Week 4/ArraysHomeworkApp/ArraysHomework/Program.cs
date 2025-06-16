
string[] names = new string[] {"Marc","Jon","Nio" };

Console.Write("Please enter a number: ");
string userInput = Console.ReadLine();
int.TryParse(userInput, out int userNum);

if(userNum > names.Length - 1)
{
    Console.WriteLine($"Please enter a number in range 0 - {names.Length - 1}");
} else
{
    Console.WriteLine(names[userNum]);
}