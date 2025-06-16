


using Methods;

// DRY - Don't Repeat Yourself
// SOLID - SRP - Single Responsibility Principle

//Console.WriteLine("This is Marc");
string name = ConsoleMessage.GetUserName();
ConsoleMessage.SayHi(name);
double result = MathShortcuts.Add(5, 4);

Console.WriteLine($"The result is {result}");
//Console.WriteLine($"The result is {MathShortcuts.Add(5,3)}");

double[] vals = new double[] { 2, 5, 6, 21, 52, 98 };
double total = MathShortcuts.AddAll(vals);
Console.WriteLine($"The total is {total}");


ConsoleMessage.SayGoodbye();