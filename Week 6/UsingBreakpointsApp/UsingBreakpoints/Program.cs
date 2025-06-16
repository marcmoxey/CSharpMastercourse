
// step into - step by step
// step over - skip over a method called
// step out - in a method, go back to parent method 


for(int i = 0; i < 20; i++)
{
    Console.WriteLine($"The value of i is {i}");

    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine($"The value of j is {j}");
    }
}

Console.ReadLine();