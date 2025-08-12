
string userInput;
do
{
    Console.Write("What is your name: ");
    userInput = Console.ReadLine();

   
}
while (userInput == ""); // if this is empty continue 
Console.WriteLine($"Your name is {userInput}");