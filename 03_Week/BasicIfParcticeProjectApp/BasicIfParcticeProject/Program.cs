
int age = 23;
int? currentAge;

if (age == 16)
{
    Console.WriteLine("You can get your learns permit");
    currentAge = 15;
}
else
{
    Console.WriteLine("You can't learn to drive yet");
    currentAge = 16;
}
Console.WriteLine(currentAge);
Console.WriteLine("End of programing");
Console.ReadLine();