// 0-based counting - 0,1,2,3,4
//string[] firstNames = new string[5];

//firstNames[0] = "tim";
//firstNames[1] = "sue";
//firstNames[2] = "bob";
//firstNames[4] = "jane";

//Console.WriteLine($"The first names are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[4]}");

//firstNames[0] = "marc";
//Console.WriteLine(firstNames[0]);

// single quote identifies a char
// double quote identifies a string 
string data = "Tim,Sue,Bob,Jane,Frank,Marc";
string[] firstNames = data.Split(',');

Console.WriteLine(firstNames[4]);
Console.WriteLine(firstNames[firstNames.Length - 1]);
Console.WriteLine(firstNames.Length);

string[] lastName = new string[] {"Corey","Smith","Jones","Moxey"};

int[] ages = new int[] {2,3,4};   