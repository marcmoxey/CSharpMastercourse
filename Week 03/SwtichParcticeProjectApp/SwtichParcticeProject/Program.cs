

Console.Write("What is your age: ");
string ageText  = Console.ReadLine();
int.TryParse(ageText, out int age); 

switch(age)
{
    case < 16:
        Console.WriteLine("You can't get your learners permit yet");
        break;
    case >= 16 and < 18:
        Console.WriteLine("You can get your license");
        break;
    case <= 20:
        Console.WriteLine("You can't drink yet");
        break;
    default:
        Console.WriteLine("You can drink");
        break;  
}