

List<string> partyList = new();

string partyName;
string numInPartyText;
int totalGuest = 0;

Console.WriteLine("-----------------------------------");
Console.WriteLine("Welcome To Guest Book Application");
do
{
    Console.Write("What is your party name: ");
    partyName = Console.ReadLine();
    partyList.Add(partyName);

    Console.Write("How many people are in your party: ");
    numInPartyText = Console.ReadLine();
    int.TryParse(numInPartyText, out int numInParty);
    totalGuest += numInParty;

    Console.Write("Are more guest coming(enter 'yes' or 'no'): ");
    string userInput = Console.ReadLine();

    if(userInput.ToLower() == "yes")
    {
        Console.Write("What is your party name: ");
        partyName = Console.ReadLine();
        partyList.Add(partyName);

        Console.Write("How many people are in your party: ");
        numInPartyText = Console.ReadLine();
        int.TryParse(numInPartyText, out numInParty);
        totalGuest += numInParty;
    }
    else if(userInput.ToLower() == "no")
    {
        foreach (string guest in partyList)
        {
            Console.WriteLine($"{guest}");
        }
        Console.WriteLine($"The total number of guest are {totalGuest}");
        break;
    }
 
  

}
while (true);