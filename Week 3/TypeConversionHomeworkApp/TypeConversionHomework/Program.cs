/*
 * 
 * Capture a user's age from the Console and 
 * then identify how old they will be in 25 years, as well
 * as how old they were 25 years ago. Print that
 * information to the Console in natural language
 */


Console.Write("How old are you: ");
string ageText = Console.ReadLine();    
int.TryParse(ageText, out int age);
int ageIn25Years = age + 25;
int age25YearsAgo = age - 25;

Console.WriteLine($"You will be {ageIn25Years} year old in 25 years");
Console.WriteLine($"You were {age25YearsAgo} year old 25 years ago");