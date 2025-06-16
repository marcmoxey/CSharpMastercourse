//bool isComplete = false;

//if (!isComplete)
//{
//    Console.WriteLine("The statement was true");
//    Console.WriteLine("This line works in true");
//}
//else
//{
//    Console.WriteLine("The statement was false");
//    Console.WriteLine("This should also run");
//}

Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

string lastName;

if (firstName.ToLower() == "marc")
{
    Console.WriteLine("Hello Mr.Moxey");
    lastName = "Moxey";
}
else
{
    Console.WriteLine($"Hello {firstName}");
    lastName = "Smith";
}
Console.WriteLine(lastName);
Console.WriteLine("End of program");
Console.ReadLine(); 