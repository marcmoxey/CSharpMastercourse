
/*
read the user age 
do a conversion
check to see if age is in correct range
 
 */

using System.Collections.Concurrent;

Console.Write("What is your age: ");
string ageText = Console.ReadLine();
bool isValidInt = int.TryParse(ageText, out int age);
Console.WriteLine($"The int is {isValidInt}");


if(age >= 12 && age <= 15)
{
    Console.WriteLine("You in middle school");
}
else if (age == 16)
{
    Console.WriteLine("You can get your learners permit");

} else if ((age > 16) && (age <= 18))
{
    Console.WriteLine("You can get your license");

} else if (age <= 20)
{
    Console.WriteLine("You can't drink yet");
}
else
{
    Console.WriteLine("Your above age");
}

