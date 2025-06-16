

Console.Write("What is your first name: ");
string firstName = Console.ReadLine();

Console.Write("What is your last name: ");
string lastName = Console.ReadLine();

if (firstName.ToLower() == "marc" &&
    lastName.ToLower() == "moxey")
{
    Console.WriteLine("Hello Professor Moxey");
} else if (firstName.ToLower() == "marc" || lastName.ToLower() == "moxey" )
{
    Console.WriteLine("You have a great part in your name");
} else
{
    Console.WriteLine("Hello student");
}



//if (firstName.ToLower() == "marc" &&
//    lastName.ToLower() == "moxey")
//{
//    Console.WriteLine("Hello Mr.Moxey");
//} else if (firstName.ToLower() == "marc")
//{
//    Console.WriteLine("Hello you have a cool first name");
//} else if (lastName.ToLower() == "moxey")
//{

//    Console.WriteLine("You have a great last name");
//}
//else
//{
//    Console.WriteLine("You don't have a cooler name");
//}


//if (firstName.ToLower() == "marc")
//{
//    Console.WriteLine("You have a cool first name");

//}


//if (lastName.ToLower() == "moxey")
//{
//    Console.WriteLine("You have a great last name");
//} else
//{
//    Console.WriteLine("Sorry you need to have cool name");
//}


//int age = 39;
// ==, >, >=, <, <=, !=


//if (age != 43)
//{
//    Console.WriteLine("Sorry you arent a great age");
//}
//if (age >= 40 && age < 50)
//{
//    Console.WriteLine("You are in your forties");
//}
//Console.ReadLine();