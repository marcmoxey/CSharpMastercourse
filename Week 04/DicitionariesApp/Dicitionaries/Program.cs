

Dictionary<string, string> lookup = new Dictionary<string, string>();
lookup["animal"] = "Not a human";
lookup["fish"] = "Not a human that swim";
lookup["Human"] = "Us";


Console.WriteLine($"The definition of fish is {lookup["fish"]}");

Dictionary<int, string> employee = new Dictionary<int, string>();
employee[95] = "Marc Moxey";
employee[28] = "Sue Storm";
employee[22] = "Tim Corey";

//Console.WriteLine($"The employee with the id 28 is {employee[29]}"); // need to be a valid key

Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();
dayOfWeek["Wednesday"] = 4;
dayOfWeek["Thursday"] = 5;
dayOfWeek["Friday"] = 6;
//dayOfWeek["Friday"] = 7; // can't have dupe keys

Console.WriteLine(dayOfWeek.Remove("Thursday"));
foreach(var day in dayOfWeek)
{
    Console.WriteLine(day);
}
//Console.WriteLine($"Wednesday is day number {dayOfWeek["Wednesday"]}");