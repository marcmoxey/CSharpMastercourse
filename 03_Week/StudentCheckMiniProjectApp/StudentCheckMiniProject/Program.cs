/*
 * 
 * Plan and build a Console application that ask a 
 * user for their name and their age. If their name is
 * Bob or Sue, address them as Professor. If the
 * person is under 21, recommend they wait X years
 * to start this class
 * 
 */

Console.Write("What is is first name: ");
string firstName = Console.ReadLine();
Console.Write("What is your age: ");
string ageText = Console.ReadLine();
int.TryParse(ageText, out int age);


if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    Console.WriteLine($"Welcome Professor {firstName}");

} else
{
    Console.WriteLine($"{firstName}");
}


if (age < 21)
{
    Console.WriteLine($"You have to wait {21 - age} years to start this class {firstName}");
}
else
{
    Console.WriteLine($"Welcome to class {firstName}");
}

//switch (firstName.ToLower())
//{
//    case "tim":
//    case "sue":
//        Console.WriteLine($"Welcome Professor {firstName}");
//        break;
//    default:
//        Console.WriteLine("Welcome Student");
//        break;
//}


//Console.Write("What is your age: ");
//string ageText = Console.ReadLine();
//int.TryParse(ageText, out int age);
//switch (age)
//{
//    case >= 21:
//        Console.WriteLine("Welcome to class");
//        break;
//    default:
//        Console.WriteLine($"You have to wait {21 - age} before you can take this class");
//        break;
//}




Console.ReadLine();
