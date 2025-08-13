

List<string> classRoster =  new List<string>();
string userInput;

do
{
    Console.Write("Add student name to roster(or type 'exit' when finish): ");
    userInput = Console.ReadLine();
    if(userInput != "exit")
    {
        classRoster.Add(userInput);
    } else
    {
        Console.WriteLine($"You have {classRoster.Count} students in your class roster");
    }
    

} while (userInput.ToLower() != "exit");