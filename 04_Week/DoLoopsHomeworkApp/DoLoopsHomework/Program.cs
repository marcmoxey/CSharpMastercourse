
string userInput;

do 
{
    Console.Write("What is your name(or type 'exit' to quit application): ");
    userInput = Console.ReadLine();
    if (userInput.ToLower() == "tim" )
    {
        Console.WriteLine($"Welcome professor {userInput}");
    } 
    else
    {
        Console.WriteLine($"Welcome {userInput}");
    }
} while (userInput.ToLower() != "exit");
