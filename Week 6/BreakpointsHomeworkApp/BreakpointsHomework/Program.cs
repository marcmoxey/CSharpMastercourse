

/* 
 * 
 * For loop that multiples a number by 5
 * and add its to the total each time
 * time through the code
 * 
*/

int total = 0;
for (int i = 1; i < 10; i++)
{
    total += i * 5;
    Console.WriteLine($"The current total is {total}");
}
Console.WriteLine($"The total is {total}");