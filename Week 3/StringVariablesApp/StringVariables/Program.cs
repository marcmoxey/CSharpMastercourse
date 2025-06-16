
// type - variable Name
string firstName = string.Empty; 
string lastName = string.Empty;
string filePath = string.Empty;


firstName = "Marc";
lastName = "Moxey";
//filePath = "C:\\Temp\\Demo"; // '\' - escape character
filePath = @"C:\Temp\Demo \n"; // '@' - treat everything as literal string, don't treat as special character
//firstName = "123";


string testString = $@"The file for {firstName} is at C:\SampleFiles";


//Console.WriteLine(firstName + " " + lastName);
Console.WriteLine($"Hello {firstName} {lastName}"); // String interpolation 
Console.WriteLine(filePath);
Console.WriteLine(testString);

